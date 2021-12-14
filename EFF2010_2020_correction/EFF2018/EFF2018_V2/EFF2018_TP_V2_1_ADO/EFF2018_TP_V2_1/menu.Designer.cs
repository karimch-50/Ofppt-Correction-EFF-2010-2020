namespace EFF2018_TP_V2_1
{
    partial class menu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.consultationMedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheMedecamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMedicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misAJoursMedicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Location = new System.Drawing.Point(125, 73);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationMedecinToolStripMenuItem,
            this.ficheMedecamentToolStripMenuItem,
            this.listeMedicamentToolStripMenuItem,
            this.misAJoursMedicamentToolStripMenuItem,
            this.infoMedecinToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(56, 156);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(735, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // consultationMedecinToolStripMenuItem
            // 
            this.consultationMedecinToolStripMenuItem.Name = "consultationMedecinToolStripMenuItem";
            this.consultationMedecinToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.consultationMedecinToolStripMenuItem.Text = "Consultation Medecin";
            this.consultationMedecinToolStripMenuItem.Click += new System.EventHandler(this.consultationMedecinToolStripMenuItem_Click);
            // 
            // ficheMedecamentToolStripMenuItem
            // 
            this.ficheMedecamentToolStripMenuItem.Name = "ficheMedecamentToolStripMenuItem";
            this.ficheMedecamentToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.ficheMedecamentToolStripMenuItem.Text = "Fiche Medecament";
            this.ficheMedecamentToolStripMenuItem.Click += new System.EventHandler(this.ficheMedecamentToolStripMenuItem_Click);
            // 
            // listeMedicamentToolStripMenuItem
            // 
            this.listeMedicamentToolStripMenuItem.Name = "listeMedicamentToolStripMenuItem";
            this.listeMedicamentToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.listeMedicamentToolStripMenuItem.Text = "Liste Medicament";
            this.listeMedicamentToolStripMenuItem.Click += new System.EventHandler(this.listeMedicamentToolStripMenuItem_Click);
            // 
            // misAJoursMedicamentToolStripMenuItem
            // 
            this.misAJoursMedicamentToolStripMenuItem.Name = "misAJoursMedicamentToolStripMenuItem";
            this.misAJoursMedicamentToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.misAJoursMedicamentToolStripMenuItem.Text = "Mis A Jours Medicament";
            this.misAJoursMedicamentToolStripMenuItem.Click += new System.EventHandler(this.misAJoursMedicamentToolStripMenuItem_Click);
            // 
            // infoMedecinToolStripMenuItem
            // 
            this.infoMedecinToolStripMenuItem.Name = "infoMedecinToolStripMenuItem";
            this.infoMedecinToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.infoMedecinToolStripMenuItem.Text = "Info Medecin";
            this.infoMedecinToolStripMenuItem.Click += new System.EventHandler(this.infoMedecinToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem consultationMedecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheMedecamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMedicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misAJoursMedicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoMedecinToolStripMenuItem;
    }
}

