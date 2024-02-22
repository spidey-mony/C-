namespace Telephone_Numbers
{
    partial class frmTelephoneNumber
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
            lblAlphanumeric = new Label();
            lblNumeric = new Label();
            txtAlphaNumericNumbers = new TextBox();
            txtNumericOnly = new TextBox();
            btnConvertToNumericOnly = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblAlphanumeric
            // 
            lblAlphanumeric.AutoSize = true;
            lblAlphanumeric.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlphanumeric.Location = new Point(38, 93);
            lblAlphanumeric.Name = "lblAlphanumeric";
            lblAlphanumeric.Size = new Size(197, 22);
            lblAlphanumeric.TabIndex = 0;
            lblAlphanumeric.Text = "Alphanumeric Numbers";
            lblAlphanumeric.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNumeric
            // 
            lblNumeric.AutoSize = true;
            lblNumeric.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeric.Location = new Point(38, 191);
            lblNumeric.Name = "lblNumeric";
            lblNumeric.Size = new Size(121, 22);
            lblNumeric.TabIndex = 1;
            lblNumeric.Text = "Numeric Only";
            lblNumeric.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAlphaNumericNumbers
            // 
            txtAlphaNumericNumbers.Location = new Point(296, 88);
            txtAlphaNumericNumbers.Margin = new Padding(3, 4, 3, 4);
            txtAlphaNumericNumbers.Name = "txtAlphaNumericNumbers";
            txtAlphaNumericNumbers.Size = new Size(134, 27);
            txtAlphaNumericNumbers.TabIndex = 1;
            // 
            // txtNumericOnly
            // 
            txtNumericOnly.Location = new Point(296, 191);
            txtNumericOnly.Margin = new Padding(3, 4, 3, 4);
            txtNumericOnly.Name = "txtNumericOnly";
            txtNumericOnly.ReadOnly = true;
            txtNumericOnly.Size = new Size(134, 27);
            txtNumericOnly.TabIndex = 3;
            // 
            // btnConvertToNumericOnly
            // 
            btnConvertToNumericOnly.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvertToNumericOnly.Location = new Point(64, 299);
            btnConvertToNumericOnly.Margin = new Padding(3, 4, 3, 4);
            btnConvertToNumericOnly.Name = "btnConvertToNumericOnly";
            btnConvertToNumericOnly.Size = new Size(125, 95);
            btnConvertToNumericOnly.TabIndex = 4;
            btnConvertToNumericOnly.Text = "&Convert To Numeric\r\nOnly\r\n";
            btnConvertToNumericOnly.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(295, 299);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 95);
            btnExit.TabIndex = 5;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmTelephoneNumber
            // 
            AcceptButton = btnConvertToNumericOnly;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(552, 467);
            Controls.Add(btnExit);
            Controls.Add(btnConvertToNumericOnly);
            Controls.Add(txtNumericOnly);
            Controls.Add(txtAlphaNumericNumbers);
            Controls.Add(lblNumeric);
            Controls.Add(lblAlphanumeric);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTelephoneNumber";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telephone Numbers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlphanumeric;
        private Label lblNumeric;
        private TextBox txtAlphaNumericNumbers;
        private TextBox txtNumericOnly;
        private Button btnConvertToNumericOnly;
        private Button btnExit;
    }
}