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
    public partial class Delete_employee : Form
    {
        public Delete_employee()
        {
            InitializeComponent();
        }

        private void Delete_employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbedumangeDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dbedumangeDataSet.employee);

        }
    }
}
