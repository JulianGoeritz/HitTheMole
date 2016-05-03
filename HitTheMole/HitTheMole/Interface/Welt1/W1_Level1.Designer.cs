namespace HitTheMole
{
    partial class W1_Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W1_Level1));
            this.mole = new System.Windows.Forms.PictureBox();
            this.hammer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.punkte = new System.Windows.Forms.Label();
            this.tot = new System.Windows.Forms.PictureBox();
            this.mole_back = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.restzeit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole_back)).BeginInit();
            this.SuspendLayout();
            // 
            // mole
            // 
            this.mole.BackColor = System.Drawing.Color.Transparent;
            this.mole.Image = ((System.Drawing.Image)(resources.GetObject("mole.Image")));
            this.mole.Location = new System.Drawing.Point(66, 193);
            this.mole.Name = "mole";
            this.mole.Size = new System.Drawing.Size(83, 90);
            this.mole.TabIndex = 0;
            this.mole.TabStop = false;
            this.mole.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole_MouseClick);
            // 
            // hammer
            // 
            this.hammer.BackColor = System.Drawing.Color.Transparent;
            this.hammer.Image = ((System.Drawing.Image)(resources.GetObject("hammer.Image")));
            this.hammer.Location = new System.Drawing.Point(507, 29);
            this.hammer.Name = "hammer";
            this.hammer.Size = new System.Drawing.Size(69, 66);
            this.hammer.TabIndex = 1;
            this.hammer.TabStop = false;
            this.hammer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Punktzahl:";
            // 
            // punkte
            // 
            this.punkte.AutoSize = true;
            this.punkte.BackColor = System.Drawing.Color.Transparent;
            this.punkte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punkte.Location = new System.Drawing.Point(129, 13);
            this.punkte.Name = "punkte";
            this.punkte.Size = new System.Drawing.Size(22, 24);
            this.punkte.TabIndex = 4;
            this.punkte.Text = "0";
            // 
            // tot
            // 
            this.tot.BackColor = System.Drawing.Color.Transparent;
            this.tot.Image = ((System.Drawing.Image)(resources.GetObject("tot.Image")));
            this.tot.Location = new System.Drawing.Point(406, 14);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(84, 91);
            this.tot.TabIndex = 5;
            this.tot.TabStop = false;
            this.tot.Visible = false;
            // 
            // mole_back
            // 
            this.mole_back.BackColor = System.Drawing.Color.Transparent;
            this.mole_back.Image = ((System.Drawing.Image)(resources.GetObject("mole_back.Image")));
            this.mole_back.Location = new System.Drawing.Point(301, 13);
            this.mole_back.Name = "mole_back";
            this.mole_back.Size = new System.Drawing.Size(83, 92);
            this.mole_back.TabIndex = 6;
            this.mole_back.TabStop = false;
            this.mole_back.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Restzeit:";
            // 
            // restzeit
            // 
            this.restzeit.AutoSize = true;
            this.restzeit.BackColor = System.Drawing.Color.Transparent;
            this.restzeit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restzeit.Location = new System.Drawing.Point(129, 45);
            this.restzeit.Name = "restzeit";
            this.restzeit.Size = new System.Drawing.Size(34, 24);
            this.restzeit.TabIndex = 8;
            this.restzeit.Text = "60";
            // 
            // W1_Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.restzeit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mole_back);
            this.Controls.Add(this.tot);
            this.Controls.Add(this.punkte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hammer);
            this.Controls.Add(this.mole);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "W1_Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spiel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.W1_Level1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.W1_Level1_FormClosed);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.W1_Level1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.mole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mole;
        private System.Windows.Forms.PictureBox hammer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label punkte;
        private System.Windows.Forms.PictureBox tot;
        private System.Windows.Forms.PictureBox mole_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label restzeit;
    }
}