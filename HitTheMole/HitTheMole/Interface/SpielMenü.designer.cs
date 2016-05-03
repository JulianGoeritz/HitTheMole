/*
 * Erstellt mit SharpDevelop.
 * Benutzer: User
 * Datum: 26.04.2016
 * Zeit: 12:34
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace HitTheMole
{
	partial class SpielMenü
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpielMenü));
            this.auswahl = new System.Windows.Forms.GroupBox();
            this.beendenBtn = new System.Windows.Forms.PictureBox();
            this.startenBtn = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.menü = new System.Windows.Forms.MenuStrip();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswahl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beendenBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startenBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menü.SuspendLayout();
            this.SuspendLayout();
            // 
            // auswahl
            // 
            this.auswahl.BackColor = System.Drawing.Color.Transparent;
            this.auswahl.Controls.Add(this.beendenBtn);
            this.auswahl.Controls.Add(this.startenBtn);
            this.auswahl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auswahl.Location = new System.Drawing.Point(44, 209);
            this.auswahl.Name = "auswahl";
            this.auswahl.Size = new System.Drawing.Size(496, 141);
            this.auswahl.TabIndex = 2;
            this.auswahl.TabStop = false;
            // 
            // beendenBtn
            // 
            this.beendenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beendenBtn.Image = ((System.Drawing.Image)(resources.GetObject("beendenBtn.Image")));
            this.beendenBtn.Location = new System.Drawing.Point(126, 79);
            this.beendenBtn.Name = "beendenBtn";
            this.beendenBtn.Size = new System.Drawing.Size(235, 49);
            this.beendenBtn.TabIndex = 14;
            this.beendenBtn.TabStop = false;
            this.beendenBtn.Click += new System.EventHandler(this.beendenBtn_Click);
            // 
            // startenBtn
            // 
            this.startenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startenBtn.Image = ((System.Drawing.Image)(resources.GetObject("startenBtn.Image")));
            this.startenBtn.Location = new System.Drawing.Point(135, 24);
            this.startenBtn.Name = "startenBtn";
            this.startenBtn.Size = new System.Drawing.Size(209, 49);
            this.startenBtn.TabIndex = 13;
            this.startenBtn.TabStop = false;
            this.startenBtn.Click += new System.EventHandler(this.startenBtn_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(140, -28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(305, 231);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // menü
            // 
            this.menü.BackColor = System.Drawing.Color.DarkGreen;
            this.menü.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menü.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem,
            this.highscoresToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menü.Location = new System.Drawing.Point(0, 0);
            this.menü.Name = "menü";
            this.menü.Size = new System.Drawing.Size(593, 33);
            this.menü.TabIndex = 4;
            this.menü.Text = "menuStrip1";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // highscoresToolStripMenuItem
            // 
            this.highscoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.highscoresToolStripMenuItem.Name = "highscoresToolStripMenuItem";
            this.highscoresToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.highscoresToolStripMenuItem.Text = "Highscores";
            this.highscoresToolStripMenuItem.Click += new System.EventHandler(this.highscoresToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // SpielMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(593, 410);
            this.Controls.Add(this.auswahl);
            this.Controls.Add(this.menü);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menü;
            this.MaximizeBox = false;
            this.Name = "SpielMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HitTheMole";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpielMenü_FormClosing);
            this.auswahl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beendenBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startenBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menü.ResumeLayout(false);
            this.menü.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.GroupBox auswahl;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox startenBtn;
        private System.Windows.Forms.PictureBox beendenBtn;
        private System.Windows.Forms.MenuStrip menü;
        private System.Windows.Forms.ToolStripMenuItem highscoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
    }
}
