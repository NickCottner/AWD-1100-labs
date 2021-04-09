
namespace GameBreak
{
    partial class FormGameBreak
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
            this.textBoxGame = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelNameHeader = new System.Windows.Forms.Label();
            this.labelPublisherHeader = new System.Windows.Forms.Label();
            this.labelPriceHeader = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGame
            // 
            this.textBoxGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGame.Location = new System.Drawing.Point(37, 32);
            this.textBoxGame.Multiline = true;
            this.textBoxGame.Name = "textBoxGame";
            this.textBoxGame.Size = new System.Drawing.Size(403, 43);
            this.textBoxGame.TabIndex = 0;
            this.textBoxGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(475, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 41);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(582, 34);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 41);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelNameHeader
            // 
            this.labelNameHeader.Location = new System.Drawing.Point(37, 90);
            this.labelNameHeader.Name = "labelNameHeader";
            this.labelNameHeader.Size = new System.Drawing.Size(73, 33);
            this.labelNameHeader.TabIndex = 6;
            this.labelNameHeader.Text = "Name:";
            this.labelNameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPublisherHeader
            // 
            this.labelPublisherHeader.Location = new System.Drawing.Point(37, 143);
            this.labelPublisherHeader.Name = "labelPublisherHeader";
            this.labelPublisherHeader.Size = new System.Drawing.Size(84, 33);
            this.labelPublisherHeader.TabIndex = 7;
            this.labelPublisherHeader.Text = "Publisher:";
            this.labelPublisherHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPriceHeader
            // 
            this.labelPriceHeader.Location = new System.Drawing.Point(37, 206);
            this.labelPriceHeader.Name = "labelPriceHeader";
            this.labelPriceHeader.Size = new System.Drawing.Size(73, 33);
            this.labelPriceHeader.TabIndex = 8;
            this.labelPriceHeader.Text = "Price:";
            this.labelPriceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(127, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(384, 33);
            this.labelName.TabIndex = 3;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPublisher
            // 
            this.labelPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublisher.Location = new System.Drawing.Point(127, 143);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(384, 33);
            this.labelPublisher.TabIndex = 4;
            this.labelPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(127, 206);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(384, 33);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormGameBreak
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPriceHeader);
            this.Controls.Add(this.labelPublisherHeader);
            this.Controls.Add(this.labelNameHeader);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxGame);
            this.Name = "FormGameBreak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Break";
            this.Load += new System.EventHandler(this.FormGameBreak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGame;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelNameHeader;
        private System.Windows.Forms.Label labelPublisherHeader;
        private System.Windows.Forms.Label labelPriceHeader;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelPrice;
    }
}

