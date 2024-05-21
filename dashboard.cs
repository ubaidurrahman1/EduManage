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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void std_Click(object sender, EventArgs e)
        {
            using (Student_reg_form nwe = new EduManage.Student_reg_form())
            {
                nwe.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Employee_details emp  = new Employee_details())
            {
                emp.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Fee_details fee = new Fee_details())
            {
                fee.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (class_details cla = new  class_details())
            {
                cla.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (salary sla = new salary())
            {
                sla.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (parent_details pd = new parent_details())
            {
                pd.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
