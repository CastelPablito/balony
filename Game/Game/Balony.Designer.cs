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
            this.Wyjscie = new System.Windows.Forms.Button();
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
            // Balony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 710);
            this.Controls.Add(this.Wyjscie);
            this.Name = "Balony";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boom Balloon!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Wyjscie;
    }
}