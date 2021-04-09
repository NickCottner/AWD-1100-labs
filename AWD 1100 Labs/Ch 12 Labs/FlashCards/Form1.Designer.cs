
namespace FlashCards
{
    partial class FormFC
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
            this.labelTerm = new System.Windows.Forms.Label();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.buttonDefine = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.labelDontKnowYet = new System.Windows.Forms.Label();
            this.textBoxDefiniton = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerm.Location = new System.Drawing.Point(22, 13);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(334, 25);
            this.labelTerm.TabIndex = 7;
            this.labelTerm.Text = "What term do you want to define?";
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTerm.Location = new System.Drawing.Point(26, 37);
            this.textBoxTerm.Multiline = true;
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(330, 46);
            this.textBoxTerm.TabIndex = 0;
            this.textBoxTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDefine
            // 
            this.buttonDefine.Location = new System.Drawing.Point(394, 36);
            this.buttonDefine.Name = "buttonDefine";
            this.buttonDefine.Size = new System.Drawing.Size(100, 46);
            this.buttonDefine.TabIndex = 1;
            this.buttonDefine.Text = "Define";
            this.buttonDefine.UseVisualStyleBackColor = true;
            this.buttonDefine.Click += new System.EventHandler(this.buttonDefine_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Location = new System.Drawing.Point(639, 37);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(97, 45);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelDefinition
            // 
            this.labelDefinition.BackColor = System.Drawing.Color.Yellow;
            this.labelDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinition.Location = new System.Drawing.Point(26, 95);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(710, 69);
            this.labelDefinition.TabIndex = 3;
            this.labelDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDontKnowYet
            // 
            this.labelDontKnowYet.BackColor = System.Drawing.Color.Yellow;
            this.labelDontKnowYet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDontKnowYet.Location = new System.Drawing.Point(22, 185);
            this.labelDontKnowYet.Name = "labelDontKnowYet";
            this.labelDontKnowYet.Size = new System.Drawing.Size(714, 71);
            this.labelDontKnowYet.TabIndex = 4;
            this.labelDontKnowYet.Text = "I don\'t know that term yet. What does it mean?";
            this.labelDontKnowYet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDefiniton
            // 
            this.textBoxDefiniton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefiniton.Location = new System.Drawing.Point(26, 286);
            this.textBoxDefiniton.Multiline = true;
            this.textBoxDefiniton.Name = "textBoxDefiniton";
            this.textBoxDefiniton.Size = new System.Drawing.Size(396, 42);
            this.textBoxDefiniton.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(465, 286);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 42);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormFC
            // 
            this.AcceptButton = this.buttonDefine;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDefiniton);
            this.Controls.Add(this.labelDontKnowYet);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDefine);
            this.Controls.Add(this.textBoxTerm);
            this.Controls.Add(this.labelTerm);
            this.Name = "FormFC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Cards";
            this.Load += new System.EventHandler(this.FormFC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.TextBox textBoxTerm;
        private System.Windows.Forms.Button buttonDefine;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.Label labelDontKnowYet;
        private System.Windows.Forms.TextBox textBoxDefiniton;
        private System.Windows.Forms.Button buttonAdd;
    }
}

