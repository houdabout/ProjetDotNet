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
    
 
        public partial class FormSaveSousFamille : Form
      {
          private GroupBox groupBox1;
          private Button sauvegarderButton;
        private ComboBox familleList;
        private TextBox nomSousTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox referenceSousTextBox;


            private void InitializeComponent()
            {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.familleList = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Controls.Add(this.familleList);
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
            // familleList
            // 
            this.familleList.FormattingEnabled = true;
            this.familleList.Location = new System.Drawing.Point(137, 129);
            this.familleList.Name = "familleList";
            this.familleList.Size = new System.Drawing.Size(289, 21);
            this.familleList.TabIndex = 6;
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
        }
}
