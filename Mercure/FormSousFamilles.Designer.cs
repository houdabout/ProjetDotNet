namespace Mercure
{
    partial class FormSousFamilles
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
            this.sousFamillesListView = new System.Windows.Forms.ListView();
            this.RefSousFamilleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomSousFamilleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FamilleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterSousFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierSousFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerSousFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sousFamillesListView
            // 
            this.sousFamillesListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sousFamillesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RefSousFamilleColumn,
            this.NomSousFamilleColumn,
            this.FamilleColumn});
            this.sousFamillesListView.FullRowSelect = true;
            this.sousFamillesListView.GridLines = true;
            this.sousFamillesListView.Location = new System.Drawing.Point(13, 13);
            this.sousFamillesListView.Name = "sousFamillesListView";
            this.sousFamillesListView.Size = new System.Drawing.Size(759, 486);
            this.sousFamillesListView.TabIndex = 0;
            this.sousFamillesListView.UseCompatibleStateImageBehavior = false;
            this.sousFamillesListView.View = System.Windows.Forms.View.Details;
            this.sousFamillesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sousFamilleListView_MouseClick);
            // 
            // RefSousFamilleColumn
            // 
            this.RefSousFamilleColumn.Text = "Reference sous-famille";
            this.RefSousFamilleColumn.Width = 150;
            // 
            // NomSousFamilleColumn
            // 
            this.NomSousFamilleColumn.Text = "Nom sous-famille";
            this.NomSousFamilleColumn.Width = 200;
            // 
            // FamilleColumn
            // 
            this.FamilleColumn.Text = "Famille";
            this.FamilleColumn.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterSousFamilleButton,
            this.modifierSousFamilleButton,
            this.supprimerSousFamilleButton});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // ajouterSousFamilleButton
            // 
            this.ajouterSousFamilleButton.Name = "ajouterSousFamilleButton";
            this.ajouterSousFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.ajouterSousFamilleButton.Text = "Ajouter";
            this.ajouterSousFamilleButton.Click += new System.EventHandler(this.ajouterSousFamilleButton_Click);
            // 
            // modifierSousFamilleButton
            // 
            this.modifierSousFamilleButton.Name = "modifierSousFamilleButton";
            this.modifierSousFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.modifierSousFamilleButton.Text = "Modifier";
            this.modifierSousFamilleButton.Click += new System.EventHandler(this.modifierSousFamilleButton_Click);
            // 
            // supprimerSousFamilleButton
            // 
            this.supprimerSousFamilleButton.Name = "supprimerSousFamilleButton";
            this.supprimerSousFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.supprimerSousFamilleButton.Text = "Supprimer";
            this.supprimerSousFamilleButton.Click += new System.EventHandler(this.supprimerSousFamilleButton_Click);
            // 
            // FormSousFamilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.sousFamillesListView);
            this.Name = "FormSousFamilles";
            this.Text = "FormSousFamilles";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView sousFamillesListView;
        private System.Windows.Forms.ColumnHeader RefSousFamilleColumn;
        private System.Windows.Forms.ColumnHeader NomSousFamilleColumn;
        private System.Windows.Forms.ColumnHeader FamilleColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterSousFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem modifierSousFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem supprimerSousFamilleButton;
    }
}