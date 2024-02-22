namespace Invoice_Total
{
  
    partial class frminvoiceTotal
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
            btnCaulate = new Button();
            btnexit = new Button();
            lblSub = new Label();
            lblDisp = new Label();
            lbltotal = new Label();
            lbldis = new Label();
            label5 = new Label();
            fontDialog1 = new FontDialog();
            lblSubtotal = new Label();
            lblDiscountPercent = new Label();
            label3 = new Label();
            lblDiscountAmount = new Label();
            lblTotals = new Label();
            SuspendLayout();
            // 
            // btnCaulate
            // 
            btnCaulate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCaulate.Location = new Point(63, 244);
            btnCaulate.Name = "btnCaulate";
            btnCaulate.Size = new Size(98, 34);
            btnCaulate.TabIndex = 2;
            btnCaulate.Text = "&Calculate";
            btnCaulate.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(212, 244);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(98, 34);
            btnexit.TabIndex = 3;
            btnexit.Text = "E&xit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += button2_Click;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSub.Location = new Point(31, 55);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(81, 22);
            lblSub.TabIndex = 0;
            lblSub.Text = "&Subtotal:";
            lblSub.TextAlign = ContentAlignment.MiddleLeft;
            lblSub.Click += label1_Click;
            // 
            // lblDisp
            // 
            lblDisp.AutoSize = true;
            lblDisp.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisp.ForeColor = Color.Black;
            lblDisp.Location = new Point(31, 93);
            lblDisp.Name = "lblDisp";
            lblDisp.Size = new Size(150, 22);
            lblDisp.TabIndex = 3;
            lblDisp.Text = "Discount Percent:";
            lblDisp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbltotal.Location = new Point(31, 171);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(57, 22);
            lbltotal.TabIndex = 4;
            lbltotal.Text = "Total:";
            lbltotal.TextAlign = ContentAlignment.MiddleLeft;
            lbltotal.Click += label3_Click;
            // 
            // lbldis
            // 
            lbldis.AutoSize = true;
            lbldis.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbldis.Location = new Point(31, 129);
            lbldis.Name = "lbldis";
            lbldis.Size = new Size(156, 22);
            lbldis.TabIndex = 5;
            lbldis.Text = "Discount Amount: ";
            lbldis.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 83);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 6;
            label5.Click += label5_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.BorderStyle = BorderStyle.Fixed3D;
            lblSubtotal.Location = new Point(221, 55);
            lblSubtotal.Margin = new Padding(2, 0, 2, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(105, 21);
            lblSubtotal.TabIndex = 7;
            lblSubtotal.Click += lblSubtotal_Click;
            // 
            // lblDiscountPercent
            // 
            lblDiscountPercent.BorderStyle = BorderStyle.Fixed3D;
            lblDiscountPercent.Location = new Point(221, 94);
            lblDiscountPercent.Margin = new Padding(2, 0, 2, 0);
            lblDiscountPercent.Name = "lblDiscountPercent";
            lblDiscountPercent.Size = new Size(105, 21);
            lblDiscountPercent.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 129);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 9;
            // 
            // lblDiscountAmount
            // 
            lblDiscountAmount.BorderStyle = BorderStyle.Fixed3D;
            lblDiscountAmount.Location = new Point(221, 131);
            lblDiscountAmount.Margin = new Padding(2, 0, 2, 0);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(105, 21);
            lblDiscountAmount.TabIndex = 10;
            // 
            // lblTotals
            // 
            lblTotals.BorderStyle = BorderStyle.Fixed3D;
            lblTotals.Location = new Point(221, 171);
            lblTotals.Margin = new Padding(2, 0, 2, 0);
            lblTotals.Name = "lblTotals";
            lblTotals.Size = new Size(105, 20);
            lblTotals.TabIndex = 11;
            // 
            // frminvoiceTotal
            // 
            AcceptButton = btnCaulate;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnexit;
            ClientSize = new Size(378, 323);
            Controls.Add(lblTotals);
            Controls.Add(lblDiscountAmount);
            Controls.Add(label3);
            Controls.Add(lblDiscountPercent);
            Controls.Add(lblSubtotal);
            Controls.Add(label5);
            Controls.Add(lbldis);
            Controls.Add(lbltotal);
            Controls.Add(lblDisp);
            Controls.Add(lblSub);
            Controls.Add(btnexit);
            Controls.Add(btnCaulate);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frminvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCaulate;
        private Button btnexit;
        private Label lblSub;
        private Label lblDisp;
        private Label lbltotal;
        private Label lbldis;
        private Label label5;
        private FontDialog fontDialog1;
        private Label lblSubtotal;
        private Label lblDiscountPercent;
        private Label label3;
        private Label lblDiscountAmount;
        private Label lblTotals;
    }
}