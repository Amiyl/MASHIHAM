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
using System.Xml.Linq;

namespace group_project
{
    public partial class frmUserTaskControl : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "EmployeeDB.accdb");
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EmployeeDB.accdb";
        public frmUserTaskControl()
        {
            InitializeComponent();
        }

        private void frmUserTaskControl_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {SharedData.Username}";
            LoadUserTasks();

        }
        private void LoadUserTasks()
        {
            try
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tasks where EmpID=" + $"{SharedData.UserId}", connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGv_user_task.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            ////to get the sum time for the user

            //connection.Open();
            //string querysum = "SELECT SUM(estimatedTime) AS TotalEstimatedTime FROM tasks WHERE EmpID = ?";

            //// Create the command with parameterized query
            //using (OleDbCommand command = new OleDbCommand(querysum, connection))
            //{
            //    // Add parameter for EmpID
            //    command.Parameters.AddWithValue("?", cmbEmployee.SelectedValue);

            //    // Execute the query and get the result
            //    object result = command.ExecuteScalar();

            //    // Check if result is not null and assign to the TextBox
            //    if (result != DBNull.Value)
            //    {
            //        lbl_totalTime.Text = result.ToString();
            //    }
            //    else
            //    {
            //        lbl_totalTime.Text = "0"; // Default value if no rows match
            //    }
            //}
            //connection.Close();
        }

        private void dataGv_user_task_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not the header row
            {
                // Access the clicked row
                DataGridViewRow row = dataGv_user_task.Rows[e.RowIndex];


                txtDiscreption.Text = row.Cells["discription"].Value?.ToString();
                txtAdminNote.Text = row.Cells["adminnote"].Value?.ToString();
                txtUserNote.Text = row.Cells["empnote"].Value?.ToString();
                lblTaskTitle.Text = row.Cells["taskTitle"].Value?.ToString();
                lblTaskID.Text = row.Cells["TaskID"].Value?.ToString();


            }
        }

        private void btnExcpt_Click(object sender, EventArgs e)
        {

            string queryupdate = "UPDATE Tasks SET [EmpDecision] = @decision WHERE TaskID = @taskid";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(queryupdate, connection);
                    command.Parameters.AddWithValue("@decision", "Yes");
                    command.Parameters.AddWithValue("@taskid", lblTaskID.Text);

                    command.ExecuteNonQuery();
                    //MessageBox.Show("Employee updated");
                    LoadUserTasks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            string queryupdate = "UPDATE Tasks SET [EmpDecision] = @decision WHERE ID = @id";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(queryupdate, connection);
                    command.Parameters.AddWithValue("@decision", "No");
                    command.Parameters.AddWithValue("@id", lblTaskID.Text);

                    command.ExecuteNonQuery();
                    //MessageBox.Show("Employee updated");
                    LoadUserTasks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {

            try
            {
                string queryupdate = "UPDATE Tasks SET [EmpNote] = @note WHERE TaskID = @taskid";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(queryupdate, connection);
                        command.Parameters.AddWithValue("@note", txtUserNote.Text);
                        command.Parameters.AddWithValue("@taskid", lblTaskID.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Task updated");
                        //ClearAllTextBoxes();
                        //txtAdminNote.Text = "";
                        //txtDescription.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            LoadUserTasks();


        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

            string queryupdate = "UPDATE Tasks SET [TaskStatus] = @decision WHERE TaskID = @taskid";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(queryupdate, connection);
                    command.Parameters.AddWithValue("@status", true);
                    command.Parameters.AddWithValue("@taskid", lblTaskID.Text);

                    command.ExecuteNonQuery();
                    //MessageBox.Show("Employee updated");
                    LoadUserTasks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadUserTasks();
        }

        private void btnRefuse_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


   

