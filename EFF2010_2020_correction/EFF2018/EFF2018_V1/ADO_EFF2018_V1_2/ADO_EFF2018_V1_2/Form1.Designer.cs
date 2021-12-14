namespace ADO_EFF2018_V1_2
{
    partial class Form1
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
            this.miseAJourVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailDuneLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseAJourVoitureToolStripMenuItem,
            this.rechercheToolStripMenuItem,
            this.consulterLocationToolStripMenuItem,
            this.detailDuneLocationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miseAJourVoitureToolStripMenuItem
            // 
            this.miseAJourVoitureToolStripMenuItem.Name = "miseAJourVoitureToolStripMenuItem";
            this.miseAJourVoitureToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.miseAJourVoitureToolStripMenuItem.Text = "Mise a Jour Voiture";
            this.miseAJourVoitureToolStripMenuItem.Click += new System.EventHandler(this.miseAJourVoitureToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.rechercheToolStripMenuItem.Text = "Recherche Voiture";
            this.rechercheToolStripMenuItem.Click += new System.EventHandler(this.rechercheToolStripMenuItem_Click);
            // 
            // consulterLocationToolStripMenuItem
            // 
            this.consulterLocationToolStripMenuItem.Name = "consulterLocationToolStripMenuItem";
            this.consulterLocationToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.consulterLocationToolStripMenuItem.Text = "Consulter location";
            this.consulterLocationToolStripMenuItem.Click += new System.EventHandler(this.consulterLocationToolStripMenuItem_Click);
            // 
            // detailDuneLocationToolStripMenuItem
            // 
            this.detailDuneLocationToolStripMenuItem.Name = "detailDuneLocationToolStripMenuItem";
            this.detailDuneLocationToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.detailDuneLocationToolStripMenuItem.Text = "detail d\'une location";
            this.detailDuneLocationToolStripMenuItem.Click += new System.EventHandler(this.detailDuneLocationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 285);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miseAJourVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailDuneLocationToolStripMenuItem;
    }
}

