namespace Calculate_Letter_Grade
{
    partial class frmCalculaterLetterGrade
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
            txtNumericGrade = new TextBox();
            lblNum = new Label();
            lblLetter = new Label();
            lblLetterGrade = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtNumericGrade
            // 
            txtNumericGrade.Location = new Point(211, 96);
            txtNumericGrade.Margin = new Padding(3, 4, 3, 4);
            txtNumericGrade.Name = "txtNumericGrade";
            txtNumericGrade.Size = new Size(166, 27);
            txtNumericGrade.TabIndex = 0;
            txtNumericGrade.TextChanged += txtNumericGrade_TextChanged;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum.Location = new Point(58, 96);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(132, 22);
            lblNum.TabIndex = 0;
            lblNum.Text = "Numeric Grade";
            lblNum.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLetter
            // 
            lblLetter.AutoSize = true;
            lblLetter.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLetter.Location = new Point(58, 179);
            lblLetter.Name = "lblLetter";
            lblLetter.Size = new Size(110, 22);
            lblLetter.TabIndex = 2;
            lblLetter.Text = "Letter Grade";
            // 
            // lblLetterGrade
            // 
            lblLetterGrade.BorderStyle = BorderStyle.Fixed3D;
            lblLetterGrade.Location = new Point(210, 176);
            lblLetterGrade.Name = "lblLetterGrade";
            lblLetterGrade.Size = new Size(167, 32);
            lblLetterGrade.TabIndex = 3;
            lblLetterGrade.TextAlign = ContentAlignment.MiddleLeft;
            lblLetterGrade.Click += lblLetterGrade_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(82, 297);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(108, 92);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "&Calulate Letter\r\nGrade\r\n";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(238, 297);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 92);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCalculaterLetterGrade
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(449, 453);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblLetterGrade);
            Controls.Add(lblLetter);
            Controls.Add(lblNum);
            Controls.Add(txtNumericGrade);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCalculaterLetterGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Letter Grade";
            Load += frmCalculaterLetterGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumericGrade;
        private Label lblNum;
        private Label lblLetter;
        private Label lblLetterGrade;
        private Button btnCalculate;
        private Button btnExit;
    }
}