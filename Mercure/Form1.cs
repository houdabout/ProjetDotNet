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
    }
}
