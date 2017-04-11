using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace Mercure
{

    public partial class FormSaveFamille : Form
    {
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Button sauvegarderButton;
        private TextBox nomFamilleTextBox;
        private TextBox referenceFamilleTextBox;
        private GroupBox groupBox1;

        /**
        * modifier une article ou non
        */
        private bool toUpdate = false;

        /**
        * nom de la base de données
        */
        private String databaseFileName = Configuration.DEFAULT_DATABASE;

        public FormSaveFamille()
        {
            InitializeComponent();
        }

        public FormSaveFamille(String databaseFileName)
        {
            this.databaseFileName = databaseFileName;
            InitializeComponent();
        }

        public FormSaveFamille(Famille famille)
        {
            InitializeComponent();
            InitializeTextBoxes(famille);
        }

        public FormSaveFamille(String databaseFileName, Famille famille)
        {
            this.databaseFileName = databaseFileName;
            InitializeComponent();
            InitializeTextBoxes(famille);
        }

        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sauvegarderButton = new System.Windows.Forms.Button();
            this.nomFamilleTextBox = new System.Windows.Forms.TextBox();
            this.referenceFamilleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sauvegarderButton);
            this.groupBox2.Controls.Add(this.nomFamilleTextBox);
            this.groupBox2.Controls.Add(this.referenceFamilleTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 211);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remplir";
            // 
            // sauvegarderButton
            // 
            this.sauvegarderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sauvegarderButton.Location = new System.Drawing.Point(216, 141);
            this.sauvegarderButton.Name = "sauvegarderButton";
            this.sauvegarderButton.Size = new System.Drawing.Size(89, 37);
            this.sauvegarderButton.TabIndex = 4;
            this.sauvegarderButton.Text = "Sauvegarder";
            this.sauvegarderButton.UseVisualStyleBackColor = false;
            this.sauvegarderButton.Click += new System.EventHandler(this.sauvegarderButton_Click);
            // 
            // nomFamilleTextBox
            // 
            this.nomFamilleTextBox.Location = new System.Drawing.Point(204, 82);
            this.nomFamilleTextBox.Name = "nomFamilleTextBox";
            this.nomFamilleTextBox.Size = new System.Drawing.Size(279, 20);
            this.nomFamilleTextBox.TabIndex = 3;
            // 
            // referenceFamilleTextBox
            // 
            this.referenceFamilleTextBox.Location = new System.Drawing.Point(204, 31);
            this.referenceFamilleTextBox.Name = "referenceFamilleTextBox";
            this.referenceFamilleTextBox.Size = new System.Drawing.Size(279, 20);
            this.referenceFamilleTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom de la famille :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reference famille :";
            // 
            // FormSaveFamille
            // 
            this.ClientSize = new System.Drawing.Size(541, 240);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormSaveFamille";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void InitializeTextBoxes(Famille famille)
        {
            referenceFamilleTextBox.Text = Convert.ToString(famille.RefFamille);
            nomFamilleTextBox.Text = famille.Nom;
        }

        private void sauvegarderButton_Click(object sender, EventArgs e)
        {
            SaveFamille();
        }

        private void SaveFamille()
        {
            String RefText = referenceFamilleTextBox.Text;
            String Nom = nomFamilleTextBox.Text;
            if(!RefText.Equals("") && !Nom.Equals(""))
            {
                try
                {
                    int RefFamille = int.Parse(RefText);
                    Famille famille = new Famille(RefFamille, Nom);
                    if (toUpdate)
                    {
                        Famille.UpdateFamille(databaseFileName, famille);
                        MessageBox.Show("The family was updated.", "Article info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        Famille.InsertFamille(databaseFileName, famille);
                        MessageBox.Show("The family was added.", "Article info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Dispose();
                }
                catch (FormatException e)
                {
                    MessageBox.Show(e.Message, "Famille error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the required fields...", "Article error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
