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
    public partial class parent_details : Form
    {
        public parent_details()
        {
            InitializeComponent();
        }

        private void parent_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbedumangeDataSet.parent' table. You can move, or remove it, as needed.
            this.parentTableAdapter.Fill(this.dbedumangeDataSet.parent);

        }
    }
}
