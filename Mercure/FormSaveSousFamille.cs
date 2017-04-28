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
/*
 * @author : HOUDA BOUTBIB et MOHAMMED ELMOUTARAJI
 * */
namespace Mercure
{
    public partial class FormSaveSousFamille : Form
    {
        private GroupBox groupBox1;
        private Button sauvegarderButton;
        private ComboBox familleComboBox;
        private TextBox nomSousTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox referenceSousTextBox;

        /**
        * modifier sous-famille ou non
        */
        private bool toUpdate = false;

        /**
        * nom de la base de données
        */
        private String databaseFileName = Configuration.DEFAULT_DATABASE;

        /**
        * Liste des familles
        */
        private List<Famille> familleList = null;

        /**
        * Constructeur par défaut
        */
        public FormSaveSousFamille()
        {
            InitializeComponent();
            InitializeLists();
        }

        /**
        * Constructeur
        * Param:
        *   Nom de la base de données
        */
        public FormSaveSousFamille(String databaseFileName)
        {
            this.databaseFileName = databaseFileName;
            InitializeComponent();
            InitializeLists();
        }

        /**
        * Constructeur
        * Param:
        *   Sous-Famille à modifier
        */
        public FormSaveSousFamille(SousFamille sousFamille)
        {
            this.toUpdate = true;
            InitializeComponent();
            InitializeLists();
            InitializeTextBoxes(sousFamille);
        }

        /**
        * Constructeur
        * Param:
        *   Nom de la base de données
        *   Sous-Famille à modifier
        */
        public FormSaveSousFamille(String databaseFileName, SousFamille sousFamille)
        {
            this.databaseFileName = databaseFileName;
            this.toUpdate = true;
            InitializeComponent();
            InitializeLists();
            InitializeTextBoxes(sousFamille);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.familleComboBox = new System.Windows.Forms.ComboBox();
            this.nomSousTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sauvegarderButton = new System.Windows.Forms.Button();
            this.referenceSousTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.familleComboBox);
            this.groupBox1.Controls.Add(this.nomSousTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sauvegarderButton);
            this.groupBox1.Controls.Add(this.referenceSousTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remplir";
            // 
            // familleComboBox
            // 
            this.familleComboBox.FormattingEnabled = true;
            this.familleComboBox.Location = new System.Drawing.Point(137, 129);
            this.familleComboBox.Name = "familleComboBox";
            this.familleComboBox.Size = new System.Drawing.Size(289, 21);
            this.familleComboBox.TabIndex = 6;
            // 
            // nomSousTextBox
            // 
            this.nomSousTextBox.Location = new System.Drawing.Point(137, 89);
            this.nomSousTextBox.Name = "nomSousTextBox";
            this.nomSousTextBox.Size = new System.Drawing.Size(289, 20);
            this.nomSousTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Famille : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reference : ";
            // 
            // sauvegarderButton
            // 
            this.sauvegarderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sauvegarderButton.Location = new System.Drawing.Point(169, 179);
            this.sauvegarderButton.Name = "sauvegarderButton";
            this.sauvegarderButton.Size = new System.Drawing.Size(115, 34);
            this.sauvegarderButton.TabIndex = 1;
            this.sauvegarderButton.Text = "Sauvegarder";
            this.sauvegarderButton.UseVisualStyleBackColor = false;
            this.sauvegarderButton.Click += new System.EventHandler(this.sauvegarderButton_Click);
            // 
            // referenceSousTextBox
            // 
            this.referenceSousTextBox.Location = new System.Drawing.Point(137, 49);
            this.referenceSousTextBox.Name = "referenceSousTextBox";
            this.referenceSousTextBox.Size = new System.Drawing.Size(289, 20);
            this.referenceSousTextBox.TabIndex = 0;
            // 
            // FormSaveSousFamille
            // 
            this.ClientSize = new System.Drawing.Size(486, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSaveSousFamille";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        /**
       * Fonction privée pour initialiser les champs de sous-famille à modifier
       */
        private void InitializeTextBoxes(SousFamille sousFamille)
        {
            referenceSousTextBox.Text = Convert.ToString(sousFamille.Ref_Sous_Famille);
            nomSousTextBox.Text = sousFamille.Nom;

            int i = 0;
            foreach (Famille famille in familleList)
            {
                if(famille.Ref_Famille == sousFamille.Ref_Famille)
                {
                    familleComboBox.SelectedIndex = i;
                }
                i++;
            }
        }

        /**
        * Fonction privée pour initialiser les listes de sous-familles et marques
        */
        private void InitializeLists()
        {
            //Chargement la liste des familles dans le combo-box
            familleList = Famille.GetAll(databaseFileName);
            foreach (Famille f in familleList)
            {
                familleComboBox.Items.Add(f.Nom);
                familleComboBox.SelectedIndex = 0; // Selection de la premiere famille par défaut
            }
        }

        /**
        * Evenement de click sur sauvegarderButton
        */
        private void sauvegarderButton_Click(object sender, EventArgs e)
        {
            SaveSousFamille();
        }

        /**
        * Fonction privée pour sauvegarder sous-famille à partir les champs de l'interface
        */
        private void SaveSousFamille()
        {
            //Reference de sous-famille
            String RefSF = referenceSousTextBox.Text;
            //Nom de sous-famille
            String Nom = nomSousTextBox.Text;
            //Indice de la famille selectionnée
            int fIndex = familleComboBox.SelectedIndex;
            //L'utilisateur doit fournir le reference, nom et la famille
            if(fIndex > -1 && !RefSF.Equals("") && !Nom.Equals(""))
            {
                try
                {
                    int RefSousFamille = int.Parse(RefSF); //converte string à int
                    int RefFamille = familleList[fIndex].Ref_Famille; // reference de la famille selectionnée
                    //Reconstruction de sous-famille
                    SousFamille sousFamille = new SousFamille(RefSousFamille, RefFamille, Nom);
                    if(toUpdate)
                    {
                        //Modification de sous-famille
                        SousFamille.UpdateSousFamille(databaseFileName, sousFamille);
                        MessageBox.Show("The sous-famille was updated.", "Sous-Famille info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Insertion de sous-famille
                        SousFamille.InsertSousFamille(databaseFileName, sousFamille);
                        MessageBox.Show("The sous-famille was added.", "Sous-Famille info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Ferme la fenetre
                    Dispose();
                }
                catch(FormatException e)
                {
                    //Message de l'exception pour notifier l'utilisateur
                    MessageBox.Show(e.Message, "Sous-Famille error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Message de remplir pour l'utilisateur
                MessageBox.Show("Please fill all the required fields...", "Sous-Famille error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
