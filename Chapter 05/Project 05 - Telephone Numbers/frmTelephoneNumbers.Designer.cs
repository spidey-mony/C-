namespace Telephone_Numbers
{
    partial class FrmTelephoneNumber
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
            txtAlphanumericNumbers = new TextBox();
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
            // txtAlphanumericNumbers
            // 
            txtAlphanumericNumbers.Location = new Point(325, 88);
            txtAlphanumericNumbers.Margin = new Padding(3, 4, 3, 4);
            txtAlphanumericNumbers.Name = "txtAlphanumericNumbers";
            txtAlphanumericNumbers.Size = new Size(134, 27);
            txtAlphanumericNumbers.TabIndex = 2;
            // 
            // txtNumericOnly
            // 
            txtNumericOnly.Location = new Point(325, 186);
            txtNumericOnly.Margin = new Padding(3, 4, 3, 4);
            txtNumericOnly.Name = "txtNumericOnly";
            txtNumericOnly.ReadOnly = true;
            txtNumericOnly.Size = new Size(134, 27);
            txtNumericOnly.TabIndex = 3;
            // 
            // btnConvertToNumericOnly
            // 
            btnConvertToNumericOnly.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvertToNumericOnly.Location = new Point(100, 299);
            btnConvertToNumericOnly.Margin = new Padding(3, 4, 3, 4);
            btnConvertToNumericOnly.Name = "btnConvertToNumericOnly";
            btnConvertToNumericOnly.Size = new Size(135, 95);
            btnConvertToNumericOnly.TabIndex = 4;
            btnConvertToNumericOnly.Text = "&Convert to\r\nNumeric\r\nOnly\r\n";
            btnConvertToNumericOnly.UseVisualStyleBackColor = true;
            btnConvertToNumericOnly.Click += btnConvertToNumericOnly_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(303, 299);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 95);
            btnExit.TabIndex = 5;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FrmTelephoneNumber
            // 
            AcceptButton = btnConvertToNumericOnly;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(552, 467);
            Controls.Add(btnExit);
            Controls.Add(btnConvertToNumericOnly);
            Controls.Add(txtNumericOnly);
            Controls.Add(txtAlphanumericNumbers);
            Controls.Add(lblNumeric);
            Controls.Add(lblAlphanumeric);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTelephoneNumber";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telephone Numbers";
            Load += FrmTelephoneNumber_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlphanumeric;
        private Label lblNumeric;
        private TextBox txtAlphanumericNumbers;
        private TextBox txtNumericOnly;
        private Button btnConvertToNumericOnly;
        private Button btnExit;
    }
}