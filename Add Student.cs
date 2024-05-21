using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EduManage
{
    public partial class Add_Student : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ubaid\EduManage\dbedumange.mdb");

        public Add_Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ensure the connection is closed if previously opened
            if (conn.State == ConnectionState.Open)
                conn.Close();

            try
            {
                // Open the connection
                conn.Open();
                // Start with a very simple INSERT command inserting into only two fields
                string sql = "INSERT INTO student (name,Father_name,Gender,DOB, Phone_no,F_Occuption,Class,Address,City) VALUES (?,?,?,?,?,?, ?,?,?)";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    // Add parameters to avoid SQL injection
                    
                    cmd.Parameters.AddWithValue("name", txtname.Text);  // Example parameter for 'name'
                    cmd.Parameters.AddWithValue("Father_name", txtfather.Text);
                    cmd.Parameters.AddWithValue("Gender", txtgender.Text);
                    cmd.Parameters.AddWithValue("DOB", txtdob.Text);
                    cmd.Parameters.AddWithValue("Phone_no", txtphone.Text);
                    cmd.Parameters.AddWithValue("F_Occuption", txtf_occ.Text);
                    cmd.Parameters.AddWithValue("Class",txtclass.Text);
                    cmd.Parameters.AddWithValue("Address",txtaddress.Text);
                    cmd.Parameters.AddWithValue("City", txtcity.Text);

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
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

          
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }
    }
}