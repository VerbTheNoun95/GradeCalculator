namespace GradeCalculator
{
    partial class Form1
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
            this.CourseSelection = new System.Windows.Forms.ComboBox();
            this.LetterGradeBox = new System.Windows.Forms.PictureBox();
            this.Assignment0_Type = new System.Windows.Forms.ComboBox();
            this.Assignment1_Type = new System.Windows.Forms.ComboBox();
            this.Assignment2_Type = new System.Windows.Forms.ComboBox();
            this.Assignment3_Type = new System.Windows.Forms.ComboBox();
            this.Assignment4_Type = new System.Windows.Forms.ComboBox();
            this.Assignment5_Type = new System.Windows.Forms.ComboBox();
            this.Assignment6_Type = new System.Windows.Forms.ComboBox();
            this.Assignment7_Type = new System.Windows.Forms.ComboBox();
            this.Assignment0 = new System.Windows.Forms.TextBox();
            this.Assignment1 = new System.Windows.Forms.TextBox();
            this.Assignment2 = new System.Windows.Forms.TextBox();
            this.Assignment3 = new System.Windows.Forms.TextBox();
            this.Assignment4 = new System.Windows.Forms.TextBox();
            this.Assignment5 = new System.Windows.Forms.TextBox();
            this.Assignment6 = new System.Windows.Forms.TextBox();
            this.Assignment7 = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CoursePrompt = new System.Windows.Forms.Label();
            this.AssignmentPrompt = new System.Windows.Forms.Label();
            this.GradePrompt = new System.Windows.Forms.Label();
            this.TotalPoints_label = new System.Windows.Forms.Label();
            this.Assignment0_Total = new System.Windows.Forms.TextBox();
            this.Assignment1_Total = new System.Windows.Forms.TextBox();
            this.Assignment2_Total = new System.Windows.Forms.TextBox();
            this.Assignment3_Total = new System.Windows.Forms.TextBox();
            this.Assignment4_Total = new System.Windows.Forms.TextBox();
            this.Assignment5_Total = new System.Windows.Forms.TextBox();
            this.Assignment6_Total = new System.Windows.Forms.TextBox();
            this.Assignment7_Total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LetterGradeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseSelection
            // 
            this.CourseSelection.FormattingEnabled = true;
            this.CourseSelection.Items.AddRange(new object[] {
            "PSY513",
            "STA502",
            "STA503"});
            this.CourseSelection.Location = new System.Drawing.Point(188, 66);
            this.CourseSelection.Name = "CourseSelection";
            this.CourseSelection.Size = new System.Drawing.Size(563, 28);
            this.CourseSelection.TabIndex = 0;
            // 
            // LetterGradeBox
            // 
            this.LetterGradeBox.Location = new System.Drawing.Point(631, 252);
            this.LetterGradeBox.Name = "LetterGradeBox";
            this.LetterGradeBox.Size = new System.Drawing.Size(215, 215);
            this.LetterGradeBox.TabIndex = 1;
            this.LetterGradeBox.TabStop = false;
            // 
            // Assignment0_Type
            // 
            this.Assignment0_Type.FormattingEnabled = true;
            this.Assignment0_Type.Items.AddRange(new object[] {
            "Homework",
            "Quiz",
            "Exam",
            "Midterm",
            "Final"});
            this.Assignment0_Type.Location = new System.Drawing.Point(61, 170);
            this.Assignment0_Type.Name = "Assignment0_Type";
            this.Assignment0_Type.Size = new System.Drawing.Size(150, 28);
            this.Assignment0_Type.TabIndex = 2;
            // 
            // Assignment1_Type
            // 
            this.Assignment1_Type.FormattingEnabled = true;
            this.Assignment1_Type.Items.AddRange(new object[] {
            "Homework",
            "Quiz",
            "Exam",
            "Midterm",
            "Final"});
            this.Assignment1_Type.Location = new System.Drawing.Point(61, 229);
            this.Assignment1_Type.Name = "Assignment1_Type";
            this.Assignment1_Type.Size = new System.Drawing.Size(150, 28);
            this.Assignment1_Type.TabIndex = 3;
            // 
            // Assignment2_Type
            // 
            this.Assignment2_Type.FormattingEnabled = true;
            this.Assignment2_Type.Items.AddRange(new object[] {
            "Homework",
            "Quiz",
            "Exam",
            "Midterm",
            "Final"});
            this.Assignment2_Type.Location = new System.Drawing.Point(61, 288);
            this.Assignment2_Type.Name = "Assignment2_Type";
            this.Assignment2_Type.Size = new System.Drawing.Size(150, 28);
            this.Assignment2_Type.TabIndex = 4;
            // 
            // Assignment3_Type
            // 
            this.Assignment3_Type.FormattingEnabled = true;
            this.Assignment3_Type.Items.AddRange(new object[] {
            "Homework",
            "Quiz",
            "Exam",
            "Midterm",
            "Final"});
            this.Assignment3_Type.Location = new System.Drawing.Point(61, 347);
            this.Assignment3_Type.Name = "Assignment3_Type";
            this.Assignment3_Type.Size = new System.Drawing.Size(150, 28);
            this.Assignment3_Type.TabIndex = 5;
            // 
            // Assignment4_Type
            // 
            this.Assignment4_Type.FormattingEnabled = true;
            this.Assignment4_Type.Items.AddRange(new object[] {
            "Homework",
            "Quiz",
            "Exam",
            "Midterm",
            "Final"});
            this.Assignment4_Type.Location = new System.Drawing.Point(61, 406);
            this.Assignment4_Type.Name = "Assignment4_Type";
            this.Assignment4_Type.Size = new System.Drawing.Size(150, 28);
            this.Assignment4_Type.TabIndex = 6;
            // 
            // Assignment5_Type
            // 
            this.Assignment5_Type.FormattingEnabled = true;
            this.Assignment5_Type.Items.AddRange(new object[] {
            "Homework",
            "Quiz",
            "Exam",
            "Midterm",
            "Final"});
            this.Assignment5_Type.Location = new System.Drawing.Point(61, 465);
            this.Assignment5_Type.Name = "Assignment5_Type";
            this.Assignment5_Type.Size = new System.Drawing.Size(150, 28);
            this.Assignment5_Type.TabIndex = 7;
            // 
            // Assignment6_Type
            // 
            this.Assignment6_Type.FormattingEnabled = true;
            this.Assignment6_Type.Items.AddRange(new object[] {
            "Homework",
            "Quiz",
            "Exam",
            "Midterm",
            "Final"});
            this.Assignment6_Type.Location = new System.Drawing.Point(61, 524);
            this.Assignment6_Type.Name = "Assignment6_Type";
            this.Assignment6_Type.Size = new System.Drawing.Size(150, 28);
            this.Assignment6_Type.TabIndex = 8;
            // 
            // Assignment7_Type
            // 
            this.Assignment7_Type.FormattingEnabled = true;
            this.Assignment7_Type.Items.AddRange(new object[] {
            "Homework",
            "Quiz",
            "Exam",
            "Midterm",
            "Final"});
            this.Assignment7_Type.Location = new System.Drawing.Point(61, 583);
            this.Assignment7_Type.Name = "Assignment7_Type";
            this.Assignment7_Type.Size = new System.Drawing.Size(150, 28);
            this.Assignment7_Type.TabIndex = 9;
            // 
            // Assignment0
            // 
            this.Assignment0.Location = new System.Drawing.Point(221, 170);
            this.Assignment0.Name = "Assignment0";
            this.Assignment0.Size = new System.Drawing.Size(100, 26);
            this.Assignment0.TabIndex = 10;
            // 
            // Assignment1
            // 
            this.Assignment1.Location = new System.Drawing.Point(221, 229);
            this.Assignment1.Name = "Assignment1";
            this.Assignment1.Size = new System.Drawing.Size(100, 26);
            this.Assignment1.TabIndex = 11;
            // 
            // Assignment2
            // 
            this.Assignment2.Location = new System.Drawing.Point(221, 288);
            this.Assignment2.Name = "Assignment2";
            this.Assignment2.Size = new System.Drawing.Size(100, 26);
            this.Assignment2.TabIndex = 12;
            // 
            // Assignment3
            // 
            this.Assignment3.Location = new System.Drawing.Point(221, 347);
            this.Assignment3.Name = "Assignment3";
            this.Assignment3.Size = new System.Drawing.Size(100, 26);
            this.Assignment3.TabIndex = 13;
            // 
            // Assignment4
            // 
            this.Assignment4.Location = new System.Drawing.Point(221, 406);
            this.Assignment4.Name = "Assignment4";
            this.Assignment4.Size = new System.Drawing.Size(100, 26);
            this.Assignment4.TabIndex = 14;
            // 
            // Assignment5
            // 
            this.Assignment5.Location = new System.Drawing.Point(221, 465);
            this.Assignment5.Name = "Assignment5";
            this.Assignment5.Size = new System.Drawing.Size(100, 26);
            this.Assignment5.TabIndex = 15;
            // 
            // Assignment6
            // 
            this.Assignment6.Location = new System.Drawing.Point(221, 524);
            this.Assignment6.Name = "Assignment6";
            this.Assignment6.Size = new System.Drawing.Size(100, 26);
            this.Assignment6.TabIndex = 16;
            // 
            // Assignment7
            // 
            this.Assignment7.Location = new System.Drawing.Point(221, 583);
            this.Assignment7.Name = "Assignment7";
            this.Assignment7.Size = new System.Drawing.Size(100, 26);
            this.Assignment7.TabIndex = 17;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(631, 511);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(215, 78);
            this.CalculateButton.TabIndex = 18;
            this.CalculateButton.Text = "Get your grade!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CoursePrompt
            // 
            this.CoursePrompt.AutoSize = true;
            this.CoursePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursePrompt.Location = new System.Drawing.Point(333, 20);
            this.CoursePrompt.Name = "CoursePrompt";
            this.CoursePrompt.Size = new System.Drawing.Size(265, 25);
            this.CoursePrompt.TabIndex = 19;
            this.CoursePrompt.Text = "Select which course you took";
            // 
            // AssignmentPrompt
            // 
            this.AssignmentPrompt.AutoSize = true;
            this.AssignmentPrompt.Location = new System.Drawing.Point(57, 135);
            this.AssignmentPrompt.Name = "AssignmentPrompt";
            this.AssignmentPrompt.Size = new System.Drawing.Size(135, 20);
            this.AssignmentPrompt.TabIndex = 20;
            this.AssignmentPrompt.Text = "Assignment Type:";
            // 
            // GradePrompt
            // 
            this.GradePrompt.AutoSize = true;
            this.GradePrompt.Location = new System.Drawing.Point(217, 135);
            this.GradePrompt.Name = "GradePrompt";
            this.GradePrompt.Size = new System.Drawing.Size(113, 20);
            this.GradePrompt.TabIndex = 21;
            this.GradePrompt.Text = "Points Earned:";
            // 
            // TotalPoints_label
            // 
            this.TotalPoints_label.AutoSize = true;
            this.TotalPoints_label.Location = new System.Drawing.Point(329, 135);
            this.TotalPoints_label.Name = "TotalPoints_label";
            this.TotalPoints_label.Size = new System.Drawing.Size(96, 20);
            this.TotalPoints_label.TabIndex = 22;
            this.TotalPoints_label.Text = "Points Total:";
            // 
            // Assignment0_Total
            // 
            this.Assignment0_Total.Location = new System.Drawing.Point(327, 170);
            this.Assignment0_Total.Name = "Assignment0_Total";
            this.Assignment0_Total.Size = new System.Drawing.Size(100, 26);
            this.Assignment0_Total.TabIndex = 23;
            // 
            // Assignment1_Total
            // 
            this.Assignment1_Total.Location = new System.Drawing.Point(327, 229);
            this.Assignment1_Total.Name = "Assignment1_Total";
            this.Assignment1_Total.Size = new System.Drawing.Size(100, 26);
            this.Assignment1_Total.TabIndex = 24;
            // 
            // Assignment2_Total
            // 
            this.Assignment2_Total.Location = new System.Drawing.Point(327, 288);
            this.Assignment2_Total.Name = "Assignment2_Total";
            this.Assignment2_Total.Size = new System.Drawing.Size(100, 26);
            this.Assignment2_Total.TabIndex = 25;
            // 
            // Assignment3_Total
            // 
            this.Assignment3_Total.Location = new System.Drawing.Point(327, 347);
            this.Assignment3_Total.Name = "Assignment3_Total";
            this.Assignment3_Total.Size = new System.Drawing.Size(100, 26);
            this.Assignment3_Total.TabIndex = 26;
            // 
            // Assignment4_Total
            // 
            this.Assignment4_Total.Location = new System.Drawing.Point(327, 406);
            this.Assignment4_Total.Name = "Assignment4_Total";
            this.Assignment4_Total.Size = new System.Drawing.Size(100, 26);
            this.Assignment4_Total.TabIndex = 27;
            // 
            // Assignment5_Total
            // 
            this.Assignment5_Total.Location = new System.Drawing.Point(327, 465);
            this.Assignment5_Total.Name = "Assignment5_Total";
            this.Assignment5_Total.Size = new System.Drawing.Size(100, 26);
            this.Assignment5_Total.TabIndex = 28;
            // 
            // Assignment6_Total
            // 
            this.Assignment6_Total.Location = new System.Drawing.Point(327, 524);
            this.Assignment6_Total.Name = "Assignment6_Total";
            this.Assignment6_Total.Size = new System.Drawing.Size(100, 26);
            this.Assignment6_Total.TabIndex = 29;
            // 
            // Assignment7_Total
            // 
            this.Assignment7_Total.Location = new System.Drawing.Point(327, 583);
            this.Assignment7_Total.Name = "Assignment7_Total";
            this.Assignment7_Total.Size = new System.Drawing.Size(100, 26);
            this.Assignment7_Total.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 704);
            this.Controls.Add(this.Assignment7_Total);
            this.Controls.Add(this.Assignment6_Total);
            this.Controls.Add(this.Assignment5_Total);
            this.Controls.Add(this.Assignment4_Total);
            this.Controls.Add(this.Assignment3_Total);
            this.Controls.Add(this.Assignment2_Total);
            this.Controls.Add(this.Assignment1_Total);
            this.Controls.Add(this.TotalPoints_label);
            this.Controls.Add(this.Assignment0_Total);
            this.Controls.Add(this.GradePrompt);
            this.Controls.Add(this.AssignmentPrompt);
            this.Controls.Add(this.CoursePrompt);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Assignment7);
            this.Controls.Add(this.Assignment6);
            this.Controls.Add(this.Assignment5);
            this.Controls.Add(this.Assignment4);
            this.Controls.Add(this.Assignment3);
            this.Controls.Add(this.Assignment2);
            this.Controls.Add(this.Assignment1);
            this.Controls.Add(this.Assignment0);
            this.Controls.Add(this.Assignment7_Type);
            this.Controls.Add(this.Assignment6_Type);
            this.Controls.Add(this.Assignment5_Type);
            this.Controls.Add(this.Assignment4_Type);
            this.Controls.Add(this.Assignment3_Type);
            this.Controls.Add(this.Assignment2_Type);
            this.Controls.Add(this.Assignment1_Type);
            this.Controls.Add(this.Assignment0_Type);
            this.Controls.Add(this.LetterGradeBox);
            this.Controls.Add(this.CourseSelection);
            this.Name = "Form1";
            this.Text = "Grade Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.LetterGradeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CourseSelection;
        private System.Windows.Forms.PictureBox LetterGradeBox;
        private System.Windows.Forms.ComboBox Assignment0_Type;
        private System.Windows.Forms.ComboBox Assignment1_Type;
        private System.Windows.Forms.ComboBox Assignment2_Type;
        private System.Windows.Forms.ComboBox Assignment3_Type;
        private System.Windows.Forms.ComboBox Assignment4_Type;
        private System.Windows.Forms.ComboBox Assignment5_Type;
        private System.Windows.Forms.ComboBox Assignment6_Type;
        private System.Windows.Forms.ComboBox Assignment7_Type;
        private System.Windows.Forms.TextBox Assignment0;
        private System.Windows.Forms.TextBox Assignment1;
        private System.Windows.Forms.TextBox Assignment2;
        private System.Windows.Forms.TextBox Assignment3;
        private System.Windows.Forms.TextBox Assignment4;
        private System.Windows.Forms.TextBox Assignment5;
        private System.Windows.Forms.TextBox Assignment6;
        private System.Windows.Forms.TextBox Assignment7;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label CoursePrompt;
        private System.Windows.Forms.Label AssignmentPrompt;
        private System.Windows.Forms.Label GradePrompt;
        private System.Windows.Forms.Label TotalPoints_label;
        private System.Windows.Forms.TextBox Assignment0_Total;
        private System.Windows.Forms.TextBox Assignment1_Total;
        private System.Windows.Forms.TextBox Assignment2_Total;
        private System.Windows.Forms.TextBox Assignment3_Total;
        private System.Windows.Forms.TextBox Assignment4_Total;
        private System.Windows.Forms.TextBox Assignment5_Total;
        private System.Windows.Forms.TextBox Assignment6_Total;
        private System.Windows.Forms.TextBox Assignment7_Total;
    }
}

