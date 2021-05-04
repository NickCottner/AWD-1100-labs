
namespace CustomDesk
{
    partial class FormCustomDesk
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
            this.labelWoodType = new System.Windows.Forms.Label();
            this.labelNumOfDrawers = new System.Windows.Forms.Label();
            this.textBoxWoodType = new System.Windows.Forms.TextBox();
            this.textBoxNumOfDrawers = new System.Windows.Forms.TextBox();
            this.buttonEstimate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxOrderSummary = new System.Windows.Forms.GroupBox();
            this.labelTheTotalCost = new System.Windows.Forms.Label();
            this.labelTheDrawerCost = new System.Windows.Forms.Label();
            this.labelTheWoodCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWoodCost = new System.Windows.Forms.Label();
            this.groupBoxOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWoodType
            // 
            this.labelWoodType.AutoSize = true;
            this.labelWoodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWoodType.Location = new System.Drawing.Point(172, 46);
            this.labelWoodType.Name = "labelWoodType";
            this.labelWoodType.Size = new System.Drawing.Size(119, 20);
            this.labelWoodType.TabIndex = 0;
            this.labelWoodType.Text = "Type of Wood";
            // 
            // labelNumOfDrawers
            // 
            this.labelNumOfDrawers.AutoSize = true;
            this.labelNumOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumOfDrawers.Location = new System.Drawing.Point(457, 46);
            this.labelNumOfDrawers.Name = "labelNumOfDrawers";
            this.labelNumOfDrawers.Size = new System.Drawing.Size(163, 20);
            this.labelNumOfDrawers.TabIndex = 1;
            this.labelNumOfDrawers.Text = "Number of Drawers";
            // 
            // textBoxWoodType
            // 
            this.textBoxWoodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxWoodType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxWoodType.Location = new System.Drawing.Point(172, 94);
            this.textBoxWoodType.Name = "textBoxWoodType";
            this.textBoxWoodType.Size = new System.Drawing.Size(150, 26);
            this.textBoxWoodType.TabIndex = 2;
            this.textBoxWoodType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNumOfDrawers
            // 
            this.textBoxNumOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumOfDrawers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxNumOfDrawers.Location = new System.Drawing.Point(457, 94);
            this.textBoxNumOfDrawers.Name = "textBoxNumOfDrawers";
            this.textBoxNumOfDrawers.Size = new System.Drawing.Size(150, 26);
            this.textBoxNumOfDrawers.TabIndex = 3;
            this.textBoxNumOfDrawers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonEstimate
            // 
            this.buttonEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEstimate.Location = new System.Drawing.Point(172, 199);
            this.buttonEstimate.Name = "buttonEstimate";
            this.buttonEstimate.Size = new System.Drawing.Size(112, 34);
            this.buttonEstimate.TabIndex = 4;
            this.buttonEstimate.Text = "Estimate";
            this.buttonEstimate.UseVisualStyleBackColor = true;
            this.buttonEstimate.Click += new System.EventHandler(this.buttonEstimate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(326, 199);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 34);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(482, 199);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 34);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxOrderSummary
            // 
            this.groupBoxOrderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBoxOrderSummary.Controls.Add(this.labelTheTotalCost);
            this.groupBoxOrderSummary.Controls.Add(this.labelTheDrawerCost);
            this.groupBoxOrderSummary.Controls.Add(this.labelTheWoodCost);
            this.groupBoxOrderSummary.Controls.Add(this.label2);
            this.groupBoxOrderSummary.Controls.Add(this.label1);
            this.groupBoxOrderSummary.Controls.Add(this.labelWoodCost);
            this.groupBoxOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOrderSummary.Location = new System.Drawing.Point(51, 276);
            this.groupBoxOrderSummary.Name = "groupBoxOrderSummary";
            this.groupBoxOrderSummary.Size = new System.Drawing.Size(689, 150);
            this.groupBoxOrderSummary.TabIndex = 7;
            this.groupBoxOrderSummary.TabStop = false;
            this.groupBoxOrderSummary.Text = "Order Summary";
            // 
            // labelTheTotalCost
            // 
            this.labelTheTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTheTotalCost.Location = new System.Drawing.Point(511, 69);
            this.labelTheTotalCost.Name = "labelTheTotalCost";
            this.labelTheTotalCost.Size = new System.Drawing.Size(149, 38);
            this.labelTheTotalCost.TabIndex = 5;
            this.labelTheTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTheDrawerCost
            // 
            this.labelTheDrawerCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTheDrawerCost.Location = new System.Drawing.Point(261, 69);
            this.labelTheDrawerCost.Name = "labelTheDrawerCost";
            this.labelTheDrawerCost.Size = new System.Drawing.Size(162, 38);
            this.labelTheDrawerCost.TabIndex = 4;
            this.labelTheDrawerCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTheWoodCost
            // 
            this.labelTheWoodCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTheWoodCost.Location = new System.Drawing.Point(15, 69);
            this.labelTheWoodCost.Name = "labelTheWoodCost";
            this.labelTheWoodCost.Size = new System.Drawing.Size(149, 38);
            this.labelTheWoodCost.TabIndex = 3;
            this.labelTheWoodCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(511, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Cost:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cost of Drawers:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWoodCost
            // 
            this.labelWoodCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWoodCost.Location = new System.Drawing.Point(15, 27);
            this.labelWoodCost.Name = "labelWoodCost";
            this.labelWoodCost.Size = new System.Drawing.Size(149, 38);
            this.labelWoodCost.TabIndex = 0;
            this.labelWoodCost.Text = "Cost of Wood:";
            this.labelWoodCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCustomDesk
            // 
            this.AcceptButton = this.buttonEstimate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOrderSummary);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEstimate);
            this.Controls.Add(this.textBoxNumOfDrawers);
            this.Controls.Add(this.textBoxWoodType);
            this.Controls.Add(this.labelNumOfDrawers);
            this.Controls.Add(this.labelWoodType);
            this.Name = "FormCustomDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Custom Desk";
            this.groupBoxOrderSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWoodType;
        private System.Windows.Forms.Label labelNumOfDrawers;
        private System.Windows.Forms.TextBox textBoxWoodType;
        private System.Windows.Forms.TextBox textBoxNumOfDrawers;
        private System.Windows.Forms.Button buttonEstimate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxOrderSummary;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWoodCost;
        private System.Windows.Forms.Label labelTheWoodCost;
        private System.Windows.Forms.Label labelTheTotalCost;
        private System.Windows.Forms.Label labelTheDrawerCost;
    }
}

