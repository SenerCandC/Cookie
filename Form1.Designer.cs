namespace CookieClicker
{
    partial class Form1
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
            this.All_Point = new System.Windows.Forms.Label();
            this.Point = new System.Windows.Forms.Label();
            this.Click = new System.Windows.Forms.Button();
            this.Upgrades = new System.Windows.Forms.Button();
            this.ShowAddPW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // All_Point
            // 
            this.All_Point.BackColor = System.Drawing.SystemColors.HotTrack;
            this.All_Point.Location = new System.Drawing.Point(12, 9);
            this.All_Point.Name = "All_Point";
            this.All_Point.Size = new System.Drawing.Size(250, 50);
            this.All_Point.TabIndex = 4;
            this.All_Point.Text = " All Point";
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Point.Location = new System.Drawing.Point(522, 9);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(250, 50);
            this.Point.TabIndex = 5;
            this.Point.Text = "Point";
            // 
            // Click
            // 
            this.Click.Location = new System.Drawing.Point(12, 112);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(132, 129);
            this.Click.TabIndex = 6;
            this.Click.Text = "Click";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.Click_Click);
            // 
            // Upgrades
            // 
            this.Upgrades.Location = new System.Drawing.Point(12, 342);
            this.Upgrades.Name = "Upgrades";
            this.Upgrades.Size = new System.Drawing.Size(188, 85);
            this.Upgrades.TabIndex = 7;
            this.Upgrades.Text = "Upgrades";
            this.Upgrades.UseVisualStyleBackColor = true;
            this.Upgrades.Click += new System.EventHandler(this.Upgrades_Click);
            // 
            // ShowAddPW
            // 
            this.ShowAddPW.AutoSize = true;
            this.ShowAddPW.Location = new System.Drawing.Point(150, 112);
            this.ShowAddPW.Name = "ShowAddPW";
            this.ShowAddPW.Size = new System.Drawing.Size(35, 13);
            this.ShowAddPW.TabIndex = 8;
            this.ShowAddPW.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ShowAddPW);
            this.Controls.Add(this.Upgrades);
            this.Controls.Add(this.Click);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.All_Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label All_Point;
        private System.Windows.Forms.Label Point;
        private System.Windows.Forms.Button Click;
        private System.Windows.Forms.Button Upgrades;
        private System.Windows.Forms.Label ShowAddPW;
    }
}

