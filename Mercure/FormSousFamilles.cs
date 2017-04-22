using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure
{
    public partial class FormSousFamilles : Form
    {
        private String databaseFileName = Configuration.DEFAULT_DATABASE;
        private List<SousFamille> sousFamilles = new List<SousFamille>();

        public FormSousFamilles()
        {
            InitializeComponent();
            LoadSousFamilles();
        }

        private void ajouterSousFamilleButton_Click(object sender, EventArgs e)
        {
            FormSaveSousFamille saveSF = new FormSaveSousFamille();
            saveSF.ShowDialog(this);
            LoadSousFamilles();
        }

        private void modifierSousFamilleButton_Click(object sender, EventArgs e)
        {
            if (sousFamillesListView.SelectedIndices.Count > 0)
            {
                int aIndex = sousFamillesListView.SelectedIndices[0];
                FormSaveSousFamille saveSF = new FormSaveSousFamille(sousFamilles[aIndex]);
                saveSF.ShowDialog(this);
                LoadSousFamilles();
            }
        }

        private void supprimerSousFamilleButton_Click(object sender, EventArgs e)
        {
            if (sousFamillesListView.SelectedIndices.Count > 0)
            {
                int aIndex = sousFamillesListView.SelectedIndices[0];
                DialogResult result = MessageBox.Show("Are you sure you want to delete : " + sousFamilles[aIndex].Nom, "Delete sous-famille",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    SousFamille.RemoveSousFamille(databaseFileName, sousFamilles[aIndex].RefSousFamille);
                    LoadSousFamilles();
                }
            }
        }

        private void sousFamilleListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (sousFamillesListView.FocusedItem != null && sousFamillesListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void LoadSousFamilles()
        {
            sousFamillesListView.Items.Clear();
            sousFamilles.Clear();
            sousFamilles.AddRange(SousFamille.GetAll(databaseFileName));
            foreach (SousFamille sousFamille in sousFamilles)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(sousFamille.RefSousFamille));

                ListViewItem.ListViewSubItem nomItem = new ListViewItem.ListViewSubItem(item, sousFamille.Nom);
                item.SubItems.Add(nomItem);

                Famille famille = Famille.FindFamille(databaseFileName, sousFamille.RefFamille);
                ListViewItem.ListViewSubItem familleItem = new ListViewItem.ListViewSubItem(item, famille != null ? famille.Nom : "");
                item.SubItems.Add(familleItem);

                sousFamillesListView.Items.Add(item);
            }
        }
    }
}
