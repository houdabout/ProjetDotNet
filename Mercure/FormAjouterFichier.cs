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

        public FormAjouterFichier()
        { }

        private void InitializeComponent()
        {
            this.Ajoute = new System.Windows.Forms.GroupBox();
            this.parcourirButton = new System.Windows.Forms.Button();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.miseRadioButton = new System.Windows.Forms.RadioButton();
            this.nouvelleRadioButton = new System.Windows.Forms.RadioButton();
            this.integrationProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressTextBox = new System.Windows.Forms.RichTextBox();
            this.commencerButton = new System.Windows.Forms.Button();
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
            this.Ajoute.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // parcourirButton
            // 
            this.parcourirButton.Location = new System.Drawing.Point(290, 28);
            this.parcourirButton.Name = "parcourirButton";
            this.parcourirButton.Size = new System.Drawing.Size(75, 20);
            this.parcourirButton.TabIndex = 1;
            this.parcourirButton.Text = "Parcourir";
            this.parcourirButton.UseVisualStyleBackColor = true;
            this.parcourirButton.Click += new System.EventHandler(this.Selectioner_Click);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Enabled = false;
            this.filenameTextBox.Location = new System.Drawing.Point(44, 28);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(215, 20);
            this.filenameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.miseRadioButton);
            this.groupBox2.Controls.Add(this.nouvelleRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
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
            this.integrationProgressBar.Location = new System.Drawing.Point(342, 210);
            this.integrationProgressBar.Name = "integrationProgressBar";
            this.integrationProgressBar.Size = new System.Drawing.Size(366, 22);
            this.integrationProgressBar.TabIndex = 2;
            this.integrationProgressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressTextBox
            // 
            this.progressTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.progressTextBox.Location = new System.Drawing.Point(12, 238);
            this.progressTextBox.Name = "progressTextBox";
            this.progressTextBox.Size = new System.Drawing.Size(696, 110);
            this.progressTextBox.TabIndex = 3;
            this.progressTextBox.Text = "";
            // 
            // commencerButton
            // 
            this.commencerButton.Location = new System.Drawing.Point(12, 210);
            this.commencerButton.Name = "commencerButton";
            this.commencerButton.Size = new System.Drawing.Size(312, 22);
            this.commencerButton.TabIndex = 4;
            this.commencerButton.Text = "Commencer Integration";
            this.commencerButton.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormAjouterFichier
            // 
            this.ClientSize = new System.Drawing.Size(720, 360);
            this.Controls.Add(this.commencerButton);
            this.Controls.Add(this.progressTextBox);
            this.Controls.Add(this.integrationProgressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Ajoute);
            this.Name = "FormAjouterFichier";
            this.Load += new System.EventHandler(this.FormAjouterFichier_Load);
            this.Ajoute.ResumeLayout(false);
            this.Ajoute.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, System.EventArgs e)
        {

        }

        private void Selectioner_Click(object sender, System.EventArgs e)
        {

        }

        private void FormAjouterFichier_Load(object sender, System.EventArgs e)
        {

        }



    }

}