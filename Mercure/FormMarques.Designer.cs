namespace Mercure
{
    partial class FormMarques
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.marqueListView = new System.Windows.Forms.ListView();
            this.RefMarqueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomMarqueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterMarqueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMarqueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerMarqueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // marqueListView
            // 
            this.marqueListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.marqueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RefMarqueColumn,
            this.NomMarqueColumn});
            this.marqueListView.FullRowSelect = true;
            this.marqueListView.GridLines = true;
            this.marqueListView.Location = new System.Drawing.Point(11, 13);
            this.marqueListView.Name = "marqueListView";
            this.marqueListView.Size = new System.Drawing.Size(761, 486);
            this.marqueListView.TabIndex = 0;
            this.marqueListView.UseCompatibleStateImageBehavior = false;
            this.marqueListView.View = System.Windows.Forms.View.Details;
            this.marqueListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.marqueListView_MouseClick);
            // 
            // RefMarqueColumn
            // 
            this.RefMarqueColumn.Text = "Reference marque";
            this.RefMarqueColumn.Width = 100;
            // 
            // NomMarqueColumn
            // 
            this.NomMarqueColumn.Text = "Nom de marque";
            this.NomMarqueColumn.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterMarqueButton,
            this.modifierMarqueButton,
            this.supprimerMarqueButton});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 70);
            // 
            // ajouterMarqueButton
            // 
            this.ajouterMarqueButton.Name = "ajouterMarqueButton";
            this.ajouterMarqueButton.Size = new System.Drawing.Size(129, 22);
            this.ajouterMarqueButton.Text = "Ajouter";
            this.ajouterMarqueButton.Click += new System.EventHandler(this.ajouterMarqueButton_Click);
            // 
            // modifierMarqueButton
            // 
            this.modifierMarqueButton.Name = "modifierMarqueButton";
            this.modifierMarqueButton.Size = new System.Drawing.Size(129, 22);
            this.modifierMarqueButton.Text = "Modifier";
            this.modifierMarqueButton.Click += new System.EventHandler(this.modifierMarqueButton_Click);
            // 
            // supprimerMarqueButton
            // 
            this.supprimerMarqueButton.Name = "supprimerMarqueButton";
            this.supprimerMarqueButton.Size = new System.Drawing.Size(129, 22);
            this.supprimerMarqueButton.Text = "Supprimer";
            this.supprimerMarqueButton.Click += new System.EventHandler(this.supprimerMarqueButton_Click);
            // 
            // FormMarques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.marqueListView);
            this.Name = "FormMarques";
            this.Text = "FormMarques";
            this.Load += new System.EventHandler(this.FormMarques_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView marqueListView;
        private System.Windows.Forms.ColumnHeader RefMarqueColumn;
        private System.Windows.Forms.ColumnHeader NomMarqueColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterMarqueButton;
        private System.Windows.Forms.ToolStripMenuItem modifierMarqueButton;
        private System.Windows.Forms.ToolStripMenuItem supprimerMarqueButton;
    }
}