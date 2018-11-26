namespace Tadrees
{
    partial class StudentClassesForm
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
            this.StudentSchedule = new System.Windows.Forms.GroupBox();
            this.StudentScheduleLabelDropClasses = new System.Windows.Forms.Button();
            this.StudentSchdeuleGridMyClasses = new System.Windows.Forms.DataGridView();
            this.StudentSchdeuleClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentScheduleSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentScheduleTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentScheduleTimings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentScheduleDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherScheduleLabelAddClasses = new System.Windows.Forms.Button();
            this.StudentScheduleLabelMyClasses = new System.Windows.Forms.Label();
            this.StudentSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentSchdeuleGridMyClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentSchedule
            // 
            this.StudentSchedule.Controls.Add(this.StudentScheduleLabelDropClasses);
            this.StudentSchedule.Controls.Add(this.StudentSchdeuleGridMyClasses);
            this.StudentSchedule.Controls.Add(this.TeacherScheduleLabelAddClasses);
            this.StudentSchedule.Controls.Add(this.StudentScheduleLabelMyClasses);
            this.StudentSchedule.Location = new System.Drawing.Point(208, 123);
            this.StudentSchedule.Name = "StudentSchedule";
            this.StudentSchedule.Size = new System.Drawing.Size(695, 362);
            this.StudentSchedule.TabIndex = 7;
            this.StudentSchedule.TabStop = false;
            this.StudentSchedule.Text = "Student - My Classess";
            // 
            // StudentScheduleLabelDropClasses
            // 
            this.StudentScheduleLabelDropClasses.Location = new System.Drawing.Point(402, 311);
            this.StudentScheduleLabelDropClasses.Name = "StudentScheduleLabelDropClasses";
            this.StudentScheduleLabelDropClasses.Size = new System.Drawing.Size(111, 25);
            this.StudentScheduleLabelDropClasses.TabIndex = 12;
            this.StudentScheduleLabelDropClasses.Text = "Back";
            this.StudentScheduleLabelDropClasses.UseVisualStyleBackColor = true;
            // 
            // StudentSchdeuleGridMyClasses
            // 
            this.StudentSchdeuleGridMyClasses.AllowUserToAddRows = false;
            this.StudentSchdeuleGridMyClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentSchdeuleGridMyClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentSchdeuleClassID,
            this.StudentScheduleSubject,
            this.StudentScheduleTeacher,
            this.StudentScheduleTimings,
            this.StudentScheduleDays});
            this.StudentSchdeuleGridMyClasses.Location = new System.Drawing.Point(84, 102);
            this.StudentSchdeuleGridMyClasses.Name = "StudentSchdeuleGridMyClasses";
            this.StudentSchdeuleGridMyClasses.RowTemplate.Height = 24;
            this.StudentSchdeuleGridMyClasses.Size = new System.Drawing.Size(570, 181);
            this.StudentSchdeuleGridMyClasses.TabIndex = 11;
            this.StudentSchdeuleGridMyClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentSchdeuleClassID
            // 
            this.StudentSchdeuleClassID.HeaderText = "ClassID";
            this.StudentSchdeuleClassID.Name = "StudentSchdeuleClassID";
            // 
            // StudentScheduleSubject
            // 
            this.StudentScheduleSubject.HeaderText = "Subject";
            this.StudentScheduleSubject.Name = "StudentScheduleSubject";
            // 
            // StudentScheduleTeacher
            // 
            this.StudentScheduleTeacher.HeaderText = "Teacher";
            this.StudentScheduleTeacher.Name = "StudentScheduleTeacher";
            // 
            // StudentScheduleTimings
            // 
            this.StudentScheduleTimings.HeaderText = "Timings";
            this.StudentScheduleTimings.Name = "StudentScheduleTimings";
            // 
            // StudentScheduleDays
            // 
            this.StudentScheduleDays.HeaderText = "Days";
            this.StudentScheduleDays.Name = "StudentScheduleDays";
            // 
            // TeacherScheduleLabelAddClasses
            // 
            this.TeacherScheduleLabelAddClasses.Location = new System.Drawing.Point(543, 311);
            this.TeacherScheduleLabelAddClasses.Name = "TeacherScheduleLabelAddClasses";
            this.TeacherScheduleLabelAddClasses.Size = new System.Drawing.Size(111, 25);
            this.TeacherScheduleLabelAddClasses.TabIndex = 10;
            this.TeacherScheduleLabelAddClasses.Text = "Add Classes";
            this.TeacherScheduleLabelAddClasses.UseVisualStyleBackColor = true;
            // 
            // StudentScheduleLabelMyClasses
            // 
            this.StudentScheduleLabelMyClasses.AutoSize = true;
            this.StudentScheduleLabelMyClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentScheduleLabelMyClasses.Location = new System.Drawing.Point(281, 49);
            this.StudentScheduleLabelMyClasses.Name = "StudentScheduleLabelMyClasses";
            this.StudentScheduleLabelMyClasses.Size = new System.Drawing.Size(146, 29);
            this.StudentScheduleLabelMyClasses.TabIndex = 9;
            this.StudentScheduleLabelMyClasses.Text = "My Classes";
            // 
            // StudentClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 507);
            this.Controls.Add(this.StudentSchedule);
            this.Name = "StudentClassesForm";
            this.Text = "Form1";
            this.StudentSchedule.ResumeLayout(false);
            this.StudentSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentSchdeuleGridMyClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentSchedule;
        private System.Windows.Forms.DataGridView StudentSchdeuleGridMyClasses;
        private System.Windows.Forms.Button TeacherScheduleLabelAddClasses;
        private System.Windows.Forms.Label StudentScheduleLabelMyClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSchdeuleClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentScheduleSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentScheduleTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentScheduleTimings;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentScheduleDays;
        private System.Windows.Forms.Button StudentScheduleLabelDropClasses;
    }
}