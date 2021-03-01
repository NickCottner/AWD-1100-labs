
namespace ArrayGUI
{
    partial class FormArrayGUI
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
            this.listBoxArray = new System.Windows.Forms.ListBox();
            this.buttonNewNumbers = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonClearListBox = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonLowest = new System.Windows.Forms.Button();
            this.buttonHighest = new System.Windows.Forms.Button();
            this.buttonSortAscending = new System.Windows.Forms.Button();
            this.buttonMedian = new System.Windows.Forms.Button();
            this.buttonSortDescending = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRange = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxArray
            // 
            this.listBoxArray.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.ItemHeight = 25;
            this.listBoxArray.Location = new System.Drawing.Point(13, 34);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new System.Drawing.Size(126, 629);
            this.listBoxArray.TabIndex = 0;
            // 
            // buttonNewNumbers
            // 
            this.buttonNewNumbers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewNumbers.Location = new System.Drawing.Point(203, 34);
            this.buttonNewNumbers.Name = "buttonNewNumbers";
            this.buttonNewNumbers.Size = new System.Drawing.Size(123, 63);
            this.buttonNewNumbers.TabIndex = 0;
            this.buttonNewNumbers.Text = "New Numbers";
            this.buttonNewNumbers.UseVisualStyleBackColor = true;
            this.buttonNewNumbers.Click += new System.EventHandler(this.buttonNewNumbers_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSum.Location = new System.Drawing.Point(407, 34);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(126, 63);
            this.buttonSum.TabIndex = 1;
            this.buttonSum.Text = "Sum";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonClearListBox
            // 
            this.buttonClearListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClearListBox.Location = new System.Drawing.Point(203, 133);
            this.buttonClearListBox.Name = "buttonClearListBox";
            this.buttonClearListBox.Size = new System.Drawing.Size(123, 63);
            this.buttonClearListBox.TabIndex = 2;
            this.buttonClearListBox.Text = "Clear ListBox";
            this.buttonClearListBox.UseVisualStyleBackColor = true;
            this.buttonClearListBox.Click += new System.EventHandler(this.buttonClearListBox_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAverage.Location = new System.Drawing.Point(407, 133);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(126, 63);
            this.buttonAverage.TabIndex = 3;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // buttonLowest
            // 
            this.buttonLowest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLowest.Location = new System.Drawing.Point(407, 232);
            this.buttonLowest.Name = "buttonLowest";
            this.buttonLowest.Size = new System.Drawing.Size(126, 66);
            this.buttonLowest.TabIndex = 5;
            this.buttonLowest.Text = "Lowest";
            this.buttonLowest.UseVisualStyleBackColor = true;
            this.buttonLowest.Click += new System.EventHandler(this.buttonLowest_Click);
            // 
            // buttonHighest
            // 
            this.buttonHighest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHighest.Location = new System.Drawing.Point(407, 329);
            this.buttonHighest.Name = "buttonHighest";
            this.buttonHighest.Size = new System.Drawing.Size(126, 60);
            this.buttonHighest.TabIndex = 7;
            this.buttonHighest.Text = "Highest";
            this.buttonHighest.UseVisualStyleBackColor = true;
            this.buttonHighest.Click += new System.EventHandler(this.buttonHighest_Click);
            // 
            // buttonSortAscending
            // 
            this.buttonSortAscending.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSortAscending.Location = new System.Drawing.Point(203, 232);
            this.buttonSortAscending.Name = "buttonSortAscending";
            this.buttonSortAscending.Size = new System.Drawing.Size(123, 66);
            this.buttonSortAscending.TabIndex = 4;
            this.buttonSortAscending.Text = "Sort Ascending";
            this.buttonSortAscending.UseVisualStyleBackColor = true;
            this.buttonSortAscending.Click += new System.EventHandler(this.buttonSortAscending_Click);
            // 
            // buttonMedian
            // 
            this.buttonMedian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMedian.Location = new System.Drawing.Point(407, 422);
            this.buttonMedian.Name = "buttonMedian";
            this.buttonMedian.Size = new System.Drawing.Size(126, 63);
            this.buttonMedian.TabIndex = 9;
            this.buttonMedian.Text = "Median";
            this.buttonMedian.UseVisualStyleBackColor = true;
            this.buttonMedian.Click += new System.EventHandler(this.buttonMedian_Click);
            // 
            // buttonSortDescending
            // 
            this.buttonSortDescending.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSortDescending.Location = new System.Drawing.Point(203, 329);
            this.buttonSortDescending.Name = "buttonSortDescending";
            this.buttonSortDescending.Size = new System.Drawing.Size(123, 60);
            this.buttonSortDescending.TabIndex = 6;
            this.buttonSortDescending.Text = "Sort Descending";
            this.buttonSortDescending.UseVisualStyleBackColor = true;
            this.buttonSortDescending.Click += new System.EventHandler(this.buttonSortDescending_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(203, 522);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(123, 59);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRange
            // 
            this.buttonRange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRange.Location = new System.Drawing.Point(407, 522);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(126, 59);
            this.buttonRange.TabIndex = 11;
            this.buttonRange.Text = "Range";
            this.buttonRange.UseVisualStyleBackColor = true;
            this.buttonRange.Click += new System.EventHandler(this.buttonRange_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(203, 422);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(123, 63);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormArrayGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(575, 680);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSortDescending);
            this.Controls.Add(this.buttonMedian);
            this.Controls.Add(this.buttonSortAscending);
            this.Controls.Add(this.buttonHighest);
            this.Controls.Add(this.buttonLowest);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonClearListBox);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonNewNumbers);
            this.Controls.Add(this.listBoxArray);
            this.Name = "FormArrayGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxArray;
        private System.Windows.Forms.Button buttonNewNumbers;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonClearListBox;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonLowest;
        private System.Windows.Forms.Button buttonHighest;
        private System.Windows.Forms.Button buttonSortAscending;
        private System.Windows.Forms.Button buttonMedian;
        private System.Windows.Forms.Button buttonSortDescending;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRange;
        private System.Windows.Forms.Button buttonSearch;
    }
}

