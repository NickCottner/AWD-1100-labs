
namespace MovieDatabase
{
    partial class FormMovieDatabase
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
            this.textBoxSearchItem = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labeltheDescription = new System.Windows.Forms.Label();
            this.labeltheDirector = new System.Windows.Forms.Label();
            this.labeltheName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearchItem
            // 
            this.textBoxSearchItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxSearchItem.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchItem.Location = new System.Drawing.Point(37, 48);
            this.textBoxSearchItem.Name = "textBoxSearchItem";
            this.textBoxSearchItem.Size = new System.Drawing.Size(400, 31);
            this.textBoxSearchItem.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Navy;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSearch.Location = new System.Drawing.Point(443, 48);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 31);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonClear.Location = new System.Drawing.Point(561, 48);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 31);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Navy;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonExit.Location = new System.Drawing.Point(679, 48);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 31);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.labeltheDescription);
            this.groupBox1.Controls.Add(this.labeltheDirector);
            this.groupBox1.Controls.Add(this.labeltheName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelDirector);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(26, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 236);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The Movie";
            // 
            // labeltheDescription
            // 
            this.labeltheDescription.BackColor = System.Drawing.Color.Navy;
            this.labeltheDescription.Location = new System.Drawing.Point(145, 155);
            this.labeltheDescription.Name = "labeltheDescription";
            this.labeltheDescription.Size = new System.Drawing.Size(580, 66);
            this.labeltheDescription.TabIndex = 5;
            this.labeltheDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labeltheDirector
            // 
            this.labeltheDirector.BackColor = System.Drawing.Color.Navy;
            this.labeltheDirector.Location = new System.Drawing.Point(145, 103);
            this.labeltheDirector.Name = "labeltheDirector";
            this.labeltheDirector.Size = new System.Drawing.Size(580, 40);
            this.labeltheDirector.TabIndex = 4;
            this.labeltheDirector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labeltheName
            // 
            this.labeltheName.BackColor = System.Drawing.Color.Navy;
            this.labeltheName.Location = new System.Drawing.Point(145, 43);
            this.labeltheName.Name = "labeltheName";
            this.labeltheName.Size = new System.Drawing.Size(580, 41);
            this.labeltheName.TabIndex = 3;
            this.labeltheName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labeltheName.Click += new System.EventHandler(this.labeltheName_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(11, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDirector
            // 
            this.labelDirector.BackColor = System.Drawing.Color.Navy;
            this.labelDirector.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDirector.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDirector.Location = new System.Drawing.Point(11, 103);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(114, 40);
            this.labelDirector.TabIndex = 1;
            this.labelDirector.Text = "Director:";
            this.labelDirector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Navy;
            this.labelName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelName.Location = new System.Drawing.Point(11, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(114, 41);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMovieDatabase
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchItem);
            this.Name = "FormMovieDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Database";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchItem;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labeltheDirector;
        private System.Windows.Forms.Label labeltheName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labeltheDescription;
    }
}

