
namespace EggsProducedByChickens
{
    partial class EggsLaid
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
            this.labeleggslaid = new System.Windows.Forms.Label();
            this.textBoxchicken1 = new System.Windows.Forms.TextBox();
            this.textBoxChicken4 = new System.Windows.Forms.TextBox();
            this.textBoxChicken3 = new System.Windows.Forms.TextBox();
            this.textBoxChicken2 = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labeTotalEggsLaid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeleggslaid
            // 
            this.labeleggslaid.AutoSize = true;
            this.labeleggslaid.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeleggslaid.Location = new System.Drawing.Point(116, 22);
            this.labeleggslaid.Name = "labeleggslaid";
            this.labeleggslaid.Size = new System.Drawing.Size(581, 38);
            this.labeleggslaid.TabIndex = 0;
            this.labeleggslaid.Text = "Enter number of eggs laid by each chicken:";
            this.labeleggslaid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxchicken1
            // 
            this.textBoxchicken1.AllowDrop = true;
            this.textBoxchicken1.ForeColor = System.Drawing.Color.Red;
            this.textBoxchicken1.Location = new System.Drawing.Point(12, 121);
            this.textBoxchicken1.Name = "textBoxchicken1";
            this.textBoxchicken1.Size = new System.Drawing.Size(150, 31);
            this.textBoxchicken1.TabIndex = 0;
            this.textBoxchicken1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxchicken1.TextChanged += new System.EventHandler(this.textBoxchicken1_TextChanged);
            // 
            // textBoxChicken4
            // 
            this.textBoxChicken4.ForeColor = System.Drawing.Color.Red;
            this.textBoxChicken4.Location = new System.Drawing.Point(648, 121);
            this.textBoxChicken4.Name = "textBoxChicken4";
            this.textBoxChicken4.Size = new System.Drawing.Size(150, 31);
            this.textBoxChicken4.TabIndex = 3;
            this.textBoxChicken4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxChicken3
            // 
            this.textBoxChicken3.ForeColor = System.Drawing.Color.Red;
            this.textBoxChicken3.Location = new System.Drawing.Point(447, 121);
            this.textBoxChicken3.Name = "textBoxChicken3";
            this.textBoxChicken3.Size = new System.Drawing.Size(150, 31);
            this.textBoxChicken3.TabIndex = 2;
            this.textBoxChicken3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxChicken2
            // 
            this.textBoxChicken2.ForeColor = System.Drawing.Color.Red;
            this.textBoxChicken2.Location = new System.Drawing.Point(239, 121);
            this.textBoxChicken2.Name = "textBoxChicken2";
            this.textBoxChicken2.Size = new System.Drawing.Size(150, 31);
            this.textBoxChicken2.TabIndex = 1;
            this.textBoxChicken2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.ForeColor = System.Drawing.Color.Red;
            this.buttonCalculate.Location = new System.Drawing.Point(311, 220);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(154, 80);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labeTotalEggsLaid
            // 
            this.labeTotalEggsLaid.AutoSize = true;
            this.labeTotalEggsLaid.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeTotalEggsLaid.ForeColor = System.Drawing.Color.Red;
            this.labeTotalEggsLaid.Location = new System.Drawing.Point(116, 363);
            this.labeTotalEggsLaid.Name = "labeTotalEggsLaid";
            this.labeTotalEggsLaid.Size = new System.Drawing.Size(0, 38);
            this.labeTotalEggsLaid.TabIndex = 6;
            // 
            // EggsLaid
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeTotalEggsLaid);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxChicken2);
            this.Controls.Add(this.textBoxChicken3);
            this.Controls.Add(this.textBoxChicken4);
            this.Controls.Add(this.textBoxchicken1);
            this.Controls.Add(this.labeleggslaid);
            this.Name = "EggsLaid";
            this.Text = "Chicken Farmer";
            this.Load += new System.EventHandler(this.EggsLaid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeleggslaid;
        private System.Windows.Forms.TextBox textBoxchicken1;
        private System.Windows.Forms.TextBox textBoxChicken4;
        private System.Windows.Forms.TextBox textBoxChicken3;
        private System.Windows.Forms.TextBox textBoxChicken2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labeTotalEggsLaid;
    }
}

