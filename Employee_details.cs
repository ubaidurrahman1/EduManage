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
    public partial class Employee_details : Form
    {
        public Employee_details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Add_employee empl = new Add_employee())
            {
               empl.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using ( Update upd = new Update())
            {
                upd.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Delete_employee d = new Delete_employee())
            {
                d.ShowDialog();
            }
        }

        private void Employee_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbedumangeDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dbedumangeDataSet.employee);

        }
    }
}
