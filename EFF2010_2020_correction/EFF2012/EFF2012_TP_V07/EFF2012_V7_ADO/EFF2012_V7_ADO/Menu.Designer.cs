namespace EFF2012_V7_ADO
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
            this.listeDEntretienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDEtretienEnRetardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDEntretienToolStripMenuItem,
            this.listeDEtretienEnRetardToolStripMenuItem,
            this.mToolStripMenuItem,
            this.impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem,
            this.imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 22);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeDEntretienToolStripMenuItem
            // 
            this.listeDEntretienToolStripMenuItem.Name = "listeDEntretienToolStripMenuItem";
            this.listeDEntretienToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.listeDEntretienToolStripMenuItem.Text = "Liste D\'Entretien";
            this.listeDEntretienToolStripMenuItem.Click += new System.EventHandler(this.listeDEntretienToolStripMenuItem_Click);
            // 
            // listeDEtretienEnRetardToolStripMenuItem
            // 
            this.listeDEtretienEnRetardToolStripMenuItem.Name = "listeDEtretienEnRetardToolStripMenuItem";
            this.listeDEtretienEnRetardToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.listeDEtretienEnRetardToolStripMenuItem.Text = "Liste D\'Etretien en Retard";
            this.listeDEtretienEnRetardToolStripMenuItem.Click += new System.EventHandler(this.listeDEtretienEnRetardToolStripMenuItem_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.mToolStripMenuItem.Text = "Mis A Jour Vehicule";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem
            // 
            this.impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem.Name = "impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem";
            this.impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem.Size = new System.Drawing.Size(282, 20);
            this.impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem.Text = "Impimer la list des vehicule diune marque donnee";
            this.impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem.Click += new System.EventHandler(this.impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem_Click);
            // 
            // imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem
            // 
            this.imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem.Name = "imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem";
            this.imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem.Size = new System.Drawing.Size(285, 20);
            this.imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem.Text = "Imrimer la list des vehicule Regreper par la Marque";
            this.imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem.Click += new System.EventHandler(this.imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 137);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeDEntretienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDEtretienEnRetardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem;
    }
}

