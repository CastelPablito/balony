namespace Game
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Wyniki = new System.Windows.Forms.Button();
            this.Wyjscie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(71, 80);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(223, 66);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Wyniki
            // 
            this.Wyniki.Location = new System.Drawing.Point(71, 197);
            this.Wyniki.Name = "Wyniki";
            this.Wyniki.Size = new System.Drawing.Size(223, 66);
            this.Wyniki.TabIndex = 1;
            this.Wyniki.Text = "Wyniki";
            this.Wyniki.UseVisualStyleBackColor = true;
            // 
            // Wyjscie
            // 
            this.Wyjscie.Location = new System.Drawing.Point(71, 315);
            this.Wyjscie.Name = "Wyjscie";
            this.Wyjscie.Size = new System.Drawing.Size(223, 66);
            this.Wyjscie.TabIndex = 2;
            this.Wyjscie.Text = "Wyjście";
            this.Wyjscie.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(365, 501);
            this.Controls.Add(this.Wyjscie);
            this.Controls.Add(this.Wyniki);
            this.Controls.Add(this.Start);
            this.Name = "Menu";
            this.Text = "Boom Balloon!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Wyniki;
        private System.Windows.Forms.Button Wyjscie;
    }
}

