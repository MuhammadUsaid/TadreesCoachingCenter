namespace Tadrees
{
    partial class StartForm
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
            this.LoginForm = new System.Windows.Forms.GroupBox();
            this.LoginTextBoxId = new System.Windows.Forms.TextBox();
            this.LoginTextBoxPassword = new System.Windows.Forms.TextBox();
            this.LoginLabelId = new System.Windows.Forms.Label();
            this.LoginLabelPassword = new System.Windows.Forms.Label();
            this.LoginButtonLogin = new System.Windows.Forms.Button();
            this.LoginComboBox = new System.Windows.Forms.ComboBox();
            this.SignUpStudent = new System.Windows.Forms.GroupBox();
            this.SignUpStudentTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.SignUpStudentTextBoxLastName = new System.Windows.Forms.TextBox();
            this.SignUpStudentTextBoxEmail = new System.Windows.Forms.TextBox();
            this.SignUpStudentTextBoxPassword = new System.Windows.Forms.TextBox();
            this.SignupStudentLabelLastName = new System.Windows.Forms.Label();
            this.SignupStudentLabelFirstName = new System.Windows.Forms.Label();
            this.SignupStudentLabelEmail = new System.Windows.Forms.Label();
            this.SignupStudentLabelPassword = new System.Windows.Forms.Label();
            this.SignUpStudentButtonSignUp = new System.Windows.Forms.Button();
            this.SignUpTeacher = new System.Windows.Forms.GroupBox();
            this.SignUpTeacherButtonSignUp = new System.Windows.Forms.Button();
            this.SignUpTeacherLabelPassword = new System.Windows.Forms.Label();
            this.SignUpTeacherLabelEmail = new System.Windows.Forms.Label();
            this.SignUpTeacherLabelLastName = new System.Windows.Forms.Label();
            this.SignUpTeacherLabelFirstName = new System.Windows.Forms.Label();
            this.SignUpTeacherTextBoxPassword = new System.Windows.Forms.TextBox();
            this.SignUpTeacherTextBoxEmail = new System.Windows.Forms.TextBox();
            this.SignUpTeacherTextBoxLastName = new System.Windows.Forms.TextBox();
            this.SignUpTeacherTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LoginForm.SuspendLayout();
            this.SignUpStudent.SuspendLayout();
            this.SignUpTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginForm
            // 
            this.LoginForm.Controls.Add(this.LoginComboBox);
            this.LoginForm.Controls.Add(this.LoginButtonLogin);
            this.LoginForm.Controls.Add(this.LoginLabelPassword);
            this.LoginForm.Controls.Add(this.LoginLabelId);
            this.LoginForm.Controls.Add(this.LoginTextBoxPassword);
            this.LoginForm.Controls.Add(this.LoginTextBoxId);
            this.LoginForm.Location = new System.Drawing.Point(27, 99);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Size = new System.Drawing.Size(1303, 69);
            this.LoginForm.TabIndex = 0;
            this.LoginForm.TabStop = false;
            this.LoginForm.Text = "LogIn";
            // 
            // LoginTextBoxId
            // 
            this.LoginTextBoxId.Location = new System.Drawing.Point(569, 28);
            this.LoginTextBoxId.Name = "LoginTextBoxId";
            this.LoginTextBoxId.Size = new System.Drawing.Size(181, 22);
            this.LoginTextBoxId.TabIndex = 0;
            this.LoginTextBoxId.UseWaitCursor = true;
            // 
            // LoginTextBoxPassword
            // 
            this.LoginTextBoxPassword.Location = new System.Drawing.Point(846, 28);
            this.LoginTextBoxPassword.Name = "LoginTextBoxPassword";
            this.LoginTextBoxPassword.Size = new System.Drawing.Size(181, 22);
            this.LoginTextBoxPassword.TabIndex = 1;
            this.LoginTextBoxPassword.UseWaitCursor = true;
            // 
            // LoginLabelId
            // 
            this.LoginLabelId.AutoSize = true;
            this.LoginLabelId.Location = new System.Drawing.Point(538, 31);
            this.LoginLabelId.Name = "LoginLabelId";
            this.LoginLabelId.Size = new System.Drawing.Size(25, 17);
            this.LoginLabelId.TabIndex = 2;
            this.LoginLabelId.Text = "ID:";
            // 
            // LoginLabelPassword
            // 
            this.LoginLabelPassword.AutoSize = true;
            this.LoginLabelPassword.Location = new System.Drawing.Point(767, 28);
            this.LoginLabelPassword.Name = "LoginLabelPassword";
            this.LoginLabelPassword.Size = new System.Drawing.Size(73, 17);
            this.LoginLabelPassword.TabIndex = 2;
            this.LoginLabelPassword.Text = "Password:";
            // 
            // LoginButtonLogin
            // 
            this.LoginButtonLogin.Location = new System.Drawing.Point(1198, 28);
            this.LoginButtonLogin.Name = "LoginButtonLogin";
            this.LoginButtonLogin.Size = new System.Drawing.Size(75, 25);
            this.LoginButtonLogin.TabIndex = 3;
            this.LoginButtonLogin.Text = "Login";
            this.LoginButtonLogin.UseVisualStyleBackColor = true;
            // 
            // LoginComboBox
            // 
            this.LoginComboBox.FormattingEnabled = true;
            this.LoginComboBox.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.LoginComboBox.Location = new System.Drawing.Point(1050, 28);
            this.LoginComboBox.Name = "LoginComboBox";
            this.LoginComboBox.Size = new System.Drawing.Size(121, 24);
            this.LoginComboBox.TabIndex = 2;
            this.LoginComboBox.Text = "Student";
            // 
            // SignUpStudent
            // 
            this.SignUpStudent.Controls.Add(this.SignUpStudentButtonSignUp);
            this.SignUpStudent.Controls.Add(this.SignupStudentLabelPassword);
            this.SignUpStudent.Controls.Add(this.SignupStudentLabelEmail);
            this.SignUpStudent.Controls.Add(this.SignupStudentLabelLastName);
            this.SignUpStudent.Controls.Add(this.SignupStudentLabelFirstName);
            this.SignUpStudent.Controls.Add(this.SignUpStudentTextBoxPassword);
            this.SignUpStudent.Controls.Add(this.SignUpStudentTextBoxEmail);
            this.SignUpStudent.Controls.Add(this.SignUpStudentTextBoxLastName);
            this.SignUpStudent.Controls.Add(this.SignUpStudentTextBoxFirstName);
            this.SignUpStudent.Location = new System.Drawing.Point(27, 192);
            this.SignUpStudent.Name = "SignUpStudent";
            this.SignUpStudent.Size = new System.Drawing.Size(456, 374);
            this.SignUpStudent.TabIndex = 1;
            this.SignUpStudent.TabStop = false;
            this.SignUpStudent.Text = "Student Signup";
            this.SignUpStudent.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SignUpStudentTextBoxFirstName
            // 
            this.SignUpStudentTextBoxFirstName.Location = new System.Drawing.Point(200, 39);
            this.SignUpStudentTextBoxFirstName.Name = "SignUpStudentTextBoxFirstName";
            this.SignUpStudentTextBoxFirstName.Size = new System.Drawing.Size(194, 22);
            this.SignUpStudentTextBoxFirstName.TabIndex = 1;
            // 
            // SignUpStudentTextBoxLastName
            // 
            this.SignUpStudentTextBoxLastName.Location = new System.Drawing.Point(200, 78);
            this.SignUpStudentTextBoxLastName.Name = "SignUpStudentTextBoxLastName";
            this.SignUpStudentTextBoxLastName.Size = new System.Drawing.Size(194, 22);
            this.SignUpStudentTextBoxLastName.TabIndex = 2;
            // 
            // SignUpStudentTextBoxEmail
            // 
            this.SignUpStudentTextBoxEmail.Location = new System.Drawing.Point(200, 124);
            this.SignUpStudentTextBoxEmail.Name = "SignUpStudentTextBoxEmail";
            this.SignUpStudentTextBoxEmail.Size = new System.Drawing.Size(194, 22);
            this.SignUpStudentTextBoxEmail.TabIndex = 3;
            this.SignUpStudentTextBoxEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SignUpStudentTextBoxPassword
            // 
            this.SignUpStudentTextBoxPassword.Location = new System.Drawing.Point(200, 172);
            this.SignUpStudentTextBoxPassword.Name = "SignUpStudentTextBoxPassword";
            this.SignUpStudentTextBoxPassword.Size = new System.Drawing.Size(194, 22);
            this.SignUpStudentTextBoxPassword.TabIndex = 4;
            // 
            // SignupStudentLabelLastName
            // 
            this.SignupStudentLabelLastName.AutoSize = true;
            this.SignupStudentLabelLastName.Location = new System.Drawing.Point(39, 83);
            this.SignupStudentLabelLastName.Name = "SignupStudentLabelLastName";
            this.SignupStudentLabelLastName.Size = new System.Drawing.Size(80, 17);
            this.SignupStudentLabelLastName.TabIndex = 3;
            this.SignupStudentLabelLastName.Text = "Last Name:";
            // 
            // SignupStudentLabelFirstName
            // 
            this.SignupStudentLabelFirstName.AutoSize = true;
            this.SignupStudentLabelFirstName.Location = new System.Drawing.Point(39, 39);
            this.SignupStudentLabelFirstName.Name = "SignupStudentLabelFirstName";
            this.SignupStudentLabelFirstName.Size = new System.Drawing.Size(80, 17);
            this.SignupStudentLabelFirstName.TabIndex = 4;
            this.SignupStudentLabelFirstName.Text = "First Name:";
            this.SignupStudentLabelFirstName.Click += new System.EventHandler(this.SignupStudentLabelFirstName_Click);
            // 
            // SignupStudentLabelEmail
            // 
            this.SignupStudentLabelEmail.AutoSize = true;
            this.SignupStudentLabelEmail.Location = new System.Drawing.Point(39, 129);
            this.SignupStudentLabelEmail.Name = "SignupStudentLabelEmail";
            this.SignupStudentLabelEmail.Size = new System.Drawing.Size(46, 17);
            this.SignupStudentLabelEmail.TabIndex = 7;
            this.SignupStudentLabelEmail.Text = "Email:";
            this.SignupStudentLabelEmail.Click += new System.EventHandler(this.SignupStudentLabelEmail_Click);
            // 
            // SignupStudentLabelPassword
            // 
            this.SignupStudentLabelPassword.AutoSize = true;
            this.SignupStudentLabelPassword.Location = new System.Drawing.Point(39, 177);
            this.SignupStudentLabelPassword.Name = "SignupStudentLabelPassword";
            this.SignupStudentLabelPassword.Size = new System.Drawing.Size(73, 17);
            this.SignupStudentLabelPassword.TabIndex = 8;
            this.SignupStudentLabelPassword.Text = "Password:";
            this.SignupStudentLabelPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // SignUpStudentButtonSignUp
            // 
            this.SignUpStudentButtonSignUp.Location = new System.Drawing.Point(319, 249);
            this.SignUpStudentButtonSignUp.Name = "SignUpStudentButtonSignUp";
            this.SignUpStudentButtonSignUp.Size = new System.Drawing.Size(75, 33);
            this.SignUpStudentButtonSignUp.TabIndex = 9;
            this.SignUpStudentButtonSignUp.Text = "SignUp";
            this.SignUpStudentButtonSignUp.UseVisualStyleBackColor = true;
            // 
            // SignUpTeacher
            // 
            this.SignUpTeacher.Controls.Add(this.SignUpTeacherButtonSignUp);
            this.SignUpTeacher.Controls.Add(this.SignUpTeacherLabelPassword);
            this.SignUpTeacher.Controls.Add(this.SignUpTeacherLabelEmail);
            this.SignUpTeacher.Controls.Add(this.SignUpTeacherLabelLastName);
            this.SignUpTeacher.Controls.Add(this.SignUpTeacherLabelFirstName);
            this.SignUpTeacher.Controls.Add(this.SignUpTeacherTextBoxPassword);
            this.SignUpTeacher.Controls.Add(this.SignUpTeacherTextBoxEmail);
            this.SignUpTeacher.Controls.Add(this.SignUpTeacherTextBoxLastName);
            this.SignUpTeacher.Controls.Add(this.SignUpTeacherTextBoxFirstName);
            this.SignUpTeacher.Location = new System.Drawing.Point(720, 213);
            this.SignUpTeacher.Name = "SignUpTeacher";
            this.SignUpTeacher.Size = new System.Drawing.Size(456, 374);
            this.SignUpTeacher.TabIndex = 3;
            this.SignUpTeacher.TabStop = false;
            this.SignUpTeacher.Text = "Teacher Signup";
            // 
            // SignUpTeacherButtonSignUp
            // 
            this.SignUpTeacherButtonSignUp.Location = new System.Drawing.Point(319, 249);
            this.SignUpTeacherButtonSignUp.Name = "SignUpTeacherButtonSignUp";
            this.SignUpTeacherButtonSignUp.Size = new System.Drawing.Size(75, 33);
            this.SignUpTeacherButtonSignUp.TabIndex = 9;
            this.SignUpTeacherButtonSignUp.Text = "SignUp";
            this.SignUpTeacherButtonSignUp.UseVisualStyleBackColor = true;
            // 
            // SignUpTeacherLabelPassword
            // 
            this.SignUpTeacherLabelPassword.AutoSize = true;
            this.SignUpTeacherLabelPassword.Location = new System.Drawing.Point(39, 177);
            this.SignUpTeacherLabelPassword.Name = "SignUpTeacherLabelPassword";
            this.SignUpTeacherLabelPassword.Size = new System.Drawing.Size(73, 17);
            this.SignUpTeacherLabelPassword.TabIndex = 8;
            this.SignUpTeacherLabelPassword.Text = "Password:";
            // 
            // SignUpTeacherLabelEmail
            // 
            this.SignUpTeacherLabelEmail.AutoSize = true;
            this.SignUpTeacherLabelEmail.Location = new System.Drawing.Point(39, 129);
            this.SignUpTeacherLabelEmail.Name = "SignUpTeacherLabelEmail";
            this.SignUpTeacherLabelEmail.Size = new System.Drawing.Size(46, 17);
            this.SignUpTeacherLabelEmail.TabIndex = 7;
            this.SignUpTeacherLabelEmail.Text = "Email:";
            // 
            // SignUpTeacherLabelLastName
            // 
            this.SignUpTeacherLabelLastName.AutoSize = true;
            this.SignUpTeacherLabelLastName.Location = new System.Drawing.Point(39, 83);
            this.SignUpTeacherLabelLastName.Name = "SignUpTeacherLabelLastName";
            this.SignUpTeacherLabelLastName.Size = new System.Drawing.Size(80, 17);
            this.SignUpTeacherLabelLastName.TabIndex = 3;
            this.SignUpTeacherLabelLastName.Text = "Last Name:";
            // 
            // SignUpTeacherLabelFirstName
            // 
            this.SignUpTeacherLabelFirstName.AutoSize = true;
            this.SignUpTeacherLabelFirstName.Location = new System.Drawing.Point(39, 39);
            this.SignUpTeacherLabelFirstName.Name = "SignUpTeacherLabelFirstName";
            this.SignUpTeacherLabelFirstName.Size = new System.Drawing.Size(80, 17);
            this.SignUpTeacherLabelFirstName.TabIndex = 4;
            this.SignUpTeacherLabelFirstName.Text = "First Name:";
            // 
            // SignUpTeacherTextBoxPassword
            // 
            this.SignUpTeacherTextBoxPassword.Location = new System.Drawing.Point(200, 172);
            this.SignUpTeacherTextBoxPassword.Name = "SignUpTeacherTextBoxPassword";
            this.SignUpTeacherTextBoxPassword.Size = new System.Drawing.Size(194, 22);
            this.SignUpTeacherTextBoxPassword.TabIndex = 4;
            // 
            // SignUpTeacherTextBoxEmail
            // 
            this.SignUpTeacherTextBoxEmail.Location = new System.Drawing.Point(200, 124);
            this.SignUpTeacherTextBoxEmail.Name = "SignUpTeacherTextBoxEmail";
            this.SignUpTeacherTextBoxEmail.Size = new System.Drawing.Size(194, 22);
            this.SignUpTeacherTextBoxEmail.TabIndex = 3;
            // 
            // SignUpTeacherTextBoxLastName
            // 
            this.SignUpTeacherTextBoxLastName.Location = new System.Drawing.Point(200, 78);
            this.SignUpTeacherTextBoxLastName.Name = "SignUpTeacherTextBoxLastName";
            this.SignUpTeacherTextBoxLastName.Size = new System.Drawing.Size(194, 22);
            this.SignUpTeacherTextBoxLastName.TabIndex = 2;
            // 
            // SignUpTeacherTextBoxFirstName
            // 
            this.SignUpTeacherTextBoxFirstName.Location = new System.Drawing.Point(200, 39);
            this.SignUpTeacherTextBoxFirstName.Name = "SignUpTeacherTextBoxFirstName";
            this.SignUpTeacherTextBoxFirstName.Size = new System.Drawing.Size(194, 22);
            this.SignUpTeacherTextBoxFirstName.TabIndex = 1;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 578);
            this.Controls.Add(this.SignUpTeacher);
            this.Controls.Add(this.SignUpStudent);
            this.Controls.Add(this.LoginForm);
            this.Name = "StartForm";
            this.Text = "Tadrees Online Coaching";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.LoginForm.ResumeLayout(false);
            this.LoginForm.PerformLayout();
            this.SignUpStudent.ResumeLayout(false);
            this.SignUpStudent.PerformLayout();
            this.SignUpTeacher.ResumeLayout(false);
            this.SignUpTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginForm;
        private System.Windows.Forms.ComboBox LoginComboBox;
        private System.Windows.Forms.Button LoginButtonLogin;
        private System.Windows.Forms.Label LoginLabelPassword;
        private System.Windows.Forms.Label LoginLabelId;
        private System.Windows.Forms.TextBox LoginTextBoxPassword;
        private System.Windows.Forms.TextBox LoginTextBoxId;
        private System.Windows.Forms.GroupBox SignUpStudent;
        private System.Windows.Forms.TextBox SignUpStudentTextBoxEmail;
        private System.Windows.Forms.TextBox SignUpStudentTextBoxLastName;
        private System.Windows.Forms.TextBox SignUpStudentTextBoxFirstName;
        private System.Windows.Forms.Label SignupStudentLabelFirstName;
        private System.Windows.Forms.TextBox SignUpStudentTextBoxPassword;
        private System.Windows.Forms.Label SignupStudentLabelLastName;
        private System.Windows.Forms.Label SignupStudentLabelPassword;
        private System.Windows.Forms.Label SignupStudentLabelEmail;
        private System.Windows.Forms.Button SignUpStudentButtonSignUp;
        private System.Windows.Forms.GroupBox SignUpTeacher;
        private System.Windows.Forms.Button SignUpTeacherButtonSignUp;
        private System.Windows.Forms.Label SignUpTeacherLabelPassword;
        private System.Windows.Forms.Label SignUpTeacherLabelEmail;
        private System.Windows.Forms.Label SignUpTeacherLabelLastName;
        private System.Windows.Forms.Label SignUpTeacherLabelFirstName;
        private System.Windows.Forms.TextBox SignUpTeacherTextBoxPassword;
        private System.Windows.Forms.TextBox SignUpTeacherTextBoxEmail;
        private System.Windows.Forms.TextBox SignUpTeacherTextBoxLastName;
        private System.Windows.Forms.TextBox SignUpTeacherTextBoxFirstName;
    }
}

