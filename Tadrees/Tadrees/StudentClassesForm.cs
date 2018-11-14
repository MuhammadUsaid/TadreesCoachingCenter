using System;
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
    public partial class StudentClassesForm : Form
    {
        public StudentClassesForm()
        {
            InitializeComponent();
        }

        private void SearchClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new StudentSearchForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
