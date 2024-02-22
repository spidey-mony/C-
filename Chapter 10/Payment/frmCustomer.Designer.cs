namespace Payment
{
    partial class frmCustomer
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
            lblCustomerName = new Label();
            lblPaymentMethod = new Label();
            lblPayment = new Label();
            cboNames = new ComboBox();
            btnSave = new Button();
            btnExit = new Button();
            btnSelectPayment = new Button();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(22, 38);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(116, 20);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer name:";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(22, 125);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(124, 20);
            lblPaymentMethod.TabIndex = 1;
            lblPaymentMethod.Text = "Payment method:";
            // 
            // lblPayment
            // 
            lblPayment.BorderStyle = BorderStyle.Fixed3D;
            lblPayment.Location = new Point(22, 165);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(284, 122);
            lblPayment.TabIndex = 2;
            // 
            // cboNames
            // 
            cboNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNames.FormattingEnabled = true;
            cboNames.Location = new Point(239, 30);
            cboNames.Name = "cboNames";
            cboNames.Size = new Size(223, 28);
            cboNames.TabIndex = 3;
            cboNames.SelectedIndexChanged += cboNames_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Location = new Point(268, 339);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Control;
            btnExit.Location = new Point(386, 339);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSelectPayment
            // 
            btnSelectPayment.BackColor = SystemColors.ActiveCaption;
            btnSelectPayment.Location = new Point(334, 162);
            btnSelectPayment.Name = "btnSelectPayment";
            btnSelectPayment.Size = new Size(146, 29);
            btnSelectPayment.TabIndex = 6;
            btnSelectPayment.Text = "Select Payment";
            btnSelectPayment.UseVisualStyleBackColor = false;
            btnSelectPayment.Click += btnSelectPayment_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(501, 401);
            Controls.Add(btnSelectPayment);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(cboNames);
            Controls.Add(lblPayment);
            Controls.Add(lblPaymentMethod);
            Controls.Add(lblCustomerName);
            Name = "frmCustomer";
            Text = "Customer";
            FormClosing += frmCustomer_FormClosing;
            Load += frmCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private Label lblPaymentMethod;
        private Label lblPayment;
        private ComboBox cboNames;
        private Button btnSave;
        private Button btnExit;
        private Button btnSelectPayment;
    }
}
