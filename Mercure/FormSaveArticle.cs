using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

/*
 * @author : HOUDA BOUTBIB et MOHAMMED ELMOUTARAJI
 * */
namespace Mercure
{
    public partial class FormSaveArticle : Form
    {
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private ComboBox sousFamilleComboBox;
        private TextBox descriptionTextBox;
        private TextBox referenceArticleTextBox;
        private Button sauvegarderButton;
        private ComboBox marqueComboBox;
        private Label label1;
        private TextBox prixTextBox;
        private TextBox quantiteTextBox;
        private Label label3;

        /**
        * modifier une article ou non
        */
        private bool toUpdate = false;

        /**
        * nom de la base de données
        */
        private String databaseFileName = Configuration.DEFAULT_DATABASE;

        /**
        * Liste des sous familles
        */
        private List<SousFamille> sousFamilleList = null;

        /**
        * Liste des marques
        */
        private List<Marque> marqueList = null;

        /**
        * Constructeur par défaut
        */
        public FormSaveArticle()
        {
            InitializeComponent();
            InitializeLists();
        }

        /**
        * Constructeur
        * Param:
        *   Article à modifier
        */
        public FormSaveArticle(Article article)
        {
            this.toUpdate = true;
            InitializeComponent();
            InitializeTextBoxes(article);
            InitializeLists();
        }

        /**
        * Constructeur
        * Param:
        *   nom de la base de données
        */
        public FormSaveArticle(String databaseFileName)
        {
            this.databaseFileName = databaseFileName;
            InitializeComponent();
            InitializeLists();
        }

        /**
        * Constructeur
        * Param:
        *   nom de la base de données
        *   Article à modifier
        */
        public FormSaveArticle(String databaseFileName, Article article)
        {
            this.databaseFileName = databaseFileName;
            this.toUpdate = true;
            InitializeComponent();
            InitializeTextBoxes(article);
            InitializeLists();
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantiteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prixTextBox = new System.Windows.Forms.TextBox();
            this.sauvegarderButton = new System.Windows.Forms.Button();
            this.marqueComboBox = new System.Windows.Forms.ComboBox();
            this.sousFamilleComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.referenceArticleTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantiteTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.prixTextBox);
            this.groupBox1.Controls.Add(this.sauvegarderButton);
            this.groupBox1.Controls.Add(this.marqueComboBox);
            this.groupBox1.Controls.Add(this.sousFamilleComboBox);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.referenceArticleTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remplir";
            // 
            // quantiteTextBox
            // 
            this.quantiteTextBox.Location = new System.Drawing.Point(191, 252);
            this.quantiteTextBox.Name = "quantiteTextBox";
            this.quantiteTextBox.Size = new System.Drawing.Size(326, 20);
            this.quantiteTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantité : ";
            // 
            // prixTextBox
            // 
            this.prixTextBox.Location = new System.Drawing.Point(191, 214);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(326, 20);
            this.prixTextBox.TabIndex = 14;
            // 
            // sauvegarderButton
            // 
            this.sauvegarderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sauvegarderButton.Location = new System.Drawing.Point(567, 128);
            this.sauvegarderButton.Name = "sauvegarderButton";
            this.sauvegarderButton.Size = new System.Drawing.Size(92, 40);
            this.sauvegarderButton.TabIndex = 13;
            this.sauvegarderButton.Text = "Sauvegarder";
            this.sauvegarderButton.UseVisualStyleBackColor = false;
            this.sauvegarderButton.Click += new System.EventHandler(this.sauvegarderButton_Click);
            // 
            // marqueComboBox
            // 
            this.marqueComboBox.FormattingEnabled = true;
            this.marqueComboBox.Location = new System.Drawing.Point(191, 170);
            this.marqueComboBox.Name = "marqueComboBox";
            this.marqueComboBox.Size = new System.Drawing.Size(326, 21);
            this.marqueComboBox.TabIndex = 11;
            // 
            // sousFamilleComboBox
            // 
            this.sousFamilleComboBox.FormattingEnabled = true;
            this.sousFamilleComboBox.Location = new System.Drawing.Point(191, 128);
            this.sousFamilleComboBox.Name = "sousFamilleComboBox";
            this.sousFamilleComboBox.Size = new System.Drawing.Size(326, 21);
            this.sousFamilleComboBox.TabIndex = 10;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(191, 85);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(326, 20);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // referenceArticleTextBox
            // 
            this.referenceArticleTextBox.Location = new System.Drawing.Point(191, 42);
            this.referenceArticleTextBox.Name = "referenceArticleTextBox";
            this.referenceArticleTextBox.Size = new System.Drawing.Size(326, 20);
            this.referenceArticleTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prix HT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marque : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sous-Famille : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reference Article : ";
            // 
            // FormSaveArticle
            // 
            this.ClientSize = new System.Drawing.Size(726, 329);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSaveArticle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

            }

        /**
        * Fonction privée pour initialiser les champs d'article à modifier
        */
        private void InitializeTextBoxes(Article article)
        {
            referenceArticleTextBox.Text = article.Ref_Article;
            descriptionTextBox.Text = article.Description;
            prixTextBox.Text = Convert.ToString(article.PrixHT); // conversion de float à string
            quantiteTextBox.Text = Convert.ToString(article.Quantite); // conversion de int à string
        }

        /**
        * Fonction privée pour initialiser les listes de sous-familles et marques
        */
        private void InitializeLists()
        {
            //Chargement la liste des sous-familles dans le combo-box
            sousFamilleList = SousFamille.GetAll(databaseFileName);
            foreach (SousFamille sf in sousFamilleList)
            {
                sousFamilleComboBox.Items.Add(sf.Nom);
                sousFamilleComboBox.SelectedIndex = 0; // Selection de premier sous-famille par défaut
            }
            //Chargement la liste des marques dans le combo-box
            marqueList = Marque.GetAll(databaseFileName);
            foreach (Marque m in marqueList)
            {
                marqueComboBox.Items.Add(m.Nom);
                marqueComboBox.SelectedIndex = 0; // Selection de la premiere articles par défaut
            }
        }

        /**
        * Evenement de click sur sauvegarderButton
        */
        private void sauvegarderButton_Click(object sender, EventArgs e)
        {
            SaveArticle(); // sauvegrder l'article

        }

        /**
        * Fonction privée pour sauvegarder une article à partir les champs de l'interface
        */
        private void SaveArticle()
        {
            //reference de l'article dans le champ de texte
            String RefArticle = referenceArticleTextBox.Text;
            //description de l'article dans le champ de texte
            String Description = descriptionTextBox.Text;
            String Prix = prixTextBox.Text;
            String Quantite = quantiteTextBox.Text;
            //l'indice de sous-famille selectionné
            int sfIndex = sousFamilleComboBox.SelectedIndex;
            //l'indice de la marque selectionnée
            int mIndex = marqueComboBox.SelectedIndex;
            if (sfIndex > -1 && mIndex > -1 && !RefArticle.Equals("") && !Description.Equals("") && !Prix.Equals("") && !Quantite.Equals(""))
            {
                try
                {
                    float prix = float.Parse(Prix, CultureInfo.InvariantCulture); // conversion de string à float
                    int quantite = int.Parse(Quantite, CultureInfo.InvariantCulture); // conversion de string à int
                
                    //Prendre sous-famille choisi
                    SousFamille sousFamille = sousFamilleList[sfIndex];
                    //Prendre la marque choisie
                    Marque marque = marqueList[mIndex];
                    //Reconstruction de l'article
                    Article article = new Article(RefArticle, Description, prix, quantite, sousFamille.Ref_Sous_Famille, marque.Ref_Marque);
                    if(toUpdate)
                    {
                        //Modification de l'article
                        Article.UpdateArticle(databaseFileName, article);
                        MessageBox.Show("The article was updated.", "Article info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Insertion de l'article
                        Article.InsertArticle(databaseFileName, article);
                        MessageBox.Show("The article was added.", "Article info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Fermer la fenetre
                    Dispose();
                }
                catch (FormatException e)
                {
                    //Message de l'exception pour notifier l'utilisateur
                    MessageBox.Show(e.Message, "Article error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //Message de remplir pour l'utilisateur
                MessageBox.Show("Please fill all the required fields...", "Article error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
