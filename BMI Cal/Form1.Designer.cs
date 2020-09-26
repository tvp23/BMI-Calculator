namespace BMI_Cal
{
    partial class Form1
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
            this.radbtnVrouw = new System.Windows.Forms.RadioButton();
            this.radbtnMan = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBerekenen = new System.Windows.Forms.Button();
            this.txtbLeeftijd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbGewicht = new System.Windows.Forms.TextBox();
            this.txtbLengte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.rtxtAdvies = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // radbtnVrouw
            // 
            this.radbtnVrouw.AutoSize = true;
            this.radbtnVrouw.Location = new System.Drawing.Point(334, 276);
            this.radbtnVrouw.Name = "radbtnVrouw";
            this.radbtnVrouw.Size = new System.Drawing.Size(68, 21);
            this.radbtnVrouw.TabIndex = 25;
            this.radbtnVrouw.TabStop = true;
            this.radbtnVrouw.Text = "Vrouw";
            this.radbtnVrouw.UseVisualStyleBackColor = true;
            // 
            // radbtnMan
            // 
            this.radbtnMan.AutoSize = true;
            this.radbtnMan.Location = new System.Drawing.Point(159, 276);
            this.radbtnMan.Name = "radbtnMan";
            this.radbtnMan.Size = new System.Drawing.Size(56, 21);
            this.radbtnMan.TabIndex = 24;
            this.radbtnMan.TabStop = true;
            this.radbtnMan.Text = "Man";
            this.radbtnMan.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Advies";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "BMI:";
            // 
            // btnBerekenen
            // 
            this.btnBerekenen.Location = new System.Drawing.Point(159, 348);
            this.btnBerekenen.Name = "btnBerekenen";
            this.btnBerekenen.Size = new System.Drawing.Size(286, 95);
            this.btnBerekenen.TabIndex = 21;
            this.btnBerekenen.Text = "BMI Berkenen";
            this.btnBerekenen.UseVisualStyleBackColor = true;
            this.btnBerekenen.Click += new System.EventHandler(this.btnBerekenen_Click);
            // 
            // txtbLeeftijd
            // 
            this.txtbLeeftijd.Location = new System.Drawing.Point(216, 214);
            this.txtbLeeftijd.Name = "txtbLeeftijd";
            this.txtbLeeftijd.Size = new System.Drawing.Size(186, 22);
            this.txtbLeeftijd.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Leeftijd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Gewicht in KG";
            // 
            // txtbGewicht
            // 
            this.txtbGewicht.Location = new System.Drawing.Point(216, 185);
            this.txtbGewicht.Name = "txtbGewicht";
            this.txtbGewicht.Size = new System.Drawing.Size(186, 22);
            this.txtbGewicht.TabIndex = 17;
            // 
            // txtbLengte
            // 
            this.txtbLengte.Location = new System.Drawing.Point(216, 156);
            this.txtbLengte.Name = "txtbLengte";
            this.txtbLengte.Size = new System.Drawing.Size(186, 22);
            this.txtbLengte.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lengte in cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(210, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "BMI Calculator";
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(216, 496);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(186, 22);
            this.txtBMI.TabIndex = 28;
            this.txtBMI.Text = "leeg";
            // 
            // rtxtAdvies
            // 
            this.rtxtAdvies.Location = new System.Drawing.Point(216, 525);
            this.rtxtAdvies.Name = "rtxtAdvies";
            this.rtxtAdvies.Size = new System.Drawing.Size(186, 96);
            this.rtxtAdvies.TabIndex = 29;
            this.rtxtAdvies.Text = "leeg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 668);
            this.Controls.Add(this.rtxtAdvies);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.radbtnVrouw);
            this.Controls.Add(this.radbtnMan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBerekenen);
            this.Controls.Add(this.txtbLeeftijd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbGewicht);
            this.Controls.Add(this.txtbLengte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radbtnVrouw;
        private System.Windows.Forms.RadioButton radbtnMan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBerekenen;
        private System.Windows.Forms.TextBox txtbLeeftijd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbGewicht;
        private System.Windows.Forms.TextBox txtbLengte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.RichTextBox rtxtAdvies;
    }
}

