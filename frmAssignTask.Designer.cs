namespace group_project
{
    partial class frmAssignTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignTask));
            lbl_totalTime = new Label();
            label2 = new Label();
            cmbEmployee = new ComboBox();
            lbl_Employee_Selection = new Label();
            dataGridViewTasks = new DataGridView();
            btnAssignTask = new Button();
            button2 = new Button();
            btnExit = new Button();
            label1 = new Label();
            lbl_task = new Label();
            txt_taskdiscreption = new RichTextBox();
            lbl_taskID = new Label();
            lbl_taskTitle = new Label();
            lblTaskidName = new Label();
            lbl_Unassignd = new Label();
            dataGv_user_task = new DataGridView();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            companyInfoToolStripMenuItem = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            addTaskToolStripMenuItem = new ToolStripMenuItem();
            assignTaskToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGv_user_task).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_totalTime
            // 
            lbl_totalTime.AutoSize = true;
            lbl_totalTime.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbl_totalTime.Location = new Point(194, 267);
            lbl_totalTime.Name = "lbl_totalTime";
            lbl_totalTime.Size = new Size(0, 25);
            lbl_totalTime.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label2.Location = new Point(61, 267);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 52;
            label2.Text = "total time assigned";
            // 
            // cmbEmployee
            // 
            cmbEmployee.Font = new Font("Franklin Gothic Medium Cond", 12F);
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(193, 204);
            cmbEmployee.Margin = new Padding(3, 4, 3, 4);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(250, 33);
            cmbEmployee.TabIndex = 51;
            cmbEmployee.SelectedIndexChanged += cmbEmployee_SelectedIndexChanged;
            cmbEmployee.SelectionChangeCommitted += cmbEmployee_SelectionChangeCommitted;
            // 
            // lbl_Employee_Selection
            // 
            lbl_Employee_Selection.AutoSize = true;
            lbl_Employee_Selection.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbl_Employee_Selection.Location = new Point(61, 208);
            lbl_Employee_Selection.Name = "lbl_Employee_Selection";
            lbl_Employee_Selection.Size = new Size(154, 25);
            lbl_Employee_Selection.TabIndex = 50;
            lbl_Employee_Selection.Text = "Employee Selection";
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(450, 480);
            dataGridViewTasks.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewTasks.Size = new Size(576, 237);
            dataGridViewTasks.TabIndex = 54;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            dataGridViewTasks.CellContentClick += dataGridViewTasks_CellContentClick;
            // 
            // btnAssignTask
            // 
            btnAssignTask.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnAssignTask.Location = new Point(109, 675);
            btnAssignTask.Margin = new Padding(3, 4, 3, 4);
            btnAssignTask.Name = "btnAssignTask";
            btnAssignTask.Size = new Size(86, 43);
            btnAssignTask.TabIndex = 55;
            btnAssignTask.Text = "Assign Task";
            btnAssignTask.UseVisualStyleBackColor = true;
            btnAssignTask.Click += btnAssignTask_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Franklin Gothic Medium Cond", 12F);
            button2.Location = new Point(216, 675);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(120, 43);
            button2.TabIndex = 56;
            button2.Text = "Un Assign Task";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Franklin Gothic Medium Cond", 12F);
            btnExit.Location = new Point(358, 675);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 43);
            btnExit.TabIndex = 57;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button3_Click_1;
            btnExit.Leave += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label1.Location = new Point(659, 33);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 58;
            label1.Text = "Users Tasks";
            // 
            // lbl_task
            // 
            lbl_task.AutoSize = true;
            lbl_task.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbl_task.Location = new Point(61, 331);
            lbl_task.Name = "lbl_task";
            lbl_task.Size = new Size(148, 25);
            lbl_task.TabIndex = 59;
            lbl_task.Text = "Task to be assignd";
            // 
            // txt_taskdiscreption
            // 
            txt_taskdiscreption.Font = new Font("Franklin Gothic Medium Cond", 12F);
            txt_taskdiscreption.Location = new Point(194, 369);
            txt_taskdiscreption.Margin = new Padding(3, 4, 3, 4);
            txt_taskdiscreption.Name = "txt_taskdiscreption";
            txt_taskdiscreption.Size = new Size(238, 127);
            txt_taskdiscreption.TabIndex = 60;
            txt_taskdiscreption.Text = "";
            // 
            // lbl_taskID
            // 
            lbl_taskID.AutoSize = true;
            lbl_taskID.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbl_taskID.Location = new Point(135, 393);
            lbl_taskID.Name = "lbl_taskID";
            lbl_taskID.Size = new Size(0, 25);
            lbl_taskID.TabIndex = 61;
            // 
            // lbl_taskTitle
            // 
            lbl_taskTitle.AutoSize = true;
            lbl_taskTitle.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbl_taskTitle.Location = new Point(194, 331);
            lbl_taskTitle.Name = "lbl_taskTitle";
            lbl_taskTitle.Size = new Size(0, 25);
            lbl_taskTitle.TabIndex = 62;
            // 
            // lblTaskidName
            // 
            lblTaskidName.AutoSize = true;
            lblTaskidName.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lblTaskidName.Location = new Point(69, 393);
            lblTaskidName.Name = "lblTaskidName";
            lblTaskidName.Size = new Size(71, 25);
            lblTaskidName.TabIndex = 63;
            lblTaskidName.Text = "Task ID:";
            // 
            // lbl_Unassignd
            // 
            lbl_Unassignd.AutoSize = true;
            lbl_Unassignd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbl_Unassignd.Location = new Point(659, 443);
            lbl_Unassignd.Name = "lbl_Unassignd";
            lbl_Unassignd.Size = new Size(120, 25);
            lbl_Unassignd.TabIndex = 64;
            lbl_Unassignd.Text = "Avelable Tasks";
            // 
            // dataGv_user_task
            // 
            dataGv_user_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGv_user_task.Location = new Point(452, 204);
            dataGv_user_task.Margin = new Padding(3, 4, 3, 4);
            dataGv_user_task.Name = "dataGv_user_task";
            dataGv_user_task.RowHeadersWidth = 51;
            dataGv_user_task.Size = new Size(576, 237);
            dataGv_user_task.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(918, 140);
            label3.Name = "label3";
            label3.Size = new Size(135, 34);
            label3.TabIndex = 66;
            label3.Text = "Admin ONLY";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, usersToolStripMenuItem, companyInfoToolStripMenuItem, tasksToolStripMenuItem, reportsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1040, 30);
            menuStrip1.TabIndex = 67;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(58, 24);
            usersToolStripMenuItem.Text = "Users";
            // 
            // companyInfoToolStripMenuItem
            // 
            companyInfoToolStripMenuItem.Name = "companyInfoToolStripMenuItem";
            companyInfoToolStripMenuItem.Size = new Size(116, 24);
            companyInfoToolStripMenuItem.Text = "Company Info";
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTaskToolStripMenuItem, assignTaskToolStripMenuItem });
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(56, 24);
            tasksToolStripMenuItem.Text = "Tasks";
            // 
            // addTaskToolStripMenuItem
            // 
            addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            addTaskToolStripMenuItem.Size = new Size(166, 26);
            addTaskToolStripMenuItem.Text = "Add Task";
            // 
            // assignTaskToolStripMenuItem
            // 
            assignTaskToolStripMenuItem.Name = "assignTaskToolStripMenuItem";
            assignTaskToolStripMenuItem.Size = new Size(166, 26);
            assignTaskToolStripMenuItem.Text = "Assign Task";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.home;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(12, 33);
            button1.Name = "button1";
            button1.Size = new Size(95, 95);
            button1.TabIndex = 68;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(347, 33);
            button3.Name = "button3";
            button3.Size = new Size(85, 95);
            button3.TabIndex = 69;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_2;
            // 
            // frmAssignTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 740);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(label3);
            Controls.Add(dataGv_user_task);
            Controls.Add(lbl_Unassignd);
            Controls.Add(lblTaskidName);
            Controls.Add(lbl_taskTitle);
            Controls.Add(lbl_taskID);
            Controls.Add(txt_taskdiscreption);
            Controls.Add(lbl_task);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(button2);
            Controls.Add(btnAssignTask);
            Controls.Add(dataGridViewTasks);
            Controls.Add(lbl_totalTime);
            Controls.Add(label2);
            Controls.Add(cmbEmployee);
            Controls.Add(lbl_Employee_Selection);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAssignTask";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign Task";
            FormClosing += frmAssignTask_FormClosing;
            Load += frmAssignTask_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGv_user_task).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_totalTime;
        private Label label2;
        private ComboBox cmbEmployee;
        private Label lbl_Employee_Selection;
        private DataGridView dataGridViewTasks;
        private Button btnAssignTask;
        private Button button2;
        private Button btnExit;
        private Label label1;
        private Label lbl_task;
        private RichTextBox txt_taskdiscreption;
        private Label lbl_taskID;
        private Label lbl_taskTitle;
        private Label lblTaskidName;
        private Label lbl_Unassignd;
        private DataGridView dataGv_user_task;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem companyInfoToolStripMenuItem;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem addTaskToolStripMenuItem;
        private ToolStripMenuItem assignTaskToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button button1;
        private Button button3;
    }
}