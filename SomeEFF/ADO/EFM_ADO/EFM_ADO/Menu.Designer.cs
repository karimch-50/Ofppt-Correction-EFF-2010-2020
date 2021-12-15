namespace EFM_ADO_karim_chaouki
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misAJourExamantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misAJourCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesNotesParCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.misAJourExamantsToolStripMenuItem,
            this.misAJourCoursToolStripMenuItem,
            this.feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem,
            this.lesNotesParCoursToolStripMenuItem,
            this.listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(39, 43);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.testToolStripMenuItem.Text = "Mis A Jour Etudiant";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // misAJourExamantsToolStripMenuItem
            // 
            this.misAJourExamantsToolStripMenuItem.Name = "misAJourExamantsToolStripMenuItem";
            this.misAJourExamantsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.misAJourExamantsToolStripMenuItem.Text = "Mis A Jour Examants";
            this.misAJourExamantsToolStripMenuItem.Click += new System.EventHandler(this.misAJourExamantsToolStripMenuItem_Click);
            // 
            // feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem
            // 
            this.feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem.Name = "feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem";
            this.feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem.Size = new System.Drawing.Size(245, 20);
            this.feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem.Text = "Feulle de Rechereche d\'Etudiant et Examen";
            this.feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem.Click += new System.EventHandler(this.feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem_Click);
            // 
            // misAJourCoursToolStripMenuItem
            // 
            this.misAJourCoursToolStripMenuItem.Name = "misAJourCoursToolStripMenuItem";
            this.misAJourCoursToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.misAJourCoursToolStripMenuItem.Text = "Mis A Jour Cours";
            this.misAJourCoursToolStripMenuItem.Click += new System.EventHandler(this.misAJourCoursToolStripMenuItem_Click);
            // 
            // lesNotesParCoursToolStripMenuItem
            // 
            this.lesNotesParCoursToolStripMenuItem.Name = "lesNotesParCoursToolStripMenuItem";
            this.lesNotesParCoursToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.lesNotesParCoursToolStripMenuItem.Text = "Les Notes par Cours";
            this.lesNotesParCoursToolStripMenuItem.Click += new System.EventHandler(this.lesNotesParCoursToolStripMenuItem_Click);
            // 
            // listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem
            // 
            this.listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem.Name = "listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem";
            this.listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem.Size = new System.Drawing.Size(252, 20);
            this.listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem.Text = "Listes des Note d\"etudiant avec ca moyenne";
            this.listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem.Click += new System.EventHandler(this.listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 145);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misAJourExamantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misAJourCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesNotesParCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem;
    }
}

