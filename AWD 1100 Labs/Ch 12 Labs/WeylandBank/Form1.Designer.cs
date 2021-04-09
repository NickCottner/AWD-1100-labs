
namespace WeylandBank
{
    partial class FormWeylandBank
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
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.labelPinNumber = new System.Windows.Forms.Label();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.textBoxPinNumber = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxWelcomeInfo = new System.Windows.Forms.TextBox();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.textBoxWithdrawal = new System.Windows.Forms.TextBox();
            this.labelWithdrawal = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdrawal = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelAccountNumber.Location = new System.Drawing.Point(97, 39);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(100, 23);
            this.labelAccountNumber.TabIndex = 9;
            this.labelAccountNumber.Text = "Account # :";
            this.labelAccountNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPinNumber
            // 
            this.labelPinNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelPinNumber.Location = new System.Drawing.Point(97, 113);
            this.labelPinNumber.Name = "labelPinNumber";
            this.labelPinNumber.Size = new System.Drawing.Size(89, 20);
            this.labelPinNumber.TabIndex = 10;
            this.labelPinNumber.Text = "PIn # :";
            this.labelPinNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccountNumber.Location = new System.Drawing.Point(204, 39);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(254, 26);
            this.textBoxAccountNumber.TabIndex = 0;
            // 
            // textBoxPinNumber
            // 
            this.textBoxPinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPinNumber.Location = new System.Drawing.Point(204, 107);
            this.textBoxPinNumber.Name = "textBoxPinNumber";
            this.textBoxPinNumber.Size = new System.Drawing.Size(254, 26);
            this.textBoxPinNumber.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Black;
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(462, 73);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(105, 32);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxWelcomeInfo
            // 
            this.textBoxWelcomeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxWelcomeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWelcomeInfo.Location = new System.Drawing.Point(53, 166);
            this.textBoxWelcomeInfo.Multiline = true;
            this.textBoxWelcomeInfo.Name = "textBoxWelcomeInfo";
            this.textBoxWelcomeInfo.Size = new System.Drawing.Size(502, 240);
            this.textBoxWelcomeInfo.TabIndex = 3;
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeposit.Location = new System.Drawing.Point(101, 490);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(254, 26);
            this.textBoxDeposit.TabIndex = 4;
            // 
            // labelDeposit
            // 
            this.labelDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelDeposit.Location = new System.Drawing.Point(97, 424);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(361, 25);
            this.labelDeposit.TabIndex = 11;
            this.labelDeposit.Text = "Would You Like To Make A Deposit?";
            this.labelDeposit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxWithdrawal
            // 
            this.textBoxWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWithdrawal.Location = new System.Drawing.Point(101, 620);
            this.textBoxWithdrawal.Name = "textBoxWithdrawal";
            this.textBoxWithdrawal.Size = new System.Drawing.Size(254, 26);
            this.textBoxWithdrawal.TabIndex = 6;
            // 
            // labelWithdrawal
            // 
            this.labelWithdrawal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelWithdrawal.Location = new System.Drawing.Point(97, 557);
            this.labelWithdrawal.Name = "labelWithdrawal";
            this.labelWithdrawal.Size = new System.Drawing.Size(361, 25);
            this.labelWithdrawal.TabIndex = 12;
            this.labelWithdrawal.Text = "Would You Like To Make A Withdrawal?";
            this.labelWithdrawal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.Black;
            this.buttonDeposit.ForeColor = System.Drawing.Color.White;
            this.buttonDeposit.Location = new System.Drawing.Point(462, 471);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(105, 32);
            this.buttonDeposit.TabIndex = 5;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdrawal
            // 
            this.buttonWithdrawal.BackColor = System.Drawing.Color.Black;
            this.buttonWithdrawal.ForeColor = System.Drawing.Color.White;
            this.buttonWithdrawal.Location = new System.Drawing.Point(462, 599);
            this.buttonWithdrawal.Name = "buttonWithdrawal";
            this.buttonWithdrawal.Size = new System.Drawing.Size(105, 32);
            this.buttonWithdrawal.TabIndex = 7;
            this.buttonWithdrawal.Text = "Withdraw";
            this.buttonWithdrawal.UseVisualStyleBackColor = false;
            this.buttonWithdrawal.Click += new System.EventHandler(this.buttonWithdrawal_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Black;
            this.buttonLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(363, 669);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(95, 32);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormWeylandBank
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelButton = this.buttonLogout;
            this.ClientSize = new System.Drawing.Size(611, 704);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonWithdrawal);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.textBoxWithdrawal);
            this.Controls.Add(this.labelWithdrawal);
            this.Controls.Add(this.textBoxDeposit);
            this.Controls.Add(this.labelDeposit);
            this.Controls.Add(this.textBoxWelcomeInfo);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPinNumber);
            this.Controls.Add(this.textBoxAccountNumber);
            this.Controls.Add(this.labelPinNumber);
            this.Controls.Add(this.labelAccountNumber);
            this.Name = "FormWeylandBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weyland Bank";
            this.Load += new System.EventHandler(this.FormWeylandBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.Label labelPinNumber;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.TextBox textBoxPinNumber;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxWelcomeInfo;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.TextBox textBoxWithdrawal;
        private System.Windows.Forms.Label labelWithdrawal;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdrawal;
        private System.Windows.Forms.Button buttonLogout;
    }
}

