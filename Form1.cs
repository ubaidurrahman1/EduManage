using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EduManage
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string Username = textBox3.Text;
            string password = textBox4.Text;
         
            if (Username == "ubaid" && password == "1234")
            {
                MessageBox.Show("Login in successful");                         
            using (dashboard dashboard = new dashboard())
                {
                    dashboard.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("failed");
            }
          
        }
    }
}
