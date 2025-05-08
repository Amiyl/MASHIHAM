namespace group_project
{
    partial class frm_Task_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Task_List));
            exitToolStripMenuItem = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            companyInfoToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewTasks = new DataGridView();
            tnm_Dete = new Button();
            btn_Updater = new Button();
            btn_Add = new Button();
            txt_EstimatedTime = new TextBox();
            txtTaskTitle = new TextBox();
            lbl_privilege = new Label();
            lbl_lastName = new Label();
            lbl_fName = new Label();
            lbl_task_titel = new Label();
            label1 = new Label();
            dateTimedeadline = new DateTimePicker();
            txtDescription = new RichTextBox();
            txtTaskID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAdminNote = new RichTextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(56, 24);
            tasksToolStripMenuItem.Text = "Tasks";
            // 
            // companyInfoToolStripMenuItem
            // 
            companyInfoToolStripMenuItem.Name = "companyInfoToolStripMenuItem";
            companyInfoToolStripMenuItem.Size = new Size(116, 24);
            companyInfoToolStripMenuItem.Text = "Company Info";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(80, 24);
            usersToolStripMenuItem.Text = "Emplyee";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, usersToolStripMenuItem, companyInfoToolStripMenuItem, tasksToolStripMenuItem, reportsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1040, 30);
            menuStrip1.TabIndex = 42;
            menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(534, 221);
            dataGridViewTasks.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewTasks.Size = new Size(449, 412);
            dataGridViewTasks.TabIndex = 41;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            // 
            // tnm_Dete
            // 
            tnm_Dete.Location = new Point(485, 679);
            tnm_Dete.Margin = new Padding(3, 4, 3, 4);
            tnm_Dete.Name = "tnm_Dete";
            tnm_Dete.Size = new Size(86, 31);
            tnm_Dete.TabIndex = 40;
            tnm_Dete.Text = "Delete";
            tnm_Dete.UseVisualStyleBackColor = true;
            // 
            // btn_Updater
            // 
            btn_Updater.Location = new Point(392, 679);
            btn_Updater.Margin = new Padding(3, 4, 3, 4);
            btn_Updater.Name = "btn_Updater";
            btn_Updater.Size = new Size(86, 31);
            btn_Updater.TabIndex = 39;
            btn_Updater.Text = "Update";
            btn_Updater.UseVisualStyleBackColor = true;
            btn_Updater.Click += btn_Updater_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(299, 679);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(86, 31);
            btn_Add.TabIndex = 38;
            btn_Add.Text = "Add Task";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_EstimatedTime
            // 
            txt_EstimatedTime.Location = new Point(145, 269);
            txt_EstimatedTime.Margin = new Padding(3, 4, 3, 4);
            txt_EstimatedTime.Name = "txt_EstimatedTime";
            txt_EstimatedTime.Size = new Size(363, 27);
            txt_EstimatedTime.TabIndex = 36;
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(145, 221);
            txtTaskTitle.Margin = new Padding(3, 4, 3, 4);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(363, 27);
            txtTaskTitle.TabIndex = 34;
            // 
            // lbl_privilege
            // 
            lbl_privilege.AutoSize = true;
            lbl_privilege.Location = new Point(38, 316);
            lbl_privilege.Name = "lbl_privilege";
            lbl_privilege.Size = new Size(69, 20);
            lbl_privilege.TabIndex = 33;
            lbl_privilege.Text = "Deadline";
            // 
            // lbl_lastName
            // 
            lbl_lastName.AutoSize = true;
            lbl_lastName.Location = new Point(37, 269);
            lbl_lastName.Name = "lbl_lastName";
            lbl_lastName.Size = new Size(112, 20);
            lbl_lastName.TabIndex = 32;
            lbl_lastName.Text = "Estimated Time";
            // 
            // lbl_fName
            // 
            lbl_fName.AutoSize = true;
            lbl_fName.Location = new Point(38, 369);
            lbl_fName.Name = "lbl_fName";
            lbl_fName.Size = new Size(116, 20);
            lbl_fName.TabIndex = 31;
            lbl_fName.Text = "Task Description";
            // 
            // lbl_task_titel
            // 
            lbl_task_titel.AutoSize = true;
            lbl_task_titel.Location = new Point(37, 225);
            lbl_task_titel.Name = "lbl_task_titel";
            lbl_task_titel.Size = new Size(69, 20);
            lbl_task_titel.TabIndex = 30;
            lbl_task_titel.Text = "Task Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 87);
            label1.Name = "label1";
            label1.Size = new Size(149, 41);
            label1.TabIndex = 43;
            label1.Text = "Tasks List";
            // 
            // dateTimedeadline
            // 
            dateTimedeadline.Location = new Point(145, 316);
            dateTimedeadline.Margin = new Padding(3, 4, 3, 4);
            dateTimedeadline.Name = "dateTimedeadline";
            dateTimedeadline.Size = new Size(363, 27);
            dateTimedeadline.TabIndex = 44;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(145, 369);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(363, 87);
            txtDescription.TabIndex = 45;
            txtDescription.Text = "";
            // 
            // txtTaskID
            // 
            txtTaskID.Enabled = false;
            txtTaskID.Location = new Point(145, 168);
            txtTaskID.Margin = new Padding(3, 4, 3, 4);
            txtTaskID.Name = "txtTaskID";
            txtTaskID.Size = new Size(363, 27);
            txtTaskID.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 172);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 47;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(917, 32);
            label3.Name = "label3";
            label3.Size = new Size(135, 34);
            label3.TabIndex = 48;
            label3.Text = "Admin ONLY";
            // 
            // txtAdminNote
            // 
            txtAdminNote.Location = new Point(145, 483);
            txtAdminNote.Margin = new Padding(3, 4, 3, 4);
            txtAdminNote.Name = "txtAdminNote";
            txtAdminNote.Size = new Size(363, 87);
            txtAdminNote.TabIndex = 49;
            txtAdminNote.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 487);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 50;
            label4.Text = "Note";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.home;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(12, 33);
            button1.Name = "button1";
            button1.Size = new Size(95, 95);
            button1.TabIndex = 51;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(349, 33);
            button2.Name = "button2";
            button2.Size = new Size(85, 95);
            button2.TabIndex = 52;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frm_Task_List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 740);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtAdminNote);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTaskID);
            Controls.Add(txtDescription);
            Controls.Add(dateTimedeadline);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridViewTasks);
            Controls.Add(tnm_Dete);
            Controls.Add(btn_Updater);
            Controls.Add(btn_Add);
            Controls.Add(txt_EstimatedTime);
            Controls.Add(txtTaskTitle);
            Controls.Add(lbl_privilege);
            Controls.Add(lbl_lastName);
            Controls.Add(lbl_fName);
            Controls.Add(lbl_task_titel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Task_List";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            FormClosing += frm_Task_List_FormClosing;
            Load += frm_Task_Monitor_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem companyInfoToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private DataGridView dataGridViewTasks;
        private Button tnm_Dete;
        private Button btn_Updater;
        private Button btn_Add;
        private TextBox txt_EstimatedTime;
        private TextBox txtTaskTitle;
        private Label lbl_privilege;
        private Label lbl_lastName;
        private Label lbl_fName;
        private Label lbl_task_titel;
        private Label label1;
        private DateTimePicker dateTimedeadline;
        private RichTextBox txtDescription;
        private TextBox txtTaskID;
        private Label label2;
        private Label label3;
        private RichTextBox txtAdminNote;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}