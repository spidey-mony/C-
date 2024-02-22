﻿namespace Invoicetoal2
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
            txtSubtotal = new TextBox();
            txtDiscountPercent = new TextBox();
            txtDiscountAmount = new TextBox();
            txtTotal = new TextBox();
            lblsub = new Label();
            lbldisp = new Label();
            lbldisa = new Label();
            lbltotal = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(85, 343);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(143, 52);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calulate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCal_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(273, 343);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(143, 52);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(287, 52);
            txtSubtotal.Margin = new Padding(3, 4, 3, 4);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(129, 27);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TextChanged += txt1_TextChanged;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Location = new Point(287, 123);
            txtDiscountPercent.Margin = new Padding(3, 4, 3, 4);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.ReadOnly = true;
            txtDiscountPercent.Size = new Size(129, 27);
            txtDiscountPercent.TabIndex = 3;
            txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(287, 189);
            txtDiscountAmount.Margin = new Padding(3, 4, 3, 4);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new Size(129, 27);
            txtDiscountAmount.TabIndex = 4;
            txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(287, 263);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(129, 27);
            txtTotal.TabIndex = 5;
            txtTotal.TabStop = false;
            // 
            // lblsub
            // 
            lblsub.AutoSize = true;
            lblsub.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblsub.Location = new Point(55, 57);
            lblsub.Name = "lblsub";
            lblsub.Size = new Size(81, 22);
            lblsub.TabIndex = 0;
            lblsub.Text = "&Subtotal:";
            lblsub.TextAlign = ContentAlignment.MiddleLeft;
            lblsub.Click += lblsub_Click;
            // 
            // lbldisp
            // 
            lbldisp.AutoSize = true;
            lbldisp.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbldisp.Location = new Point(56, 128);
            lbldisp.Name = "lbldisp";
            lbldisp.Size = new Size(150, 22);
            lbldisp.TabIndex = 7;
            lbldisp.Text = "Discount Percent:";
            lbldisp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbldisa
            // 
            lbldisa.AutoSize = true;
            lbldisa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbldisa.Location = new Point(55, 194);
            lbldisa.Name = "lbldisa";
            lbldisa.Size = new Size(151, 22);
            lbldisa.TabIndex = 8;
            lbldisa.Text = "Discount Amount:";
            lbldisa.TextAlign = ContentAlignment.MiddleLeft;
            lbldisa.Click += label3_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbltotal.Location = new Point(56, 263);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(57, 22);
            lbltotal.TabIndex = 9;
            lbltotal.Text = "Total:";
            lbltotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(478, 429);
            Controls.Add(lbltotal);
            Controls.Add(lbldisa);
            Controls.Add(lbldisp);
            Controls.Add(lblsub);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(txtSubtotal);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            Load += frmInvoiceTotal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnExit;
        private TextBox txtSubtotal;
        private TextBox txtDiscountPercent;
        private TextBox txtDiscountAmount;
        private TextBox txtTotal;
        private Label lblsub;
        private Label lbldisp;
        private Label lbldisa;
        private Label lbltotal;
    }
}