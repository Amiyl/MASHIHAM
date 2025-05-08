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
    public partial class frm_Task_List : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "EmployeeDB.accdb");
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EmployeeDB.accdb";
        public frm_Task_List()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome exit = new frmHome();
            exit.Show();
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {//**********

            try
            {

                //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EmployeeDB.accdb";

                string query = "INSERT INTO tasks ([taskTitle],[discription], [estimatedTime], [deadline],[AdminNote]) VALUES (@taskTitle, @discription, @estimatedTime, @deadline,@adminnote)";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@txtTaskTitle", txtTaskTitle.Text);
                        command.Parameters.AddWithValue("@discription", txtDescription.Text);
                        command.Parameters.AddWithValue("@estimatedTime", int.Parse(txt_EstimatedTime.Text));
                        command.Parameters.AddWithValue("@deadline", dateTimedeadline.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@adminnote", txtAdminNote.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Task Added");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //*********

        }

        private void frm_Task_Monitor_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }
        private void LoadTasks()
        {
            try
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tasks", connection);
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
        private void ClearAllTextBoxes()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }
        private void btn_Updater_Click(object sender, EventArgs e)
        {

            try
            {
                string queryupdate = "UPDATE Tasks SET [taskTitle] = @tasktitle, [discription] = @Discr, [estimatedTime] = @est, [deadline]=@DeadLine,[AdminNote]=@adminnote WHERE TaskID = @taskid";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(queryupdate, connection);
                        command.Parameters.AddWithValue("@tasktitle", txtTaskTitle.Text);
                        command.Parameters.AddWithValue("@Discr", txtDescription.Text);
                        command.Parameters.AddWithValue("@est", txt_EstimatedTime.Text);
                        command.Parameters.AddWithValue("@DeadLine", dateTimedeadline.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@adminnote", txtAdminNote.Text);
                        command.Parameters.AddWithValue("@taskid", txtTaskID.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Task updated");
                        ClearAllTextBoxes();
                        txtAdminNote.Text = "";
                        txtDescription.Text = "";
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
            LoadTasks();

        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not the header row
            {
                // Access the clicked row
                DataGridViewRow row = dataGridViewTasks.Rows[e.RowIndex];

                // Populate input fields
                txtTaskID.Text = row.Cells["TaskID"].Value?.ToString();
                txtTaskTitle.Text = row.Cells["taskTitle"].Value?.ToString();
                txtDescription.Text = row.Cells["discription"].Value?.ToString();
                txt_EstimatedTime.Text = row.Cells["estimatedTime"].Value?.ToString();
                dateTimedeadline.Value = DateTime.Parse(row.Cells["deadline"].Value.ToString());
                txtAdminNote.Text = row.Cells["AdminNote"].Value?.ToString();
            }
        }

        private void frm_Task_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
