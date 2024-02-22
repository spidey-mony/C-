namespace Payment
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBilling = new GroupBox();
            rdoBillCustomer = new RadioButton();
            rdoCreditCard = new RadioButton();
            lstCreditCardType = new ListBox();
            txtCardNumber = new TextBox();
            cboExpirationMonth = new ComboBox();
            cboExpirationYear = new ComboBox();
            chkDefault = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grpBilling.SuspendLayout();
            SuspendLayout();
            // 
            // grpBilling
            // 
            grpBilling.Controls.Add(rdoBillCustomer);
            grpBilling.Controls.Add(rdoCreditCard);
            grpBilling.Location = new Point(23, 39);
            grpBilling.Name = "grpBilling";
            grpBilling.Size = new Size(450, 69);
            grpBilling.TabIndex = 7;
            grpBilling.TabStop = false;
            grpBilling.Text = "Billing";
            // 
            // rdoBillCustomer
            // 
            rdoBillCustomer.AutoSize = true;
            rdoBillCustomer.Location = new Point(284, 26);
            rdoBillCustomer.Name = "rdoBillCustomer";
            rdoBillCustomer.Size = new Size(116, 24);
            rdoBillCustomer.TabIndex = 9;
            rdoBillCustomer.Text = "Bill customer";
            rdoBillCustomer.UseVisualStyleBackColor = true;
            rdoBillCustomer.CheckedChanged += Billing_CheckedChanged;
            // 
            // rdoCreditCard
            // 
            rdoCreditCard.AutoSize = true;
            rdoCreditCard.Checked = true;
            rdoCreditCard.Location = new Point(40, 26);
            rdoCreditCard.Name = "rdoCreditCard";
            rdoCreditCard.Size = new Size(103, 24);
            rdoCreditCard.TabIndex = 8;
            rdoCreditCard.TabStop = true;
            rdoCreditCard.Text = "Credit card";
            rdoCreditCard.UseVisualStyleBackColor = true;
            // 
            // lstCreditCardType
            // 
            lstCreditCardType.FormattingEnabled = true;
            lstCreditCardType.Location = new Point(193, 135);
            lstCreditCardType.Name = "lstCreditCardType";
            lstCreditCardType.Size = new Size(280, 104);
            lstCreditCardType.TabIndex = 1;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(193, 261);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(280, 27);
            txtCardNumber.TabIndex = 1;
            // 
            // cboExpirationMonth
            // 
            cboExpirationMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExpirationMonth.FormattingEnabled = true;
            cboExpirationMonth.Location = new Point(193, 322);
            cboExpirationMonth.Name = "cboExpirationMonth";
            cboExpirationMonth.Size = new Size(145, 28);
            cboExpirationMonth.TabIndex = 2;
            // 
            // cboExpirationYear
            // 
            cboExpirationYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExpirationYear.FormattingEnabled = true;
            cboExpirationYear.Location = new Point(358, 322);
            cboExpirationYear.Name = "cboExpirationYear";
            cboExpirationYear.Size = new Size(115, 28);
            cboExpirationYear.TabIndex = 3;
            // 
            // chkDefault
            // 
            chkDefault.AutoSize = true;
            chkDefault.Location = new Point(23, 382);
            chkDefault.Name = "chkDefault";
            chkDefault.Size = new Size(223, 24);
            chkDefault.TabIndex = 4;
            chkDefault.Text = "Set as default billing method";
            chkDefault.UseVisualStyleBackColor = true;
            chkDefault.CheckedChanged += Billing_CheckedChanged;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(244, 431);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 5;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(379, 431);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 135);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 8;
            label1.Text = "Credit card type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 268);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 9;
            label2.Text = "Card number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 330);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 10;
            label3.Text = "Expiration date:";
            // 
            // frmPayment
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(500, 483);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkDefault);
            Controls.Add(cboExpirationYear);
            Controls.Add(cboExpirationMonth);
            Controls.Add(txtCardNumber);
            Controls.Add(lstCreditCardType);
            Controls.Add(grpBilling);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "frmPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += frmPayment_Load;
            grpBilling.ResumeLayout(false);
            grpBilling.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBilling;
        private RadioButton rdoBillCustomer;
        private RadioButton rdoCreditCard;
        private ListBox lstCreditCardType;
        private TextBox txtCardNumber;
        private ComboBox cboExpirationMonth;
        private ComboBox cboExpirationYear;
        private CheckBox chkDefault;
        private Button btnOK;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}