using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Mercure
{
    public partial class Form1 : Form
    {
        private String databaseFile = "Mercure.SQLite";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            handleFileDialog();
        }

        private void openUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handleFileDialog();
        }

        private void handleFileDialog()
        {
            FileDialog form = new OpenFileDialog();
            form.InitialDirectory = "C:\\";
            form.Filter = "XML Files (*.xml)|*.xml";
            form.RestoreDirectory = true;

            if (form.ShowDialog() == DialogResult.OK)
            {
                handleXML(form.FileName);  
            }
        }

        private void handleXML(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNode root = doc.ChildNodes[1];
            int childCount = root.ChildNodes.Count;
            foreach(XmlNode node in root.ChildNodes)
            {
                //Handle marque
                String marqueNom = node.ChildNodes[2].InnerText;
                Marque marque = Marque.FindMarqueByNom(databaseFile, marqueNom);
                if(marque == null)
                {
                    int Count = Marque.GetSize(databaseFile);
                    marque = new Marque(Count, marqueNom);
                    Marque.InsertMarque(databaseFile, marque);
                }

                //Handle Famille
                String familleNom = node.ChildNodes[3].InnerText;
                Famille famille = Famille.FindFamilleByNom(databaseFile, familleNom);
                if(famille == null)
                {
                    int Count = Famille.GetSize(databaseFile);
                    famille = new Famille(Count, familleNom);
                    Famille.AddFamille(databaseFile, famille);
                }

                //Handle SousFamille
                String sousFamilleNom = node.ChildNodes[4].InnerText;
                SousFamille sousFamille = SousFamille.FindSousFamilleByNom(databaseFile, sousFamilleNom);
                if (sousFamille == null)
                {
                    int Count = SousFamille.GetSize(databaseFile);
                    sousFamille = new SousFamille(Count, famille.RefFamille, sousFamilleNom);
                    SousFamille.InsertSousFamille(databaseFile, sousFamille);
                }

                //Handle article
                String refArticle = node.ChildNodes[1].InnerText;
                String description = node.ChildNodes[0].InnerText;
                float prixHT = float.Parse(node.ChildNodes[5].InnerText);
                Article article = Article.FindArticle(databaseFile, refArticle);
                if (article == null)
                {
                    article = new Article(refArticle, description, prixHT, 0, sousFamille.RefSousFamille, marque.RefMarque);
                }
                
                progressBar1.Value += 100 / childCount;
            }
        }
    }
}
