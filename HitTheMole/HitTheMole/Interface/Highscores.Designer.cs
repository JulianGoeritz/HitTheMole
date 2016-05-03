namespace HitTheMole
{
    partial class Highscores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Highscores));
            this.datenbankAnsicht = new System.Windows.Forms.DataGridView();
            this.SpielerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Highscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Welt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenbankEinträge = new System.Windows.Forms.Label();
            this.abfrage = new System.Windows.Forms.Label();
            this.neuLaden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datenbankAnsicht)).BeginInit();
            this.SuspendLayout();
            // 
            // datenbankAnsicht
            // 
            this.datenbankAnsicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datenbankAnsicht.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpielerName,
            this.Highscore,
            this.Welt,
            this.Level,
            this.Datum});
            this.datenbankAnsicht.Location = new System.Drawing.Point(58, 41);
            this.datenbankAnsicht.Name = "datenbankAnsicht";
            this.datenbankAnsicht.ReadOnly = true;
            this.datenbankAnsicht.Size = new System.Drawing.Size(543, 258);
            this.datenbankAnsicht.TabIndex = 0;
            // 
            // SpielerName
            // 
            this.SpielerName.HeaderText = "Name des Spielers";
            this.SpielerName.Name = "SpielerName";
            this.SpielerName.ReadOnly = true;
            // 
            // Highscore
            // 
            this.Highscore.HeaderText = "Highscore des Spielers";
            this.Highscore.Name = "Highscore";
            this.Highscore.ReadOnly = true;
            // 
            // Welt
            // 
            this.Welt.HeaderText = "Welt";
            this.Welt.Name = "Welt";
            this.Welt.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // datenbankEinträge
            // 
            this.datenbankEinträge.Dock = System.Windows.Forms.DockStyle.Top;
            this.datenbankEinträge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenbankEinträge.Location = new System.Drawing.Point(0, 0);
            this.datenbankEinträge.Name = "datenbankEinträge";
            this.datenbankEinträge.Size = new System.Drawing.Size(663, 38);
            this.datenbankEinträge.TabIndex = 1;
            this.datenbankEinträge.Text = "Einträge";
            this.datenbankEinträge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // abfrage
            // 
            this.abfrage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.abfrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.abfrage.Location = new System.Drawing.Point(0, 380);
            this.abfrage.Name = "abfrage";
            this.abfrage.Size = new System.Drawing.Size(663, 34);
            this.abfrage.TabIndex = 2;
            this.abfrage.Text = "Abfrage";
            this.abfrage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // neuLaden
            // 
            this.neuLaden.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.neuLaden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neuLaden.Location = new System.Drawing.Point(0, 339);
            this.neuLaden.Name = "neuLaden";
            this.neuLaden.Size = new System.Drawing.Size(663, 41);
            this.neuLaden.TabIndex = 3;
            this.neuLaden.Text = "Neu laden";
            this.neuLaden.UseVisualStyleBackColor = true;
            this.neuLaden.Click += new System.EventHandler(this.neuLaden_Click);
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 414);
            this.Controls.Add(this.neuLaden);
            this.Controls.Add(this.abfrage);
            this.Controls.Add(this.datenbankEinträge);
            this.Controls.Add(this.datenbankAnsicht);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Highscores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscores";
            ((System.ComponentModel.ISupportInitialize)(this.datenbankAnsicht)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datenbankAnsicht;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpielerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Highscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Welt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.Label datenbankEinträge;
        private System.Windows.Forms.Label abfrage;
        private System.Windows.Forms.Button neuLaden;
    }
}