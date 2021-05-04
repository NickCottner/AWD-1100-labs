
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
            this.pictureBoxSH = new System.Windows.Forms.PictureBox();
            this.groupBoxSHInfo = new System.Windows.Forms.GroupBox();
            this.labelWikis = new System.Windows.Forms.Label();
            this.labelTheBiography = new System.Windows.Forms.Label();
            this.labelBiography = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTheSuperpower = new System.Windows.Forms.Label();
            this.labelTheDislikes = new System.Windows.Forms.Label();
            this.labelTheLikes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDislikes = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSH)).BeginInit();
            this.groupBoxSHInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSH
            // 
            this.comboBoxSH.BackColor = System.Drawing.Color.White;
            this.comboBoxSH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSH.FormattingEnabled = true;
            this.comboBoxSH.Location = new System.Drawing.Point(13, 13);
            this.comboBoxSH.Name = "comboBoxSH";
            this.comboBoxSH.Size = new System.Drawing.Size(218, 33);
            this.comboBoxSH.TabIndex = 0;
            this.comboBoxSH.SelectedIndexChanged += new System.EventHandler(this.comboBoxSH_SelectedIndexChanged);
            // 
            // pictureBoxSH
            // 
            this.pictureBoxSH.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSH.Location = new System.Drawing.Point(637, 13);
            this.pictureBoxSH.Name = "pictureBoxSH";
            this.pictureBoxSH.Size = new System.Drawing.Size(329, 595);
            this.pictureBoxSH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSH.TabIndex = 2;
            this.pictureBoxSH.TabStop = false;
            // 
            // groupBoxSHInfo
            // 
            this.groupBoxSHInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxSHInfo.Controls.Add(this.labelWikis);
            this.groupBoxSHInfo.Controls.Add(this.labelTheBiography);
            this.groupBoxSHInfo.Controls.Add(this.labelBiography);
            this.groupBoxSHInfo.Controls.Add(this.labelName);
            this.groupBoxSHInfo.Controls.Add(this.labelTheSuperpower);
            this.groupBoxSHInfo.Controls.Add(this.labelTheDislikes);
            this.groupBoxSHInfo.Controls.Add(this.labelTheLikes);
            this.groupBoxSHInfo.Controls.Add(this.label2);
            this.groupBoxSHInfo.Controls.Add(this.labelDislikes);
            this.groupBoxSHInfo.Controls.Add(this.labelLikes);
            this.groupBoxSHInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSHInfo.Location = new System.Drawing.Point(13, 52);
            this.groupBoxSHInfo.Name = "groupBoxSHInfo";
            this.groupBoxSHInfo.Size = new System.Drawing.Size(618, 556);
            this.groupBoxSHInfo.TabIndex = 3;
            this.groupBoxSHInfo.TabStop = false;
            this.groupBoxSHInfo.Text = "Superhero Info";
            // 
            // labelWikis
            // 
            this.labelWikis.BackColor = System.Drawing.Color.Navy;
            this.labelWikis.ForeColor = System.Drawing.Color.White;
            this.labelWikis.Location = new System.Drawing.Point(10, 512);
            this.labelWikis.Name = "labelWikis";
            this.labelWikis.Size = new System.Drawing.Size(592, 38);
            this.labelWikis.TabIndex = 9;
            this.labelWikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTheBiography
            // 
            this.labelTheBiography.BackColor = System.Drawing.Color.Navy;
            this.labelTheBiography.ForeColor = System.Drawing.Color.White;
            this.labelTheBiography.Location = new System.Drawing.Point(10, 357);
            this.labelTheBiography.Name = "labelTheBiography";
            this.labelTheBiography.Size = new System.Drawing.Size(592, 141);
            this.labelTheBiography.TabIndex = 8;
            this.labelTheBiography.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBiography
            // 
            this.labelBiography.AutoSize = true;
            this.labelBiography.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBiography.Location = new System.Drawing.Point(10, 306);
            this.labelBiography.Name = "labelBiography";
            this.labelBiography.Size = new System.Drawing.Size(152, 38);
            this.labelBiography.TabIndex = 7;
            this.labelBiography.Text = "Biography";
            this.labelBiography.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Navy;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(10, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(592, 77);
            this.labelName.TabIndex = 6;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTheSuperpower
            // 
            this.labelTheSuperpower.BackColor = System.Drawing.Color.Navy;
            this.labelTheSuperpower.ForeColor = System.Drawing.Color.White;
            this.labelTheSuperpower.Location = new System.Drawing.Point(153, 251);
            this.labelTheSuperpower.Name = "labelTheSuperpower";
            this.labelTheSuperpower.Size = new System.Drawing.Size(449, 38);
            this.labelTheSuperpower.TabIndex = 5;
            this.labelTheSuperpower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTheDislikes
            // 
            this.labelTheDislikes.BackColor = System.Drawing.Color.Navy;
            this.labelTheDislikes.ForeColor = System.Drawing.Color.White;
            this.labelTheDislikes.Location = new System.Drawing.Point(153, 208);
            this.labelTheDislikes.Name = "labelTheDislikes";
            this.labelTheDislikes.Size = new System.Drawing.Size(449, 38);
            this.labelTheDislikes.TabIndex = 4;
            this.labelTheDislikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTheLikes
            // 
            this.labelTheLikes.BackColor = System.Drawing.Color.Navy;
            this.labelTheLikes.ForeColor = System.Drawing.Color.White;
            this.labelTheLikes.Location = new System.Drawing.Point(153, 161);
            this.labelTheLikes.Name = "labelTheLikes";
            this.labelTheLikes.Size = new System.Drawing.Size(449, 38);
            this.labelTheLikes.TabIndex = 3;
            this.labelTheLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Superpower:";
            // 
            // labelDislikes
            // 
            this.labelDislikes.AutoSize = true;
            this.labelDislikes.Location = new System.Drawing.Point(49, 215);
            this.labelDislikes.Name = "labelDislikes";
            this.labelDislikes.Size = new System.Drawing.Size(81, 25);
            this.labelDislikes.TabIndex = 1;
            this.labelDislikes.Text = "Dislikes:";
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Location = new System.Drawing.Point(71, 168);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(59, 25);
            this.labelLikes.TabIndex = 0;
            this.labelLikes.Text = "Likes:";
            // 
            // FormSHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(972, 620);
            this.Controls.Add(this.groupBoxSHInfo);
            this.Controls.Add(this.pictureBoxSH);
            this.Controls.Add(this.comboBoxSH);
            this.Name = "FormSHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Superhero Database";
            this.Activated += new System.EventHandler(this.FormSHDB_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSH)).EndInit();
            this.groupBoxSHInfo.ResumeLayout(false);
            this.groupBoxSHInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSH;
        private System.Windows.Forms.PictureBox pictureBoxSH;
        private System.Windows.Forms.GroupBox groupBoxSHInfo;
        private System.Windows.Forms.Label labelTheSuperpower;
        private System.Windows.Forms.Label labelTheDislikes;
        private System.Windows.Forms.Label labelTheLikes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDislikes;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBiography;
        private System.Windows.Forms.Label labelTheBiography;
        private System.Windows.Forms.Label labelWikis;
    }
}

