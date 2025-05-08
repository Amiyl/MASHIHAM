using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace group_project
{

    public partial class EmployeeForm : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "EmployeeDB.accdb");
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EmployeeDB.accdb";
        public EmployeeForm()
        {
            InitializeComponent();

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Employees", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewEmployees.DataSource = dt;
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

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EmployeeDB.accdb";

                string query = "INSERT INTO Employees ([EmpName], [Position], [Salary],[Admin]) VALUES (@name, @position, @salary,@admin)";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@position", txtPosition.Text);
                        command.Parameters.AddWithValue("@salary", txtSalary.Text);
                        command.Parameters.AddWithValue("@admin", chbxAdmin.CheckState);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Employee Added");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                LoadEmployees();
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

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string queryupdate = "UPDATE Employees SET [EmpName] = @name, [Position] = @position, [Salary] = @salary WHERE EmployeeID = @id";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(queryupdate, connection);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@position", txtPosition.Text);
                        command.Parameters.AddWithValue("@salary", txtSalary.Text);
                        command.Parameters.AddWithValue("@id", txtEmployeeID.Text);
                        command.ExecuteNonQuery();
                        //MessageBox.Show("Employee updated");
                        ClearAllTextBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                LoadEmployees();


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

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not the header row
            {
                // Access the clicked row
                DataGridViewRow row = dataGridViewEmployees.Rows[e.RowIndex];

                // Populate input fields
                txtEmployeeID.Text = row.Cells["EmployeeID"].Value?.ToString();
                txtName.Text = row.Cells["EmpName"].Value?.ToString();
                txtPosition.Text = row.Cells["Position"].Value?.ToString();
                txtSalary.Text = row.Cells["Salary"].Value?.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("DELETE FROM Employees WHERE EmployeeID = @id", connection);
                command.Parameters.AddWithValue("@id", txtEmployeeID.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted");
                connection.Close();
                LoadEmployees();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFormIfNotOpen();
        }
        private void OpenFormIfNotOpen()
        {
            // Check if the form is already open
            bool isFormOpen = false;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "EmployeeForm") // Replace with the actual name of your form
                {
                    isFormOpen = true;
                    openForm.BringToFront(); // Make it active (bring it to the front)
                    break;
                }
            }

            if (!isFormOpen)
            {
                // If the form is not open, create a new instance and show it
                EmployeeForm myForm = new EmployeeForm(); // Replace MyForm with your form class
                myForm.Show();
            }
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Task_List frm_Task_Monitor = new frm_Task_List();
            frm_Task_Monitor.Show();
            //this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            //this.Close();
        }

        private void homeToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
