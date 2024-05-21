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
    public partial class Delete_class : Form
    {
        public Delete_class()
        {
            InitializeComponent();
        }

        private void Delete_class_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbedumangeDataSet.class_details' table. You can move, or remove it, as needed.
            this.class_detailsTableAdapter.Fill(this.dbedumangeDataSet.class_details);

        }
    }
}
