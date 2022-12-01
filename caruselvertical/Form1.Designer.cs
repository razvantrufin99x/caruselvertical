namespace caruselvertical
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.elementcarusel1 = new caruselvertical.elementcarusel();
            this.elementcarusel2 = new caruselvertical.elementcarusel();
            this.elementcarusel3 = new caruselvertical.elementcarusel();
            this.elementcarusel4 = new caruselvertical.elementcarusel();
            this.elementcarusel5 = new caruselvertical.elementcarusel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // elementcarusel1
            // 
            this.elementcarusel1.BackColor = System.Drawing.Color.Red;
            this.elementcarusel1.Location = new System.Drawing.Point(12, 46);
            this.elementcarusel1.Name = "elementcarusel1";
            this.elementcarusel1.Size = new System.Drawing.Size(150, 150);
            this.elementcarusel1.TabIndex = 2;
            // 
            // elementcarusel2
            // 
            this.elementcarusel2.BackColor = System.Drawing.Color.Red;
            this.elementcarusel2.Location = new System.Drawing.Point(12, 202);
            this.elementcarusel2.Name = "elementcarusel2";
            this.elementcarusel2.Size = new System.Drawing.Size(150, 150);
            this.elementcarusel2.TabIndex = 3;
            // 
            // elementcarusel3
            // 
            this.elementcarusel3.BackColor = System.Drawing.Color.Red;
            this.elementcarusel3.Location = new System.Drawing.Point(12, 358);
            this.elementcarusel3.Name = "elementcarusel3";
            this.elementcarusel3.Size = new System.Drawing.Size(150, 150);
            this.elementcarusel3.TabIndex = 4;
            // 
            // elementcarusel4
            // 
            this.elementcarusel4.BackColor = System.Drawing.Color.Red;
            this.elementcarusel4.Location = new System.Drawing.Point(12, 404);
            this.elementcarusel4.Name = "elementcarusel4";
            this.elementcarusel4.Size = new System.Drawing.Size(150, 150);
            this.elementcarusel4.TabIndex = 5;
            // 
            // elementcarusel5
            // 
            this.elementcarusel5.BackColor = System.Drawing.Color.Red;
            this.elementcarusel5.Location = new System.Drawing.Point(12, 457);
            this.elementcarusel5.Name = "elementcarusel5";
            this.elementcarusel5.Size = new System.Drawing.Size(150, 150);
            this.elementcarusel5.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 482);
            this.Controls.Add(this.elementcarusel5);
            this.Controls.Add(this.elementcarusel4);
            this.Controls.Add(this.elementcarusel3);
            this.Controls.Add(this.elementcarusel2);
            this.Controls.Add(this.elementcarusel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private elementcarusel elementcarusel1;
        private elementcarusel elementcarusel2;
        private elementcarusel elementcarusel3;
        private elementcarusel elementcarusel4;
        private elementcarusel elementcarusel5;
    }
}

