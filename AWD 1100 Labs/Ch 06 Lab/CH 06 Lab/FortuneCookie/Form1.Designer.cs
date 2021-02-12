
namespace FortuneCookie
{
    partial class FormFortuneCookie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFortuneCookie));
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelFortunes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpen.ForeColor = System.Drawing.Color.White;
            this.buttonOpen.Location = new System.Drawing.Point(54, 30);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(112, 68);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelFortunes
            // 
            this.labelFortunes.AutoSize = true;
            this.labelFortunes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFortunes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFortunes.Location = new System.Drawing.Point(54, 146);
            this.labelFortunes.Name = "labelFortunes";
            this.labelFortunes.Size = new System.Drawing.Size(0, 25);
            this.labelFortunes.TabIndex = 1;
            // 
            // FormFortuneCookie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 246);
            this.Controls.Add(this.labelFortunes);
            this.Controls.Add(this.buttonOpen);
            this.Name = "FormFortuneCookie";
            this.Text = "Fortune Cookie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelFortunes;
    }
}

