namespace HitTheMole
{
    partial class Einstellungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Einstellungen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.highscoresJaNein = new System.Windows.Forms.CheckBox();
            this.musikAnAus = new System.Windows.Forms.CheckBox();
            this.spielVer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dotNetVersion = new System.Windows.Forms.Label();
            this.nickNameTxt = new System.Windows.Forms.Label();
            this.nickName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.highscoresJaNein);
            this.groupBox1.Controls.Add(this.musikAnAus);
            this.groupBox1.Controls.Add(this.spielVer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dotNetVersion);
            this.groupBox1.Location = new System.Drawing.Point(39, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // highscoresJaNein
            // 
            this.highscoresJaNein.AutoSize = true;
            this.highscoresJaNein.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoresJaNein.Location = new System.Drawing.Point(252, 60);
            this.highscoresJaNein.Name = "highscoresJaNein";
            this.highscoresJaNein.Size = new System.Drawing.Size(211, 29);
            this.highscoresJaNein.TabIndex = 22;
            this.highscoresJaNein.Text = "Highscores speichern";
            this.highscoresJaNein.UseVisualStyleBackColor = true;
            // 
            // musikAnAus
            // 
            this.musikAnAus.AutoSize = true;
            this.musikAnAus.Checked = true;
            this.musikAnAus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.musikAnAus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musikAnAus.Location = new System.Drawing.Point(320, 19);
            this.musikAnAus.Name = "musikAnAus";
            this.musikAnAus.Size = new System.Drawing.Size(81, 29);
            this.musikAnAus.TabIndex = 20;
            this.musikAnAus.Text = "Musik";
            this.musikAnAus.UseVisualStyleBackColor = true;
            // 
            // spielVer
            // 
            this.spielVer.AutoSize = true;
            this.spielVer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spielVer.Location = new System.Drawing.Point(133, 64);
            this.spielVer.Name = "spielVer";
            this.spielVer.Size = new System.Drawing.Size(80, 25);
            this.spielVer.TabIndex = 19;
            this.spielVer.Text = "spielVer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Spiel-Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = ".NET-Version:";
            // 
            // dotNetVersion
            // 
            this.dotNetVersion.AutoSize = true;
            this.dotNetVersion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotNetVersion.Location = new System.Drawing.Point(133, 23);
            this.dotNetVersion.Name = "dotNetVersion";
            this.dotNetVersion.Size = new System.Drawing.Size(99, 25);
            this.dotNetVersion.TabIndex = 17;
            this.dotNetVersion.Text = "dotNetVer";
            // 
            // nickNameTxt
            // 
            this.nickNameTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickNameTxt.Location = new System.Drawing.Point(207, 9);
            this.nickNameTxt.Name = "nickNameTxt";
            this.nickNameTxt.Size = new System.Drawing.Size(103, 23);
            this.nickNameTxt.TabIndex = 20;
            this.nickNameTxt.Text = "Nickname";
            // 
            // nickName
            // 
            this.nickName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickName.Location = new System.Drawing.Point(150, 35);
            this.nickName.MaxLength = 20;
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(209, 25);
            this.nickName.TabIndex = 19;
            this.nickName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 194);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nickNameTxt);
            this.Controls.Add(this.nickName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Einstellungen";
            this.Text = "Einstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Einstellungen_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox highscoresJaNein;
        private System.Windows.Forms.CheckBox musikAnAus;
        private System.Windows.Forms.Label spielVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dotNetVersion;
        private System.Windows.Forms.Label nickNameTxt;
        private System.Windows.Forms.TextBox nickName;
    }
}