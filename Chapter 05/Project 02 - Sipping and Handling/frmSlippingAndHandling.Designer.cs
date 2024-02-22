namespace Slipping_and_Handing
{
    partial class frmSlippingAndHandling
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
            txtOrderTotal = new TextBox();
            txtCustomer = new TextBox();
            lblorderTotal = new Label();
            lblCustomer = new Label();
            lblShoppingCosts = new Label();
            lblSales = new Label();
            lblGrandTotal = new Label();
            lblShipping = new Label();
            lblSale = new Label();
            lblGrandTotal1 = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(494, 56);
            txtOrderTotal.Margin = new Padding(3, 4, 3, 4);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(114, 27);
            txtOrderTotal.TabIndex = 0;
            txtOrderTotal.TextChanged += txtOrderTotal_TextChanged;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(494, 116);
            txtCustomer.Margin = new Padding(3, 4, 3, 4);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(114, 27);
            txtCustomer.TabIndex = 1;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // lblorderTotal
            // 
            lblorderTotal.AutoSize = true;
            lblorderTotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblorderTotal.Location = new Point(33, 61);
            lblorderTotal.Name = "lblorderTotal";
            lblorderTotal.Size = new Size(103, 22);
            lblorderTotal.TabIndex = 2;
            lblorderTotal.Text = "Order Total";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomer.Location = new Point(33, 121);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(392, 22);
            lblCustomer.TabIndex = 3;
            lblCustomer.Text = "Customer Type (P=Preferrred N=non-Preferred)\r\n";
            // 
            // lblShoppingCosts
            // 
            lblShoppingCosts.AutoSize = true;
            lblShoppingCosts.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShoppingCosts.Location = new Point(33, 195);
            lblShoppingCosts.Name = "lblShoppingCosts";
            lblShoppingCosts.Size = new Size(384, 22);
            lblShoppingCosts.TabIndex = 4;
            lblShoppingCosts.Text = "Shopping Costs (Free for Preferred Customers)";
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSales.Location = new Point(33, 261);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(128, 22);
            lblSales.TabIndex = 5;
            lblSales.Text = "Sales Tax(7%)";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGrandTotal.Location = new Point(33, 325);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(105, 22);
            lblGrandTotal.TabIndex = 6;
            lblGrandTotal.Text = "Grand Total";
            // 
            // lblShipping
            // 
            lblShipping.BorderStyle = BorderStyle.Fixed3D;
            lblShipping.Location = new Point(494, 186);
            lblShipping.Name = "lblShipping";
            lblShipping.Size = new Size(114, 31);
            lblShipping.TabIndex = 7;
            lblShipping.Click += lblShopping_Click;
            // 
            // lblSale
            // 
            lblSale.BorderStyle = BorderStyle.Fixed3D;
            lblSale.Location = new Point(494, 252);
            lblSale.Name = "lblSale";
            lblSale.Size = new Size(114, 31);
            lblSale.TabIndex = 8;
            lblSale.Click += lblSale_Click;
            // 
            // lblGrandTotal1
            // 
            lblGrandTotal1.BorderStyle = BorderStyle.Fixed3D;
            lblGrandTotal1.Location = new Point(494, 307);
            lblGrandTotal1.Name = "lblGrandTotal1";
            lblGrandTotal1.Size = new Size(114, 40);
            lblGrandTotal1.TabIndex = 9;
            lblGrandTotal1.Click += Label8_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(155, 404);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 86);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "&Calculate Grand Total";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(382, 404);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 86);
            btnExit.TabIndex = 12;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmSlippingAndHandling
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(675, 600);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblGrandTotal1);
            Controls.Add(lblSale);
            Controls.Add(lblShipping);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblSales);
            Controls.Add(lblShoppingCosts);
            Controls.Add(lblCustomer);
            Controls.Add(lblorderTotal);
            Controls.Add(txtCustomer);
            Controls.Add(txtOrderTotal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSlippingAndHandling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Slipping and Handling";
            Load += frmSlippingAndHandling_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrderTotal;
        private TextBox txtCustomer;
        private Label lblorderTotal;
        private Label lblCustomer;
        private Label lblShoppingCosts;
        private Label lblSales;
        private Label lblGrandTotal;
        private Label lblShipping;
        private Label lblSale;
        private Label lblGrandTotal1;
        private Button btnCalculate;
        private Button btnExit;
    }
}