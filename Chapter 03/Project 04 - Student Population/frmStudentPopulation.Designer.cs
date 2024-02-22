namespace Student_Population
{
    partial class FrmStudentPopulation
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
            lblAnnualG = new Label();
            lblNumberOfY = new Label();
            lblProject = new Label();
            txtNumberOfStudentsToday = new TextBox();
            txtAnnualGrowthRate = new TextBox();
            txtNumberOfyears = new TextBox();
            txtProjectNumberOfStudents = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblnumberOfS
            // 
            lblnumberOfS.AutoSize = true;
            lblnumberOfS.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblnumberOfS.Location = new Point(16, 48);
            lblnumberOfS.Name = "lblnumberOfS";
            lblnumberOfS.Size = new Size(214, 22);
            lblnumberOfS.TabIndex = 0;
            lblnumberOfS.Text = "Nunber of Students Today";
            // 
            // lblAnnualG
            // 
            lblAnnualG.AutoSize = true;
            lblAnnualG.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnnualG.Location = new Point(18, 112);
            lblAnnualG.Name = "lblAnnualG";
            lblAnnualG.Size = new Size(172, 22);
            lblAnnualG.TabIndex = 1;
            lblAnnualG.Text = "Annual Growth Rate";
            // 
            // lblNumberOfY
            // 
            lblNumberOfY.AutoSize = true;
            lblNumberOfY.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberOfY.Location = new Point(19, 172);
            lblNumberOfY.Name = "lblNumberOfY";
            lblNumberOfY.Size = new Size(143, 22);
            lblNumberOfY.TabIndex = 2;
            lblNumberOfY.Text = "Number of Years";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProject.Location = new Point(19, 227);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(227, 22);
            lblProject.TabIndex = 3;
            lblProject.Text = "Project Number of Students";
            // 
            // txtNumberOfStudentsToday
            // 
            txtNumberOfStudentsToday.Location = new Point(317, 43);
            txtNumberOfStudentsToday.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfStudentsToday.Name = "txtNumberOfStudentsToday";
            txtNumberOfStudentsToday.Size = new Size(137, 27);
            txtNumberOfStudentsToday.TabIndex = 4;
            // 
            // txtAnnualGrowthRate
            // 
            txtAnnualGrowthRate.Location = new Point(317, 107);
            txtAnnualGrowthRate.Margin = new Padding(3, 4, 3, 4);
            txtAnnualGrowthRate.Name = "txtAnnualGrowthRate";
            txtAnnualGrowthRate.Size = new Size(137, 27);
            txtAnnualGrowthRate.TabIndex = 5;
            // 
            // txtNumberOfyears
            // 
            txtNumberOfyears.Location = new Point(317, 167);
            txtNumberOfyears.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfyears.Name = "txtNumberOfyears";
            txtNumberOfyears.Size = new Size(137, 27);
            txtNumberOfyears.TabIndex = 6;
            // 
            // txtProjectNumberOfStudents
            // 
            txtProjectNumberOfStudents.Location = new Point(317, 222);
            txtProjectNumberOfStudents.Margin = new Padding(3, 4, 3, 4);
            txtProjectNumberOfStudents.Name = "txtProjectNumberOfStudents";
            txtProjectNumberOfStudents.ReadOnly = true;
            txtProjectNumberOfStudents.Size = new Size(137, 27);
            txtProjectNumberOfStudents.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(105, 335);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(105, 89);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Project\r\nStudent\r\nPopulation\r\n";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnProjectStudentPopulation_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(317, 335);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 89);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FrmStudentPopulation
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(542, 505);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtProjectNumberOfStudents);
            Controls.Add(txtNumberOfyears);
            Controls.Add(txtAnnualGrowthRate);
            Controls.Add(txtNumberOfStudentsToday);
            Controls.Add(lblProject);
            Controls.Add(lblNumberOfY);
            Controls.Add(lblAnnualG);
            Controls.Add(lblnumberOfS);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmStudentPopulation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Population";
            Load += FrmStudentPopulation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumberOfS;
        private Label lblAnnualG;
        private Label lblNumberOfY;
        private Label lblProject;
        private TextBox txtNumberOfStudentsToday;
        private TextBox txtAnnualGrowthRate;
        private TextBox txtNumberOfyears;
        private TextBox txtProjectNumberOfStudents;
        private Button btnCalculate;
        private Button btnExit;
    }
}