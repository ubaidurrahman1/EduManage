using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EduManage
{
    public partial class Add_employee : Form
    {
        OleDbConnection emp = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ubaid\EduManage\dbedumange.mdb");
        public Add_employee()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emp.State == ConnectionState.Open)
                emp.Close();

            try
            {
                // Open the connection
                emp.Open();
                // Start with a very simple INSERT command inserting into only two fields
                string sql = "INSERT INTO employee (Name,Father_name,Phone_no,Address) VALUES (?,?,?,?)";
                using (OleDbCommand cmd = new OleDbCommand(sql, emp))
                {
                    // Add parameters to avoid SQL injection

                    cmd.Parameters.AddWithValue("Name",txtename.Text);  // Example parameter for 'name'
                  cmd.Parameters.AddWithValue("Father_name",txtefathername.Text);
                   cmd.Parameters.AddWithValue("Phone_no",txtephone.Text);
                cmd.Parameters.AddWithValue("Address",txteadress.Text);
                  

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
                if (emp.State == ConnectionState.Open)
                    emp.Close();
            }


        }
    }
    }

