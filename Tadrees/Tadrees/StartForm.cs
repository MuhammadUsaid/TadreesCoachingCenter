﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tadrees
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SignUpTeacher_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SignupStudentLabelEmail_Click(object sender, EventArgs e)
        {

        }

        private void SignupStudentLabelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void SignUpStudentButtonSignUp_Click(object sender, EventArgs e)
        {
            OpenClassesForm(SignupStudentComboBox.Text);
        }

        private void LoginButtonLogin_Click(object sender, EventArgs e)
        {
            OpenClassesForm(LoginComboBox.Text);
        }
        private void OpenClassesForm(string text)
        {
            if (text == "Student")
            {
                this.Hide();
                Form form = new StudentClassesForm();
                form.FormClosed += (s, args) => this.Close();
                form.Show();
            }
            else
            {
                this.Hide();
                Form form = new TeacherClassesForm();
                form.FormClosed += (s, args) => this.Close();
                form.Show();
            }
        }
    }
}
