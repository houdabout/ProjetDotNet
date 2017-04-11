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
    public partial class FormPrincipal : Form
    {
        private String databaseFileName = Configuration.DEFAULT_DATABASE;
        private List<Article> articles = new List<Article>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadArticles();
        }

        private void ajouteFichierButton_Click(object sender, EventArgs e)
        {
            FormAjouterFichier ajout = new FormAjouterFichier();
            ajout.ShowDialog();
            LoadArticles();
        }

        private void ajouterArticleButton_Click(object sender, EventArgs e)
        {
            FormSaveArticle saveArticle = new FormSaveArticle();
            saveArticle.ShowDialog();
            LoadArticles();
        }

        private void modifierArticleButton_Click(object sender, EventArgs e)
        {
            ModifierArticle();
        }

        private void supprimerArticleButton_Click(object sender, EventArgs e)
        {
            SupprimerArticle();
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
        
        private void articleTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (articleListView.FocusedItem != null && articleListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void articleTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierArticle();
        }

        private void articleTable_Keys_Click(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F5:
                    LoadArticles();
                    break;
                case Keys.Enter:
                    ModifierArticle();
                    break;
                case Keys.Delete:
                    SupprimerArticle();
                    break;
            }
        }

        private void ajouterUnArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterArticle();
        }

        private void modifierArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierArticle();
        }

        private void supprimerArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerArticle();
        }

        private void LoadArticles()
        {
            articleListView.Items.Clear();
            articles.Clear();
            articles.AddRange(Article.GetAll(databaseFileName));
            foreach (Article article in articles)
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

                articleListView.Items.Add(item);
            }
        }

        private void ModifierArticle()
        {
            if (articleListView.SelectedIndices.Count > 0)
            {
                int aIndex = articleListView.SelectedIndices[0];
                FormSaveArticle saveArticle = new FormSaveArticle(articles[aIndex]);
                saveArticle.ShowDialog(this);
                LoadArticles();
            }
        }

        private void SupprimerArticle()
        {
            if (articleListView.SelectedIndices.Count > 0)
            {
                int aIndex = articleListView.SelectedIndices[0];
                DialogResult result = MessageBox.Show("Are you sure you want to delete : " + articles[aIndex].RefArticle, "Delete article",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Article.RemoveArticle(databaseFileName, articles[aIndex].RefArticle);
                    LoadArticles();
                }
            }
        }

        private void AjouterArticle()
        {
            FormSaveArticle saveArticle = new FormSaveArticle();
            saveArticle.ShowDialog();
            LoadArticles();
        }
    }
}
