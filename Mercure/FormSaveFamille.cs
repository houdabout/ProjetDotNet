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
        * modifier une famille ou non
        */
        private bool toUpdate = false;

        /**
        * nom de la base de données
        */
        private String databaseFileName = Configuration.DEFAULT_DATABASE;

        /**
        * Constructeur par défaut
        */
        public FormSaveFamille()
        {
            InitializeComponent();
        }

        /**
        * Constructeur
        * Param:
        *   Nom de la base de données
        */
        public FormSaveFamille(String databaseFileName)
        {
            this.databaseFileName = databaseFileName;
            InitializeComponent();
        }

        /**
        * Constructeur
        * Param:
        *   Famille à modifier
        */
        public FormSaveFamille(Famille famille)
        {
            this.toUpdate = true;
            InitializeComponent();
            InitializeTextBoxes(famille);
        }

        /**
        * Constructeur
        * Param:
        *   Nom de la base de données
        *   Famille à modifier
        */
        public FormSaveFamille(String databaseFileName, Famille famille)
        {
            this.toUpdate = true;
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

        /**
        * Fonction privée pour initialiser les champs de la famille à modifier
        */
        private void InitializeTextBoxes(Famille famille)
        {
            referenceFamilleTextBox.Text = Convert.ToString(famille.RefFamille); //converte int à string
            nomFamilleTextBox.Text = famille.Nom;
        }

        /**
        * Evenement de click sur sauvegarderButton
        */
        private void sauvegarderButton_Click(object sender, EventArgs e)
        {
            SaveFamille();
        }

        /**
        * Fonction privée pour sauvegarder une famille à partir les champs de l'interface
        */
        private void SaveFamille()
        {
            //Reference de la famille
            String RefText = referenceFamilleTextBox.Text;
            //Nom de la famille
            String Nom = nomFamilleTextBox.Text;
            //L'utilisateur doit fournir le reference et le nom
            if(!RefText.Equals("") && !Nom.Equals(""))
            {
                try
                {
                    int RefFamille = int.Parse(RefText); // converte string à int
                    Famille famille = new Famille(RefFamille, Nom); // Reconstruction de la famille
                    if (toUpdate)
                    {
                        //Modification de la famille
                        Famille.UpdateFamille(databaseFileName, famille);
                        MessageBox.Show("The family was updated.", "Famille info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        //Insertion de la famille
                        Famille.InsertFamille(databaseFileName, famille);
                        MessageBox.Show("The family was added.", "Famille info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Ferme la fenetre
                    Dispose();
                }
                catch (FormatException e)
                {
                    //Message de l'exception pour notifier l'utilisateur
                    MessageBox.Show(e.Message, "Famille error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Message de remplir pour l'utilisateur
                MessageBox.Show("Please fill all the required fields...", "Famille error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
