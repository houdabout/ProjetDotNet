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
using System.Threading;

namespace Mercure
{


    public partial class FormAjouterFichier : Form
    {
       
        private Button parcourirButton;
        private TextBox filenameTextBox;
        private GroupBox groupBox2;
        private RadioButton miseRadioButton;
        private RadioButton nouvelleRadioButton;
        private ProgressBar integrationProgressBar;
        private RichTextBox progressTextBox;
        private Button commencerButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private GroupBox Ajoute;

        /**
        * Constante pour l'operation de mise à jour
        */
        private const String OPERATION_UPDATE = "update";
        
        /**
        * Constante pour l'operation de la nouvelle integration
        */
        private const String OPERATION_CLEAR_INSERT = "clear&insert";

        /**
        * Nom de la base de données
        */
        private String databaseFileName = "Mercure.SQLite";

        /**
        * Nom du fichier XML
        */
        private String XmlFileName = null;

        /**
        * Operation de l'integration, par defaut c'est la nouvelle integration
        */
        private String operation = OPERATION_CLEAR_INSERT;

        public FormAjouterFichier()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Ajoute = new System.Windows.Forms.GroupBox();
            this.parcourirButton = new System.Windows.Forms.Button();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.commencerButton = new System.Windows.Forms.Button();
            this.miseRadioButton = new System.Windows.Forms.RadioButton();
            this.nouvelleRadioButton = new System.Windows.Forms.RadioButton();
            this.integrationProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressTextBox = new System.Windows.Forms.RichTextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Ajoute.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ajoute
            // 
            this.Ajoute.Controls.Add(this.parcourirButton);
            this.Ajoute.Controls.Add(this.filenameTextBox);
            this.Ajoute.Location = new System.Drawing.Point(12, 12);
            this.Ajoute.Name = "Ajoute";
            this.Ajoute.Size = new System.Drawing.Size(696, 77);
            this.Ajoute.TabIndex = 0;
            this.Ajoute.TabStop = false;
            this.Ajoute.Text = "Selectionner Fichier";
            // 
            // parcourirButton
            // 
            this.parcourirButton.Location = new System.Drawing.Point(287, 28);
            this.parcourirButton.Name = "parcourirButton";
            this.parcourirButton.Size = new System.Drawing.Size(163, 20);
            this.parcourirButton.TabIndex = 1;
            this.parcourirButton.Text = "Parcourir";
            this.parcourirButton.UseVisualStyleBackColor = true;
            this.parcourirButton.Click += new System.EventHandler(this.parcourirButton_Click);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(44, 28);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(215, 20);
            this.filenameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.commencerButton);
            this.groupBox2.Controls.Add(this.miseRadioButton);
            this.groupBox2.Controls.Add(this.nouvelleRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // commencerButton
            // 
            this.commencerButton.Location = new System.Drawing.Point(330, 32);
            this.commencerButton.Name = "commencerButton";
            this.commencerButton.Size = new System.Drawing.Size(163, 22);
            this.commencerButton.TabIndex = 4;
            this.commencerButton.Text = "Commencer Integration";
            this.commencerButton.UseVisualStyleBackColor = true;
            this.commencerButton.Click += new System.EventHandler(this.commencerButton_Click);
            // 
            // miseRadioButton
            // 
            this.miseRadioButton.AutoSize = true;
            this.miseRadioButton.Location = new System.Drawing.Point(197, 35);
            this.miseRadioButton.Name = "miseRadioButton";
            this.miseRadioButton.Size = new System.Drawing.Size(76, 17);
            this.miseRadioButton.TabIndex = 1;
            this.miseRadioButton.TabStop = true;
            this.miseRadioButton.Text = "Mise à jour";
            this.miseRadioButton.UseVisualStyleBackColor = true;
            // 
            // nouvelleRadioButton
            // 
            this.nouvelleRadioButton.AutoSize = true;
            this.nouvelleRadioButton.Checked = true;
            this.nouvelleRadioButton.Location = new System.Drawing.Point(44, 35);
            this.nouvelleRadioButton.Name = "nouvelleRadioButton";
            this.nouvelleRadioButton.Size = new System.Drawing.Size(119, 17);
            this.nouvelleRadioButton.TabIndex = 0;
            this.nouvelleRadioButton.TabStop = true;
            this.nouvelleRadioButton.Text = "Nouvelle integration";
            this.nouvelleRadioButton.UseVisualStyleBackColor = true;
            // 
            // integrationProgressBar
            // 
            this.integrationProgressBar.Location = new System.Drawing.Point(12, 210);
            this.integrationProgressBar.Name = "integrationProgressBar";
            this.integrationProgressBar.Size = new System.Drawing.Size(696, 22);
            this.integrationProgressBar.Step = 1;
            this.integrationProgressBar.TabIndex = 2;
            // 
            // progressTextBox
            // 
            this.progressTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.progressTextBox.Location = new System.Drawing.Point(12, 238);
            this.progressTextBox.Name = "progressTextBox";
            this.progressTextBox.Size = new System.Drawing.Size(696, 110);
            this.progressTextBox.TabIndex = 3;
            this.progressTextBox.Text = "";
            this.progressTextBox.TextChanged += new System.EventHandler(this.progressTextBox_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormAjouterFichier
            // 
            this.ClientSize = new System.Drawing.Size(720, 360);
            this.Controls.Add(this.progressTextBox);
            this.Controls.Add(this.integrationProgressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Ajoute);
            this.Name = "FormAjouterFichier";
            this.Ajoute.ResumeLayout(false);
            this.Ajoute.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        /**
        * Evenement du changement de texte dans progressTextBox
        */
        private void progressTextBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            progressTextBox.SelectionStart = progressTextBox.Text.Length;
            // scroll it automatically
            progressTextBox.ScrollToCaret();
        }

        /**
        * Evenement de click de parcourirButton
        */
        private void parcourirButton_Click(object sender, EventArgs e)
        {
            FileDialog form = new OpenFileDialog();
            form.InitialDirectory = "C:\\";
            form.Filter = "XML Files (*.xml)|*.xml";
            form.RestoreDirectory = true;
            //Ouverture d'un dialogue de fichier
            if (form.ShowDialog() == DialogResult.OK)
            {
                //Sauvegarde du nom de fichier
                setCurrentFileName(form.FileName);
            }
        }

        /**
        * Evenement de click de commencerButton
        */
        private void commencerButton_Click(object sender, EventArgs e)
        {
            if(XmlFileName != null)
            {
                //Efface les messages dans progressTextBox
                RegisterMessage(null, true);

                //Enregistre l'option choisi par l'utilisateur
                bool miseChecked = miseRadioButton.Checked;
                if (miseChecked)
                {
                    operation = OPERATION_UPDATE;
                } else
                {
                    operation = OPERATION_CLEAR_INSERT;
                }

                //Un thread séparé pour gérer le fichier xml
                Thread workerThread = new Thread(new ThreadStart(HandleXML));
                workerThread.Start();
            }
            else
            {
                RegisterMessage("You have to select a file...", true);
            }
        }

        /**
        * Fonction privée pour gérer le fichier xml
        */
        private void HandleXML()
        {
            //Efface la base de données si l'utilisateur a choisi nouvelle integration
            SQLiteHelper helper = new SQLiteHelper(databaseFileName);
            if (operation == OPERATION_CLEAR_INSERT)
            {
                helper.ClearDB();
                RegisterMessage("Database is cleared.");
            }

            //Charge le fichier xml et affiche un message à l'utilisateur
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFileName);
            RegisterMessage("Document is loaded.");

            //Prendre le noeud des articles
            XmlNode root = doc.ChildNodes[1];

            //Nombre des articles dans le fichier
            int childCount = root.ChildNodes.Count;

            //Combien devrait augmenter la barre de progression
            int incrementor = (int)Math.Ceiling((double)(100 / childCount));

            foreach (XmlNode node in root.ChildNodes)
            {
                //Insère la marque dans la base de données
                Marque marque = HandleMarque(node);

                //Insère la famille dans la base de données
                Famille famille = HandleFamille(node);

                //Insère le sous-famille dans la base de données 
                SousFamille sousFamille = HandleSousFamille(node, famille);

                //Insère l'article dans la base de données
                Article article = HandleArticle(node, marque, sousFamille);

                //Incremente la barre de progression
                IncrementProgress(incrementor);
            }
            //Affiche un message de succés
            RegisterMessage("The integration was successful.");
            //Efface l'ancien nom de fichier
            setCurrentFileName(null);
            //Réinitialise la barre de progression
            ResetProgress();
        }


        /**
        * Fonction privée pour gérer la marque dans le noeud
        */
        private Marque HandleMarque(XmlNode node)
        {
            //Nom de la marque
            String marqueNom = node.ChildNodes[2].InnerText;
            //Recherche si la marque est déjà dans la base de données
            Marque marque = Marque.FindMarqueByNom(databaseFileName, marqueNom);
            if (marque == null)
            {
                //Insertion de la marque
                int Count = Marque.GetSize(databaseFileName);
                marque = new Marque(Count, marqueNom);
                Marque.InsertMarque(databaseFileName, marque);

                //Affiche d'un message de notification
                RegisterMessage("Marque : " + marqueNom + " is added.");
            }

            return marque;
        }

        /**
        * Fonction privée pour gérer le sous-famille dans le noeud
        */
        private SousFamille HandleSousFamille(XmlNode node, Famille famille)
        {
            //Npm de sous-famille
            String sousFamilleNom = node.ChildNodes[4].InnerText;
            //Recherche si le sous-famille est déjà dans la base de données
            SousFamille sousFamille = SousFamille.FindSousFamilleByNom(databaseFileName, sousFamilleNom);
            if (sousFamille == null)
            {
                //Insertion de sous-famille
                int Count = SousFamille.GetSize(databaseFileName);
                sousFamille = new SousFamille(Count, famille.RefFamille, sousFamilleNom);
                SousFamille.InsertSousFamille(databaseFileName, sousFamille);

                //Affiche d'un message de notification
                RegisterMessage("Sous-Famille : " + sousFamilleNom + " is added.");
            }

            return sousFamille;
        }

        /**
        * Fonction privée pour gérer la famille dans le noeud
        */
        private Famille HandleFamille(XmlNode node)
        {
            //Nom de la Famille
            String familleNom = node.ChildNodes[3].InnerText;
            //Recherche si la famille est déjà dans la base de données
            Famille famille = Famille.FindFamilleByNom(databaseFileName, familleNom);
            if (famille == null)
            {
                //Insertion de la famille
                int Count = Famille.GetSize(databaseFileName);
                famille = new Famille(Count, familleNom);
                Famille.InsertFamille(databaseFileName, famille);

                //Affiche d'un message de notification
                RegisterMessage("Famille : " + familleNom + " is added.");
            }

            return famille;
        }

        /**
        * Fonction privée pour gérer l'article dans le noeud
        */
        private Article HandleArticle(XmlNode node, Marque marque, SousFamille sousFamille)
        {
            //Reference de l'article
            String refArticle = node.ChildNodes[1].InnerText;
            //Description de l'article
            String description = node.ChildNodes[0].InnerText;
            //Prix de l'article
            float prixHT = float.Parse(node.ChildNodes[5].InnerText);

            //Recherche si l'article est déjà dans la base de données
            Article article = Article.FindArticle(databaseFileName, refArticle);
            if (article == null)
            {
                //Insertion de l'article
                article = new Article(refArticle, description, prixHT, 0, sousFamille.RefSousFamille, marque.RefMarque);
                Article.InsertArticle(databaseFileName, article);

                //Affiche d'un message de notification
                RegisterMessage("Article : " + refArticle + " is added.");
            }
            return article;
        }

        /**
        * Fonction privée pour afficher un message à l'utilisateur
        */
        private void RegisterMessage(String message, bool preempty = false)
        {
            this.Invoke((MethodInvoker)delegate 
            {
                if (preempty)
                {
                    //Vide le boite de texte
                    progressTextBox.Text = "";
                }
                //Ajoute un texte dans progressTextBox
                progressTextBox.AppendText(message + "\n");
            });
        }

        /**
        * Fonction privée pour incrementer la barre de progression
        */
        private void IncrementProgress(int progress)
        {
            this.Invoke((MethodInvoker)delegate
            {
                //Incremente la barre s'il ne dépasse pas 100
                if (integrationProgressBar.Value < 100 && integrationProgressBar.Value + progress <= 100)
                {
                    integrationProgressBar.Value += progress;
                }
                //S'il dépasse 100 on met la valeur 100 dans la barre de progression
                else
                {
                    integrationProgressBar.Value = 100;
                }
            });
        }

        /**
        * Fonction privée pour réinitialiser la barre de progression
        */
        private void ResetProgress()
        {
            this.Invoke((MethodInvoker)delegate
            {
                integrationProgressBar.Value = 0;
            });
        }

        /**
        * Fonction privée pour définir le nom de fichier actuel
        */
        private void setCurrentFileName(String name)
        {
            XmlFileName = name;
            this.Invoke((MethodInvoker)delegate
            {
                this.filenameTextBox.Text = XmlFileName;
            });
        }
    }
}