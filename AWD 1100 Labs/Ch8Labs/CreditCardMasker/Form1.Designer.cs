
namespace CreditCardMasker
{
    partial class FormCCMasker
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
            this.textBoxCCNumber = new System.Windows.Forms.TextBox();
            this.buttonMask = new System.Windows.Forms.Button();
            this.labelMaskedCC = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCCNumber
            // 
            this.textBoxCCNumber.BackColor = System.Drawing.Color.Aqua;
            this.textBoxCCNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCCNumber.Location = new System.Drawing.Point(25, 32);
            this.textBoxCCNumber.Name = "textBoxCCNumber";
            this.textBoxCCNumber.Size = new System.Drawing.Size(346, 31);
            this.textBoxCCNumber.TabIndex = 0;
            // 
            // buttonMask
            // 
            this.buttonMask.BackColor = System.Drawing.Color.Aqua;
            this.buttonMask.Location = new System.Drawing.Point(407, 25);
            this.buttonMask.Name = "buttonMask";
            this.buttonMask.Size = new System.Drawing.Size(112, 38);
            this.buttonMask.TabIndex = 1;
            this.buttonMask.Text = "Mask";
            this.buttonMask.UseVisualStyleBackColor = false;
            this.buttonMask.Click += new System.EventHandler(this.buttonMask_Click);
            // 
            // labelMaskedCC
            // 
            this.labelMaskedCC.BackColor = System.Drawing.Color.Aqua;
            this.labelMaskedCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMaskedCC.Location = new System.Drawing.Point(25, 108);
            this.labelMaskedCC.Name = "labelMaskedCC";
            this.labelMaskedCC.Size = new System.Drawing.Size(346, 38);
            this.labelMaskedCC.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Aqua;
            this.buttonClear.Location = new System.Drawing.Point(407, 108);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 38);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Aqua;
            this.buttonExit.Location = new System.Drawing.Point(533, 66);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 38);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormCCMasker
            // 
            this.AcceptButton = this.buttonMask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(800, 205);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelMaskedCC);
            this.Controls.Add(this.buttonMask);
            this.Controls.Add(this.textBoxCCNumber);
            this.Name = "FormCCMasker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Card Masker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCCNumber;
        private System.Windows.Forms.Button buttonMask;
        private System.Windows.Forms.Label labelMaskedCC;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

