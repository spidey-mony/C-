namespace Slipping_and_Handing
{
    partial class frmSippingAndHandling
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
            lblShopping = new Label();
            lblSale = new Label();
            lblGrand = new Label();
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
            txtOrderTotal.TabIndex = 1;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(494, 116);
            txtCustomer.Margin = new Padding(3, 4, 3, 4);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(114, 27);
            txtCustomer.TabIndex = 2;
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
            // lblShopping
            // 
            lblShopping.BorderStyle = BorderStyle.Fixed3D;
            lblShopping.Location = new Point(494, 186);
            lblShopping.Name = "lblShopping";
            lblShopping.Size = new Size(114, 31);
            lblShopping.TabIndex = 7;
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
            // lblGrand
            // 
            lblGrand.BorderStyle = BorderStyle.Fixed3D;
            lblGrand.Location = new Point(494, 307);
            lblGrand.Name = "lblGrand";
            lblGrand.Size = new Size(114, 40);
            lblGrand.TabIndex = 9;
            lblGrand.Click += label8_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(152, 428);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 69);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "C&alculate\r\nGrandTotal\r\n";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(362, 428);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 69);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmSippingAndHandling
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(675, 600);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblGrand);
            Controls.Add(lblSale);
            Controls.Add(lblShopping);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblSales);
            Controls.Add(lblShoppingCosts);
            Controls.Add(lblCustomer);
            Controls.Add(lblorderTotal);
            Controls.Add(txtCustomer);
            Controls.Add(txtOrderTotal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSippingAndHandling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipping and Handling";
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
        private Label lblShopping;
        private Label lblSale;
        private Label lblGrand;
        private Button btnCalculate;
        private Button btnExit;
    }
}