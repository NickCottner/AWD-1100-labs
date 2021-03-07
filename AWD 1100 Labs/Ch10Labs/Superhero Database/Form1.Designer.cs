
namespace Superhero_Database
{
    partial class FormSHDB
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
            this.comboBoxSH = new System.Windows.Forms.ComboBox();
            this.groupBoxSH = new System.Windows.Forms.GroupBox();
            this.labelWiki = new System.Windows.Forms.Label();
            this.labelTheBiography = new System.Windows.Forms.Label();
            this.labelBiography = new System.Windows.Forms.Label();
            this.labelTheSP = new System.Windows.Forms.Label();
            this.labelSP = new System.Windows.Forms.Label();
            this.labelTheDislikes = new System.Windows.Forms.Label();
            this.labelDislikes = new System.Windows.Forms.Label();
            this.labelTheLikes = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxSH = new System.Windows.Forms.PictureBox();
            this.groupBoxSH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSH)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSH
            // 
            this.comboBoxSH.FormattingEnabled = true;
            this.comboBoxSH.Location = new System.Drawing.Point(13, 13);
            this.comboBoxSH.Name = "comboBoxSH";
            this.comboBoxSH.Size = new System.Drawing.Size(182, 33);
            this.comboBoxSH.TabIndex = 0;
            this.comboBoxSH.SelectedIndexChanged += new System.EventHandler(this.comboBoxSH_SelectedIndexChanged);
            // 
            // groupBoxSH
            // 
            this.groupBoxSH.Controls.Add(this.labelWiki);
            this.groupBoxSH.Controls.Add(this.labelTheBiography);
            this.groupBoxSH.Controls.Add(this.labelBiography);
            this.groupBoxSH.Controls.Add(this.labelTheSP);
            this.groupBoxSH.Controls.Add(this.labelSP);
            this.groupBoxSH.Controls.Add(this.labelTheDislikes);
            this.groupBoxSH.Controls.Add(this.labelDislikes);
            this.groupBoxSH.Controls.Add(this.labelTheLikes);
            this.groupBoxSH.Controls.Add(this.labelLikes);
            this.groupBoxSH.Controls.Add(this.labelName);
            this.groupBoxSH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSH.Location = new System.Drawing.Point(13, 52);
            this.groupBoxSH.Name = "groupBoxSH";
            this.groupBoxSH.Size = new System.Drawing.Size(609, 386);
            this.groupBoxSH.TabIndex = 1;
            this.groupBoxSH.TabStop = false;
            this.groupBoxSH.Text = "Superhero";
            // 
            // labelWiki
            // 
            this.labelWiki.AutoSize = true;
            this.labelWiki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelWiki.Location = new System.Drawing.Point(7, 346);
            this.labelWiki.Name = "labelWiki";
            this.labelWiki.Size = new System.Drawing.Size(0, 25);
            this.labelWiki.TabIndex = 9;
            // 
            // labelTheBiography
            // 
            this.labelTheBiography.AutoSize = true;
            this.labelTheBiography.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTheBiography.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTheBiography.Location = new System.Drawing.Point(7, 254);
            this.labelTheBiography.Name = "labelTheBiography";
            this.labelTheBiography.Size = new System.Drawing.Size(0, 21);
            this.labelTheBiography.TabIndex = 8;
            // 
            // labelBiography
            // 
            this.labelBiography.BackColor = System.Drawing.SystemColors.Menu;
            this.labelBiography.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBiography.Location = new System.Drawing.Point(7, 217);
            this.labelBiography.Name = "labelBiography";
            this.labelBiography.Size = new System.Drawing.Size(117, 37);
            this.labelBiography.TabIndex = 7;
            this.labelBiography.Text = "Biography";
            // 
            // labelTheSP
            // 
            this.labelTheSP.AutoSize = true;
            this.labelTheSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelTheSP.Location = new System.Drawing.Point(116, 165);
            this.labelTheSP.Name = "labelTheSP";
            this.labelTheSP.Size = new System.Drawing.Size(0, 25);
            this.labelTheSP.TabIndex = 6;
            // 
            // labelSP
            // 
            this.labelSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSP.Location = new System.Drawing.Point(7, 165);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(125, 25);
            this.labelSP.TabIndex = 5;
            this.labelSP.Text = "Superpower: ";
            // 
            // labelTheDislikes
            // 
            this.labelTheDislikes.AutoSize = true;
            this.labelTheDislikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelTheDislikes.Location = new System.Drawing.Point(76, 129);
            this.labelTheDislikes.Name = "labelTheDislikes";
            this.labelTheDislikes.Size = new System.Drawing.Size(0, 25);
            this.labelTheDislikes.TabIndex = 4;
            // 
            // labelDislikes
            // 
            this.labelDislikes.AutoSize = true;
            this.labelDislikes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDislikes.Location = new System.Drawing.Point(7, 129);
            this.labelDislikes.Name = "labelDislikes";
            this.labelDislikes.Size = new System.Drawing.Size(86, 25);
            this.labelDislikes.TabIndex = 3;
            this.labelDislikes.Text = "Dislikes: ";
            // 
            // labelTheLikes
            // 
            this.labelTheLikes.AutoSize = true;
            this.labelTheLikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelTheLikes.Location = new System.Drawing.Point(54, 95);
            this.labelTheLikes.Name = "labelTheLikes";
            this.labelTheLikes.Size = new System.Drawing.Size(0, 25);
            this.labelTheLikes.TabIndex = 2;
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLikes.Location = new System.Drawing.Point(6, 95);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(64, 25);
            this.labelLikes.TabIndex = 1;
            this.labelLikes.Text = "Likes: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(7, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 32);
            this.labelName.TabIndex = 0;
            // 
            // pictureBoxSH
            // 
            this.pictureBoxSH.Location = new System.Drawing.Point(526, 1);
            this.pictureBoxSH.Name = "pictureBoxSH";
            this.pictureBoxSH.Size = new System.Drawing.Size(284, 314);
            this.pictureBoxSH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSH.TabIndex = 2;
            this.pictureBoxSH.TabStop = false;
            // 
            // FormSHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxSH);
            this.Controls.Add(this.groupBoxSH);
            this.Controls.Add(this.comboBoxSH);
            this.Name = "FormSHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Superhero Database";
            this.Activated += new System.EventHandler(this.FormSHDB_Activated);
            this.groupBoxSH.ResumeLayout(false);
            this.groupBoxSH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSH;
        private System.Windows.Forms.GroupBox groupBoxSH;
        private System.Windows.Forms.Label labelWiki;
        private System.Windows.Forms.Label labelTheBiography;
        private System.Windows.Forms.Label labelBiography;
        private System.Windows.Forms.Label labelTheSP;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Label labelTheDislikes;
        private System.Windows.Forms.Label labelDislikes;
        private System.Windows.Forms.Label labelTheLikes;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxSH;
    }
}

