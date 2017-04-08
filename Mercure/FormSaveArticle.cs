using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
namespace Mercure
{
    
        public partial class FormSaveArticle : Form
    {
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private NumericUpDown prixComponent;
        private ComboBox sousFamilleList;
        private TextBox descriptionTextBox;
        private TextBox referenceArticleTextBox;
        private Button sauvegarderButton;
        private ComboBox marqueList;
        private Label label1;




            private void InitializeComponent()
            {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sauvegarderButton = new System.Windows.Forms.Button();
            this.prixComponent = new System.Windows.Forms.NumericUpDown();
            this.marqueList = new System.Windows.Forms.ComboBox();
            this.sousFamilleList = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.referenceArticleTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prixComponent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sauvegarderButton);
            this.groupBox1.Controls.Add(this.prixComponent);
            this.groupBox1.Controls.Add(this.marqueList);
            this.groupBox1.Controls.Add(this.sousFamilleList);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.referenceArticleTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remplir";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sauvegarderButton
            // 
            this.sauvegarderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sauvegarderButton.Location = new System.Drawing.Point(567, 117);
            this.sauvegarderButton.Name = "sauvegarderButton";
            this.sauvegarderButton.Size = new System.Drawing.Size(92, 40);
            this.sauvegarderButton.TabIndex = 13;
            this.sauvegarderButton.Text = "Sauvegarder";
            this.sauvegarderButton.UseVisualStyleBackColor = false;
            this.sauvegarderButton.Click += new System.EventHandler(this.sauvegarderButton_Click);
            // 
            // prixComponent
            // 
            this.prixComponent.Location = new System.Drawing.Point(191, 215);
            this.prixComponent.Name = "prixComponent";
            this.prixComponent.Size = new System.Drawing.Size(326, 20);
            this.prixComponent.TabIndex = 12;
            // 
            // marqueList
            // 
            this.marqueList.FormattingEnabled = true;
            this.marqueList.Location = new System.Drawing.Point(191, 170);
            this.marqueList.Name = "marqueList";
            this.marqueList.Size = new System.Drawing.Size(326, 21);
            this.marqueList.TabIndex = 11;
            // 
            // sousFamilleList
            // 
            this.sousFamilleList.FormattingEnabled = true;
            this.sousFamilleList.Location = new System.Drawing.Point(191, 128);
            this.sousFamilleList.Name = "sousFamilleList";
            this.sousFamilleList.Size = new System.Drawing.Size(326, 21);
            this.sousFamilleList.TabIndex = 10;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormSaveArticle
            // 
            this.ClientSize = new System.Drawing.Size(722, 292);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSaveArticle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prixComponent)).EndInit();
            this.ResumeLayout(false);

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

        private void sauvegarderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
