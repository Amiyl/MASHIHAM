namespace group_project
{
    partial class frmUserTaskControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserTaskControl));
            lblWelcome = new Label();
            dataGv_user_task = new DataGridView();
            lbl_taskList = new Label();
            btnComplete = new Button();
            btnRefuse = new Button();
            btnExcpt = new Button();
            lblTaskTitle = new Label();
            lblTitle = new Label();
            txtDiscreption = new RichTextBox();
            label1 = new Label();
            lblUserNote = new Label();
            lblAdminNote = new Label();
            txtAdminNote = new RichTextBox();
            txtUserNote = new RichTextBox();
            btnUpdateNote = new Button();
            lblTaskID = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGv_user_task).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            lblWelcome.Location = new Point(627, 103);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(106, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME";
            // 
            // dataGv_user_task
            // 
            dataGv_user_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGv_user_task.Location = new Point(540, 184);
            dataGv_user_task.Margin = new Padding(3, 4, 3, 4);
            dataGv_user_task.Name = "dataGv_user_task";
            dataGv_user_task.RowHeadersWidth = 51;
            dataGv_user_task.Size = new Size(336, 349);
            dataGv_user_task.TabIndex = 66;
            dataGv_user_task.CellClick += dataGv_user_task_CellClick;
            // 
            // lbl_taskList
            // 
            lbl_taskList.AutoSize = true;
            lbl_taskList.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            lbl_taskList.Location = new Point(659, 148);
            lbl_taskList.Name = "lbl_taskList";
            lbl_taskList.Size = new Size(133, 30);
            lbl_taskList.TabIndex = 67;
            lbl_taskList.Text = "Assignd Tasks";
            // 
            // btnComplete
            // 
            btnComplete.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            btnComplete.Location = new Point(605, 618);
            btnComplete.Margin = new Padding(3, 4, 3, 4);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(147, 44);
            btnComplete.TabIndex = 68;
            btnComplete.Text = "Task Completed";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnRefuse
            // 
            btnRefuse.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            btnRefuse.Location = new Point(297, 618);
            btnRefuse.Margin = new Padding(3, 4, 3, 4);
            btnRefuse.Name = "btnRefuse";
            btnRefuse.Size = new Size(147, 44);
            btnRefuse.TabIndex = 69;
            btnRefuse.Text = "Refuse";
            btnRefuse.UseVisualStyleBackColor = true;
            btnRefuse.Click += btnRefuse_Click_1;
            // 
            // btnExcpt
            // 
            btnExcpt.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            btnExcpt.Location = new Point(142, 618);
            btnExcpt.Margin = new Padding(3, 4, 3, 4);
            btnExcpt.Name = "btnExcpt";
            btnExcpt.Size = new Size(147, 44);
            btnExcpt.TabIndex = 70;
            btnExcpt.Text = "Excpt";
            btnExcpt.UseVisualStyleBackColor = true;
            btnExcpt.Click += btnExcpt_Click;
            // 
            // lblTaskTitle
            // 
            lblTaskTitle.AutoSize = true;
            lblTaskTitle.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            lblTaskTitle.Location = new Point(59, 116);
            lblTaskTitle.Name = "lblTaskTitle";
            lblTaskTitle.Size = new Size(93, 30);
            lblTaskTitle.TabIndex = 71;
            lblTaskTitle.Text = "Task Title";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            lblTitle.Location = new Point(181, 191);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 30);
            lblTitle.TabIndex = 72;
            // 
            // txtDiscreption
            // 
            txtDiscreption.Location = new Point(164, 152);
            txtDiscreption.Margin = new Padding(3, 4, 3, 4);
            txtDiscreption.Name = "txtDiscreption";
            txtDiscreption.Size = new Size(318, 167);
            txtDiscreption.TabIndex = 73;
            txtDiscreption.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            label1.Location = new Point(59, 148);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 74;
            label1.Text = "Discreption";
            // 
            // lblUserNote
            // 
            lblUserNote.AutoSize = true;
            lblUserNote.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            lblUserNote.Location = new Point(59, 468);
            lblUserNote.Name = "lblUserNote";
            lblUserNote.Size = new Size(99, 30);
            lblUserNote.TabIndex = 75;
            lblUserNote.Text = "User Note";
            // 
            // lblAdminNote
            // 
            lblAdminNote.AutoSize = true;
            lblAdminNote.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            lblAdminNote.Location = new Point(59, 362);
            lblAdminNote.Name = "lblAdminNote";
            lblAdminNote.Size = new Size(115, 30);
            lblAdminNote.TabIndex = 76;
            lblAdminNote.Text = "Admin Note";
            // 
            // txtAdminNote
            // 
            txtAdminNote.Location = new Point(164, 340);
            txtAdminNote.Margin = new Padding(3, 4, 3, 4);
            txtAdminNote.Name = "txtAdminNote";
            txtAdminNote.Size = new Size(318, 96);
            txtAdminNote.TabIndex = 77;
            txtAdminNote.Text = "";
            // 
            // txtUserNote
            // 
            txtUserNote.Location = new Point(164, 446);
            txtUserNote.Margin = new Padding(3, 4, 3, 4);
            txtUserNote.Name = "txtUserNote";
            txtUserNote.Size = new Size(318, 96);
            txtUserNote.TabIndex = 78;
            txtUserNote.Text = "";
            // 
            // btnUpdateNote
            // 
            btnUpdateNote.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            btnUpdateNote.Location = new Point(451, 618);
            btnUpdateNote.Margin = new Padding(3, 4, 3, 4);
            btnUpdateNote.Name = "btnUpdateNote";
            btnUpdateNote.Size = new Size(147, 44);
            btnUpdateNote.TabIndex = 79;
            btnUpdateNote.Text = "Update Note";
            btnUpdateNote.UseVisualStyleBackColor = true;
            btnUpdateNote.Click += btnUpdateNote_Click;
            // 
            // lblTaskID
            // 
            lblTaskID.AutoSize = true;
            lblTaskID.Location = new Point(307, 115);
            lblTaskID.Name = "lblTaskID";
            lblTaskID.Size = new Size(58, 20);
            lblTaskID.TabIndex = 80;
            lblTaskID.Text = "Task ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 115);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 81;
            label2.Text = "Task ID: ";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.home;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(-2, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 95);
            button1.TabIndex = 82;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(406, 2);
            button2.Name = "button2";
            button2.Size = new Size(85, 95);
            button2.TabIndex = 83;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmUserTaskControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 683);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lblTaskID);
            Controls.Add(btnUpdateNote);
            Controls.Add(txtUserNote);
            Controls.Add(txtAdminNote);
            Controls.Add(lblAdminNote);
            Controls.Add(lblUserNote);
            Controls.Add(label1);
            Controls.Add(txtDiscreption);
            Controls.Add(lblTitle);
            Controls.Add(lblTaskTitle);
            Controls.Add(btnExcpt);
            Controls.Add(btnRefuse);
            Controls.Add(btnComplete);
            Controls.Add(lbl_taskList);
            Controls.Add(dataGv_user_task);
            Controls.Add(lblWelcome);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUserTaskControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserTaskControl";
            Load += frmUserTaskControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGv_user_task).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private DataGridView dataGv_user_task;
        private Label lbl_taskList;
        private Button btnComplete;
        private Button btnRefuse;
        private Button btnExcpt;
        private Label lblTaskTitle;
        private Label lblTitle;
        private RichTextBox txtDiscreption;
        private Label label1;
        private Label lblUserNote;
        private Label lblAdminNote;
        private RichTextBox txtAdminNote;
        private RichTextBox txtUserNote;
        private Button btnUpdateNote;
        private Label lblTaskID;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}