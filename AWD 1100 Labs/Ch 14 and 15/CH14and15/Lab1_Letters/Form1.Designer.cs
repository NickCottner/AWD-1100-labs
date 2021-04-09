
namespace Lab1_Letters
{
    partial class FormLetterDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLetterInfo = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelAdditionalFee = new System.Windows.Forms.Label();
            this.textBoxTrackingNumber = new System.Windows.Forms.TextBox();
            this.textBoxSentDate = new System.Windows.Forms.TextBox();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            this.labelTrackingNumber = new System.Windows.Forms.Label();
            this.labelSentDate = new System.Windows.Forms.Label();
            this.labelRecipient = new System.Windows.Forms.Label();
            this.groupBoxLetterHistory = new System.Windows.Forms.GroupBox();
            this.textBoxLetterHistory = new System.Windows.Forms.TextBox();
            this.groupBoxLetterInfo.SuspendLayout();
            this.groupBoxLetterHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLetterInfo
            // 
            this.groupBoxLetterInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxLetterInfo.Controls.Add(this.buttonExit);
            this.groupBoxLetterInfo.Controls.Add(this.buttonClear);
            this.groupBoxLetterInfo.Controls.Add(this.buttonSend);
            this.groupBoxLetterInfo.Controls.Add(this.labelAdditionalFee);
            this.groupBoxLetterInfo.Controls.Add(this.textBoxTrackingNumber);
            this.groupBoxLetterInfo.Controls.Add(this.textBoxSentDate);
            this.groupBoxLetterInfo.Controls.Add(this.textBoxRecipient);
            this.groupBoxLetterInfo.Controls.Add(this.labelTrackingNumber);
            this.groupBoxLetterInfo.Controls.Add(this.labelSentDate);
            this.groupBoxLetterInfo.Controls.Add(this.labelRecipient);
            this.groupBoxLetterInfo.Location = new System.Drawing.Point(13, 13);
            this.groupBoxLetterInfo.Name = "groupBoxLetterInfo";
            this.groupBoxLetterInfo.Size = new System.Drawing.Size(424, 528);
            this.groupBoxLetterInfo.TabIndex = 0;
            this.groupBoxLetterInfo.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(308, 317);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 51);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(169, 317);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 51);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(35, 317);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 51);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelAdditionalFee
            // 
            this.labelAdditionalFee.AutoSize = true;
            this.labelAdditionalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditionalFee.Location = new System.Drawing.Point(30, 247);
            this.labelAdditionalFee.Name = "labelAdditionalFee";
            this.labelAdditionalFee.Size = new System.Drawing.Size(353, 25);
            this.labelAdditionalFee.TabIndex = 9;
            this.labelAdditionalFee.Text = "(Additional Fee For Certified Letter)";
            // 
            // textBoxTrackingNumber
            // 
            this.textBoxTrackingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrackingNumber.Location = new System.Drawing.Point(198, 133);
            this.textBoxTrackingNumber.Name = "textBoxTrackingNumber";
            this.textBoxTrackingNumber.Size = new System.Drawing.Size(208, 26);
            this.textBoxTrackingNumber.TabIndex = 2;
            this.textBoxTrackingNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSentDate
            // 
            this.textBoxSentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSentDate.Location = new System.Drawing.Point(197, 77);
            this.textBoxSentDate.Name = "textBoxSentDate";
            this.textBoxSentDate.Size = new System.Drawing.Size(208, 26);
            this.textBoxSentDate.TabIndex = 1;
            this.textBoxSentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecipient.Location = new System.Drawing.Point(198, 22);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(208, 26);
            this.textBoxRecipient.TabIndex = 0;
            this.textBoxRecipient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTrackingNumber
            // 
            this.labelTrackingNumber.AutoSize = true;
            this.labelTrackingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackingNumber.Location = new System.Drawing.Point(7, 133);
            this.labelTrackingNumber.Name = "labelTrackingNumber";
            this.labelTrackingNumber.Size = new System.Drawing.Size(184, 25);
            this.labelTrackingNumber.TabIndex = 8;
            this.labelTrackingNumber.Text = "Tracking Number:";
            // 
            // labelSentDate
            // 
            this.labelSentDate.AutoSize = true;
            this.labelSentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentDate.Location = new System.Drawing.Point(76, 78);
            this.labelSentDate.Name = "labelSentDate";
            this.labelSentDate.Size = new System.Drawing.Size(115, 25);
            this.labelSentDate.TabIndex = 7;
            this.labelSentDate.Text = "Sent Date:";
            // 
            // labelRecipient
            // 
            this.labelRecipient.AutoSize = true;
            this.labelRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecipient.Location = new System.Drawing.Point(83, 22);
            this.labelRecipient.Name = "labelRecipient";
            this.labelRecipient.Size = new System.Drawing.Size(108, 25);
            this.labelRecipient.TabIndex = 6;
            this.labelRecipient.Text = "Recipient:";
            // 
            // groupBoxLetterHistory
            // 
            this.groupBoxLetterHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxLetterHistory.Controls.Add(this.textBoxLetterHistory);
            this.groupBoxLetterHistory.Location = new System.Drawing.Point(458, 13);
            this.groupBoxLetterHistory.Name = "groupBoxLetterHistory";
            this.groupBoxLetterHistory.Size = new System.Drawing.Size(424, 528);
            this.groupBoxLetterHistory.TabIndex = 1;
            this.groupBoxLetterHistory.TabStop = false;
            // 
            // textBoxLetterHistory
            // 
            this.textBoxLetterHistory.Location = new System.Drawing.Point(7, 22);
            this.textBoxLetterHistory.Multiline = true;
            this.textBoxLetterHistory.Name = "textBoxLetterHistory";
            this.textBoxLetterHistory.ReadOnly = true;
            this.textBoxLetterHistory.Size = new System.Drawing.Size(411, 500);
            this.textBoxLetterHistory.TabIndex = 0;
            // 
            // FormLetterDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(923, 553);
            this.Controls.Add(this.groupBoxLetterHistory);
            this.Controls.Add(this.groupBoxLetterInfo);
            this.Name = "FormLetterDelivery";
            this.Text = "Letter Deilvery";
            this.Load += new System.EventHandler(this.FormLetterDelivery_Load);
            this.groupBoxLetterInfo.ResumeLayout(false);
            this.groupBoxLetterInfo.PerformLayout();
            this.groupBoxLetterHistory.ResumeLayout(false);
            this.groupBoxLetterHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLetterInfo;
        private System.Windows.Forms.TextBox textBoxTrackingNumber;
        private System.Windows.Forms.TextBox textBoxSentDate;
        private System.Windows.Forms.TextBox textBoxRecipient;
        private System.Windows.Forms.Label labelTrackingNumber;
        private System.Windows.Forms.Label labelSentDate;
        private System.Windows.Forms.Label labelRecipient;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelAdditionalFee;
        private System.Windows.Forms.GroupBox groupBoxLetterHistory;
        private System.Windows.Forms.TextBox textBoxLetterHistory;
    }
}

