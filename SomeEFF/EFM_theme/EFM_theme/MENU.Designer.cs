
namespace EFM_theme
{
    partial class MENU
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
            this.mAJTHEMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherCommentaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToutesLesIdeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pourcentageSecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAJTHEMEToolStripMenuItem,
            this.afficherCommentaireToolStripMenuItem,
            this.afficherToutesLesIdeesToolStripMenuItem,
            this.pourcentageSecteursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(19, 115);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(822, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mAJTHEMEToolStripMenuItem
            // 
            this.mAJTHEMEToolStripMenuItem.Name = "mAJTHEMEToolStripMenuItem";
            this.mAJTHEMEToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.mAJTHEMEToolStripMenuItem.Text = "MAJ THEME";
            this.mAJTHEMEToolStripMenuItem.Click += new System.EventHandler(this.mAJTHEMEToolStripMenuItem_Click);
            // 
            // afficherCommentaireToolStripMenuItem
            // 
            this.afficherCommentaireToolStripMenuItem.Name = "afficherCommentaireToolStripMenuItem";
            this.afficherCommentaireToolStripMenuItem.Size = new System.Drawing.Size(191, 25);
            this.afficherCommentaireToolStripMenuItem.Text = "Afficher Commentaire";
            this.afficherCommentaireToolStripMenuItem.Click += new System.EventHandler(this.afficherCommentaireToolStripMenuItem_Click);
            // 
            // afficherToutesLesIdeesToolStripMenuItem
            // 
            this.afficherToutesLesIdeesToolStripMenuItem.Name = "afficherToutesLesIdeesToolStripMenuItem";
            this.afficherToutesLesIdeesToolStripMenuItem.Size = new System.Drawing.Size(204, 25);
            this.afficherToutesLesIdeesToolStripMenuItem.Text = "Afficher toutes les idees";
            this.afficherToutesLesIdeesToolStripMenuItem.Click += new System.EventHandler(this.afficherToutesLesIdeesToolStripMenuItem_Click);
            // 
            // pourcentageSecteursToolStripMenuItem
            // 
            this.pourcentageSecteursToolStripMenuItem.Name = "pourcentageSecteursToolStripMenuItem";
            this.pourcentageSecteursToolStripMenuItem.Size = new System.Drawing.Size(187, 25);
            this.pourcentageSecteursToolStripMenuItem.Text = "Pourcentage Secteurs";
            this.pourcentageSecteursToolStripMenuItem.Click += new System.EventHandler(this.pourcentageSecteursToolStripMenuItem_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 364);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MENU";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mAJTHEMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherCommentaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToutesLesIdeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pourcentageSecteursToolStripMenuItem;
    }
}

