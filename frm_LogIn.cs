using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group_project
{
    public partial class LoginForm : Form
    {
        
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "EmployeeDB.accdb");
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EmployeeDB.accdb";
        public LoginForm()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM employees WHERE EmpName = @username AND password = @password";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Check if a record is returned
                            {
                                // Retrieve the value of the 'admin' field
                                string adminStatus = reader["admin"].ToString();

                                if (adminStatus.Equals("true", StringComparison.OrdinalIgnoreCase))
                                {
                                    // Admin login
                                    this.Hide();
                                    new frmHome().Show();
                                }
                                else if (adminStatus.Equals("false", StringComparison.OrdinalIgnoreCase))
                                {
                                    // Regular user login
                                    this.Hide();
                                    OpenTaskControlForm(reader["EmpName"].ToString(), Convert.ToInt32(reader["EmployeeID"]));
                                }
                                else
                                {
                                    MessageBox.Show("Invalid admin status in the database.");
                                }
                            }
                            else
                            {
                                // No record found for the username and password
                                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void OpenTaskControlForm(string username, int userId)
        {
            SharedData.Username = username;
            SharedData.UserId = userId;

            frmUserTaskControl taskControlForm = new frmUserTaskControl();
            taskControlForm.Show();
        }
    }
}
