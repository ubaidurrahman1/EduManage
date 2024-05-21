using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EduManage
{
    public partial class Student_reg_form : Form
    {
        public Student_reg_form()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Add_Student sab = new  Add_Student())
            {
                sab.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (UP up = new UP())
            {
                up.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Delete_student delt = new Delete_student())
            {
                delt.ShowDialog();
            }
        }

        private void Student_reg_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbedumangeDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dbedumangeDataSet.student);



        }
    }
}
