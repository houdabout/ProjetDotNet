namespace Mercure
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouteFichierButton = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterArticleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierArticleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerArticleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.sousFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterSousFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modiferSousFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerSousFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMarqueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMarqueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerMarqueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.articleList = new System.Windows.Forms.ListView();
            this.RefArticleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SousFamilleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MarqueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantiteColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrixColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.articlesToolStripMenuItem,
            this.familleToolStripMenuItem,
            this.sousFamilleToolStripMenuItem,
            this.marqueToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(690, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouteFichierButton});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Fichier";
            // 
            // ajouteFichierButton
            // 
            this.ajouteFichierButton.Name = "ajouteFichierButton";
            this.ajouteFichierButton.Size = new System.Drawing.Size(113, 22);
            this.ajouteFichierButton.Text = "Ajouter";
            this.ajouteFichierButton.Click += new System.EventHandler(this.ajouteFichierButton_Click);
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterArticleButton,
            this.modifierArticleButton,
            this.supprimerArticleButton});
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.articlesToolStripMenuItem.Text = "Articles";
            // 
            // ajouterArticleButton
            // 
            this.ajouterArticleButton.Name = "ajouterArticleButton";
            this.ajouterArticleButton.Size = new System.Drawing.Size(129, 22);
            this.ajouterArticleButton.Text = "Ajouter";
            this.ajouterArticleButton.Click += new System.EventHandler(this.ajouterArticleButton_Click);
            // 
            // modifierArticleButton
            // 
            this.modifierArticleButton.Name = "modifierArticleButton";
            this.modifierArticleButton.Size = new System.Drawing.Size(129, 22);
            this.modifierArticleButton.Text = "Modifier";
            // 
            // supprimerArticleButton
            // 
            this.supprimerArticleButton.Name = "supprimerArticleButton";
            this.supprimerArticleButton.Size = new System.Drawing.Size(129, 22);
            this.supprimerArticleButton.Text = "Supprimer";
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterFamilleButton,
            this.modifierFamilleButton,
            this.supprimerFamilleButton});
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.familleToolStripMenuItem.Text = "Famille";
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
            // 
            // supprimerFamilleButton
            // 
            this.supprimerFamilleButton.Name = "supprimerFamilleButton";
            this.supprimerFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.supprimerFamilleButton.Text = "Supprimer";
            // 
            // sousFamilleToolStripMenuItem
            // 
            this.sousFamilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterSousFamilleButton,
            this.modiferSousFamilleButton,
            this.supprimerSousFamilleButton});
            this.sousFamilleToolStripMenuItem.Name = "sousFamilleToolStripMenuItem";
            this.sousFamilleToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.sousFamilleToolStripMenuItem.Text = "SousFamille";
            // 
            // ajouterSousFamilleButton
            // 
            this.ajouterSousFamilleButton.Name = "ajouterSousFamilleButton";
            this.ajouterSousFamilleButton.Size = new System.Drawing.Size(129, 22);
            this.ajouterSousFamilleButton.Text = "Ajouter";
            // 
            // modiferSousFamilleButton
            // 
            this.modiferSousFamilleButton.Name = "modiferSousFamilleButton";
            this.modiferSousFamilleButton.Size = new System.Drawing.Size(129, 22);
            this.modiferSousFamilleButton.Text = "Modifer";
            // 
            // supprimerSousFamilleButton
            // 
            this.supprimerSousFamilleButton.Name = "supprimerSousFamilleButton";
            this.supprimerSousFamilleButton.Size = new System.Drawing.Size(129, 22);
            this.supprimerSousFamilleButton.Text = "Supprimer";
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterMarqueButton,
            this.modifierMarqueButton,
            this.supprimerMarqueButton});
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.marqueToolStripMenuItem.Text = "Marque";
            // 
            // ajouterMarqueButton
            // 
            this.ajouterMarqueButton.Name = "ajouterMarqueButton";
            this.ajouterMarqueButton.Size = new System.Drawing.Size(129, 22);
            this.ajouterMarqueButton.Text = "Ajouter";
            // 
            // modifierMarqueButton
            // 
            this.modifierMarqueButton.Name = "modifierMarqueButton";
            this.modifierMarqueButton.Size = new System.Drawing.Size(129, 22);
            this.modifierMarqueButton.Text = "Modifier";
            // 
            // supprimerMarqueButton
            // 
            this.supprimerMarqueButton.Name = "supprimerMarqueButton";
            this.supprimerMarqueButton.Size = new System.Drawing.Size(129, 22);
            this.supprimerMarqueButton.Text = "Supprimer";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 275);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(690, 22);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // articleList
            // 
            this.articleList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.articleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RefArticleColumn,
            this.DescriptionColumn,
            this.SousFamilleColumn,
            this.MarqueColumn,
            this.QuantiteColumn,
            this.PrixColumn});
            this.articleList.GridLines = true;
            this.articleList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.articleList.Location = new System.Drawing.Point(12, 62);
            this.articleList.MultiSelect = false;
            this.articleList.Name = "articleList";
            this.articleList.Size = new System.Drawing.Size(666, 210);
            this.articleList.TabIndex = 3;
            this.articleList.UseCompatibleStateImageBehavior = false;
            this.articleList.View = System.Windows.Forms.View.Details;
            // 
            // RefArticleColumn
            // 
            this.RefArticleColumn.Text = "Reference Article";
            this.RefArticleColumn.Width = 100;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.Text = "Description";
            this.DescriptionColumn.Width = 100;
            // 
            // SousFamilleColumn
            // 
            this.SousFamilleColumn.Text = "Sous-Famille";
            this.SousFamilleColumn.Width = 110;
            // 
            // MarqueColumn
            // 
            this.MarqueColumn.Text = "Marque";
            this.MarqueColumn.Width = 100;
            // 
            // QuantiteColumn
            // 
            this.QuantiteColumn.Text = "Quantitée";
            this.QuantiteColumn.Width = 100;
            // 
            // PrixColumn
            // 
            this.PrixColumn.Text = "PrixHT";
            this.PrixColumn.Width = 100;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(690, 297);
            this.Controls.Add(this.articleList);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouteFichierButton;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ListView articleList;
        private System.Windows.Forms.ColumnHeader RefArticleColumn;
        private System.Windows.Forms.ColumnHeader DescriptionColumn;
        private System.Windows.Forms.ColumnHeader SousFamilleColumn;
        private System.Windows.Forms.ColumnHeader MarqueColumn;
        private System.Windows.Forms.ColumnHeader QuantiteColumn;
        private System.Windows.Forms.ToolStripMenuItem ajouterArticleButton;
        private System.Windows.Forms.ToolStripMenuItem modifierArticleButton;
        private System.Windows.Forms.ToolStripMenuItem supprimerArticleButton;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem modifierFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem supprimerFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem sousFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterSousFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem modiferSousFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem supprimerSousFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMarqueButton;
        private System.Windows.Forms.ToolStripMenuItem modifierMarqueButton;
        private System.Windows.Forms.ToolStripMenuItem supprimerMarqueButton;
        private System.Windows.Forms.ColumnHeader PrixColumn;
    }
}