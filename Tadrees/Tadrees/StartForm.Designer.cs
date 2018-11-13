﻿namespace Tadrees
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
            this.LoginComboBox = new System.Windows.Forms.ComboBox();
            this.LoginButtonLogin = new System.Windows.Forms.Button();
            this.LoginLabelPassword = new System.Windows.Forms.Label();
            this.LoginLabelId = new System.Windows.Forms.Label();
            this.LoginTextBoxPassword = new System.Windows.Forms.TextBox();
            this.LoginTextBoxId = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.GroupBox();
            this.SignUpStudentButtonSignUp = new System.Windows.Forms.Button();
            this.SignupStudentLabelPassword = new System.Windows.Forms.Label();
            this.SignupStudentLabelEmail = new System.Windows.Forms.Label();
            this.SignupStudentLabelLastName = new System.Windows.Forms.Label();
            this.SignupStudentLabelFirstName = new System.Windows.Forms.Label();
            this.SignUpStudentTextBoxPassword = new System.Windows.Forms.TextBox();
            this.SignUpStudentTextBoxEmail = new System.Windows.Forms.TextBox();
            this.SignUpStudentTextBoxLastName = new System.Windows.Forms.TextBox();
            this.SignUpStudentTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LoginForm.SuspendLayout();
            this.SignUp.SuspendLayout();
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
            this.LoginForm.Location = new System.Drawing.Point(199, 117);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Size = new System.Drawing.Size(887, 69);
            this.LoginForm.TabIndex = 0;
            this.LoginForm.TabStop = false;
            this.LoginForm.Text = "LogIn";
            // 
            // LoginComboBox
            // 
            this.LoginComboBox.FormattingEnabled = true;
            this.LoginComboBox.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.LoginComboBox.Location = new System.Drawing.Point(646, 25);
            this.LoginComboBox.Name = "LoginComboBox";
            this.LoginComboBox.Size = new System.Drawing.Size(121, 24);
            this.LoginComboBox.TabIndex = 2;
            this.LoginComboBox.Text = "Student";
            // 
            // LoginButtonLogin
            // 
            this.LoginButtonLogin.Location = new System.Drawing.Point(794, 25);
            this.LoginButtonLogin.Name = "LoginButtonLogin";
            this.LoginButtonLogin.Size = new System.Drawing.Size(75, 25);
            this.LoginButtonLogin.TabIndex = 3;
            this.LoginButtonLogin.Text = "Login";
            this.LoginButtonLogin.UseVisualStyleBackColor = true;
            // 
            // LoginLabelPassword
            // 
            this.LoginLabelPassword.AutoSize = true;
            this.LoginLabelPassword.Location = new System.Drawing.Point(363, 25);
            this.LoginLabelPassword.Name = "LoginLabelPassword";
            this.LoginLabelPassword.Size = new System.Drawing.Size(73, 17);
            this.LoginLabelPassword.TabIndex = 2;
            this.LoginLabelPassword.Text = "Password:";
            // 
            // LoginLabelId
            // 
            this.LoginLabelId.AutoSize = true;
            this.LoginLabelId.Location = new System.Drawing.Point(134, 28);
            this.LoginLabelId.Name = "LoginLabelId";
            this.LoginLabelId.Size = new System.Drawing.Size(25, 17);
            this.LoginLabelId.TabIndex = 2;
            this.LoginLabelId.Text = "ID:";
            // 
            // LoginTextBoxPassword
            // 
            this.LoginTextBoxPassword.Location = new System.Drawing.Point(442, 25);
            this.LoginTextBoxPassword.Name = "LoginTextBoxPassword";
            this.LoginTextBoxPassword.Size = new System.Drawing.Size(181, 22);
            this.LoginTextBoxPassword.TabIndex = 1;
            this.LoginTextBoxPassword.UseWaitCursor = true;
            // 
            // LoginTextBoxId
            // 
            this.LoginTextBoxId.Location = new System.Drawing.Point(165, 25);
            this.LoginTextBoxId.Name = "LoginTextBoxId";
            this.LoginTextBoxId.Size = new System.Drawing.Size(181, 22);
            this.LoginTextBoxId.TabIndex = 0;
            this.LoginTextBoxId.UseWaitCursor = true;
            // 
            // SignUp
            // 
            this.SignUp.Controls.Add(this.SignUpStudentButtonSignUp);
            this.SignUp.Controls.Add(this.SignupStudentLabelPassword);
            this.SignUp.Controls.Add(this.SignupStudentLabelEmail);
            this.SignUp.Controls.Add(this.SignupStudentLabelLastName);
            this.SignUp.Controls.Add(this.SignupStudentLabelFirstName);
            this.SignUp.Controls.Add(this.SignUpStudentTextBoxPassword);
            this.SignUp.Controls.Add(this.SignUpStudentTextBoxEmail);
            this.SignUp.Controls.Add(this.SignUpStudentTextBoxLastName);
            this.SignUp.Controls.Add(this.SignUpStudentTextBoxFirstName);
            this.SignUp.Location = new System.Drawing.Point(443, 192);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(456, 374);
            this.SignUp.TabIndex = 1;
            this.SignUp.TabStop = false;
            this.SignUp.Text = "Signup";
            this.SignUp.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // SignUpStudentTextBoxPassword
            // 
            this.SignUpStudentTextBoxPassword.Location = new System.Drawing.Point(200, 172);
            this.SignUpStudentTextBoxPassword.Name = "SignUpStudentTextBoxPassword";
            this.SignUpStudentTextBoxPassword.PasswordChar = '*';
            this.SignUpStudentTextBoxPassword.Size = new System.Drawing.Size(194, 22);
            this.SignUpStudentTextBoxPassword.TabIndex = 4;
            // 
            // SignUpStudentTextBoxEmail
            // 
            this.SignUpStudentTextBoxEmail.Location = new System.Drawing.Point(200, 124);
            this.SignUpStudentTextBoxEmail.Name = "SignUpStudentTextBoxEmail";
            this.SignUpStudentTextBoxEmail.Size = new System.Drawing.Size(194, 22);
            this.SignUpStudentTextBoxEmail.TabIndex = 3;
            this.SignUpStudentTextBoxEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SignUpStudentTextBoxLastName
            // 
            this.SignUpStudentTextBoxLastName.Location = new System.Drawing.Point(200, 78);
            this.SignUpStudentTextBoxLastName.Name = "SignUpStudentTextBoxLastName";
            this.SignUpStudentTextBoxLastName.Size = new System.Drawing.Size(194, 22);
            this.SignUpStudentTextBoxLastName.TabIndex = 2;
            // 
            // SignUpStudentTextBoxFirstName
            // 
            this.SignUpStudentTextBoxFirstName.Location = new System.Drawing.Point(200, 39);
            this.SignUpStudentTextBoxFirstName.Name = "SignUpStudentTextBoxFirstName";
            this.SignUpStudentTextBoxFirstName.Size = new System.Drawing.Size(194, 22);
            this.SignUpStudentTextBoxFirstName.TabIndex = 1;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 578);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.LoginForm);
            this.Name = "StartForm";
            this.Text = "Tadrees Online Coaching";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.LoginForm.ResumeLayout(false);
            this.LoginForm.PerformLayout();
            this.SignUp.ResumeLayout(false);
            this.SignUp.PerformLayout();
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
        private System.Windows.Forms.GroupBox SignUp;
        private System.Windows.Forms.TextBox SignUpStudentTextBoxEmail;
        private System.Windows.Forms.TextBox SignUpStudentTextBoxLastName;
        private System.Windows.Forms.TextBox SignUpStudentTextBoxFirstName;
        private System.Windows.Forms.Label SignupStudentLabelFirstName;
        private System.Windows.Forms.TextBox SignUpStudentTextBoxPassword;
        private System.Windows.Forms.Label SignupStudentLabelLastName;
        private System.Windows.Forms.Label SignupStudentLabelPassword;
        private System.Windows.Forms.Label SignupStudentLabelEmail;
        private System.Windows.Forms.Button SignUpStudentButtonSignUp;
    }
}

