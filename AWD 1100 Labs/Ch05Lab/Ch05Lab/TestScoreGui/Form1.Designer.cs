
namespace TestScoreGui
{
    partial class FormTestScores
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
            this.labelTestScore = new System.Windows.Forms.Label();
            this.textBoxTestScore = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelNumberofScores = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelLowest = new System.Windows.Forms.Label();
            this.labelHighest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTestScore
            // 
            this.labelTestScore.AutoSize = true;
            this.labelTestScore.Location = new System.Drawing.Point(13, 13);
            this.labelTestScore.Name = "labelTestScore";
            this.labelTestScore.Size = new System.Drawing.Size(208, 25);
            this.labelTestScore.TabIndex = 0;
            this.labelTestScore.Text = "Please Enter a Test Score:";
            // 
            // textBoxTestScore
            // 
            this.textBoxTestScore.Location = new System.Drawing.Point(12, 41);
            this.textBoxTestScore.Name = "textBoxTestScore";
            this.textBoxTestScore.Size = new System.Drawing.Size(208, 31);
            this.textBoxTestScore.TabIndex = 1;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 92);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(112, 57);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelNumberofScores
            // 
            this.labelNumberofScores.AutoSize = true;
            this.labelNumberofScores.BackColor = System.Drawing.Color.Blue;
            this.labelNumberofScores.ForeColor = System.Drawing.Color.White;
            this.labelNumberofScores.Location = new System.Drawing.Point(12, 200);
            this.labelNumberofScores.Name = "labelNumberofScores";
            this.labelNumberofScores.Size = new System.Drawing.Size(0, 25);
            this.labelNumberofScores.TabIndex = 3;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.BackColor = System.Drawing.Color.Blue;
            this.labelSum.ForeColor = System.Drawing.Color.White;
            this.labelSum.Location = new System.Drawing.Point(12, 237);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(0, 25);
            this.labelSum.TabIndex = 4;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.BackColor = System.Drawing.Color.Blue;
            this.labelAverage.ForeColor = System.Drawing.Color.White;
            this.labelAverage.Location = new System.Drawing.Point(12, 275);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(0, 25);
            this.labelAverage.TabIndex = 5;
            // 
            // labelLowest
            // 
            this.labelLowest.AutoSize = true;
            this.labelLowest.BackColor = System.Drawing.Color.Blue;
            this.labelLowest.ForeColor = System.Drawing.Color.White;
            this.labelLowest.Location = new System.Drawing.Point(12, 317);
            this.labelLowest.Name = "labelLowest";
            this.labelLowest.Size = new System.Drawing.Size(0, 25);
            this.labelLowest.TabIndex = 6;
            // 
            // labelHighest
            // 
            this.labelHighest.AutoSize = true;
            this.labelHighest.BackColor = System.Drawing.Color.Blue;
            this.labelHighest.ForeColor = System.Drawing.Color.White;
            this.labelHighest.Location = new System.Drawing.Point(13, 360);
            this.labelHighest.Name = "labelHighest";
            this.labelHighest.Size = new System.Drawing.Size(0, 25);
            this.labelHighest.TabIndex = 7;
            // 
            // FormTestScores
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.labelHighest);
            this.Controls.Add(this.labelLowest);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelNumberofScores);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxTestScore);
            this.Controls.Add(this.labelTestScore);
            this.Name = "FormTestScores";
            this.Text = "Test Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTestScore;
        private System.Windows.Forms.TextBox textBoxTestScore;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelNumberofScores;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelLowest;
        private System.Windows.Forms.Label labelHighest;
    }
}

