namespace Tadrees
{
    partial class TeacherSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherSearchForm));
            this.TeacherSearchPictureBox = new System.Windows.Forms.PictureBox();
            this.TeacherSearchLabel = new System.Windows.Forms.Label();
            this.MakeClass = new System.Windows.Forms.GroupBox();
            this.MakeClassLabelTimings = new System.Windows.Forms.Label();
            this.MakeClassClassCapacity = new System.Windows.Forms.Label();
            this.MakeClassComboBoxTimings = new System.Windows.Forms.ComboBox();
            this.MakeClassComboBoxClassCapacity = new System.Windows.Forms.ComboBox();
            this.MakeClassComboBoxDays = new System.Windows.Forms.ComboBox();
            this.MakeClassLabelDays = new System.Windows.Forms.Label();
            this.TeacherSearchButtonBack = new System.Windows.Forms.Button();
            this.MakeClassLabelClassLevel = new System.Windows.Forms.Label();
            this.MakeClassLabelSubjects = new System.Windows.Forms.Label();
            this.MakeClassLabelBoradName = new System.Windows.Forms.Label();
            this.MakeClassComboBoxClassLevel = new System.Windows.Forms.ComboBox();
            this.MakeClassComboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.MakeClassComboBoxBoardName = new System.Windows.Forms.ComboBox();
            this.TeacherSearchSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherSearchPictureBox)).BeginInit();
            this.MakeClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherSearchPictureBox
            // 
            this.TeacherSearchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TeacherSearchPictureBox.Image")));
            this.TeacherSearchPictureBox.Location = new System.Drawing.Point(13, 9);
            this.TeacherSearchPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherSearchPictureBox.Name = "TeacherSearchPictureBox";
            this.TeacherSearchPictureBox.Size = new System.Drawing.Size(100, 92);
            this.TeacherSearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TeacherSearchPictureBox.TabIndex = 14;
            this.TeacherSearchPictureBox.TabStop = false;
            // 
            // TeacherSearchLabel
            // 
            this.TeacherSearchLabel.AutoSize = true;
            this.TeacherSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.TeacherSearchLabel.ForeColor = System.Drawing.Color.Teal;
            this.TeacherSearchLabel.Location = new System.Drawing.Point(169, 34);
            this.TeacherSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeacherSearchLabel.Name = "TeacherSearchLabel";
            this.TeacherSearchLabel.Size = new System.Drawing.Size(697, 67);
            this.TeacherSearchLabel.TabIndex = 13;
            this.TeacherSearchLabel.Text = "Tadrees Virtual Coaching";
            // 
            // MakeClass
            // 
            this.MakeClass.Controls.Add(this.MakeClassLabelTimings);
            this.MakeClass.Controls.Add(this.MakeClassClassCapacity);
            this.MakeClass.Controls.Add(this.MakeClassComboBoxTimings);
            this.MakeClass.Controls.Add(this.MakeClassComboBoxClassCapacity);
            this.MakeClass.Controls.Add(this.MakeClassComboBoxDays);
            this.MakeClass.Controls.Add(this.MakeClassLabelDays);
            this.MakeClass.Controls.Add(this.TeacherSearchButtonBack);
            this.MakeClass.Controls.Add(this.MakeClassLabelClassLevel);
            this.MakeClass.Controls.Add(this.MakeClassLabelSubjects);
            this.MakeClass.Controls.Add(this.MakeClassLabelBoradName);
            this.MakeClass.Controls.Add(this.MakeClassComboBoxClassLevel);
            this.MakeClass.Controls.Add(this.MakeClassComboBoxSubjects);
            this.MakeClass.Controls.Add(this.MakeClassComboBoxBoardName);
            this.MakeClass.Controls.Add(this.TeacherSearchSearchButton);
            this.MakeClass.Location = new System.Drawing.Point(306, 120);
            this.MakeClass.Margin = new System.Windows.Forms.Padding(4);
            this.MakeClass.Name = "MakeClass";
            this.MakeClass.Padding = new System.Windows.Forms.Padding(4);
            this.MakeClass.Size = new System.Drawing.Size(440, 569);
            this.MakeClass.TabIndex = 12;
            this.MakeClass.TabStop = false;
            this.MakeClass.Text = "Make Class";
            // 
            // MakeClassLabelTimings
            // 
            this.MakeClassLabelTimings.AutoSize = true;
            this.MakeClassLabelTimings.Location = new System.Drawing.Point(40, 316);
            this.MakeClassLabelTimings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MakeClassLabelTimings.Name = "MakeClassLabelTimings";
            this.MakeClassLabelTimings.Size = new System.Drawing.Size(61, 17);
            this.MakeClassLabelTimings.TabIndex = 9;
            this.MakeClassLabelTimings.Text = "Timings:";
            // 
            // MakeClassClassCapacity
            // 
            this.MakeClassClassCapacity.AutoSize = true;
            this.MakeClassClassCapacity.Location = new System.Drawing.Point(40, 388);
            this.MakeClassClassCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MakeClassClassCapacity.Name = "MakeClassClassCapacity";
            this.MakeClassClassCapacity.Size = new System.Drawing.Size(112, 17);
            this.MakeClassClassCapacity.TabIndex = 11;
            this.MakeClassClassCapacity.Text = "Class Capapcity:";
            // 
            // MakeClassComboBoxTimings
            // 
            this.MakeClassComboBoxTimings.FormattingEnabled = true;
            this.MakeClassComboBoxTimings.Items.AddRange(new object[] {
            "Agha Khan Education Board",
            "Cambridge Board",
            "Federal Board",
            "Sindh Board"});
            this.MakeClassComboBoxTimings.Location = new System.Drawing.Point(155, 306);
            this.MakeClassComboBoxTimings.Margin = new System.Windows.Forms.Padding(4);
            this.MakeClassComboBoxTimings.Name = "MakeClassComboBoxTimings";
            this.MakeClassComboBoxTimings.Size = new System.Drawing.Size(213, 24);
            this.MakeClassComboBoxTimings.TabIndex = 10;
            // 
            // MakeClassComboBoxClassCapacity
            // 
            this.MakeClassComboBoxClassCapacity.FormattingEnabled = true;
            this.MakeClassComboBoxClassCapacity.Items.AddRange(new object[] {
            "Agha Khan Education Board",
            "Cambridge Board",
            "Federal Board",
            "Sindh Board"});
            this.MakeClassComboBoxClassCapacity.Location = new System.Drawing.Point(155, 378);
            this.MakeClassComboBoxClassCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.MakeClassComboBoxClassCapacity.Name = "MakeClassComboBoxClassCapacity";
            this.MakeClassComboBoxClassCapacity.Size = new System.Drawing.Size(213, 24);
            this.MakeClassComboBoxClassCapacity.TabIndex = 12;
            // 
            // MakeClassComboBoxDays
            // 
            this.MakeClassComboBoxDays.FormattingEnabled = true;
            this.MakeClassComboBoxDays.Items.AddRange(new object[] {
            "Agha Khan Education Board",
            "Cambridge Board",
            "Federal Board",
            "Sindh Board"});
            this.MakeClassComboBoxDays.Location = new System.Drawing.Point(155, 236);
            this.MakeClassComboBoxDays.Margin = new System.Windows.Forms.Padding(4);
            this.MakeClassComboBoxDays.Name = "MakeClassComboBoxDays";
            this.MakeClassComboBoxDays.Size = new System.Drawing.Size(213, 24);
            this.MakeClassComboBoxDays.TabIndex = 8;
            // 
            // MakeClassLabelDays
            // 
            this.MakeClassLabelDays.AutoSize = true;
            this.MakeClassLabelDays.Location = new System.Drawing.Point(40, 246);
            this.MakeClassLabelDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MakeClassLabelDays.Name = "MakeClassLabelDays";
            this.MakeClassLabelDays.Size = new System.Drawing.Size(44, 17);
            this.MakeClassLabelDays.TabIndex = 7;
            this.MakeClassLabelDays.Text = "Days:";
            // 
            // TeacherSearchButtonBack
            // 
            this.TeacherSearchButtonBack.Location = new System.Drawing.Point(31, 474);
            this.TeacherSearchButtonBack.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherSearchButtonBack.Name = "TeacherSearchButtonBack";
            this.TeacherSearchButtonBack.Size = new System.Drawing.Size(123, 28);
            this.TeacherSearchButtonBack.TabIndex = 14;
            this.TeacherSearchButtonBack.Text = "Back";
            this.TeacherSearchButtonBack.UseVisualStyleBackColor = true;
            // 
            // MakeClassLabelClassLevel
            // 
            this.MakeClassLabelClassLevel.AutoSize = true;
            this.MakeClassLabelClassLevel.Location = new System.Drawing.Point(40, 175);
            this.MakeClassLabelClassLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MakeClassLabelClassLevel.Name = "MakeClassLabelClassLevel";
            this.MakeClassLabelClassLevel.Size = new System.Drawing.Size(84, 17);
            this.MakeClassLabelClassLevel.TabIndex = 5;
            this.MakeClassLabelClassLevel.Text = "Class Level:";
            // 
            // MakeClassLabelSubjects
            // 
            this.MakeClassLabelSubjects.AutoSize = true;
            this.MakeClassLabelSubjects.Location = new System.Drawing.Point(40, 107);
            this.MakeClassLabelSubjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MakeClassLabelSubjects.Name = "MakeClassLabelSubjects";
            this.MakeClassLabelSubjects.Size = new System.Drawing.Size(66, 17);
            this.MakeClassLabelSubjects.TabIndex = 3;
            this.MakeClassLabelSubjects.Text = "Subjects:";
            // 
            // MakeClassLabelBoradName
            // 
            this.MakeClassLabelBoradName.AutoSize = true;
            this.MakeClassLabelBoradName.Location = new System.Drawing.Point(40, 46);
            this.MakeClassLabelBoradName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MakeClassLabelBoradName.Name = "MakeClassLabelBoradName";
            this.MakeClassLabelBoradName.Size = new System.Drawing.Size(91, 17);
            this.MakeClassLabelBoradName.TabIndex = 1;
            this.MakeClassLabelBoradName.Text = "Board Name:";
            // 
            // MakeClassComboBoxClassLevel
            // 
            this.MakeClassComboBoxClassLevel.Items.AddRange(new object[] {
            "Agha Khan Education Board",
            "Cambridge Board",
            "Federal Board",
            "Sindh Board"});
            this.MakeClassComboBoxClassLevel.Location = new System.Drawing.Point(155, 165);
            this.MakeClassComboBoxClassLevel.Margin = new System.Windows.Forms.Padding(4);
            this.MakeClassComboBoxClassLevel.Name = "MakeClassComboBoxClassLevel";
            this.MakeClassComboBoxClassLevel.Size = new System.Drawing.Size(213, 24);
            this.MakeClassComboBoxClassLevel.TabIndex = 6;
            // 
            // MakeClassComboBoxSubjects
            // 
            this.MakeClassComboBoxSubjects.FormattingEnabled = true;
            this.MakeClassComboBoxSubjects.Items.AddRange(new object[] {
            "Agha Khan Education Board",
            "Cambridge Board",
            "Federal Board",
            "Sindh Board"});
            this.MakeClassComboBoxSubjects.Location = new System.Drawing.Point(155, 97);
            this.MakeClassComboBoxSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.MakeClassComboBoxSubjects.Name = "MakeClassComboBoxSubjects";
            this.MakeClassComboBoxSubjects.Size = new System.Drawing.Size(213, 24);
            this.MakeClassComboBoxSubjects.TabIndex = 4;
            // 
            // MakeClassComboBoxBoardName
            // 
            this.MakeClassComboBoxBoardName.FormattingEnabled = true;
            this.MakeClassComboBoxBoardName.Items.AddRange(new object[] {
            "Agha Khan Education Board",
            "Cambridge Board",
            "Federal Board",
            "Sindh Board"});
            this.MakeClassComboBoxBoardName.Location = new System.Drawing.Point(155, 42);
            this.MakeClassComboBoxBoardName.Margin = new System.Windows.Forms.Padding(4);
            this.MakeClassComboBoxBoardName.Name = "MakeClassComboBoxBoardName";
            this.MakeClassComboBoxBoardName.Size = new System.Drawing.Size(213, 24);
            this.MakeClassComboBoxBoardName.TabIndex = 2;
            // 
            // TeacherSearchSearchButton
            // 
            this.TeacherSearchSearchButton.Location = new System.Drawing.Point(247, 474);
            this.TeacherSearchSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherSearchSearchButton.Name = "TeacherSearchSearchButton";
            this.TeacherSearchSearchButton.Size = new System.Drawing.Size(123, 28);
            this.TeacherSearchSearchButton.TabIndex = 13;
            this.TeacherSearchSearchButton.Text = "Search";
            this.TeacherSearchSearchButton.UseVisualStyleBackColor = true;
            // 
            // TeacherSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 656);
            this.Controls.Add(this.TeacherSearchPictureBox);
            this.Controls.Add(this.TeacherSearchLabel);
            this.Controls.Add(this.MakeClass);
            this.Name = "TeacherSearchForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TeacherSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherSearchPictureBox)).EndInit();
            this.MakeClass.ResumeLayout(false);
            this.MakeClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TeacherSearchPictureBox;
        private System.Windows.Forms.Label TeacherSearchLabel;
        private System.Windows.Forms.GroupBox MakeClass;
        private System.Windows.Forms.Label MakeClassLabelTimings;
        private System.Windows.Forms.Label MakeClassClassCapacity;
        private System.Windows.Forms.ComboBox MakeClassComboBoxTimings;
        private System.Windows.Forms.ComboBox MakeClassComboBoxClassCapacity;
        private System.Windows.Forms.ComboBox MakeClassComboBoxDays;
        private System.Windows.Forms.Label MakeClassLabelDays;
        private System.Windows.Forms.Button TeacherSearchButtonBack;
        private System.Windows.Forms.Label MakeClassLabelClassLevel;
        private System.Windows.Forms.Label MakeClassLabelSubjects;
        private System.Windows.Forms.Label MakeClassLabelBoradName;
        private System.Windows.Forms.ComboBox MakeClassComboBoxClassLevel;
        private System.Windows.Forms.ComboBox MakeClassComboBoxSubjects;
        private System.Windows.Forms.ComboBox MakeClassComboBoxBoardName;
        private System.Windows.Forms.Button TeacherSearchSearchButton;
    }
}