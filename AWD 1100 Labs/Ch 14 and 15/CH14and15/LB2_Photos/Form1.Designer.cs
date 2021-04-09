
namespace LB2_Photos
{
    partial class FormPhotos
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
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.groupBoxFramed = new System.Windows.Forms.GroupBox();
            this.radioButtonFramed = new System.Windows.Forms.RadioButton();
            this.radioButtonMatted = new System.Windows.Forms.RadioButton();
            this.radioButtonUnframed = new System.Windows.Forms.RadioButton();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.radioButtonGold = new System.Windows.Forms.RadioButton();
            this.radioButtonSilver = new System.Windows.Forms.RadioButton();
            this.radioButtonSteel = new System.Windows.Forms.RadioButton();
            this.radioButtonOak = new System.Windows.Forms.RadioButton();
            this.radioButtonPine = new System.Windows.Forms.RadioButton();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.radioButtonEclectic = new System.Windows.Forms.RadioButton();
            this.radioButtonVintage = new System.Windows.Forms.RadioButton();
            this.radioButtonAntique = new System.Windows.Forms.RadioButton();
            this.radioButtonModern = new System.Windows.Forms.RadioButton();
            this.radioButtonSimple = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelTheCost = new System.Windows.Forms.Label();
            this.labelTotals = new System.Windows.Forms.Label();
            this.groupBoxFramed.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxMaterial.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(13, 13);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(86, 20);
            this.labelWidth.TabIndex = 11;
            this.labelWidth.Text = "Width (in)";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(13, 103);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(93, 20);
            this.labelHeight.TabIndex = 12;
            this.labelHeight.Text = "Height (in)";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(112, 13);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(656, 26);
            this.textBoxWidth.TabIndex = 0;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(112, 103);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(656, 26);
            this.textBoxHeight.TabIndex = 1;
            // 
            // groupBoxFramed
            // 
            this.groupBoxFramed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBoxFramed.Controls.Add(this.radioButtonFramed);
            this.groupBoxFramed.Controls.Add(this.radioButtonMatted);
            this.groupBoxFramed.Controls.Add(this.radioButtonUnframed);
            this.groupBoxFramed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFramed.Location = new System.Drawing.Point(17, 187);
            this.groupBoxFramed.Name = "groupBoxFramed";
            this.groupBoxFramed.Size = new System.Drawing.Size(200, 136);
            this.groupBoxFramed.TabIndex = 2;
            this.groupBoxFramed.TabStop = false;
            this.groupBoxFramed.Text = "Framed";
            // 
            // radioButtonFramed
            // 
            this.radioButtonFramed.AutoSize = true;
            this.radioButtonFramed.Location = new System.Drawing.Point(7, 96);
            this.radioButtonFramed.Name = "radioButtonFramed";
            this.radioButtonFramed.Size = new System.Drawing.Size(95, 24);
            this.radioButtonFramed.TabIndex = 2;
            this.radioButtonFramed.TabStop = true;
            this.radioButtonFramed.Text = "Framed";
            this.radioButtonFramed.UseVisualStyleBackColor = true;
            // 
            // radioButtonMatted
            // 
            this.radioButtonMatted.AutoSize = true;
            this.radioButtonMatted.Location = new System.Drawing.Point(7, 66);
            this.radioButtonMatted.Name = "radioButtonMatted";
            this.radioButtonMatted.Size = new System.Drawing.Size(90, 24);
            this.radioButtonMatted.TabIndex = 1;
            this.radioButtonMatted.TabStop = true;
            this.radioButtonMatted.Text = "Matted";
            this.radioButtonMatted.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnframed
            // 
            this.radioButtonUnframed.AutoSize = true;
            this.radioButtonUnframed.Location = new System.Drawing.Point(7, 36);
            this.radioButtonUnframed.Name = "radioButtonUnframed";
            this.radioButtonUnframed.Size = new System.Drawing.Size(113, 24);
            this.radioButtonUnframed.TabIndex = 0;
            this.radioButtonUnframed.TabStop = true;
            this.radioButtonUnframed.Text = "Unframed";
            this.radioButtonUnframed.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBoxColor.Controls.Add(this.radioButtonWhite);
            this.groupBoxColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Controls.Add(this.radioButtonBlack);
            this.groupBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxColor.Location = new System.Drawing.Point(17, 356);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(200, 220);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.Location = new System.Drawing.Point(7, 190);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(80, 24);
            this.radioButtonWhite.TabIndex = 4;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.Text = "White";
            this.radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(7, 145);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(70, 24);
            this.radioButtonBlue.TabIndex = 3;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(7, 106);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(84, 24);
            this.radioButtonGreen.TabIndex = 2;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(7, 67);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(67, 24);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(7, 26);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(78, 24);
            this.radioButtonBlack.TabIndex = 0;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBoxMaterial.Controls.Add(this.radioButtonGold);
            this.groupBoxMaterial.Controls.Add(this.radioButtonSilver);
            this.groupBoxMaterial.Controls.Add(this.radioButtonSteel);
            this.groupBoxMaterial.Controls.Add(this.radioButtonOak);
            this.groupBoxMaterial.Controls.Add(this.radioButtonPine);
            this.groupBoxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMaterial.Location = new System.Drawing.Point(281, 356);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(200, 220);
            this.groupBoxMaterial.TabIndex = 4;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Material";
            // 
            // radioButtonGold
            // 
            this.radioButtonGold.AutoSize = true;
            this.radioButtonGold.Location = new System.Drawing.Point(7, 190);
            this.radioButtonGold.Name = "radioButtonGold";
            this.radioButtonGold.Size = new System.Drawing.Size(72, 24);
            this.radioButtonGold.TabIndex = 4;
            this.radioButtonGold.TabStop = true;
            this.radioButtonGold.Text = "Gold";
            this.radioButtonGold.UseVisualStyleBackColor = true;
            // 
            // radioButtonSilver
            // 
            this.radioButtonSilver.AutoSize = true;
            this.radioButtonSilver.Location = new System.Drawing.Point(6, 145);
            this.radioButtonSilver.Name = "radioButtonSilver";
            this.radioButtonSilver.Size = new System.Drawing.Size(78, 24);
            this.radioButtonSilver.TabIndex = 3;
            this.radioButtonSilver.TabStop = true;
            this.radioButtonSilver.Text = "Silver";
            this.radioButtonSilver.UseVisualStyleBackColor = true;
            // 
            // radioButtonSteel
            // 
            this.radioButtonSteel.AutoSize = true;
            this.radioButtonSteel.Location = new System.Drawing.Point(7, 106);
            this.radioButtonSteel.Name = "radioButtonSteel";
            this.radioButtonSteel.Size = new System.Drawing.Size(76, 24);
            this.radioButtonSteel.TabIndex = 2;
            this.radioButtonSteel.TabStop = true;
            this.radioButtonSteel.Text = "Steel";
            this.radioButtonSteel.UseVisualStyleBackColor = true;
            // 
            // radioButtonOak
            // 
            this.radioButtonOak.AutoSize = true;
            this.radioButtonOak.Location = new System.Drawing.Point(7, 67);
            this.radioButtonOak.Name = "radioButtonOak";
            this.radioButtonOak.Size = new System.Drawing.Size(66, 24);
            this.radioButtonOak.TabIndex = 1;
            this.radioButtonOak.TabStop = true;
            this.radioButtonOak.Text = "Oak";
            this.radioButtonOak.UseVisualStyleBackColor = true;
            // 
            // radioButtonPine
            // 
            this.radioButtonPine.AutoSize = true;
            this.radioButtonPine.Location = new System.Drawing.Point(7, 25);
            this.radioButtonPine.Name = "radioButtonPine";
            this.radioButtonPine.Size = new System.Drawing.Size(69, 24);
            this.radioButtonPine.TabIndex = 0;
            this.radioButtonPine.TabStop = true;
            this.radioButtonPine.Text = "Pine";
            this.radioButtonPine.UseVisualStyleBackColor = true;
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBoxStyle.Controls.Add(this.radioButtonEclectic);
            this.groupBoxStyle.Controls.Add(this.radioButtonVintage);
            this.groupBoxStyle.Controls.Add(this.radioButtonAntique);
            this.groupBoxStyle.Controls.Add(this.radioButtonModern);
            this.groupBoxStyle.Controls.Add(this.radioButtonSimple);
            this.groupBoxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStyle.Location = new System.Drawing.Point(552, 356);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(200, 220);
            this.groupBoxStyle.TabIndex = 5;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "Style";
            // 
            // radioButtonEclectic
            // 
            this.radioButtonEclectic.AutoSize = true;
            this.radioButtonEclectic.Location = new System.Drawing.Point(7, 190);
            this.radioButtonEclectic.Name = "radioButtonEclectic";
            this.radioButtonEclectic.Size = new System.Drawing.Size(97, 24);
            this.radioButtonEclectic.TabIndex = 4;
            this.radioButtonEclectic.TabStop = true;
            this.radioButtonEclectic.Text = "Eclectic";
            this.radioButtonEclectic.UseVisualStyleBackColor = true;
            // 
            // radioButtonVintage
            // 
            this.radioButtonVintage.AutoSize = true;
            this.radioButtonVintage.Location = new System.Drawing.Point(7, 145);
            this.radioButtonVintage.Name = "radioButtonVintage";
            this.radioButtonVintage.Size = new System.Drawing.Size(96, 24);
            this.radioButtonVintage.TabIndex = 3;
            this.radioButtonVintage.TabStop = true;
            this.radioButtonVintage.Text = "Vintage";
            this.radioButtonVintage.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntique
            // 
            this.radioButtonAntique.AutoSize = true;
            this.radioButtonAntique.Location = new System.Drawing.Point(7, 106);
            this.radioButtonAntique.Name = "radioButtonAntique";
            this.radioButtonAntique.Size = new System.Drawing.Size(96, 24);
            this.radioButtonAntique.TabIndex = 2;
            this.radioButtonAntique.TabStop = true;
            this.radioButtonAntique.Text = "Antique";
            this.radioButtonAntique.UseVisualStyleBackColor = true;
            // 
            // radioButtonModern
            // 
            this.radioButtonModern.AutoSize = true;
            this.radioButtonModern.Location = new System.Drawing.Point(6, 67);
            this.radioButtonModern.Name = "radioButtonModern";
            this.radioButtonModern.Size = new System.Drawing.Size(94, 24);
            this.radioButtonModern.TabIndex = 1;
            this.radioButtonModern.TabStop = true;
            this.radioButtonModern.Text = "Modern";
            this.radioButtonModern.UseVisualStyleBackColor = true;
            // 
            // radioButtonSimple
            // 
            this.radioButtonSimple.AutoSize = true;
            this.radioButtonSimple.Location = new System.Drawing.Point(7, 25);
            this.radioButtonSimple.Name = "radioButtonSimple";
            this.radioButtonSimple.Size = new System.Drawing.Size(88, 24);
            this.radioButtonSimple.TabIndex = 0;
            this.radioButtonSimple.TabStop = true;
            this.radioButtonSimple.Text = "Simple";
            this.radioButtonSimple.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(17, 595);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(102, 41);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(134, 595);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 41);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(255, 595);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(102, 41);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCost
            // 
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(381, 595);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(100, 41);
            this.labelCost.TabIndex = 13;
            this.labelCost.Text = "Cost:";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTheCost
            // 
            this.labelTheCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelTheCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheCost.Location = new System.Drawing.Point(488, 595);
            this.labelTheCost.Name = "labelTheCost";
            this.labelTheCost.Size = new System.Drawing.Size(167, 41);
            this.labelTheCost.TabIndex = 9;
            this.labelTheCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotals
            // 
            this.labelTotals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotals.Location = new System.Drawing.Point(12, 661);
            this.labelTotals.Name = "labelTotals";
            this.labelTotals.Size = new System.Drawing.Size(643, 41);
            this.labelTotals.TabIndex = 10;
            this.labelTotals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPhotos
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.labelTotals);
            this.Controls.Add(this.labelTheCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxStyle);
            this.Controls.Add(this.groupBoxMaterial);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxFramed);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Name = "FormPhotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photoshop";
            this.groupBoxFramed.ResumeLayout(false);
            this.groupBoxFramed.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.GroupBox groupBoxFramed;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.GroupBox groupBoxMaterial;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.RadioButton radioButtonFramed;
        private System.Windows.Forms.RadioButton radioButtonMatted;
        private System.Windows.Forms.RadioButton radioButtonUnframed;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButtonGold;
        private System.Windows.Forms.RadioButton radioButtonSilver;
        private System.Windows.Forms.RadioButton radioButtonSteel;
        private System.Windows.Forms.RadioButton radioButtonOak;
        private System.Windows.Forms.RadioButton radioButtonPine;
        private System.Windows.Forms.RadioButton radioButtonEclectic;
        private System.Windows.Forms.RadioButton radioButtonVintage;
        private System.Windows.Forms.RadioButton radioButtonAntique;
        private System.Windows.Forms.RadioButton radioButtonModern;
        private System.Windows.Forms.RadioButton radioButtonSimple;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelTheCost;
        private System.Windows.Forms.Label labelTotals;
    }
}

