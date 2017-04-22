namespace Mercure
{
    partial class FormFamilles
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
            this.familleListView = new System.Windows.Forms.ListView();
            this.RefFamilleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomFamilleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // familleListView
            // 
            this.familleListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.familleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RefFamilleColumn,
            this.NomFamilleColumn});
            this.familleListView.FullRowSelect = true;
            this.familleListView.GridLines = true;
            this.familleListView.Location = new System.Drawing.Point(13, 13);
            this.familleListView.Name = "familleListView";
            this.familleListView.Size = new System.Drawing.Size(759, 486);
            this.familleListView.TabIndex = 0;
            this.familleListView.UseCompatibleStateImageBehavior = false;
            this.familleListView.View = System.Windows.Forms.View.Details;
            this.familleListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.familleListView_MouseClick);
            // 
            // RefFamilleColumn
            // 
            this.RefFamilleColumn.Text = "Reference famille";
            this.RefFamilleColumn.Width = 100;
            // 
            // NomFamilleColumn
            // 
            this.NomFamilleColumn.Text = "Nom de la famille";
            this.NomFamilleColumn.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterFamilleButton,
            this.modifierFamilleButton,
            this.supprimerFamilleButton});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // ajouterFamilleButton
            // 
            this.ajouterFamilleButton.Name = "ajouterFamilleButton";
            this.ajouterFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.ajouterFamilleButton.Text = "Ajouter";
            this.ajouterFamilleButton.Click += new System.EventHandler(this.ajouterFamilleButton_Click);
            // 
            // modifierFamilleButton
            // 
            this.modifierFamilleButton.Name = "modifierFamilleButton";
            this.modifierFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.modifierFamilleButton.Text = "Modifier";
            this.modifierFamilleButton.Click += new System.EventHandler(this.modifierFamilleButton_Click);
            // 
            // supprimerFamilleButton
            // 
            this.supprimerFamilleButton.Name = "supprimerFamilleButton";
            this.supprimerFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.supprimerFamilleButton.Text = "Supprimer";
            this.supprimerFamilleButton.Click += new System.EventHandler(this.supprimerFamilleButton_Click);
            // 
            // FormFamilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.familleListView);
            this.Name = "FormFamilles";
            this.Text = "FormFamilles";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView familleListView;
        private System.Windows.Forms.ColumnHeader RefFamilleColumn;
        private System.Windows.Forms.ColumnHeader NomFamilleColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem modifierFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem supprimerFamilleButton;
    }
}