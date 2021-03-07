
namespace MultiSearch
{
    partial class FormSL
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
            this.labelFN = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.buttonFNSearch = new System.Windows.Forms.Button();
            this.buttonLNSearch = new System.Windows.Forms.Button();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.labelTGPA = new System.Windows.Forms.Label();
            this.labelTCG = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.labelGPA = new System.Windows.Forms.Label();
            this.labelCG = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Location = new System.Drawing.Point(13, 13);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(97, 25);
            this.labelFN.TabIndex = 0;
            this.labelFN.Text = "First Name";
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Location = new System.Drawing.Point(319, 13);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(95, 25);
            this.labelLN.TabIndex = 1;
            this.labelLN.Text = "Last Name";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(13, 54);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(203, 31);
            this.textBoxFN.TabIndex = 0;
            // 
            // textBoxLN
            // 
            this.textBoxLN.Location = new System.Drawing.Point(319, 54);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(203, 31);
            this.textBoxLN.TabIndex = 1;
            // 
            // buttonFNSearch
            // 
            this.buttonFNSearch.Location = new System.Drawing.Point(13, 103);
            this.buttonFNSearch.Name = "buttonFNSearch";
            this.buttonFNSearch.Size = new System.Drawing.Size(203, 34);
            this.buttonFNSearch.TabIndex = 2;
            this.buttonFNSearch.Text = "Search by First Name";
            this.buttonFNSearch.UseVisualStyleBackColor = true;
            this.buttonFNSearch.Click += new System.EventHandler(this.buttonFNSearch_Click);
            // 
            // buttonLNSearch
            // 
            this.buttonLNSearch.Location = new System.Drawing.Point(319, 103);
            this.buttonLNSearch.Name = "buttonLNSearch";
            this.buttonLNSearch.Size = new System.Drawing.Size(203, 34);
            this.buttonLNSearch.TabIndex = 3;
            this.buttonLNSearch.Text = "Search by Last Name";
            this.buttonLNSearch.UseVisualStyleBackColor = true;
            this.buttonLNSearch.Click += new System.EventHandler(this.buttonLNSearch_Click);
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.labelTGPA);
            this.groupBoxStudent.Controls.Add(this.labelTCG);
            this.groupBoxStudent.Controls.Add(this.labelTC);
            this.groupBoxStudent.Controls.Add(this.labelGPA);
            this.groupBoxStudent.Controls.Add(this.labelCG);
            this.groupBoxStudent.Controls.Add(this.labelCourse);
            this.groupBoxStudent.Controls.Add(this.labelName);
            this.groupBoxStudent.Location = new System.Drawing.Point(13, 238);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(374, 296);
            this.groupBoxStudent.TabIndex = 6;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Student";
            // 
            // labelTGPA
            // 
            this.labelTGPA.BackColor = System.Drawing.Color.Blue;
            this.labelTGPA.Location = new System.Drawing.Point(81, 217);
            this.labelTGPA.Name = "labelTGPA";
            this.labelTGPA.Size = new System.Drawing.Size(199, 38);
            this.labelTGPA.TabIndex = 6;
            // 
            // labelTCG
            // 
            this.labelTCG.BackColor = System.Drawing.Color.Blue;
            this.labelTCG.Location = new System.Drawing.Point(155, 154);
            this.labelTCG.Name = "labelTCG";
            this.labelTCG.Size = new System.Drawing.Size(199, 38);
            this.labelTCG.TabIndex = 5;
            // 
            // labelTC
            // 
            this.labelTC.BackColor = System.Drawing.Color.Blue;
            this.labelTC.Location = new System.Drawing.Point(104, 85);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(199, 38);
            this.labelTC.TabIndex = 4;
            // 
            // labelGPA
            // 
            this.labelGPA.AutoSize = true;
            this.labelGPA.Location = new System.Drawing.Point(26, 230);
            this.labelGPA.Name = "labelGPA";
            this.labelGPA.Size = new System.Drawing.Size(49, 25);
            this.labelGPA.TabIndex = 3;
            this.labelGPA.Text = "GPA:";
            // 
            // labelCG
            // 
            this.labelCG.AutoSize = true;
            this.labelCG.Location = new System.Drawing.Point(26, 154);
            this.labelCG.Name = "labelCG";
            this.labelCG.Size = new System.Drawing.Size(123, 25);
            this.labelCG.TabIndex = 2;
            this.labelCG.Text = "Course Grade:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(26, 85);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(71, 25);
            this.labelCourse.TabIndex = 1;
            this.labelCourse.Text = "Course:";
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Yellow;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(7, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(296, 38);
            this.labelName.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(13, 171);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(203, 34);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(319, 171);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(203, 34);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormSL
            // 
            this.AcceptButton = this.buttonFNSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(584, 546);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBoxStudent);
            this.Controls.Add(this.buttonLNSearch);
            this.Controls.Add(this.buttonFNSearch);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.labelFN);
            this.Name = "FormSL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.Button buttonFNSearch;
        private System.Windows.Forms.Button buttonLNSearch;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.Label labelTGPA;
        private System.Windows.Forms.Label labelTCG;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelGPA;
        private System.Windows.Forms.Label labelCG;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

