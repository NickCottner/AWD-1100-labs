
namespace Rock_Paper_Scissors
{
    partial class RockPaperScissors
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
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.labelComputerChoice = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.labelComputerScore = new System.Windows.Forms.Label();
            this.labelWinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRock
            // 
            this.buttonRock.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonRock.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRock.Location = new System.Drawing.Point(38, 36);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(126, 82);
            this.buttonRock.TabIndex = 0;
            this.buttonRock.Text = "Rock";
            this.buttonRock.UseVisualStyleBackColor = false;
            // 
            // buttonPaper
            // 
            this.buttonPaper.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonPaper.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPaper.Location = new System.Drawing.Point(334, 36);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(122, 82);
            this.buttonPaper.TabIndex = 1;
            this.buttonPaper.Text = "Paper";
            this.buttonPaper.UseVisualStyleBackColor = false;
            // 
            // buttonScissors
            // 
            this.buttonScissors.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonScissors.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonScissors.Location = new System.Drawing.Point(621, 36);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(132, 82);
            this.buttonScissors.TabIndex = 2;
            this.buttonScissors.Text = "Scissors";
            this.buttonScissors.UseVisualStyleBackColor = false;
            // 
            // labelComputerChoice
            // 
            this.labelComputerChoice.AutoSize = true;
            this.labelComputerChoice.BackColor = System.Drawing.Color.Navy;
            this.labelComputerChoice.ForeColor = System.Drawing.Color.White;
            this.labelComputerChoice.Location = new System.Drawing.Point(38, 171);
            this.labelComputerChoice.Name = "labelComputerChoice";
            this.labelComputerChoice.Size = new System.Drawing.Size(59, 25);
            this.labelComputerChoice.TabIndex = 3;
            this.labelComputerChoice.Text = "label1";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.BackColor = System.Drawing.Color.Navy;
            this.labelPlayerScore.ForeColor = System.Drawing.Color.White;
            this.labelPlayerScore.Location = new System.Drawing.Point(38, 267);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(59, 25);
            this.labelPlayerScore.TabIndex = 4;
            this.labelPlayerScore.Text = "label2";
            // 
            // labelComputerScore
            // 
            this.labelComputerScore.AutoSize = true;
            this.labelComputerScore.BackColor = System.Drawing.Color.Navy;
            this.labelComputerScore.ForeColor = System.Drawing.Color.White;
            this.labelComputerScore.Location = new System.Drawing.Point(316, 267);
            this.labelComputerScore.Name = "labelComputerScore";
            this.labelComputerScore.Size = new System.Drawing.Size(59, 25);
            this.labelComputerScore.TabIndex = 5;
            this.labelComputerScore.Text = "label3";
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.BackColor = System.Drawing.Color.Navy;
            this.labelWinner.ForeColor = System.Drawing.Color.White;
            this.labelWinner.Location = new System.Drawing.Point(38, 374);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(59, 25);
            this.labelWinner.TabIndex = 6;
            this.labelWinner.Text = "label4";
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.labelComputerScore);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.labelComputerChoice);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Name = "RockPaperScissors";
            this.Text = "RockPaperScissors";
            this.Load += new System.EventHandler(this.RockPaperScissors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Label labelComputerChoice;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Label labelComputerScore;
        private System.Windows.Forms.Label labelWinner;
    }
}

