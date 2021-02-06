
namespace KMtoMilesConverterGUI
{
    partial class Ch04Lab
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
            this.DistanceMiles = new System.Windows.Forms.Label();
            this.DistanceKM = new System.Windows.Forms.Label();
            this.textBoxMiles = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.btnConvertToKm = new System.Windows.Forms.Button();
            this.btnConvertToMiles = new System.Windows.Forms.Button();
            this.labelmilesiskm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DistanceMiles
            // 
            this.DistanceMiles.AutoSize = true;
            this.DistanceMiles.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DistanceMiles.Location = new System.Drawing.Point(71, 30);
            this.DistanceMiles.Name = "DistanceMiles";
            this.DistanceMiles.Size = new System.Drawing.Size(199, 32);
            this.DistanceMiles.TabIndex = 0;
            this.DistanceMiles.Text = "Distance in Miles";
            // 
            // DistanceKM
            // 
            this.DistanceKM.AutoSize = true;
            this.DistanceKM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DistanceKM.Location = new System.Drawing.Point(401, 30);
            this.DistanceKM.Name = "DistanceKM";
            this.DistanceKM.Size = new System.Drawing.Size(257, 32);
            this.DistanceKM.TabIndex = 1;
            this.DistanceKM.Text = "Distance in Kilometers";
            this.DistanceKM.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMiles
            // 
            this.textBoxMiles.AccessibleName = "TextBoxMiles";
            this.textBoxMiles.Location = new System.Drawing.Point(90, 83);
            this.textBoxMiles.Name = "textBoxMiles";
            this.textBoxMiles.Size = new System.Drawing.Size(150, 31);
            this.textBoxMiles.TabIndex = 0;
            this.textBoxMiles.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxKm
            // 
            this.textBoxKm.AccessibleName = "TextBoxKm";
            this.textBoxKm.Location = new System.Drawing.Point(451, 83);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(150, 31);
            this.textBoxKm.TabIndex = 1;
            // 
            // btnConvertToKm
            // 
            this.btnConvertToKm.Location = new System.Drawing.Point(91, 163);
            this.btnConvertToKm.Name = "btnConvertToKm";
            this.btnConvertToKm.Size = new System.Drawing.Size(149, 60);
            this.btnConvertToKm.TabIndex = 2;
            this.btnConvertToKm.TabStop = false;
            this.btnConvertToKm.Text = "Convert to Km";
            this.btnConvertToKm.UseVisualStyleBackColor = true;
            this.btnConvertToKm.Click += new System.EventHandler(this.btnConvertToKm_Click);
            // 
            // btnConvertToMiles
            // 
            this.btnConvertToMiles.Location = new System.Drawing.Point(452, 163);
            this.btnConvertToMiles.Name = "btnConvertToMiles";
            this.btnConvertToMiles.Size = new System.Drawing.Size(149, 60);
            this.btnConvertToMiles.TabIndex = 3;
            this.btnConvertToMiles.TabStop = false;
            this.btnConvertToMiles.Text = "Convert to Miles";
            this.btnConvertToMiles.UseVisualStyleBackColor = true;
            this.btnConvertToMiles.Click += new System.EventHandler(this.btnConvertToMiles_Click);
            // 
            // labelmilesiskm
            // 
            this.labelmilesiskm.AutoSize = true;
            this.labelmilesiskm.Location = new System.Drawing.Point(135, 319);
            this.labelmilesiskm.Name = "labelmilesiskm";
            this.labelmilesiskm.Size = new System.Drawing.Size(0, 25);
            this.labelmilesiskm.TabIndex = 4;
            this.labelmilesiskm.Click += new System.EventHandler(this.labelmilesiskm_Click);
            // 
            // Ch04Lab
            // 
            this.AcceptButton = this.btnConvertToKm;
            this.AccessibleName = "TextBoxKm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelmilesiskm);
            this.Controls.Add(this.btnConvertToMiles);
            this.Controls.Add(this.btnConvertToKm);
            this.Controls.Add(this.textBoxKm);
            this.Controls.Add(this.textBoxMiles);
            this.Controls.Add(this.DistanceKM);
            this.Controls.Add(this.DistanceMiles);
            this.Name = "Ch04Lab";
            this.Text = "Distance Converter";
            this.Load += new System.EventHandler(this.Ch04Lab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DistanceMiles;
        private System.Windows.Forms.Label DistanceKM;
        private System.Windows.Forms.TextBox textBoxMiles;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.Button btnConvertToKm;
        private System.Windows.Forms.Button btnConvertToMiles;
        private System.Windows.Forms.Label labelmilesiskm;
    }
}

