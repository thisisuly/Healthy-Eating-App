namespace Healthy_Eating_App
{
    partial class Meal
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
            this.mealLbl = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealLbl
            // 
            this.mealLbl.AutoSize = true;
            this.mealLbl.Location = new System.Drawing.Point(69, 35);
            this.mealLbl.Name = "mealLbl";
            this.mealLbl.Size = new System.Drawing.Size(252, 16);
            this.mealLbl.TabIndex = 0;
            this.mealLbl.Text = "How we can make a Pineapple Smoothie";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(72, 74);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(456, 321);
            this.webBrowser1.TabIndex = 1;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(85, 402);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.mealLbl);
            this.Name = "Meal";
            this.Text = "Meal";
            this.Load += new System.EventHandler(this.Meal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealLbl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BackBtn;
    }
}