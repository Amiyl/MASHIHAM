using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group_project
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void asllTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Task_List frm_Task_Monitor = new frm_Task_List();
            frm_Task_Monitor.Show();
            this.Close();
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Task_List _Task = new frm_Task_List();
            _Task.Show();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void assignTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignTask assign_Task = new frmAssignTask();
            assign_Task.Show();
            this.Close();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
