namespace Game
{
    partial class Balony
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
            this.components = new System.ComponentModel.Container();
            this.Wyjscie = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.punkty = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GameSpace = new Game.GamePanel();
            this.chlor = new System.Windows.Forms.PictureBox();
            this.cyjanowodor = new System.Windows.Forms.PictureBox();
            this.co2 = new System.Windows.Forms.PictureBox();
            this.hel = new System.Windows.Forms.PictureBox();
            this.metan = new System.Windows.Forms.PictureBox();
            this.siarkowodor = new System.Windows.Forms.PictureBox();
            this.tlen = new System.Windows.Forms.PictureBox();
            this.czad = new System.Windows.Forms.PictureBox();
            this.wodor = new System.Windows.Forms.PictureBox();
            this.azot = new System.Windows.Forms.PictureBox();
            this.GameSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chlor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyjanowodor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.co2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siarkowodor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wodor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azot)).BeginInit();
            this.SuspendLayout();
            // 
            // Wyjscie
            // 
            this.Wyjscie.Location = new System.Drawing.Point(767, 639);
            this.Wyjscie.Name = "Wyjscie";
            this.Wyjscie.Size = new System.Drawing.Size(152, 46);
            this.Wyjscie.TabIndex = 0;
            this.Wyjscie.Text = "Wyjscie";
            this.Wyjscie.UseVisualStyleBackColor = true;
            this.Wyjscie.Click += new System.EventHandler(this.Wyjscie_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(767, 577);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(152, 46);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // punkty
            // 
            this.punkty.AutoSize = true;
            this.punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.punkty.Location = new System.Drawing.Point(759, 21);
            this.punkty.Name = "punkty";
            this.punkty.Size = new System.Drawing.Size(181, 46);
            this.punkty.TabIndex = 3;
            this.punkty.Text = "PUNKTY";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(773, 81);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(146, 24);
            this.progressBar1.TabIndex = 4;
            // 
            // GameSpace
            // 
            this.GameSpace.BackColor = System.Drawing.SystemColors.Menu;
            this.GameSpace.BackgroundImage = global::Game.Properties.Resources.tlo;
            this.GameSpace.Controls.Add(this.chlor);
            this.GameSpace.Controls.Add(this.cyjanowodor);
            this.GameSpace.Controls.Add(this.co2);
            this.GameSpace.Controls.Add(this.hel);
            this.GameSpace.Controls.Add(this.metan);
            this.GameSpace.Controls.Add(this.siarkowodor);
            this.GameSpace.Controls.Add(this.tlen);
            this.GameSpace.Controls.Add(this.czad);
            this.GameSpace.Controls.Add(this.wodor);
            this.GameSpace.Controls.Add(this.azot);
            this.GameSpace.Location = new System.Drawing.Point(0, 0);
            this.GameSpace.Name = "GameSpace";
            this.GameSpace.Size = new System.Drawing.Size(758, 712);
            this.GameSpace.TabIndex = 1;
            this.GameSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.GameSpace_Paint);
            // 
            // chlor
            // 
            this.chlor.BackColor = System.Drawing.Color.Transparent;
            this.chlor.Image = global::Game.Properties.Resources.chlor;
            this.chlor.Location = new System.Drawing.Point(112, 584);
            this.chlor.Name = "chlor";
            this.chlor.Size = new System.Drawing.Size(104, 104);
            this.chlor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.chlor.TabIndex = 9;
            this.chlor.TabStop = false;
            this.chlor.Tag = "chlor";
            this.chlor.Click += new System.EventHandler(this.chlor_Click);
            // 
            // cyjanowodor
            // 
            this.cyjanowodor.BackColor = System.Drawing.Color.Transparent;
            this.cyjanowodor.Image = global::Game.Properties.Resources.cyjanowodor;
            this.cyjanowodor.Location = new System.Drawing.Point(222, 577);
            this.cyjanowodor.Name = "cyjanowodor";
            this.cyjanowodor.Size = new System.Drawing.Size(106, 111);
            this.cyjanowodor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cyjanowodor.TabIndex = 8;
            this.cyjanowodor.TabStop = false;
            this.cyjanowodor.Tag = "cyjanowodor";
            this.cyjanowodor.Click += new System.EventHandler(this.cyjanowodor_Click);
            // 
            // co2
            // 
            this.co2.BackColor = System.Drawing.Color.Transparent;
            this.co2.Image = global::Game.Properties.Resources.dwutlenek_wegla;
            this.co2.Location = new System.Drawing.Point(334, 577);
            this.co2.Name = "co2";
            this.co2.Size = new System.Drawing.Size(107, 101);
            this.co2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.co2.TabIndex = 7;
            this.co2.TabStop = false;
            this.co2.Tag = "co2";
            this.co2.Click += new System.EventHandler(this.co2_Click);
            // 
            // hel
            // 
            this.hel.BackColor = System.Drawing.Color.Transparent;
            this.hel.Image = global::Game.Properties.Resources.hel;
            this.hel.Location = new System.Drawing.Point(447, 577);
            this.hel.Name = "hel";
            this.hel.Size = new System.Drawing.Size(90, 96);
            this.hel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hel.TabIndex = 6;
            this.hel.TabStop = false;
            this.hel.Tag = "hel";
            this.hel.Click += new System.EventHandler(this.hel_Click);
            // 
            // metan
            // 
            this.metan.BackColor = System.Drawing.Color.Transparent;
            this.metan.Image = global::Game.Properties.Resources.metan;
            this.metan.Location = new System.Drawing.Point(543, 562);
            this.metan.Name = "metan";
            this.metan.Size = new System.Drawing.Size(123, 102);
            this.metan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.metan.TabIndex = 5;
            this.metan.TabStop = false;
            this.metan.Tag = "metan";
            this.metan.Click += new System.EventHandler(this.metan_Click);
            // 
            // siarkowodor
            // 
            this.siarkowodor.BackColor = System.Drawing.Color.Transparent;
            this.siarkowodor.Image = global::Game.Properties.Resources.siarkowodor;
            this.siarkowodor.Location = new System.Drawing.Point(595, 400);
            this.siarkowodor.Name = "siarkowodor";
            this.siarkowodor.Size = new System.Drawing.Size(107, 101);
            this.siarkowodor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.siarkowodor.TabIndex = 4;
            this.siarkowodor.TabStop = false;
            this.siarkowodor.Tag = "siarkowodor";
            this.siarkowodor.Click += new System.EventHandler(this.siarkowodor_Click);
            // 
            // tlen
            // 
            this.tlen.BackColor = System.Drawing.Color.Transparent;
            this.tlen.Image = global::Game.Properties.Resources.tlen;
            this.tlen.Location = new System.Drawing.Point(472, 418);
            this.tlen.Name = "tlen";
            this.tlen.Size = new System.Drawing.Size(90, 96);
            this.tlen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tlen.TabIndex = 3;
            this.tlen.TabStop = false;
            this.tlen.Tag = "tlen";
            this.tlen.Click += new System.EventHandler(this.tlen_Click);
            // 
            // czad
            // 
            this.czad.BackColor = System.Drawing.Color.Transparent;
            this.czad.Image = global::Game.Properties.Resources.tlenek_wegla;
            this.czad.Location = new System.Drawing.Point(360, 418);
            this.czad.Name = "czad";
            this.czad.Size = new System.Drawing.Size(123, 102);
            this.czad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.czad.TabIndex = 2;
            this.czad.TabStop = false;
            this.czad.Tag = "czad";
            this.czad.Click += new System.EventHandler(this.czad_Click);
            // 
            // wodor
            // 
            this.wodor.BackColor = System.Drawing.Color.Transparent;
            this.wodor.Image = global::Game.Properties.Resources.wodór;
            this.wodor.Location = new System.Drawing.Point(222, 418);
            this.wodor.Name = "wodor";
            this.wodor.Size = new System.Drawing.Size(104, 104);
            this.wodor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.wodor.TabIndex = 1;
            this.wodor.TabStop = false;
            this.wodor.Tag = "wodor";
            this.wodor.Click += new System.EventHandler(this.wodor_Click);
            // 
            // azot
            // 
            this.azot.BackColor = System.Drawing.Color.Transparent;
            this.azot.Image = global::Game.Properties.Resources.azot;
            this.azot.Location = new System.Drawing.Point(0, 584);
            this.azot.Name = "azot";
            this.azot.Size = new System.Drawing.Size(106, 111);
            this.azot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.azot.TabIndex = 0;
            this.azot.TabStop = false;
            this.azot.Tag = "azot";
            this.azot.Click += new System.EventHandler(this.azot_Click);
            // 
            // Balony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(936, 710);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.punkty);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.GameSpace);
            this.Controls.Add(this.Wyjscie);
            this.Name = "Balony";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boom Balloon!";
            this.GameSpace.ResumeLayout(false);
            this.GameSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chlor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyjanowodor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.co2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siarkowodor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wodor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wyjscie;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label punkty;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox azot;
        private GamePanel GameSpace;
        private System.Windows.Forms.PictureBox chlor;
        private System.Windows.Forms.PictureBox cyjanowodor;
        private System.Windows.Forms.PictureBox co2;
        private System.Windows.Forms.PictureBox hel;
        private System.Windows.Forms.PictureBox metan;
        private System.Windows.Forms.PictureBox siarkowodor;
        private System.Windows.Forms.PictureBox tlen;
        private System.Windows.Forms.PictureBox czad;
        private System.Windows.Forms.PictureBox wodor;
    }
}