
namespace ReverseGUI
{
    partial class FormReverse4
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
            this.groupBoxReverseOrder = new System.Windows.Forms.GroupBox();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.textBoxNumber3 = new System.Windows.Forms.TextBox();
            this.textBoxNumber4 = new System.Windows.Forms.TextBox();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxReverseOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxReverseOrder
            // 
            this.groupBoxReverseOrder.BackColor = System.Drawing.Color.Teal;
            this.groupBoxReverseOrder.Controls.Add(this.textBoxNumber4);
            this.groupBoxReverseOrder.Controls.Add(this.textBoxNumber3);
            this.groupBoxReverseOrder.Controls.Add(this.textBoxNumber2);
            this.groupBoxReverseOrder.Controls.Add(this.textBoxNumber1);
            this.groupBoxReverseOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxReverseOrder.ForeColor = System.Drawing.Color.White;
            this.groupBoxReverseOrder.Location = new System.Drawing.Point(13, 13);
            this.groupBoxReverseOrder.Name = "groupBoxReverseOrder";
            this.groupBoxReverseOrder.Size = new System.Drawing.Size(532, 123);
            this.groupBoxReverseOrder.TabIndex = 0;
            this.groupBoxReverseOrder.TabStop = false;
            this.groupBoxReverseOrder.Text = "Reverse Number Order";
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.BackColor = System.Drawing.Color.Navy;
            this.textBoxNumber1.ForeColor = System.Drawing.Color.White;
            this.textBoxNumber1.Location = new System.Drawing.Point(31, 56);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(93, 31);
            this.textBoxNumber1.TabIndex = 0;
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.BackColor = System.Drawing.Color.Navy;
            this.textBoxNumber2.ForeColor = System.Drawing.Color.White;
            this.textBoxNumber2.Location = new System.Drawing.Point(158, 56);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(93, 31);
            this.textBoxNumber2.TabIndex = 1;
            // 
            // textBoxNumber3
            // 
            this.textBoxNumber3.BackColor = System.Drawing.Color.Navy;
            this.textBoxNumber3.ForeColor = System.Drawing.Color.White;
            this.textBoxNumber3.Location = new System.Drawing.Point(285, 56);
            this.textBoxNumber3.Name = "textBoxNumber3";
            this.textBoxNumber3.Size = new System.Drawing.Size(93, 31);
            this.textBoxNumber3.TabIndex = 2;
            // 
            // textBoxNumber4
            // 
            this.textBoxNumber4.BackColor = System.Drawing.Color.Navy;
            this.textBoxNumber4.ForeColor = System.Drawing.Color.White;
            this.textBoxNumber4.Location = new System.Drawing.Point(412, 56);
            this.textBoxNumber4.Name = "textBoxNumber4";
            this.textBoxNumber4.Size = new System.Drawing.Size(93, 31);
            this.textBoxNumber4.TabIndex = 3;
            // 
            // buttonReverse
            // 
            this.buttonReverse.BackColor = System.Drawing.Color.Teal;
            this.buttonReverse.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReverse.ForeColor = System.Drawing.Color.White;
            this.buttonReverse.Location = new System.Drawing.Point(13, 167);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(112, 65);
            this.buttonReverse.TabIndex = 4;
            this.buttonReverse.Text = "Reverse";
            this.buttonReverse.UseVisualStyleBackColor = false;
            this.buttonReverse.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Teal;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(221, 167);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 65);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Teal;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(433, 167);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 65);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormReverse4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 254);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.groupBoxReverseOrder);
            this.Name = "FormReverse4";
            this.Text = "Reverse4";
            this.groupBoxReverseOrder.ResumeLayout(false);
            this.groupBoxReverseOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReverseOrder;
        private System.Windows.Forms.TextBox textBoxNumber4;
        private System.Windows.Forms.TextBox textBoxNumber3;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

