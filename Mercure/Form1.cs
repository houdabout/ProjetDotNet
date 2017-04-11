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
        private String databaseFileName = Configuration.DEFAULT_DATABASE;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void ajouteFichierButton_Click(object sender, EventArgs e)
        {
            FormAjouterFichier ajout = new FormAjouterFichier();
            ajout.ShowDialog();
            //TODO: update table
        }

        private void ajouterArticleButton_Click(object sender, EventArgs e)
        {
            FormSaveArticle saveArticle = new FormSaveArticle();
            saveArticle.ShowDialog();
        }

        private void ajouterFamilleButton_Click(object sender, EventArgs e)
        {
            FormSaveFamille saveFamille = new FormSaveFamille();
            saveFamille.ShowDialog();
        }

        private void ajouterMarqueButton_Click(object sender, EventArgs e)
        {
            FormSaveMarque saveMarque = new FormSaveMarque();
            saveMarque.ShowDialog();
        }

        private void ajouterSousFamilleButton_Click(object sender, EventArgs e)
        {
            FormSaveSousFamille saveSousFamille = new FormSaveSousFamille();
            saveSousFamille.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            articleTable.Items.Clear();
            List<Article> articles = Article.GetAll(databaseFileName);
            foreach(Article article in articles)
            {
                ListViewItem item = new ListViewItem(article.RefArticle);

                ListViewItem.ListViewSubItem descriptionItem = new ListViewItem.ListViewSubItem(item, article.Description);
                item.SubItems.Add(descriptionItem);

                SousFamille sousFamille = SousFamille.FindSousFamille(databaseFileName, article.RefSousFamille);
                ListViewItem.ListViewSubItem sousFamilleItem = new ListViewItem.ListViewSubItem(item, sousFamille.Nom);
                item.SubItems.Add(sousFamilleItem);

                Marque marque = Marque.FindMarque(databaseFileName, article.RefMarque);
                ListViewItem.ListViewSubItem marqueItem = new ListViewItem.ListViewSubItem(item, marque.Nom);
                item.SubItems.Add(marqueItem);

                ListViewItem.ListViewSubItem quantiteItem = new ListViewItem.ListViewSubItem(item, Convert.ToString(article.Quantite));
                item.SubItems.Add(quantiteItem);

                ListViewItem.ListViewSubItem prixItem = new ListViewItem.ListViewSubItem(item, Convert.ToString(article.PrixHT));
                item.SubItems.Add(prixItem);
                
                articleTable.Items.Add(item);
            }
            Console.WriteLine("finished");
        }
    }
}
