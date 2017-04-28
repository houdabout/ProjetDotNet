using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * @author : HOUDA BOUTBIB et MOHAMMED ELMOUTARAJI
 * */
namespace Mercure
{
    public partial class FormFamilles : Form
    {
        private String databaseFileName = Configuration.DEFAULT_DATABASE;
        private List<Famille> familles = new List<Famille>();


        public FormFamilles()
        {
            InitializeComponent();
            LoadFamilles();
        }

        private void ajouterFamilleButton_Click(object sender, EventArgs e)
        {
            FormSaveFamille saveFamille = new FormSaveFamille();
            saveFamille.ShowDialog();
            LoadFamilles();
        }

        private void modifierFamilleButton_Click(object sender, EventArgs e)
        {
            if (familleListView.SelectedIndices.Count > 0)
            {
                int aIndex = familleListView.SelectedIndices[0];
                FormSaveFamille saveFamille = new FormSaveFamille(familles[aIndex]);
                saveFamille.ShowDialog(this);
                LoadFamilles();
            }
        }

        private void supprimerFamilleButton_Click(object sender, EventArgs e)
        {
            if (familleListView.SelectedIndices.Count > 0)
            {
                int aIndex = familleListView.SelectedIndices[0];
                DialogResult result = MessageBox.Show("Are you sure you want to delete : " + familles[aIndex].Nom, "Delete famille",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Famille.RemoveFamille(databaseFileName, familles[aIndex].Ref_Famille);
                    LoadFamilles();
                }
            }
        }

        private void familleListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (familleListView.FocusedItem != null && familleListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void LoadFamilles()
        {
            familleListView.Items.Clear();
            familles.Clear();
            familles.AddRange(Famille.GetAll(databaseFileName));
            foreach (Famille famille in familles)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(famille.Ref_Famille));

                ListViewItem.ListViewSubItem nomItem = new ListViewItem.ListViewSubItem(item, famille.Nom);
                item.SubItems.Add(nomItem);

                familleListView.Items.Add(item);
            }
        }
    }
}
