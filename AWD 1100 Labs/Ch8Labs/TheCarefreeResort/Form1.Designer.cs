
namespace TheCarefreeResort
{
    partial class FormCarefreeResort
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
            this.labelNightsStayed = new System.Windows.Forms.Label();
            this.textBoxNightsStayed = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxTotalCostOfStay = new System.Windows.Forms.GroupBox();
            this.labelTheTotalCost = new System.Windows.Forms.Label();
            this.labelTheNightlyCost = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelNightlyCost = new System.Windows.Forms.Label();
            this.groupBoxTotalCostOfStay.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNightsStayed
            // 
            this.labelNightsStayed.AutoSize = true;
            this.labelNightsStayed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNightsStayed.Location = new System.Drawing.Point(50, 44);
            this.labelNightsStayed.Name = "labelNightsStayed";
            this.labelNightsStayed.Size = new System.Drawing.Size(131, 25);
            this.labelNightsStayed.TabIndex = 0;
            this.labelNightsStayed.Text = "Nights Stayed";
            // 
            // textBoxNightsStayed
            // 
            this.textBoxNightsStayed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNightsStayed.Location = new System.Drawing.Point(50, 96);
            this.textBoxNightsStayed.Name = "textBoxNightsStayed";
            this.textBoxNightsStayed.Size = new System.Drawing.Size(131, 31);
            this.textBoxNightsStayed.TabIndex = 0;
            this.textBoxNightsStayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.Location = new System.Drawing.Point(250, 12);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(112, 34);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(250, 77);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 34);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(250, 143);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 34);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxTotalCostOfStay
            // 
            this.groupBoxTotalCostOfStay.Controls.Add(this.labelTheTotalCost);
            this.groupBoxTotalCostOfStay.Controls.Add(this.labelTheNightlyCost);
            this.groupBoxTotalCostOfStay.Controls.Add(this.labelTotalCost);
            this.groupBoxTotalCostOfStay.Controls.Add(this.labelNightlyCost);
            this.groupBoxTotalCostOfStay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxTotalCostOfStay.Location = new System.Drawing.Point(449, 12);
            this.groupBoxTotalCostOfStay.Name = "groupBoxTotalCostOfStay";
            this.groupBoxTotalCostOfStay.Size = new System.Drawing.Size(300, 165);
            this.groupBoxTotalCostOfStay.TabIndex = 4;
            this.groupBoxTotalCostOfStay.TabStop = false;
            this.groupBoxTotalCostOfStay.Text = "Cost of Stay";
            // 
            // labelTheTotalCost
            // 
            this.labelTheTotalCost.BackColor = System.Drawing.Color.White;
            this.labelTheTotalCost.Location = new System.Drawing.Point(169, 107);
            this.labelTheTotalCost.Name = "labelTheTotalCost";
            this.labelTheTotalCost.Size = new System.Drawing.Size(96, 25);
            this.labelTheTotalCost.TabIndex = 3;
            // 
            // labelTheNightlyCost
            // 
            this.labelTheNightlyCost.BackColor = System.Drawing.Color.White;
            this.labelTheNightlyCost.Location = new System.Drawing.Point(33, 107);
            this.labelTheNightlyCost.Name = "labelTheNightlyCost";
            this.labelTheNightlyCost.Size = new System.Drawing.Size(117, 25);
            this.labelTheNightlyCost.TabIndex = 2;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalCost.Location = new System.Drawing.Point(169, 50);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(96, 25);
            this.labelTotalCost.TabIndex = 1;
            this.labelTotalCost.Text = "Total Cost";
            // 
            // labelNightlyCost
            // 
            this.labelNightlyCost.AutoSize = true;
            this.labelNightlyCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNightlyCost.Location = new System.Drawing.Point(33, 50);
            this.labelNightlyCost.Name = "labelNightlyCost";
            this.labelNightlyCost.Size = new System.Drawing.Size(117, 25);
            this.labelNightlyCost.TabIndex = 0;
            this.labelNightlyCost.Text = "Nightly Cost";
            // 
            // FormCarefreeResort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTotalCostOfStay);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxNightsStayed);
            this.Controls.Add(this.labelNightsStayed);
            this.Name = "FormCarefreeResort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Carefree Resort";
            this.groupBoxTotalCostOfStay.ResumeLayout(false);
            this.groupBoxTotalCostOfStay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNightsStayed;
        private System.Windows.Forms.TextBox textBoxNightsStayed;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxTotalCostOfStay;
        private System.Windows.Forms.Label labelTheTotalCost;
        private System.Windows.Forms.Label labelTheNightlyCost;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelNightlyCost;
    }
}

