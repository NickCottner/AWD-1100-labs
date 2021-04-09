
namespace FoodOrder
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
            this.labelNameOnOrder = new System.Windows.Forms.Label();
            this.textBoxNameOnOrder = new System.Windows.Forms.TextBox();
            this.labelNameError = new System.Windows.Forms.Label();
            this.labelQuestionSundae = new System.Windows.Forms.Label();
            this.labelQuestionSoda = new System.Windows.Forms.Label();
            this.checkBoxSundaeYes = new System.Windows.Forms.CheckBox();
            this.checkBoxSodaYes = new System.Windows.Forms.CheckBox();
            this.labelSundaeToppings = new System.Windows.Forms.Label();
            this.labelDrrinkMixins = new System.Windows.Forms.Label();
            this.checkedListBoxSundaeTopping = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxSodaMixIns = new System.Windows.Forms.CheckedListBox();
            this.textBoxOrderSummary = new System.Windows.Forms.TextBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNameOnOrder
            // 
            this.labelNameOnOrder.AutoSize = true;
            this.labelNameOnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOnOrder.Location = new System.Drawing.Point(13, 13);
            this.labelNameOnOrder.Name = "labelNameOnOrder";
            this.labelNameOnOrder.Size = new System.Drawing.Size(314, 20);
            this.labelNameOnOrder.TabIndex = 0;
            this.labelNameOnOrder.Text = "What name do you want on the order?";
            // 
            // textBoxNameOnOrder
            // 
            this.textBoxNameOnOrder.Location = new System.Drawing.Point(17, 55);
            this.textBoxNameOnOrder.Name = "textBoxNameOnOrder";
            this.textBoxNameOnOrder.Size = new System.Drawing.Size(310, 26);
            this.textBoxNameOnOrder.TabIndex = 1;
            // 
            // labelNameError
            // 
            this.labelNameError.AutoSize = true;
            this.labelNameError.ForeColor = System.Drawing.Color.Red;
            this.labelNameError.Location = new System.Drawing.Point(17, 88);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(51, 20);
            this.labelNameError.TabIndex = 2;
            this.labelNameError.Text = "label1";
            // 
            // labelQuestionSundae
            // 
            this.labelQuestionSundae.AutoSize = true;
            this.labelQuestionSundae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionSundae.Location = new System.Drawing.Point(17, 123);
            this.labelQuestionSundae.Name = "labelQuestionSundae";
            this.labelQuestionSundae.Size = new System.Drawing.Size(197, 20);
            this.labelQuestionSundae.TabIndex = 3;
            this.labelQuestionSundae.Text = "Do you want a sundae?";
            // 
            // labelQuestionSoda
            // 
            this.labelQuestionSoda.AutoSize = true;
            this.labelQuestionSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionSoda.Location = new System.Drawing.Point(282, 123);
            this.labelQuestionSoda.Name = "labelQuestionSoda";
            this.labelQuestionSoda.Size = new System.Drawing.Size(177, 20);
            this.labelQuestionSoda.TabIndex = 4;
            this.labelQuestionSoda.Text = "Do you want a soda?";
            // 
            // checkBoxSundaeYes
            // 
            this.checkBoxSundaeYes.AutoSize = true;
            this.checkBoxSundaeYes.Location = new System.Drawing.Point(21, 173);
            this.checkBoxSundaeYes.Name = "checkBoxSundaeYes";
            this.checkBoxSundaeYes.Size = new System.Drawing.Size(63, 24);
            this.checkBoxSundaeYes.TabIndex = 5;
            this.checkBoxSundaeYes.Text = "Yes";
            this.checkBoxSundaeYes.UseVisualStyleBackColor = true;
            // 
            // checkBoxSodaYes
            // 
            this.checkBoxSodaYes.AutoSize = true;
            this.checkBoxSodaYes.Location = new System.Drawing.Point(286, 173);
            this.checkBoxSodaYes.Name = "checkBoxSodaYes";
            this.checkBoxSodaYes.Size = new System.Drawing.Size(63, 24);
            this.checkBoxSodaYes.TabIndex = 6;
            this.checkBoxSodaYes.Text = "Yes";
            this.checkBoxSodaYes.UseVisualStyleBackColor = true;
            // 
            // labelSundaeToppings
            // 
            this.labelSundaeToppings.AutoSize = true;
            this.labelSundaeToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSundaeToppings.Location = new System.Drawing.Point(17, 227);
            this.labelSundaeToppings.Name = "labelSundaeToppings";
            this.labelSundaeToppings.Size = new System.Drawing.Size(149, 20);
            this.labelSundaeToppings.TabIndex = 7;
            this.labelSundaeToppings.Text = "Sundae Toppings";
            // 
            // labelDrrinkMixins
            // 
            this.labelDrrinkMixins.AutoSize = true;
            this.labelDrrinkMixins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrrinkMixins.Location = new System.Drawing.Point(282, 227);
            this.labelDrrinkMixins.Name = "labelDrrinkMixins";
            this.labelDrrinkMixins.Size = new System.Drawing.Size(105, 20);
            this.labelDrrinkMixins.TabIndex = 8;
            this.labelDrrinkMixins.Text = "Drink Mixins";
            // 
            // checkedListBoxSundaeTopping
            // 
            this.checkedListBoxSundaeTopping.FormattingEnabled = true;
            this.checkedListBoxSundaeTopping.Items.AddRange(new object[] {
            "Sprinkles",
            "Nuts",
            "Chocolate Syrup"});
            this.checkedListBoxSundaeTopping.Location = new System.Drawing.Point(21, 262);
            this.checkedListBoxSundaeTopping.Name = "checkedListBoxSundaeTopping";
            this.checkedListBoxSundaeTopping.Size = new System.Drawing.Size(166, 73);
            this.checkedListBoxSundaeTopping.TabIndex = 9;
            // 
            // checkedListBoxSodaMixIns
            // 
            this.checkedListBoxSodaMixIns.FormattingEnabled = true;
            this.checkedListBoxSodaMixIns.Items.AddRange(new object[] {
            "Lime Flavor",
            "Peach Flavor",
            "Mango Flavor"});
            this.checkedListBoxSodaMixIns.Location = new System.Drawing.Point(286, 262);
            this.checkedListBoxSodaMixIns.Name = "checkedListBoxSodaMixIns";
            this.checkedListBoxSodaMixIns.Size = new System.Drawing.Size(166, 73);
            this.checkedListBoxSodaMixIns.TabIndex = 10;
            // 
            // textBoxOrderSummary
            // 
            this.textBoxOrderSummary.Location = new System.Drawing.Point(547, 55);
            this.textBoxOrderSummary.Multiline = true;
            this.textBoxOrderSummary.Name = "textBoxOrderSummary";
            this.textBoxOrderSummary.Size = new System.Drawing.Size(464, 346);
            this.textBoxOrderSummary.TabIndex = 11;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(547, 32);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(54, 20);
            this.labelOrder.TabIndex = 12;
            this.labelOrder.Text = "Order";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(547, 408);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(54, 20);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.textBoxOrderSummary);
            this.Controls.Add(this.checkedListBoxSodaMixIns);
            this.Controls.Add(this.checkedListBoxSundaeTopping);
            this.Controls.Add(this.labelDrrinkMixins);
            this.Controls.Add(this.labelSundaeToppings);
            this.Controls.Add(this.checkBoxSodaYes);
            this.Controls.Add(this.checkBoxSundaeYes);
            this.Controls.Add(this.labelQuestionSoda);
            this.Controls.Add(this.labelQuestionSundae);
            this.Controls.Add(this.labelNameError);
            this.Controls.Add(this.textBoxNameOnOrder);
            this.Controls.Add(this.labelNameOnOrder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameOnOrder;
        private System.Windows.Forms.TextBox textBoxNameOnOrder;
        private System.Windows.Forms.Label labelNameError;
        private System.Windows.Forms.Label labelQuestionSundae;
        private System.Windows.Forms.Label labelQuestionSoda;
        private System.Windows.Forms.CheckBox checkBoxSundaeYes;
        private System.Windows.Forms.CheckBox checkBoxSodaYes;
        private System.Windows.Forms.Label labelSundaeToppings;
        private System.Windows.Forms.Label labelDrrinkMixins;
        private System.Windows.Forms.CheckedListBox checkedListBoxSundaeTopping;
        private System.Windows.Forms.CheckedListBox checkedListBoxSodaMixIns;
        private System.Windows.Forms.TextBox textBoxOrderSummary;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelTotal;
    }
}

