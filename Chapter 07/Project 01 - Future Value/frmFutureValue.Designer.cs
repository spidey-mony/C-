namespace The_Future_value_
{
    partial class FrmFutureValue
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnCalculate = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMonthlyInvestment = new TextBox();
            txtInteresetRate = new TextBox();
            txtYears = new TextBox();
            txtFutureValue = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(52, 331);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(149, 64);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(262, 331);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(149, 64);
            btnExit.TabIndex = 1;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 50);
            label1.Name = "label1";
            label1.Size = new Size(150, 19);
            label1.TabIndex = 2;
            label1.Text = "Monthly Investment:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 108);
            label2.Name = "label2";
            label2.Size = new Size(148, 19);
            label2.TabIndex = 3;
            label2.Text = "Yearly Interest Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 176);
            label3.Name = "label3";
            label3.Size = new Size(132, 19);
            label3.TabIndex = 4;
            label3.Text = "Number of Years: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 243);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 5;
            label4.Text = "Future Value:";
            label4.Click += label4_Click;
            // 
            // txtMonthlyInvestment
            // 
            txtMonthlyInvestment.Location = new Point(275, 42);
            txtMonthlyInvestment.Margin = new Padding(3, 4, 3, 4);
            txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            txtMonthlyInvestment.Size = new Size(148, 27);
            txtMonthlyInvestment.TabIndex = 6;
            txtMonthlyInvestment.TextChanged += ClearFutureValue;
            // 
            // txtInteresetRate
            // 
            txtInteresetRate.Location = new Point(275, 100);
            txtInteresetRate.Margin = new Padding(3, 4, 3, 4);
            txtInteresetRate.Name = "txtInteresetRate";
            txtInteresetRate.Size = new Size(148, 27);
            txtInteresetRate.TabIndex = 7;
            txtInteresetRate.TextChanged += ClearFutureValue;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(275, 168);
            txtYears.Margin = new Padding(3, 4, 3, 4);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(148, 27);
            txtYears.TabIndex = 8;
            txtYears.TextChanged += ClearFutureValue;
            // 
            // txtFutureValue
            // 
            txtFutureValue.Location = new Point(275, 235);
            txtFutureValue.Margin = new Padding(3, 4, 3, 4);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.ReadOnly = true;
            txtFutureValue.Size = new Size(148, 27);
            txtFutureValue.TabIndex = 9;
            txtFutureValue.TabStop = false;
            txtFutureValue.TextChanged += textBox4_TextChanged;
            // 
            // FrmFutureValue
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(480, 481);
            Controls.Add(txtFutureValue);
            Controls.Add(txtYears);
            Controls.Add(txtInteresetRate);
            Controls.Add(txtMonthlyInvestment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmFutureValue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Future Value";
            Load += FrmFuture_V_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnCalculate;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMonthlyInvestment;
        private TextBox txtInteresetRate;
        private TextBox txtYears;
        private TextBox txtFutureValue;
    }
}