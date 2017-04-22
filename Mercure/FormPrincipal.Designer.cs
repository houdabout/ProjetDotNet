namespace Mercure
{
    partial class FormPrincipal
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouteFichierButton = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterArticleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierArticleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerArticleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.sousFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeSousFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterSousFamilleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMarqueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMarqueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.RefArticleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SousFamilleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MarqueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantiteColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrixColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.articleListView = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.menuStrip2.Size = new System.Drawing.Size(844, 24);
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
            this.modifierArticleButton.Click += new System.EventHandler(this.modifierArticleButton_Click);
            // 
            // supprimerArticleButton
            // 
            this.supprimerArticleButton.Name = "supprimerArticleButton";
            this.supprimerArticleButton.Size = new System.Drawing.Size(129, 22);
            this.supprimerArticleButton.Text = "Supprimer";
            this.supprimerArticleButton.Click += new System.EventHandler(this.supprimerArticleButton_Click);
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeFamilleButton,
            this.ajouterFamilleButton});
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.familleToolStripMenuItem.Text = "Famille";
            // 
            // listeFamilleButton
            // 
            this.listeFamilleButton.Name = "listeFamilleButton";
            this.listeFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.listeFamilleButton.Text = "Liste";
            // 
            // ajouterFamilleButton
            // 
            this.ajouterFamilleButton.Name = "ajouterFamilleButton";
            this.ajouterFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.ajouterFamilleButton.Text = "Ajouter";
            this.ajouterFamilleButton.Click += new System.EventHandler(this.ajouterFamilleButton_Click);
            // 
            // sousFamilleToolStripMenuItem
            // 
            this.sousFamilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeSousFamilleButton,
            this.ajouterSousFamilleButton});
            this.sousFamilleToolStripMenuItem.Name = "sousFamilleToolStripMenuItem";
            this.sousFamilleToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.sousFamilleToolStripMenuItem.Text = "SousFamille";
            // 
            // listeSousFamilleButton
            // 
            this.listeSousFamilleButton.Name = "listeSousFamilleButton";
            this.listeSousFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.listeSousFamilleButton.Text = "Liste";
            // 
            // ajouterSousFamilleButton
            // 
            this.ajouterSousFamilleButton.Name = "ajouterSousFamilleButton";
            this.ajouterSousFamilleButton.Size = new System.Drawing.Size(152, 22);
            this.ajouterSousFamilleButton.Text = "Ajouter";
            this.ajouterSousFamilleButton.Click += new System.EventHandler(this.ajouterSousFamilleButton_Click);
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeMarqueButton,
            this.ajouterMarqueButton});
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.marqueToolStripMenuItem.Text = "Marque";
            // 
            // listeMarqueButton
            // 
            this.listeMarqueButton.Name = "listeMarqueButton";
            this.listeMarqueButton.Size = new System.Drawing.Size(152, 22);
            this.listeMarqueButton.Text = "Liste";
            this.listeMarqueButton.Click += new System.EventHandler(this.listeMarqueButton_Click);
            // 
            // ajouterMarqueButton
            // 
            this.ajouterMarqueButton.Name = "ajouterMarqueButton";
            this.ajouterMarqueButton.Size = new System.Drawing.Size(152, 22);
            this.ajouterMarqueButton.Text = "Ajouter";
            this.ajouterMarqueButton.Click += new System.EventHandler(this.ajouterMarqueButton_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 454);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(844, 22);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
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
            // articleListView
            // 
            this.articleListView.AutoArrange = false;
            this.articleListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.articleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RefArticleColumn,
            this.DescriptionColumn,
            this.SousFamilleColumn,
            this.MarqueColumn,
            this.QuantiteColumn,
            this.PrixColumn});
            this.articleListView.FullRowSelect = true;
            this.articleListView.GridLines = true;
            this.articleListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.articleListView.Location = new System.Drawing.Point(12, 27);
            this.articleListView.MultiSelect = false;
            this.articleListView.Name = "articleListView";
            this.articleListView.Size = new System.Drawing.Size(820, 415);
            this.articleListView.TabIndex = 3;
            this.articleListView.UseCompatibleStateImageBehavior = false;
            this.articleListView.View = System.Windows.Forms.View.Details;
            this.articleListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.articleTable_Keys_Click);
            this.articleListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.articleTable_MouseClick);
            this.articleListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.articleTable_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnArticleToolStripMenuItem,
            this.modifierArticleToolStripMenuItem,
            this.supprimerArticleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // ajouterUnArticleToolStripMenuItem
            // 
            this.ajouterUnArticleToolStripMenuItem.Name = "ajouterUnArticleToolStripMenuItem";
            this.ajouterUnArticleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ajouterUnArticleToolStripMenuItem.Text = "Ajouter un article";
            this.ajouterUnArticleToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnArticleToolStripMenuItem_Click);
            // 
            // modifierArticleToolStripMenuItem
            // 
            this.modifierArticleToolStripMenuItem.Name = "modifierArticleToolStripMenuItem";
            this.modifierArticleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.modifierArticleToolStripMenuItem.Text = "Modifier";
            this.modifierArticleToolStripMenuItem.Click += new System.EventHandler(this.modifierArticleToolStripMenuItem_Click);
            // 
            // supprimerArticleToolStripMenuItem
            // 
            this.supprimerArticleToolStripMenuItem.Name = "supprimerArticleToolStripMenuItem";
            this.supprimerArticleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.supprimerArticleToolStripMenuItem.Text = "Supprimer";
            this.supprimerArticleToolStripMenuItem.Click += new System.EventHandler(this.supprimerArticleToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(844, 476);
            this.Controls.Add(this.articleListView);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "FormPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem ajouterArticleButton;
        private System.Windows.Forms.ToolStripMenuItem modifierArticleButton;
        private System.Windows.Forms.ToolStripMenuItem supprimerArticleButton;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem sousFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterSousFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem listeSousFamilleButton;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMarqueButton;
        private System.Windows.Forms.ToolStripMenuItem listeMarqueButton;
        private System.Windows.Forms.ColumnHeader RefArticleColumn;
        private System.Windows.Forms.ColumnHeader DescriptionColumn;
        private System.Windows.Forms.ColumnHeader SousFamilleColumn;
        private System.Windows.Forms.ColumnHeader MarqueColumn;
        private System.Windows.Forms.ColumnHeader QuantiteColumn;
        private System.Windows.Forms.ColumnHeader PrixColumn;
        private System.Windows.Forms.ListView articleListView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeFamilleButton;
    }
}