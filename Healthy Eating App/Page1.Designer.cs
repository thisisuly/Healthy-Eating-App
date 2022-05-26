namespace Healthy_Eating_App
{
    partial class Page1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.MealBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Healthy_Eating_App.Properties.Resources.Pineapple1;
            this.pictureBox1.Location = new System.Drawing.Point(32, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(709, 23);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(411, 31);
            this.WelcomeLbl.TabIndex = 1;
            this.WelcomeLbl.Text = "Health Benefit\'s of Pineapple\'s";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(712, 83);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(44, 16);
            this.descLbl.TabIndex = 2;
            this.descLbl.Text = "label1";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(1047, 476);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 37);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // MealBtn
            // 
            this.MealBtn.Location = new System.Drawing.Point(518, 476);
            this.MealBtn.Name = "MealBtn";
            this.MealBtn.Size = new System.Drawing.Size(318, 37);
            this.MealBtn.TabIndex = 4;
            this.MealBtn.Text = "How to Make a Healthy Meal";
            this.MealBtn.UseVisualStyleBackColor = true;
            this.MealBtn.Click += new System.EventHandler(this.MealBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(865, 476);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(154, 37);
            this.InfoBtn.TabIndex = 5;
            this.InfoBtn.Text = "Nutritional Value";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 590);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.MealBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Page1";
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button MealBtn;
        private System.Windows.Forms.Button InfoBtn;
    }
}