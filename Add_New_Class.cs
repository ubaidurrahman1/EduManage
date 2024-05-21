using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EduManage
{
    public partial class Add_New_Class : Form
    {
        OleDbConnection cls = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ubaid\EduManage\dbedumange.mdb");
        public Add_New_Class()
        {
            InitializeComponent();
        }

        private void Add_New_Class_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (cls.State == ConnectionState.Open)
                    cls.Close();

                try
                {
                    // Open the connection
                    cls.Open();
                    // Start with a very simple INSERT command inserting into only two fields
                    string sql = "INSERT INTO class details (Name) VALUES (?)";
                    using (OleDbCommand cmd = new OleDbCommand(sql, cls))
                    {
                        // Add parameters to avoid SQL injection

                        cmd.Parameters.AddWithValue("Name",textBox1.Text);  // Example parameter for 'name'
                      //  cmd.Parameters.AddWithValue("no of student",textBox2.Text);
                      //  cmd.Parameters.AddWithValue("no of chair",textBox3.Text);
                        //cmd.Parameters.AddWithValue("no of table",textBox4.Text);
                        //cmd.Parameters.AddWithValue("room no", textBox5.Text);

                        // Execute the query and get the number of rows affected
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} record(s) were inserted.", "Success");
                    }
                }
                catch (Exception ex)
                {
                    // Provide a detailed error message including the full exception
                    MessageBox.Show($"An error occurred while inserting the data: {ex.ToString()}", "Error");
                }
                finally
                {
                    // Ensure the connection is closed after the operation
                    if (cls.State == ConnectionState.Open)
                        cls.Close();
                }


            }
        }
    }
}
