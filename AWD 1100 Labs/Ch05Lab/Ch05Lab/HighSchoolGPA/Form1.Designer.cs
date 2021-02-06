
namespace HighSchoolGPA
{
    partial class Form1
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
            this.labelgpa = new System.Windows.Forms.Label();
            this.labeladmissions = new System.Windows.Forms.Label();
            this.textBoxgpa = new System.Windows.Forms.TextBox();
            this.textBoxadmissiontestscore = new System.Windows.Forms.TextBox();
            this.btnadmit = new System.Windows.Forms.Button();
            this.labelacceptorreject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelgpa
            // 
            this.labelgpa.AutoSize = true;
            this.labelgpa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelgpa.Location = new System.Drawing.Point(42, 13);
            this.labelgpa.Name = "labelgpa";
            this.labelgpa.Size = new System.Drawing.Size(62, 32);
            this.labelgpa.TabIndex = 0;
            this.labelgpa.Text = "GPA";
            this.labelgpa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeladmissions
            // 
            this.labeladmissions.AutoSize = true;
            this.labeladmissions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeladmissions.Location = new System.Drawing.Point(306, 13);
            this.labeladmissions.Name = "labeladmissions";
            this.labeladmissions.Size = new System.Drawing.Size(256, 32);
            this.labeladmissions.TabIndex = 1;
            this.labeladmissions.Text = "Admission Test Score";
            this.labeladmissions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labeladmissions.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxgpa
            // 
            this.textBoxgpa.Location = new System.Drawing.Point(42, 61);
            this.textBoxgpa.Name = "textBoxgpa";
            this.textBoxgpa.Size = new System.Drawing.Size(150, 31);
            this.textBoxgpa.TabIndex = 2;
            this.textBoxgpa.TextChanged += new System.EventHandler(this.textBoxgpa_TextChanged);
            // 
            // textBoxadmissiontestscore
            // 
            this.textBoxadmissiontestscore.Location = new System.Drawing.Point(306, 61);
            this.textBoxadmissiontestscore.Name = "textBoxadmissiontestscore";
            this.textBoxadmissiontestscore.Size = new System.Drawing.Size(150, 31);
            this.textBoxadmissiontestscore.TabIndex = 3;
            // 
            // btnadmit
            // 
            this.btnadmit.Location = new System.Drawing.Point(42, 194);
            this.btnadmit.Name = "btnadmit";
            this.btnadmit.Size = new System.Drawing.Size(112, 34);
            this.btnadmit.TabIndex = 4;
            this.btnadmit.Text = "Admit";
            this.btnadmit.UseVisualStyleBackColor = true;
            this.btnadmit.Click += new System.EventHandler(this.btnadmit_Click);
            // 
            // labelacceptorreject
            // 
            this.labelacceptorreject.AutoSize = true;
            this.labelacceptorreject.Location = new System.Drawing.Point(225, 199);
            this.labelacceptorreject.Name = "labelacceptorreject";
            this.labelacceptorreject.Size = new System.Drawing.Size(0, 25);
            this.labelacceptorreject.TabIndex = 5;
            this.labelacceptorreject.Click += new System.EventHandler(this.labelacceptorreject_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnadmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelacceptorreject);
            this.Controls.Add(this.btnadmit);
            this.Controls.Add(this.textBoxadmissiontestscore);
            this.Controls.Add(this.textBoxgpa);
            this.Controls.Add(this.labeladmissions);
            this.Controls.Add(this.labelgpa);
            this.Name = "Form1";
            this.Text = "College Admission";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelgpa;
        private System.Windows.Forms.Label labeladmissions;
        private System.Windows.Forms.TextBox textBoxgpa;
        private System.Windows.Forms.TextBox textBoxadmissiontestscore;
        private System.Windows.Forms.Button btnadmit;
        private System.Windows.Forms.Label labelacceptorreject;
    }
}

