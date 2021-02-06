
namespace VowelCount
{
    partial class FormVowels
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
            this.labelEnterPhrase = new System.Windows.Forms.Label();
            this.textBoxEnterPhrase = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelNumberVowels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEnterPhrase
            // 
            this.labelEnterPhrase.AutoSize = true;
            this.labelEnterPhrase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnterPhrase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEnterPhrase.Location = new System.Drawing.Point(71, 42);
            this.labelEnterPhrase.Name = "labelEnterPhrase";
            this.labelEnterPhrase.Size = new System.Drawing.Size(267, 32);
            this.labelEnterPhrase.TabIndex = 0;
            this.labelEnterPhrase.Text = "Please Enter A Phrase:";
            this.labelEnterPhrase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxEnterPhrase
            // 
            this.textBoxEnterPhrase.Location = new System.Drawing.Point(71, 92);
            this.textBoxEnterPhrase.Multiline = true;
            this.textBoxEnterPhrase.Name = "textBoxEnterPhrase";
            this.textBoxEnterPhrase.Size = new System.Drawing.Size(357, 139);
            this.textBoxEnterPhrase.TabIndex = 1;
            this.textBoxEnterPhrase.TextChanged += new System.EventHandler(this.textBoxEnterPhrase_TextChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.ForeColor = System.Drawing.Color.Black;
            this.buttonEnter.Location = new System.Drawing.Point(560, 132);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(112, 65);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelNumberVowels
            // 
            this.labelNumberVowels.AutoSize = true;
            this.labelNumberVowels.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelNumberVowels.Enabled = false;
            this.labelNumberVowels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumberVowels.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumberVowels.Location = new System.Drawing.Point(71, 365);
            this.labelNumberVowels.Name = "labelNumberVowels";
            this.labelNumberVowels.Size = new System.Drawing.Size(0, 32);
            this.labelNumberVowels.TabIndex = 3;
            // 
            // FormVowels
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNumberVowels);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxEnterPhrase);
            this.Controls.Add(this.labelEnterPhrase);
            this.Name = "FormVowels";
            this.Text = "Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterPhrase;
        private System.Windows.Forms.TextBox textBoxEnterPhrase;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelNumberVowels;
    }
}

