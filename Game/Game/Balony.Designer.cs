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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balony));
            this.Wyjscie = new System.Windows.Forms.Button();
            this.GameSpace = new System.Windows.Forms.Panel();
            this.Pauza = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            // GameSpace
            // 
            this.GameSpace.BackColor = System.Drawing.SystemColors.Menu;
            this.GameSpace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameSpace.BackgroundImage")));
            this.GameSpace.Location = new System.Drawing.Point(0, 0);
            this.GameSpace.Name = "GameSpace";
            this.GameSpace.Size = new System.Drawing.Size(758, 712);
            this.GameSpace.TabIndex = 1;
            this.GameSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.GameSpace_Paint);
            // 
            // Pauza
            // 
            this.Pauza.Location = new System.Drawing.Point(767, 577);
            this.Pauza.Name = "Pauza";
            this.Pauza.Size = new System.Drawing.Size(152, 46);
            this.Pauza.TabIndex = 2;
            this.Pauza.Text = "Pauza";
            this.Pauza.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Balony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(936, 710);
            this.Controls.Add(this.Pauza);
            this.Controls.Add(this.GameSpace);
            this.Controls.Add(this.Wyjscie);
            this.Name = "Balony";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boom Balloon!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Wyjscie;
        private System.Windows.Forms.Panel GameSpace;
        private System.Windows.Forms.Button Pauza;
        private System.Windows.Forms.Timer timer;
    }
}