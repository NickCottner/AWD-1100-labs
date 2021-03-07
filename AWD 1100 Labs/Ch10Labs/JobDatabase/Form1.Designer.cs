
namespace JobDatabase
{
    partial class FormJD
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
            this.labelJobInterest = new System.Windows.Forms.Label();
            this.labelSelectAll = new System.Windows.Forms.Label();
            this.listBoxJobs = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelJobInterest
            // 
            this.labelJobInterest.AutoSize = true;
            this.labelJobInterest.Location = new System.Drawing.Point(13, 13);
            this.labelJobInterest.Name = "labelJobInterest";
            this.labelJobInterest.Size = new System.Drawing.Size(309, 25);
            this.labelJobInterest.TabIndex = 0;
            this.labelJobInterest.Text = "What industries are you interested in?";
            // 
            // labelSelectAll
            // 
            this.labelSelectAll.AutoSize = true;
            this.labelSelectAll.Location = new System.Drawing.Point(13, 42);
            this.labelSelectAll.Name = "labelSelectAll";
            this.labelSelectAll.Size = new System.Drawing.Size(184, 25);
            this.labelSelectAll.TabIndex = 1;
            this.labelSelectAll.Text = "(Select All That Apply)";
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.ItemHeight = 25;
            this.listBoxJobs.Items.AddRange(new object[] {
            "Information Technology",
            "Mechanical Engineering",
            "Chemical Engineering ",
            "HVAC ",
            "Automotive"});
            this.listBoxJobs.Location = new System.Drawing.Point(13, 71);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(232, 129);
            this.listBoxJobs.TabIndex = 2;
            this.listBoxJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxJobs_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 239);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormJD
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listBoxJobs);
            this.Controls.Add(this.labelSelectAll);
            this.Controls.Add(this.labelJobInterest);
            this.Name = "FormJD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Databases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJobInterest;
        private System.Windows.Forms.Label labelSelectAll;
        private System.Windows.Forms.ListBox listBoxJobs;
        private System.Windows.Forms.Button btnSearch;
    }
}

