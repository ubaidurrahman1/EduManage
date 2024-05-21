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
    public partial class Fee_details : Form
    {
        public Fee_details()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Fee_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbedumangeDataSet.fee' table. You can move, or remove it, as needed.
            this.feeTableAdapter.Fill(this.dbedumangeDataSet.fee);

        }
    }
}
