namespace group_project
{
    partial class frm_Add_Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Task));
            txt_ID = new TextBox();
            lbl_Descreption = new Label();
            lbl_ID = new Label();
            txtDescription = new RichTextBox();
            btn_save = new Button();
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
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_ID
            // 
            txt_ID.Enabled = false;
            txt_ID.Location = new Point(158, 147);
            txt_ID.Margin = new Padding(3, 4, 3, 4);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(114, 27);
            txt_ID.TabIndex = 23;
            // 
            // lbl_Descreption
            // 
            lbl_Descreption.AutoSize = true;
            lbl_Descreption.Location = new Point(69, 201);
            lbl_Descreption.Name = "lbl_Descreption";
            lbl_Descreption.Size = new Size(85, 20);
            lbl_Descreption.TabIndex = 22;
            lbl_Descreption.Text = "Description";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(69, 151);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(55, 20);
            lbl_ID.TabIndex = 21;
            lbl_ID.Text = "Task ID";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(153, 201);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(635, 328);
            txtDescription.TabIndex = 25;
            txtDescription.Text = "";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(398, 557);
            btn_save.Margin = new Padding(3, 4, 3, 4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(86, 31);
            btn_save.TabIndex = 26;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, usersToolStripMenuItem, companyInfoToolStripMenuItem, tasksToolStripMenuItem, reportsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 28;
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
            button1.TabIndex = 52;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(280, 33);
            button2.Name = "button2";
            button2.Size = new Size(85, 95);
            button2.TabIndex = 53;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frm_Add_Task
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_save);
            Controls.Add(txtDescription);
            Controls.Add(txt_ID);
            Controls.Add(lbl_Descreption);
            Controls.Add(lbl_ID);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Add_Task";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Ditels";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ID;
        private Label lbl_Descreption;
        private Label lbl_ID;
        private RichTextBox txtDescription;
        private Button btn_save;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem companyInfoToolStripMenuItem;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addTaskToolStripMenuItem;
        private ToolStripMenuItem assignTaskToolStripMenuItem;
        private Button button1;
        private Button button2;
    }
}