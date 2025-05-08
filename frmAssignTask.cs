using System;
using System.Collections;
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
    public partial class frmAssignTask : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "EmployeeDB.accdb");
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EmployeeDB.accdb";
        public frmAssignTask()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void frmAssignTask_Load(object sender, EventArgs e)
        {
            LoadTasks();
            loadUsers();
        }
        private void LoadTasks()
        {
            try
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tasks where EmpID=0", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewTasks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void loadUsers()
        {
            connection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM employees", connection);

            try
            {

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbEmployee.DataSource = dt;
                DataRow placeholderRow = dt.NewRow();
                placeholderRow["EmployeeID"] = -1; // Placeholder value
                placeholderRow["EmpName"] = "Select User"; // Placeholder text
                dt.Rows.InsertAt(placeholderRow, 0); // Insert at the top

                cmbEmployee.DisplayMember = "EmpName";
                cmbEmployee.ValueMember = "EmployeeID";
                cmbEmployee.Refresh();
                cmbEmployee.SelectedValue = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not the header row
            {
                // Access the clicked row
                DataGridViewRow row = dataGridViewTasks.Rows[e.RowIndex];


                txt_taskdiscreption.Text = row.Cells["discription"].Value?.ToString();
                lbl_taskID.Text = row.Cells["TaskID"].Value?.ToString();
                lbl_taskTitle.Text = row.Cells["taskTitle"].Value?.ToString();

            }
        }

        private void frmAssignTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            try
            {
                string queryupdate = "UPDATE Tasks SET [EmpID] = @empID WHERE TaskID = @taskid";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(queryupdate, connection);
                        command.Parameters.AddWithValue("@empID", cmbEmployee.SelectedValue);
                        command.Parameters.AddWithValue("@taskid", lbl_taskID.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("task updated");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                LoadTasks();
                LoadUserTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadUserTasks()
        {
            try
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tasks where EmpID=" + cmbEmployee.SelectedValue, connection);

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

            //to get the sum time for the user

            connection.Open();
            string querysum = "SELECT SUM(estimatedTime) AS TotalEstimatedTime FROM tasks WHERE EmpID = ?";

            // Create the command with parameterized query
            using (OleDbCommand command = new OleDbCommand(querysum, connection))
            {
                // Add parameter for EmpID
                command.Parameters.AddWithValue("?", cmbEmployee.SelectedValue);

                // Execute the query and get the result
                object result = command.ExecuteScalar();

                // Check if result is not null and assign to the TextBox
                if (result != DBNull.Value)
                {
                    lbl_totalTime.Text = result.ToString();
                }
                else
                {
                    lbl_totalTime.Text = "0"; // Default value if no rows match
                }
            }
            connection.Close();
        }

        private void cmbEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex != -1)
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); };
                LoadUserTasks();

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void dataGridViewTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            //this.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
