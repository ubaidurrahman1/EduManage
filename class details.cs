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
    public partial class class_details : Form
    {
        public class_details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Add_New_Class anc = new Add_New_Class())
            {
                anc.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (update_class uc = new update_class())
            {
                uc.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Delete_class dc = new Delete_class())
            {
                dc.ShowDialog();
            }
        }

        private void class_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbedumangeDataSet.class_details' table. You can move, or remove it, as needed.
            this.class_detailsTableAdapter.Fill(this.dbedumangeDataSet.class_details);

        }
    }
}
