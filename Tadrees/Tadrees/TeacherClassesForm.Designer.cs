namespace Tadrees
{
    partial class TeacherClassesForm
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
            this.TeacherSchedule = new System.Windows.Forms.GroupBox();
            this.TeacherScheduleLabelMyClasses = new System.Windows.Forms.Label();
            this.TeacherScheduleLabelAddClasses = new System.Windows.Forms.Button();
            this.TeacherSchdeuleGridMyClasses = new System.Windows.Forms.DataGridView();
            this.TeacherSchdeuleClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherScheduleSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherScheduleCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherScheduleTimings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherScheduleDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherSchdeuleGridMyClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherSchedule
            // 
            this.TeacherSchedule.Controls.Add(this.TeacherSchdeuleGridMyClasses);
            this.TeacherSchedule.Controls.Add(this.TeacherScheduleLabelAddClasses);
            this.TeacherSchedule.Controls.Add(this.TeacherScheduleLabelMyClasses);
            this.TeacherSchedule.Location = new System.Drawing.Point(53, 44);
            this.TeacherSchedule.Name = "TeacherSchedule";
            this.TeacherSchedule.Size = new System.Drawing.Size(695, 362);
            this.TeacherSchedule.TabIndex = 6;
            this.TeacherSchedule.TabStop = false;
            this.TeacherSchedule.Text = "Teacher - My Classess";
            // 
            // TeacherScheduleLabelMyClasses
            // 
            this.TeacherScheduleLabelMyClasses.AutoSize = true;
            this.TeacherScheduleLabelMyClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherScheduleLabelMyClasses.Location = new System.Drawing.Point(268, 60);
            this.TeacherScheduleLabelMyClasses.Name = "TeacherScheduleLabelMyClasses";
            this.TeacherScheduleLabelMyClasses.Size = new System.Drawing.Size(146, 29);
            this.TeacherScheduleLabelMyClasses.TabIndex = 5;
            this.TeacherScheduleLabelMyClasses.Text = "My Classes";
            // 
            // TeacherScheduleLabelAddClasses
            // 
            this.TeacherScheduleLabelAddClasses.Location = new System.Drawing.Point(530, 322);
            this.TeacherScheduleLabelAddClasses.Name = "TeacherScheduleLabelAddClasses";
            this.TeacherScheduleLabelAddClasses.Size = new System.Drawing.Size(94, 25);
            this.TeacherScheduleLabelAddClasses.TabIndex = 7;
            this.TeacherScheduleLabelAddClasses.Text = "Add Classes";
            this.TeacherScheduleLabelAddClasses.UseVisualStyleBackColor = true;
            this.TeacherScheduleLabelAddClasses.Click += new System.EventHandler(this.AddClasses_Click);
            // 
            // TeacherSchdeuleGridMyClasses
            // 
            this.TeacherSchdeuleGridMyClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherSchdeuleGridMyClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherSchdeuleClassID,
            this.TeacherScheduleSubject,
            this.TeacherScheduleCapacity,
            this.TeacherScheduleTimings,
            this.TeacherScheduleDays});
            this.TeacherSchdeuleGridMyClasses.Location = new System.Drawing.Point(71, 113);
            this.TeacherSchdeuleGridMyClasses.Name = "TeacherSchdeuleGridMyClasses";
            this.TeacherSchdeuleGridMyClasses.RowTemplate.Height = 24;
            this.TeacherSchdeuleGridMyClasses.Size = new System.Drawing.Size(542, 181);
            this.TeacherSchdeuleGridMyClasses.TabIndex = 8;
            this.TeacherSchdeuleGridMyClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TeacherSchdeuleClassID
            // 
            this.TeacherSchdeuleClassID.HeaderText = "ClassID";
            this.TeacherSchdeuleClassID.Name = "TeacherSchdeuleClassID";
            // 
            // TeacherScheduleSubject
            // 
            this.TeacherScheduleSubject.HeaderText = "Subject";
            this.TeacherScheduleSubject.Name = "TeacherScheduleSubject";
            // 
            // TeacherScheduleCapacity
            // 
            this.TeacherScheduleCapacity.HeaderText = "Capacity";
            this.TeacherScheduleCapacity.Name = "TeacherScheduleCapacity";
            // 
            // TeacherScheduleTimings
            // 
            this.TeacherScheduleTimings.HeaderText = "Timings";
            this.TeacherScheduleTimings.Name = "TeacherScheduleTimings";
            // 
            // TeacherScheduleDays
            // 
            this.TeacherScheduleDays.HeaderText = "Days";
            this.TeacherScheduleDays.Name = "TeacherScheduleDays";
            // 
            // TeacherClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TeacherSchedule);
            this.Name = "TeacherClassesForm";
            this.Text = "Form1";
            this.TeacherSchedule.ResumeLayout(false);
            this.TeacherSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherSchdeuleGridMyClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TeacherSchedule;
        private System.Windows.Forms.Label TeacherScheduleLabelMyClasses;
        private System.Windows.Forms.Button TeacherScheduleLabelAddClasses;
        private System.Windows.Forms.DataGridView TeacherSchdeuleGridMyClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherSchdeuleClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherScheduleSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherScheduleCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherScheduleTimings;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherScheduleDays;
    }
}