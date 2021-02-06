
namespace HomeSalesGUI
{
    partial class FormHomeSales
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
            this.labelCostofSale = new System.Windows.Forms.Label();
            this.textBoxcostOfSale = new System.Windows.Forms.TextBox();
            this.labelWhoMadeSale = new System.Windows.Forms.Label();
            this.buttonDanielle = new System.Windows.Forms.Button();
            this.buttonEdward = new System.Windows.Forms.Button();
            this.buttonFrancis = new System.Windows.Forms.Button();
            this.labelDanielleSales = new System.Windows.Forms.Label();
            this.labelEdwardSales = new System.Windows.Forms.Label();
            this.labelFrancisSales = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelWhoMostSales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCostofSale
            // 
            this.labelCostofSale.AutoSize = true;
            this.labelCostofSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCostofSale.Location = new System.Drawing.Point(22, 23);
            this.labelCostofSale.Name = "labelCostofSale";
            this.labelCostofSale.Size = new System.Drawing.Size(291, 32);
            this.labelCostofSale.TabIndex = 0;
            this.labelCostofSale.Text = "How much was the sale?";
            // 
            // textBoxcostOfSale
            // 
            this.textBoxcostOfSale.Location = new System.Drawing.Point(13, 58);
            this.textBoxcostOfSale.Name = "textBoxcostOfSale";
            this.textBoxcostOfSale.Size = new System.Drawing.Size(300, 31);
            this.textBoxcostOfSale.TabIndex = 0;
            this.textBoxcostOfSale.TextChanged += new System.EventHandler(this.textBoxcostOfSale_TextChanged);
            // 
            // labelWhoMadeSale
            // 
            this.labelWhoMadeSale.AutoSize = true;
            this.labelWhoMadeSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWhoMadeSale.Location = new System.Drawing.Point(22, 92);
            this.labelWhoMadeSale.Name = "labelWhoMadeSale";
            this.labelWhoMadeSale.Size = new System.Drawing.Size(242, 32);
            this.labelWhoMadeSale.TabIndex = 2;
            this.labelWhoMadeSale.Text = "Who made the sale?";
            // 
            // buttonDanielle
            // 
            this.buttonDanielle.Location = new System.Drawing.Point(22, 142);
            this.buttonDanielle.Name = "buttonDanielle";
            this.buttonDanielle.Size = new System.Drawing.Size(112, 55);
            this.buttonDanielle.TabIndex = 1;
            this.buttonDanielle.Text = "Danielle";
            this.buttonDanielle.UseVisualStyleBackColor = true;
            this.buttonDanielle.Click += new System.EventHandler(this.buttonDanielle_Click);
            // 
            // buttonEdward
            // 
            this.buttonEdward.Location = new System.Drawing.Point(167, 142);
            this.buttonEdward.Name = "buttonEdward";
            this.buttonEdward.Size = new System.Drawing.Size(112, 55);
            this.buttonEdward.TabIndex = 2;
            this.buttonEdward.Text = "Edward";
            this.buttonEdward.UseVisualStyleBackColor = true;
            this.buttonEdward.Click += new System.EventHandler(this.buttonEdward_Click);
            // 
            // buttonFrancis
            // 
            this.buttonFrancis.Location = new System.Drawing.Point(316, 142);
            this.buttonFrancis.Name = "buttonFrancis";
            this.buttonFrancis.Size = new System.Drawing.Size(112, 55);
            this.buttonFrancis.TabIndex = 3;
            this.buttonFrancis.Text = "Francis";
            this.buttonFrancis.UseVisualStyleBackColor = true;
            this.buttonFrancis.Click += new System.EventHandler(this.buttonFrancis_Click);
            // 
            // labelDanielleSales
            // 
            this.labelDanielleSales.AutoSize = true;
            this.labelDanielleSales.Location = new System.Drawing.Point(22, 239);
            this.labelDanielleSales.Name = "labelDanielleSales";
            this.labelDanielleSales.Size = new System.Drawing.Size(0, 25);
            this.labelDanielleSales.TabIndex = 4;
            // 
            // labelEdwardSales
            // 
            this.labelEdwardSales.AutoSize = true;
            this.labelEdwardSales.Location = new System.Drawing.Point(22, 264);
            this.labelEdwardSales.Name = "labelEdwardSales";
            this.labelEdwardSales.Size = new System.Drawing.Size(0, 25);
            this.labelEdwardSales.TabIndex = 5;
            // 
            // labelFrancisSales
            // 
            this.labelFrancisSales.AutoSize = true;
            this.labelFrancisSales.Location = new System.Drawing.Point(22, 289);
            this.labelFrancisSales.Name = "labelFrancisSales";
            this.labelFrancisSales.Size = new System.Drawing.Size(0, 25);
            this.labelFrancisSales.TabIndex = 6;
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Location = new System.Drawing.Point(22, 314);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(0, 25);
            this.labelGrandTotal.TabIndex = 7;
            // 
            // labelWhoMostSales
            // 
            this.labelWhoMostSales.AutoSize = true;
            this.labelWhoMostSales.Location = new System.Drawing.Point(22, 378);
            this.labelWhoMostSales.Name = "labelWhoMostSales";
            this.labelWhoMostSales.Size = new System.Drawing.Size(0, 25);
            this.labelWhoMostSales.TabIndex = 8;
            // 
            // FormHomeSales
            // 
            this.AcceptButton = this.buttonDanielle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWhoMostSales);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.labelFrancisSales);
            this.Controls.Add(this.labelEdwardSales);
            this.Controls.Add(this.labelDanielleSales);
            this.Controls.Add(this.buttonFrancis);
            this.Controls.Add(this.buttonEdward);
            this.Controls.Add(this.buttonDanielle);
            this.Controls.Add(this.labelWhoMadeSale);
            this.Controls.Add(this.textBoxcostOfSale);
            this.Controls.Add(this.labelCostofSale);
            this.Name = "FormHomeSales";
            this.Text = "Home Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCostofSale;
        private System.Windows.Forms.TextBox textBoxcostOfSale;
        private System.Windows.Forms.Label labelWhoMadeSale;
        private System.Windows.Forms.Button buttonDanielle;
        private System.Windows.Forms.Button buttonEdward;
        private System.Windows.Forms.Button buttonFrancis;
        private System.Windows.Forms.Label labelDanielleSales;
        private System.Windows.Forms.Label labelEdwardSales;
        private System.Windows.Forms.Label labelFrancisSales;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelWhoMostSales;
    }
}

