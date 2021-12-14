namespace ADO_EFF2010_TP_V01
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mAJTableHopitaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJTabeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJTablePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJTableSejourneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisaisTableSoignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feuilleDeRechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.afficheSpecialiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAJTableHopitaleToolStripMenuItem,
            this.mAJTabeleToolStripMenuItem,
            this.mAJTablePatientToolStripMenuItem,
            this.mAJTableSejourneToolStripMenuItem,
            this.saisaisTableSoignToolStripMenuItem,
            this.feuilleDeRechercherToolStripMenuItem,
            this.afficheSpecialiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 71);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mAJTableHopitaleToolStripMenuItem
            // 
            this.mAJTableHopitaleToolStripMenuItem.Name = "mAJTableHopitaleToolStripMenuItem";
            this.mAJTableHopitaleToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.mAJTableHopitaleToolStripMenuItem.Text = "MAJ Table Hopital";
            this.mAJTableHopitaleToolStripMenuItem.Click += new System.EventHandler(this.mAJTableHopitaleToolStripMenuItem_Click);
            // 
            // mAJTabeleToolStripMenuItem
            // 
            this.mAJTabeleToolStripMenuItem.Name = "mAJTabeleToolStripMenuItem";
            this.mAJTabeleToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.mAJTabeleToolStripMenuItem.Text = "MAJ tabele Medecin";
            this.mAJTabeleToolStripMenuItem.Click += new System.EventHandler(this.mAJTabeleToolStripMenuItem_Click);
            // 
            // mAJTablePatientToolStripMenuItem
            // 
            this.mAJTablePatientToolStripMenuItem.Name = "mAJTablePatientToolStripMenuItem";
            this.mAJTablePatientToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.mAJTablePatientToolStripMenuItem.Text = "MAJ Table Patient";
            this.mAJTablePatientToolStripMenuItem.Click += new System.EventHandler(this.mAJTablePatientToolStripMenuItem_Click);
            // 
            // mAJTableSejourneToolStripMenuItem
            // 
            this.mAJTableSejourneToolStripMenuItem.Name = "mAJTableSejourneToolStripMenuItem";
            this.mAJTableSejourneToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.mAJTableSejourneToolStripMenuItem.Text = "MAJ Table Sejourne";
            this.mAJTableSejourneToolStripMenuItem.Click += new System.EventHandler(this.mAJTableSejourneToolStripMenuItem_Click);
            // 
            // saisaisTableSoignToolStripMenuItem
            // 
            this.saisaisTableSoignToolStripMenuItem.Name = "saisaisTableSoignToolStripMenuItem";
            this.saisaisTableSoignToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.saisaisTableSoignToolStripMenuItem.Text = "Saisais Table Soigne";
            this.saisaisTableSoignToolStripMenuItem.Click += new System.EventHandler(this.saisaisTableSoignToolStripMenuItem_Click);
            // 
            // feuilleDeRechercherToolStripMenuItem
            // 
            this.feuilleDeRechercherToolStripMenuItem.Name = "feuilleDeRechercherToolStripMenuItem";
            this.feuilleDeRechercherToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.feuilleDeRechercherToolStripMenuItem.Text = "Feuille de Rechercher";
            this.feuilleDeRechercherToolStripMenuItem.Click += new System.EventHandler(this.feuilleDeRechercherToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ouitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // afficheSpecialiteToolStripMenuItem
            // 
            this.afficheSpecialiteToolStripMenuItem.Name = "afficheSpecialiteToolStripMenuItem";
            this.afficheSpecialiteToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.afficheSpecialiteToolStripMenuItem.Text = "Affiche Specialite";
            this.afficheSpecialiteToolStripMenuItem.Click += new System.EventHandler(this.afficheSpecialiteToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 166);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.ToolStripMenuItem mAJTableHopitaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJTabeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJTablePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJTableSejourneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisaisTableSoignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feuilleDeRechercherToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem afficheSpecialiteToolStripMenuItem;
    }
}

