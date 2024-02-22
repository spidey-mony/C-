namespace Invoicetoal2
{
    partial class frmInvoiceTotal
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
            btnCalculate = new Button();
            btnExit = new Button();
            txtDiscountPercent = new TextBox();
            txtDiscountAmount = new TextBox();
            txtTotal = new TextBox();
            lblsubtotal = new Label();
            lbldiscountP = new Label();
            lbldiscountA = new Label();
            lbltotal = new Label();
            lblEnterSub = new Label();
            txtSubtotal = new TextBox();
            txtEnterSubtotal = new TextBox();
            txtNumberofInvoices = new TextBox();
            txttotalOfInvoices = new TextBox();
            txtInvoiceAverages = new TextBox();
            lblNumOfInvoice = new Label();
            lblTotalOfinvoice = new Label();
            lblInvoiceAv = new Label();
            btnClearTotals = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.GradientInactiveCaption;
            btnCalculate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(115, 421);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(143, 52);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calulate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCal_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(513, 418);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(143, 52);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Location = new Point(201, 174);
            txtDiscountPercent.Margin = new Padding(3, 4, 3, 4);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.ReadOnly = true;
            txtDiscountPercent.Size = new Size(129, 27);
            txtDiscountPercent.TabIndex = 3;
            txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(201, 244);
            txtDiscountAmount.Margin = new Padding(3, 4, 3, 4);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new Size(129, 27);
            txtDiscountAmount.TabIndex = 4;
            txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(201, 324);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(129, 27);
            txtTotal.TabIndex = 5;
            txtTotal.TabStop = false;
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblsubtotal.Location = new Point(12, 108);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(70, 19);
            lblsubtotal.TabIndex = 0;
            lblsubtotal.Text = "&Subtotal:";
            lblsubtotal.TextAlign = ContentAlignment.MiddleLeft;
            lblsubtotal.Click += lblsub_Click;
            // 
            // lbldiscountP
            // 
            lbldiscountP.AutoSize = true;
            lbldiscountP.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbldiscountP.Location = new Point(12, 181);
            lbldiscountP.Name = "lbldiscountP";
            lbldiscountP.Size = new Size(133, 19);
            lbldiscountP.TabIndex = 7;
            lbldiscountP.Text = "Discount Percent:";
            lbldiscountP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbldiscountA
            // 
            lbldiscountA.AutoSize = true;
            lbldiscountA.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbldiscountA.Location = new Point(12, 251);
            lbldiscountA.Name = "lbldiscountA";
            lbldiscountA.Size = new Size(133, 19);
            lbldiscountA.TabIndex = 8;
            lbldiscountA.Text = "Discount Amount:";
            lbldiscountA.TextAlign = ContentAlignment.MiddleLeft;
            lbldiscountA.Click += label3_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbltotal.Location = new Point(15, 331);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(48, 19);
            lbltotal.TabIndex = 9;
            lbltotal.Text = "Total:";
            lbltotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEnterSub
            // 
            lblEnterSub.AutoSize = true;
            lblEnterSub.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnterSub.Location = new Point(12, 42);
            lblEnterSub.Name = "lblEnterSub";
            lblEnterSub.Size = new Size(111, 19);
            lblEnterSub.TabIndex = 10;
            lblEnterSub.Text = "Enter Subtotal:";
            lblEnterSub.Click += lblEnterSub_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(201, 101);
            txtSubtotal.Margin = new Padding(3, 4, 3, 4);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(129, 27);
            txtSubtotal.TabIndex = 11;
            // 
            // txtEnterSubtotal
            // 
            txtEnterSubtotal.Location = new Point(201, 33);
            txtEnterSubtotal.Margin = new Padding(3, 4, 3, 4);
            txtEnterSubtotal.Name = "txtEnterSubtotal";
            txtEnterSubtotal.Size = new Size(129, 27);
            txtEnterSubtotal.TabIndex = 1;
            txtEnterSubtotal.TextChanged += txtEnterSub_TextChanged;
            // 
            // txtNumberofInvoices
            // 
            txtNumberofInvoices.Location = new Point(555, 33);
            txtNumberofInvoices.Margin = new Padding(3, 4, 3, 4);
            txtNumberofInvoices.Name = "txtNumberofInvoices";
            txtNumberofInvoices.ReadOnly = true;
            txtNumberofInvoices.Size = new Size(129, 27);
            txtNumberofInvoices.TabIndex = 13;
            // 
            // txttotalOfInvoices
            // 
            txttotalOfInvoices.Location = new Point(555, 101);
            txttotalOfInvoices.Margin = new Padding(3, 4, 3, 4);
            txttotalOfInvoices.Name = "txttotalOfInvoices";
            txttotalOfInvoices.ReadOnly = true;
            txttotalOfInvoices.Size = new Size(129, 27);
            txttotalOfInvoices.TabIndex = 14;
            // 
            // txtInvoiceAverages
            // 
            txtInvoiceAverages.Location = new Point(555, 173);
            txtInvoiceAverages.Margin = new Padding(3, 4, 3, 4);
            txtInvoiceAverages.Name = "txtInvoiceAverages";
            txtInvoiceAverages.ReadOnly = true;
            txtInvoiceAverages.Size = new Size(130, 27);
            txtInvoiceAverages.TabIndex = 15;
            // 
            // lblNumOfInvoice
            // 
            lblNumOfInvoice.AutoSize = true;
            lblNumOfInvoice.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumOfInvoice.Location = new Point(377, 42);
            lblNumOfInvoice.Name = "lblNumOfInvoice";
            lblNumOfInvoice.Size = new Size(149, 19);
            lblNumOfInvoice.TabIndex = 16;
            lblNumOfInvoice.Text = "Number of Invoices:";
            // 
            // lblTotalOfinvoice
            // 
            lblTotalOfinvoice.AutoSize = true;
            lblTotalOfinvoice.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalOfinvoice.Location = new Point(377, 110);
            lblTotalOfinvoice.Name = "lblTotalOfinvoice";
            lblTotalOfinvoice.Size = new Size(128, 19);
            lblTotalOfinvoice.TabIndex = 17;
            lblTotalOfinvoice.Text = "Total of Invoices:";
            // 
            // lblInvoiceAv
            // 
            lblInvoiceAv.AutoSize = true;
            lblInvoiceAv.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblInvoiceAv.Location = new Point(380, 182);
            lblInvoiceAv.Name = "lblInvoiceAv";
            lblInvoiceAv.Size = new Size(128, 19);
            lblInvoiceAv.TabIndex = 18;
            lblInvoiceAv.Text = "Invoice Averages:";
            // 
            // btnClearTotals
            // 
            btnClearTotals.AutoSize = true;
            btnClearTotals.BackColor = SystemColors.GradientActiveCaption;
            btnClearTotals.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearTotals.Location = new Point(310, 421);
            btnClearTotals.Margin = new Padding(3, 4, 3, 4);
            btnClearTotals.Name = "btnClearTotals";
            btnClearTotals.Size = new Size(156, 49);
            btnClearTotals.TabIndex = 19;
            btnClearTotals.Text = "Clear Totals";
            btnClearTotals.UseVisualStyleBackColor = false;
            btnClearTotals.Click += btnclear_Click;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(734, 553);
            Controls.Add(btnClearTotals);
            Controls.Add(lblInvoiceAv);
            Controls.Add(lblTotalOfinvoice);
            Controls.Add(lblNumOfInvoice);
            Controls.Add(txtInvoiceAverages);
            Controls.Add(txttotalOfInvoices);
            Controls.Add(txtNumberofInvoices);
            Controls.Add(txtEnterSubtotal);
            Controls.Add(txtSubtotal);
            Controls.Add(lblEnterSub);
            Controls.Add(lbltotal);
            Controls.Add(lbldiscountA);
            Controls.Add(lbldiscountP);
            Controls.Add(lblsubtotal);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            Load += frmtotal2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnExit;
        private TextBox txtDiscountPercent;
        private TextBox txtDiscountAmount;
        private TextBox txtTotal;
        private Label lblsubtotal;
        private Label lbldiscountP;
        private Label lbldiscountA;
        private Label lbltotal;
        private Label lblEnterSub;
        private TextBox txtSubtotal;
        private TextBox txtEnterSubtotal;
        private TextBox txtNumberofInvoices;
        private TextBox txttotalOfInvoices;
        private TextBox txtInvoiceAverages;
        private Label lblNumOfInvoice;
        private Label lblTotalOfinvoice;
        private Label lblInvoiceAv;
        private Button btnClearTotals;
    }
}