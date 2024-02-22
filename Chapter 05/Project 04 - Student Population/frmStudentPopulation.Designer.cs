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
            txtNumberOfStudents = new TextBox();
            txtAnnualGrowthRate = new TextBox();
            txtNumberOfYears = new TextBox();
            txtProjectNumberOfStudents = new TextBox();
            btnProjectStudentPopulation = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblnumberOfS
            // 
            lblnumberOfS.AutoSize = true;
            lblnumberOfS.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblnumberOfS.Location = new Point(16, 48);
            lblnumberOfS.Name = "lblnumberOfS";
            lblnumberOfS.Size = new Size(205, 20);
            lblnumberOfS.TabIndex = 0;
            lblnumberOfS.Text = "Nunber of Students Today:";
            // 
            // lblAnnualG
            // 
            lblAnnualG.AutoSize = true;
            lblAnnualG.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnnualG.Location = new Point(16, 107);
            lblAnnualG.Name = "lblAnnualG";
            lblAnnualG.Size = new Size(162, 20);
            lblAnnualG.TabIndex = 1;
            lblAnnualG.Text = "Annual Growth Rate:";
            // 
            // lblNumberOfY
            // 
            lblNumberOfY.AutoSize = true;
            lblNumberOfY.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberOfY.Location = new Point(19, 167);
            lblNumberOfY.Name = "lblNumberOfY";
            lblNumberOfY.Size = new Size(136, 20);
            lblNumberOfY.TabIndex = 2;
            lblNumberOfY.Text = "Number of Years:";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblProject.Location = new Point(19, 229);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(216, 20);
            lblProject.TabIndex = 3;
            lblProject.Text = "Project Number of Students:";
            // 
            // txtNumberOfStudents
            // 
            txtNumberOfStudents.Location = new Point(329, 41);
            txtNumberOfStudents.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfStudents.Name = "txtNumberOfStudents";
            txtNumberOfStudents.Size = new Size(137, 27);
            txtNumberOfStudents.TabIndex = 4;
            // 
            // txtAnnualGrowthRate
            // 
            txtAnnualGrowthRate.Location = new Point(329, 100);
            txtAnnualGrowthRate.Margin = new Padding(3, 4, 3, 4);
            txtAnnualGrowthRate.Name = "txtAnnualGrowthRate";
            txtAnnualGrowthRate.Size = new Size(137, 27);
            txtAnnualGrowthRate.TabIndex = 5;
            // 
            // txtNumberOfYears
            // 
            txtNumberOfYears.Location = new Point(329, 160);
            txtNumberOfYears.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfYears.Name = "txtNumberOfYears";
            txtNumberOfYears.Size = new Size(137, 27);
            txtNumberOfYears.TabIndex = 6;
            // 
            // txtProjectNumberOfStudents
            // 
            txtProjectNumberOfStudents.Location = new Point(329, 222);
            txtProjectNumberOfStudents.Margin = new Padding(3, 4, 3, 4);
            txtProjectNumberOfStudents.Name = "txtProjectNumberOfStudents";
            txtProjectNumberOfStudents.ReadOnly = true;
            txtProjectNumberOfStudents.Size = new Size(137, 27);
            txtProjectNumberOfStudents.TabIndex = 7;
            // 
            // btnProjectStudentPopulation
            // 
            btnProjectStudentPopulation.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnProjectStudentPopulation.Location = new Point(106, 319);
            btnProjectStudentPopulation.Margin = new Padding(3, 4, 3, 4);
            btnProjectStudentPopulation.Name = "btnProjectStudentPopulation";
            btnProjectStudentPopulation.Size = new Size(105, 89);
            btnProjectStudentPopulation.TabIndex = 8;
            btnProjectStudentPopulation.Text = "&Project\r\nStudent\r\nPopulation\r\n";
            btnProjectStudentPopulation.UseVisualStyleBackColor = true;
            btnProjectStudentPopulation.Click += btnProjectStudentPopulation_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(329, 319);
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
            AcceptButton = btnProjectStudentPopulation;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(542, 505);
            Controls.Add(btnExit);
            Controls.Add(btnProjectStudentPopulation);
            Controls.Add(txtProjectNumberOfStudents);
            Controls.Add(txtNumberOfYears);
            Controls.Add(txtAnnualGrowthRate);
            Controls.Add(txtNumberOfStudents);
            Controls.Add(lblProject);
            Controls.Add(lblNumberOfY);
            Controls.Add(lblAnnualG);
            Controls.Add(lblnumberOfS);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmStudentPopulation";
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
        private TextBox txtNumberOfStudents;
        private TextBox txtAnnualGrowthRate;
        private TextBox txtNumberOfYears;
        private TextBox txtProjectNumberOfStudents;
        private Button btnProjectStudentPopulation;
        private Button btnExit;
    }
}