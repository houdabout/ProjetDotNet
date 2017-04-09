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

        private const String OPERATION_UPDATE = "update";
        private const String OPERATION_CLEAR_INSERT = "clear&insert";

        private String databaseFileName = "Mercure.SQLite";
        private String XmlFileName = null;
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
        
        private void progressTextBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            progressTextBox.SelectionStart = progressTextBox.Text.Length;
            // scroll it automatically
            progressTextBox.ScrollToCaret();
        }

        private void parcourirButton_Click(object sender, EventArgs e)
        {
            FileDialog form = new OpenFileDialog();
            form.InitialDirectory = "C:\\";
            form.Filter = "XML Files (*.xml)|*.xml";
            form.RestoreDirectory = true;
            if (form.ShowDialog() == DialogResult.OK)
            {
                setCurrentFileName(form.FileName);
            }
        }

        private void commencerButton_Click(object sender, EventArgs e)
        {
            if(XmlFileName != null)
            {
                RegisterMessage(null, true);
                bool miseChecked = miseRadioButton.Checked;
                if (miseChecked)
                {
                    operation = OPERATION_UPDATE;
                }
                Thread tid1 = new Thread(new ThreadStart(HandleXML));
                tid1.Start();
            }
            else
            {
                RegisterMessage("You have to select a file...", true);
            }
        }

        private void HandleXML()
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFileName);
            if (operation == OPERATION_CLEAR_INSERT)
            {
                helper.ClearDB();
                RegisterMessage("Database is cleared.");
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFileName);
            RegisterMessage("Document is loaded.");
            XmlNode root = doc.ChildNodes[1];
            int childCount = root.ChildNodes.Count;
            int incrementor = (int)Math.Ceiling((double)(100 / childCount));
            foreach (XmlNode node in root.ChildNodes)
            {
                Marque marque = HandleMarque(node);

                Famille famille = HandleFamille(node);

                SousFamille sousFamille = HandleSousFamille(node, famille);

                Article article = HandleArticle(node, marque, sousFamille);

                IncrementProgress(incrementor);
            }
            RegisterMessage("The integration was successful.");
            setCurrentFileName(null);
            ResetProgress();
        }

        private Article HandleArticle(XmlNode node, Marque marque, SousFamille sousFamille)
        {
            //Handle article
            String refArticle = node.ChildNodes[1].InnerText;
            String description = node.ChildNodes[0].InnerText;
            float prixHT = float.Parse(node.ChildNodes[5].InnerText);
            Article article = Article.FindArticle(databaseFileName, refArticle);
            if (article == null)
            {
                article = new Article(refArticle, description, prixHT, 0, sousFamille.RefSousFamille, marque.RefMarque);
                Article.InsertArticle(databaseFileName, article);

                RegisterMessage("Article : " + refArticle + " is added.");
            }
            return article;
        }

        private SousFamille HandleSousFamille(XmlNode node, Famille famille)
        {
            //Handle SousFamille
            String sousFamilleNom = node.ChildNodes[4].InnerText;
            SousFamille sousFamille = SousFamille.FindSousFamilleByNom(databaseFileName, sousFamilleNom);
            if (sousFamille == null)
            {
                int Count = SousFamille.GetSize(databaseFileName);
                sousFamille = new SousFamille(Count, famille.RefFamille, sousFamilleNom);
                SousFamille.InsertSousFamille(databaseFileName, sousFamille);

                RegisterMessage("Sous-Famille : " + sousFamilleNom + " is added.");
            }

            return sousFamille;
        }

        private Famille HandleFamille(XmlNode node)
        {
            //Handle Famille
            String familleNom = node.ChildNodes[3].InnerText;
            Famille famille = Famille.FindFamilleByNom(databaseFileName, familleNom);
            if (famille == null)
            {
                int Count = Famille.GetSize(databaseFileName);
                famille = new Famille(Count, familleNom);
                Famille.InsertFamille(databaseFileName, famille);

                RegisterMessage("Famille : " + familleNom + " is added.");
            }

            return famille;
        }

        private Marque HandleMarque(XmlNode node)
        {
            //Handle marque
            String marqueNom = node.ChildNodes[2].InnerText;
            Marque marque = Marque.FindMarqueByNom(databaseFileName, marqueNom);
            if (marque == null)
            {
                int Count = Marque.GetSize(databaseFileName);
                marque = new Marque(Count, marqueNom);
                Marque.InsertMarque(databaseFileName, marque);

                RegisterMessage("Marque : "+ marqueNom + " is added.");
            }

            return marque;
        }

        private void RegisterMessage(String message, bool preempty = false)
        {
            this.Invoke((MethodInvoker)delegate 
            {
                if (preempty)
                {
                    progressTextBox.Text = "";
                }
                progressTextBox.AppendText(message + "\n");
            });
        }

        private void IncrementProgress(int progress)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (integrationProgressBar.Value < 100 && integrationProgressBar.Value + progress <= 100)
                {
                    integrationProgressBar.Value += progress;
                }
                else
                {
                    integrationProgressBar.Value = 100;
                }
            });
        }

        private void ResetProgress()
        {
            this.Invoke((MethodInvoker)delegate
            {
                integrationProgressBar.Value = 0;
            });
        }

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