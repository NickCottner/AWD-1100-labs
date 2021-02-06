
namespace CatgegoryHurricanes
{
    partial class CategoryofHurricane
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxWindSpeed = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWindSpeed.Location = new System.Drawing.Point(78, 45);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(151, 32);
            this.labelWindSpeed.TabIndex = 0;
            this.labelWindSpeed.Text = "Wind Speed";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(539, 45);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(118, 32);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category";
            // 
            // textBoxWindSpeed
            // 
            this.textBoxWindSpeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxWindSpeed.Location = new System.Drawing.Point(78, 103);
            this.textBoxWindSpeed.Name = "textBoxWindSpeed";
            this.textBoxWindSpeed.Size = new System.Drawing.Size(173, 31);
            this.textBoxWindSpeed.TabIndex = 2;
            this.textBoxWindSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWindSpeed.TextChanged += new System.EventHandler(this.textBoxWindSpeed_TextChanged);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCategory.Location = new System.Drawing.Point(539, 103);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.ReadOnly = true;
            this.textBoxCategory.Size = new System.Drawing.Size(169, 31);
            this.textBoxCategory.TabIndex = 3;
            this.textBoxCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstimate.Location = new System.Drawing.Point(330, 70);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(126, 49);
            this.btnEstimate.TabIndex = 4;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // CategoryofHurricane
            // 
            this.AcceptButton = this.btnEstimate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 179);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxWindSpeed);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelWindSpeed);
            this.Name = "CategoryofHurricane";
            this.Text = "Category of Hurricanes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxWindSpeed;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Button btnEstimate;
    }
}

