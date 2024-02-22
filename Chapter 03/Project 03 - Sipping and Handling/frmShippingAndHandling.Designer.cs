namespace Slipping_and_Handing
{
    partial class frmShippingAndHandling
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
            txtCustomerType = new TextBox();
            lblorderTotal = new Label();
            lblCustomer = new Label();
            lblShopping = new Label();
            lblSales = new Label();
            lblGrand = new Label();
            lblShoppingCosts = new Label();
            lblSaleTax = new Label();
            lblGrandTotal = new Label();
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
            // 
            // txtCustomerType
            // 
            txtCustomerType.Location = new Point(494, 116);
            txtCustomerType.Margin = new Padding(3, 4, 3, 4);
            txtCustomerType.Name = "txtCustomerType";
            txtCustomerType.Size = new Size(114, 27);
            txtCustomerType.TabIndex = 1;
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
            // lblShopping
            // 
            lblShopping.AutoSize = true;
            lblShopping.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShopping.Location = new Point(33, 195);
            lblShopping.Name = "lblShopping";
            lblShopping.Size = new Size(384, 22);
            lblShopping.TabIndex = 4;
            lblShopping.Text = "Shopping Costs (Free for Preferred Customers)";
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
            // lblGrand
            // 
            lblGrand.AutoSize = true;
            lblGrand.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGrand.Location = new Point(33, 325);
            lblGrand.Name = "lblGrand";
            lblGrand.Size = new Size(105, 22);
            lblGrand.TabIndex = 6;
            lblGrand.Text = "Grand Total";
            // 
            // lblShoppingCosts
            // 
            lblShoppingCosts.BorderStyle = BorderStyle.Fixed3D;
            lblShoppingCosts.Location = new Point(494, 186);
            lblShoppingCosts.Name = "lblShoppingCosts";
            lblShoppingCosts.Size = new Size(114, 31);
            lblShoppingCosts.TabIndex = 7;
            // 
            // lblSaleTax
            // 
            lblSaleTax.BorderStyle = BorderStyle.Fixed3D;
            lblSaleTax.Location = new Point(494, 252);
            lblSaleTax.Name = "lblSaleTax";
            lblSaleTax.Size = new Size(114, 31);
            lblSaleTax.TabIndex = 8;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.BorderStyle = BorderStyle.Fixed3D;
            lblGrandTotal.Location = new Point(494, 307);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(114, 40);
            lblGrandTotal.TabIndex = 9;
            lblGrandTotal.Click += label8_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(162, 412);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 69);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = " C&alculate\r\nGrand  Total\r\n";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(352, 412);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 69);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmShippingAndHandling
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(675, 600);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblSaleTax);
            Controls.Add(lblShoppingCosts);
            Controls.Add(lblGrand);
            Controls.Add(lblSales);
            Controls.Add(lblShopping);
            Controls.Add(lblCustomer);
            Controls.Add(lblorderTotal);
            Controls.Add(txtCustomerType);
            Controls.Add(txtOrderTotal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmShippingAndHandling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shipping and Handling";
            Load += frmShippingAndHandling_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrderTotal;
        private TextBox txtCustomerType;
        private Label lblorderTotal;
        private Label lblCustomer;
        private Label lblShopping;
        private Label lblSales;
        private Label lblGrand;
        private Label lblShoppingCosts;
        private Label lblSaleTax;
        private Label lblGrandTotal;
        private Button btnCalculate;
        private Button btnExit;
    }
}