
namespace CreditCardMaster
{
    partial class FormCardMasker
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
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.buttonMask = new System.Windows.Forms.Button();
            this.labelMaskedNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(35, 43);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(265, 31);
            this.textBoxCardNumber.TabIndex = 0;
            // 
            // buttonMask
            // 
            this.buttonMask.Location = new System.Drawing.Point(339, 43);
            this.buttonMask.Name = "buttonMask";
            this.buttonMask.Size = new System.Drawing.Size(112, 34);
            this.buttonMask.TabIndex = 1;
            this.buttonMask.Text = "Mask";
            this.buttonMask.UseVisualStyleBackColor = true;
            this.buttonMask.Click += new System.EventHandler(this.buttonMask_Click);
            // 
            // labelMaskedNumber
            // 
            this.labelMaskedNumber.Location = new System.Drawing.Point(35, 119);
            this.labelMaskedNumber.Name = "labelMaskedNumber";
            this.labelMaskedNumber.Size = new System.Drawing.Size(265, 33);
            this.labelMaskedNumber.TabIndex = 2;
            this.labelMaskedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCardMasker
            // 
            this.AcceptButton = this.buttonMask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMaskedNumber);
            this.Controls.Add(this.buttonMask);
            this.Controls.Add(this.textBoxCardNumber);
            this.Name = "FormCardMasker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Card Masker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Button buttonMask;
        private System.Windows.Forms.Label labelMaskedNumber;
    }
}

