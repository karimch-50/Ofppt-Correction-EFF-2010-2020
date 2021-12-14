namespace ADO_EFF2011_TP_V01
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
            this.misAJourAutocaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieCalendrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listVoyageAssurerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerCalendrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalKilometreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misAJourAutocaresToolStripMenuItem,
            this.saisieCalendrierToolStripMenuItem,
            this.listVoyageAssurerToolStripMenuItem,
            this.imprimerCalendrierToolStripMenuItem,
            this.totalKilometreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(36, 96);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // misAJourAutocaresToolStripMenuItem
            // 
            this.misAJourAutocaresToolStripMenuItem.Name = "misAJourAutocaresToolStripMenuItem";
            this.misAJourAutocaresToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.misAJourAutocaresToolStripMenuItem.Text = "Mis a jour Autocares";
            this.misAJourAutocaresToolStripMenuItem.Click += new System.EventHandler(this.misAJourAutocaresToolStripMenuItem_Click);
            // 
            // saisieCalendrierToolStripMenuItem
            // 
            this.saisieCalendrierToolStripMenuItem.Name = "saisieCalendrierToolStripMenuItem";
            this.saisieCalendrierToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.saisieCalendrierToolStripMenuItem.Text = "Saisie Calendrier";
            this.saisieCalendrierToolStripMenuItem.Click += new System.EventHandler(this.saisieCalendrierToolStripMenuItem_Click);
            // 
            // listVoyageAssurerToolStripMenuItem
            // 
            this.listVoyageAssurerToolStripMenuItem.Name = "listVoyageAssurerToolStripMenuItem";
            this.listVoyageAssurerToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.listVoyageAssurerToolStripMenuItem.Text = "List Voyage Assurer";
            this.listVoyageAssurerToolStripMenuItem.Click += new System.EventHandler(this.listVoyageAssurerToolStripMenuItem_Click);
            // 
            // imprimerCalendrierToolStripMenuItem
            // 
            this.imprimerCalendrierToolStripMenuItem.Name = "imprimerCalendrierToolStripMenuItem";
            this.imprimerCalendrierToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.imprimerCalendrierToolStripMenuItem.Text = "Imprimer Calendrier";
            this.imprimerCalendrierToolStripMenuItem.Click += new System.EventHandler(this.imprimerCalendrierToolStripMenuItem_Click);
            // 
            // totalKilometreToolStripMenuItem
            // 
            this.totalKilometreToolStripMenuItem.Name = "totalKilometreToolStripMenuItem";
            this.totalKilometreToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.totalKilometreToolStripMenuItem.Text = "Total Kilometre";
            this.totalKilometreToolStripMenuItem.Click += new System.EventHandler(this.totalKilometreToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem misAJourAutocaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieCalendrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listVoyageAssurerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerCalendrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalKilometreToolStripMenuItem;
    }
}

