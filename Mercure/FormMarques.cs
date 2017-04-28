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
    public partial class FormMarques : Form
    {
        private String databaseFileName = Configuration.DEFAULT_DATABASE;
        private List<Marque> marques = new List<Marque>();

        public FormMarques()
        {
            InitializeComponent();
        }

        private void FormMarques_Load(object sender, EventArgs e)
        {
            LoadMarques();
        }

        private void LoadMarques()
        {
            marqueListView.Items.Clear();
            marques.Clear();
            marques.AddRange(Marque.GetAll(databaseFileName));
            foreach(Marque marque in marques)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(marque.Ref_Marque));

                ListViewItem.ListViewSubItem nomItem = new ListViewItem.ListViewSubItem(item, marque.Nom);
                item.SubItems.Add(nomItem);

                marqueListView.Items.Add(item);
            }
        }

        private void ajouterMarqueButton_Click(object sender, EventArgs e)
        {
            FormSaveMarque saveMarque = new FormSaveMarque();
            saveMarque.ShowDialog(this);
            LoadMarques();
        }

        private void modifierMarqueButton_Click(object sender, EventArgs e)
        {
            if (marqueListView.SelectedIndices.Count > 0)
            {
                int aIndex = marqueListView.SelectedIndices[0];
                FormSaveMarque saveMarque = new FormSaveMarque(marques[aIndex]);
                saveMarque.ShowDialog(this);
                LoadMarques();
            }
        }

        private void supprimerMarqueButton_Click(object sender, EventArgs e)
        {
            if (marqueListView.SelectedIndices.Count > 0)
            {
                int aIndex = marqueListView.SelectedIndices[0];
                DialogResult result = MessageBox.Show("Are you sure you want to delete : " + marques[aIndex].Nom, "Delete marque",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Marque.RemoveMarque(databaseFileName, marques[aIndex].Ref_Marque);
                    LoadMarques();
                }
            }
        }

        private void marqueListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (marqueListView.FocusedItem != null && marqueListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
