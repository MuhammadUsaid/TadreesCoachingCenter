namespace Tadrees
{
    partial class SearchResultForm
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
            this.StudentSchdeuleGridMyClasses = new System.Windows.Forms.DataGridView();
            this.StudentSchdeuleClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentScheduleSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentScheduleTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentScheduleTimings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentScheduleDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentSchdeuleGridMyClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentSchdeuleGridMyClasses
            // 
            this.StudentSchdeuleGridMyClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentSchdeuleGridMyClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentSchdeuleClassID,
            this.StudentScheduleSubject,
            this.StudentScheduleTeacher,
            this.StudentScheduleTimings,
            this.StudentScheduleDays});
            this.StudentSchdeuleGridMyClasses.Location = new System.Drawing.Point(124, 181);
            this.StudentSchdeuleGridMyClasses.Name = "StudentSchdeuleGridMyClasses";
            this.StudentSchdeuleGridMyClasses.RowTemplate.Height = 24;
            this.StudentSchdeuleGridMyClasses.Size = new System.Drawing.Size(542, 181);
            this.StudentSchdeuleGridMyClasses.TabIndex = 12;
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
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentSchdeuleGridMyClasses);
            this.Name = "SearchResultForm";
            this.Text = "Search Results";
            ((System.ComponentModel.ISupportInitialize)(this.StudentSchdeuleGridMyClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentSchdeuleGridMyClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSchdeuleClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentScheduleSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentScheduleTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentScheduleTimings;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentScheduleDays;
    }
}