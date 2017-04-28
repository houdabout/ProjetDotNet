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

/*
 * @author : HOUDA BOUTBIB et MOHAMMED ELMOUTARAJI
 * */

namespace Mercure
{
    public partial class FormPrincipal : Form
    {
        private String databaseFileName = Configuration.DEFAULT_DATABASE;
        private List<Article> articles = new List<Article>();

        private int sortColumn = -1;

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
            ajout.ShowDialog(this);
            LoadArticles();
        }

        private void ajouterArticleButton_Click(object sender, EventArgs e)
        {
            FormSaveArticle saveArticle = new FormSaveArticle();
            saveArticle.ShowDialog(this);
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
            saveFamille.ShowDialog(this);
        }

        private void ajouterMarqueButton_Click(object sender, EventArgs e)
        {
            FormSaveMarque saveMarque = new FormSaveMarque();
            saveMarque.ShowDialog(this);
        }

        private void ajouterSousFamilleButton_Click(object sender, EventArgs e)
        {
            FormSaveSousFamille saveSousFamille = new FormSaveSousFamille();
            saveSousFamille.ShowDialog(this);
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
                ListViewItem item = new ListViewItem(article.Ref_Article);

                ListViewItem.ListViewSubItem descriptionItem = new ListViewItem.ListViewSubItem(item, article.Description);
                item.SubItems.Add(descriptionItem);

                SousFamille sousFamille = SousFamille.FindSousFamille(databaseFileName, article.Ref_Sous_Famille);
                ListViewItem.ListViewSubItem sousFamilleItem = new ListViewItem.ListViewSubItem(item, sousFamille != null ? sousFamille.Nom : "");
                item.SubItems.Add(sousFamilleItem);

                Marque marque = Marque.FindMarque(databaseFileName, article.Ref_Marque);
                ListViewItem.ListViewSubItem marqueItem = new ListViewItem.ListViewSubItem(item, marque != null ? marque.Nom : "");
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
                DialogResult result = MessageBox.Show("Are you sure you want to delete : " + articles[aIndex].Ref_Article, "Delete article",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Article.RemoveArticle(databaseFileName, articles[aIndex].Ref_Article);
                    LoadArticles();
                }
            }
        }

        private void AjouterArticle()
        {
            FormSaveArticle saveArticle = new FormSaveArticle();
            saveArticle.ShowDialog(this);
            LoadArticles();
        }

        private void listeMarqueButton_Click(object sender, EventArgs e)
        {
            FormMarques marques = new FormMarques();
            marques.ShowDialog(this);
        }

        private void listeFamilleButton_Click(object sender, EventArgs e)
        {
            FormFamilles familles = new FormFamilles();
            familles.ShowDialog(this);
        }

        private void listeSousFamilleButton_Click(object sender, EventArgs e)
        {
            FormSousFamilles sousFamilles = new FormSousFamilles();
            sousFamilles.ShowDialog(this);
        }

        private void articleListView_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                articleListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (articleListView.Sorting == System.Windows.Forms.SortOrder.Ascending)
                    articleListView.Sorting = System.Windows.Forms.SortOrder.Descending;
                else
                    articleListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            articleListView.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.articleListView.ListViewItemSorter = new ListViewItemComparer(e.Column, articleListView.Sorting);
        }
    }
}
