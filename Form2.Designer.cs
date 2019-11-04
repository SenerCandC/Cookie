namespace CookieClicker
{
    partial class Form2
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
            this.U_Clik = new System.Windows.Forms.Button();
            this.U_M_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.All_Point = new System.Windows.Forms.Label();
            this.Point = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // U_Clik
            // 
            this.U_Clik.Location = new System.Drawing.Point(12, 89);
            this.U_Clik.Name = "U_Clik";
            this.U_Clik.Size = new System.Drawing.Size(112, 81);
            this.U_Clik.TabIndex = 0;
            this.U_Clik.Text = "Upgrade Click";
            this.U_Clik.UseVisualStyleBackColor = true;
            this.U_Clik.Click += new System.EventHandler(this.U_Clik_Click);
            // 
            // U_M_Click
            // 
            this.U_M_Click.Location = new System.Drawing.Point(12, 190);
            this.U_M_Click.Name = "U_M_Click";
            this.U_M_Click.Size = new System.Drawing.Size(112, 81);
            this.U_M_Click.TabIndex = 1;
            this.U_M_Click.Text = "U_M_Click";
            this.U_M_Click.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1";
            // 
            // All_Point
            // 
            this.All_Point.BackColor = System.Drawing.SystemColors.HotTrack;
            this.All_Point.Location = new System.Drawing.Point(9, 9);
            this.All_Point.Name = "All_Point";
            this.All_Point.Size = new System.Drawing.Size(250, 50);
            this.All_Point.TabIndex = 5;
            this.All_Point.Text = " All Point";
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Point.Location = new System.Drawing.Point(522, 9);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(250, 50);
            this.Point.TabIndex = 6;
            this.Point.Text = "Point";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.All_Point);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.U_M_Click);
            this.Controls.Add(this.U_Clik);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button U_Clik;
        private System.Windows.Forms.Button U_M_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label All_Point;
        private System.Windows.Forms.Label Point;
    }
}