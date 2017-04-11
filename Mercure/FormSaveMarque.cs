﻿using System;
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
      public partial class FormSaveMarque : Form
      {
        private GroupBox groupBox1;
        private Button sauvegarderButton;
        private TextBox nomMarqueTextBox;
        private Label label2;
        private Label label1;
        private TextBox referenceMarqueTextBox;

        /**
        * modifier une marque ou non
        */
        private bool toUpdate = false;

        /**
        * nom de la base de données
        */
        private String databaseFileName = Configuration.DEFAULT_DATABASE;

        public FormSaveMarque()
        {
            InitializeComponent();
        }

        public FormSaveMarque(String databaseFileName)
        {
            this.databaseFileName = databaseFileName;
            InitializeComponent();
        }

        public FormSaveMarque(Marque marque)
        {
            InitializeComponent();
            InitializeTextBoxes(marque);
        }

        public FormSaveMarque(String databaseFileName, Marque marque)
        {
            this.databaseFileName = databaseFileName;
            InitializeComponent();
            InitializeTextBoxes(marque);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomMarqueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sauvegarderButton = new System.Windows.Forms.Button();
            this.referenceMarqueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomMarqueTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sauvegarderButton);
            this.groupBox1.Controls.Add(this.referenceMarqueTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remplir";
            // 
            // nomMarqueTextBox
            // 
            this.nomMarqueTextBox.Location = new System.Drawing.Point(104, 97);
            this.nomMarqueTextBox.Name = "nomMarqueTextBox";
            this.nomMarqueTextBox.Size = new System.Drawing.Size(280, 20);
            this.nomMarqueTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reference :";
            // 
            // sauvegarderButton
            // 
            this.sauvegarderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sauvegarderButton.Location = new System.Drawing.Point(166, 142);
            this.sauvegarderButton.Name = "sauvegarderButton";
            this.sauvegarderButton.Size = new System.Drawing.Size(86, 32);
            this.sauvegarderButton.TabIndex = 1;
            this.sauvegarderButton.Text = "Sauvegarder";
            this.sauvegarderButton.UseVisualStyleBackColor = false;
            this.sauvegarderButton.Click += new System.EventHandler(this.sauvegarderButton_Click);
            // 
            // referenceMarqueTextBox
            // 
            this.referenceMarqueTextBox.Location = new System.Drawing.Point(104, 47);
            this.referenceMarqueTextBox.Name = "referenceMarqueTextBox";
            this.referenceMarqueTextBox.Size = new System.Drawing.Size(280, 20);
            this.referenceMarqueTextBox.TabIndex = 0;
            // 
            // FormSaveMarque
            // 
            this.ClientSize = new System.Drawing.Size(446, 221);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSaveMarque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void InitializeTextBoxes(Marque marque)
        {
            referenceMarqueTextBox.Text = Convert.ToString(marque.RefMarque);
            nomMarqueTextBox.Text = marque.Nom;
        }

        private void sauvegarderButton_Click(object sender, EventArgs e)
        {
            SaveMarque();
        }

        private void SaveMarque()
        {
            String RefM = referenceMarqueTextBox.Text;
            String NomMarque = nomMarqueTextBox.Text;

            if(!RefM.Equals("") && !NomMarque.Equals(""))
            {
                try
                {
                    int RefMarque = int.Parse(RefM);
                    Marque marque = new Marque(RefMarque, NomMarque);
                    if(toUpdate)
                    {
                        Marque.UpdateMarque(databaseFileName, marque);
                        MessageBox.Show("The marque was updated.", "Marque info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Marque.InsertMarque(databaseFileName, marque);
                        MessageBox.Show("The marque was added.", "Marque info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Dispose();
                }
                catch(FormatException e)
                {
                    //Message de l'exception pour notifier l'utilisateur
                    MessageBox.Show(e.Message, "Marque error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Message de remplission pour l'utilisateur
                MessageBox.Show("Please fill all the required fields...", "Marque error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
