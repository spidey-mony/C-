namespace Student_Population
{
    partial class frmStudentPopulation
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
            lblnumberOfS = new Label();
            lblAnnualGrowth = new Label();
            lblNumberOfYears = new Label();
            lblProject = new Label();
            txtNumberOfStudents = new TextBox();
            txtAnnualGrowthRate = new TextBox();
            txtNumberofYears = new TextBox();
            txtProjectNumberOfStudents = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblnumberOfS
            // 
            lblnumberOfS.AutoSize = true;
            lblnumberOfS.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblnumberOfS.Location = new Point(19, 57);
            lblnumberOfS.Name = "lblnumberOfS";
            lblnumberOfS.Size = new Size(220, 22);
            lblnumberOfS.TabIndex = 0;
            lblnumberOfS.Text = "Nunber of Students Today:";
            // 
            // lblAnnualGrowth
            // 
            lblAnnualGrowth.AutoSize = true;
            lblAnnualGrowth.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnnualGrowth.Location = new Point(19, 117);
            lblAnnualGrowth.Name = "lblAnnualGrowth";
            lblAnnualGrowth.Size = new Size(178, 22);
            lblAnnualGrowth.TabIndex = 1;
            lblAnnualGrowth.Text = "Annual Growth Rate:";
            lblAnnualGrowth.Click += lblAnnualG_Click;
            // 
            // lblNumberOfYears
            // 
            lblNumberOfYears.AutoSize = true;
            lblNumberOfYears.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberOfYears.Location = new Point(19, 183);
            lblNumberOfYears.Name = "lblNumberOfYears";
            lblNumberOfYears.Size = new Size(149, 22);
            lblNumberOfYears.TabIndex = 2;
            lblNumberOfYears.Text = "Number of Years:";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProject.Location = new Point(19, 246);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(233, 22);
            lblProject.TabIndex = 3;
            lblProject.Text = "Project Number of Students:";
            // 
            // txtNumberOfStudents
            // 
            txtNumberOfStudents.Location = new Point(343, 52);
            txtNumberOfStudents.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfStudents.Name = "txtNumberOfStudents";
            txtNumberOfStudents.Size = new Size(137, 27);
            txtNumberOfStudents.TabIndex = 1;
            // 
            // txtAnnualGrowthRate
            // 
            txtAnnualGrowthRate.Location = new Point(343, 112);
            txtAnnualGrowthRate.Margin = new Padding(3, 4, 3, 4);
            txtAnnualGrowthRate.Name = "txtAnnualGrowthRate";
            txtAnnualGrowthRate.Size = new Size(137, 27);
            txtAnnualGrowthRate.TabIndex = 2;
            // 
            // txtNumberofYears
            // 
            txtNumberofYears.Location = new Point(343, 178);
            txtNumberofYears.Margin = new Padding(3, 4, 3, 4);
            txtNumberofYears.Name = "txtNumberofYears";
            txtNumberofYears.Size = new Size(137, 27);
            txtNumberofYears.TabIndex = 3;
            // 
            // txtProjectNumberOfStudents
            // 
            txtProjectNumberOfStudents.Location = new Point(343, 241);
            txtProjectNumberOfStudents.Margin = new Padding(3, 4, 3, 4);
            txtProjectNumberOfStudents.Name = "txtProjectNumberOfStudents";
            txtProjectNumberOfStudents.ReadOnly = true;
            txtProjectNumberOfStudents.Size = new Size(137, 27);
            txtProjectNumberOfStudents.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(92, 336);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(105, 89);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Project\r\nStudent\r\nPopulation\r\n";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(328, 336);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 89);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmStudentPopulation
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(542, 505);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtProjectNumberOfStudents);
            Controls.Add(txtNumberofYears);
            Controls.Add(txtAnnualGrowthRate);
            Controls.Add(txtNumberOfStudents);
            Controls.Add(lblProject);
            Controls.Add(lblNumberOfYears);
            Controls.Add(lblAnnualGrowth);
            Controls.Add(lblnumberOfS);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStudentPopulation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Population";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumberOfS;
        private Label lblAnnualGrowth;
        private Label lblNumberOfYears;
        private Label lblProject;
        private TextBox txtNumberOfStudents;
        private TextBox txtAnnualGrowthRate;
        private TextBox txtNumberofYears;
        private TextBox txtProjectNumberOfStudents;
        private Button btnCalculate;
        private Button btnExit;
    }
}