using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
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
        private Button Selectioner;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ProgressBar progressBar1;
        private RichTextBox richTextBox1;
        private Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private GroupBox Ajoute;

        public FormAjouterFichier()
        { }

        private void InitializeComponent()
        {
            this.Ajoute = new System.Windows.Forms.GroupBox();
            this.Selectioner = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Ajoute.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ajoute
            // 
            this.Ajoute.Controls.Add(this.Selectioner);
            this.Ajoute.Controls.Add(this.textBox1);
            this.Ajoute.Location = new System.Drawing.Point(12, 12);
            this.Ajoute.Name = "Ajoute";
            this.Ajoute.Size = new System.Drawing.Size(526, 77);
            this.Ajoute.TabIndex = 0;
            this.Ajoute.TabStop = false;
            this.Ajoute.Text = "Selectionner Fichier";
            this.Ajoute.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Selectioner
            // 
            this.Selectioner.Location = new System.Drawing.Point(248, 25);
            this.Selectioner.Name = "Selectioner";
            this.Selectioner.Size = new System.Drawing.Size(75, 23);
            this.Selectioner.TabIndex = 1;
            this.Selectioner.Text = "Selectionner";
            this.Selectioner.UseVisualStyleBackColor = true;
            this.Selectioner.Click += new System.EventHandler(this.Selectioner_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(-3, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(235, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mise a jours";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(44, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nouvelle integration";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(342, 210);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 22);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(-3, 238);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(730, 129);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-3, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Commencer Integration";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormAjouterFichier
            // 
            this.ClientSize = new System.Drawing.Size(720, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar1);
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