namespace group_project
{
    partial class frm_Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Tasks));
            dataGridView1 = new DataGridView();
            tnm_Dete = new Button();
            btn_Updater = new Button();
            btn_Add = new Button();
            txt_FName = new TextBox();
            txt_ID = new TextBox();
            lbl_AssignTo = new Label();
            lbl_fName = new Label();
            lbl_ID = new Label();
            stn_Assign = new Button();
            comboUsers = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(449, 175);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(432, 412);
            dataGridView1.TabIndex = 26;
            // 
            // tnm_Dete
            // 
            tnm_Dete.Location = new Point(232, 519);
            tnm_Dete.Margin = new Padding(3, 4, 3, 4);
            tnm_Dete.Name = "tnm_Dete";
            tnm_Dete.Size = new Size(86, 31);
            tnm_Dete.TabIndex = 25;
            tnm_Dete.Text = "Delete";
            tnm_Dete.UseVisualStyleBackColor = true;
            // 
            // btn_Updater
            // 
            btn_Updater.Location = new Point(140, 519);
            btn_Updater.Margin = new Padding(3, 4, 3, 4);
            btn_Updater.Name = "btn_Updater";
            btn_Updater.Size = new Size(86, 31);
            btn_Updater.TabIndex = 24;
            btn_Updater.Text = "Update";
            btn_Updater.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(47, 519);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(86, 31);
            btn_Add.TabIndex = 23;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // txt_FName
            // 
            txt_FName.Location = new Point(149, 224);
            txt_FName.Margin = new Padding(3, 4, 3, 4);
            txt_FName.Name = "txt_FName";
            txt_FName.Size = new Size(114, 27);
            txt_FName.TabIndex = 20;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(149, 175);
            txt_ID.Margin = new Padding(3, 4, 3, 4);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(114, 27);
            txt_ID.TabIndex = 19;
            // 
            // lbl_AssignTo
            // 
            lbl_AssignTo.AutoSize = true;
            lbl_AssignTo.Location = new Point(60, 272);
            lbl_AssignTo.Name = "lbl_AssignTo";
            lbl_AssignTo.Size = new Size(72, 20);
            lbl_AssignTo.TabIndex = 17;
            lbl_AssignTo.Text = "Assign To";
            // 
            // lbl_fName
            // 
            lbl_fName.AutoSize = true;
            lbl_fName.Location = new Point(60, 228);
            lbl_fName.Name = "lbl_fName";
            lbl_fName.Size = new Size(85, 20);
            lbl_fName.TabIndex = 16;
            lbl_fName.Text = "Description";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(60, 179);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(55, 20);
            lbl_ID.TabIndex = 15;
            lbl_ID.Text = "Task ID";
            // 
            // stn_Assign
            // 
            stn_Assign.Location = new Point(325, 519);
            stn_Assign.Margin = new Padding(3, 4, 3, 4);
            stn_Assign.Name = "stn_Assign";
            stn_Assign.Size = new Size(86, 31);
            stn_Assign.TabIndex = 27;
            stn_Assign.Text = "Assign";
            stn_Assign.UseVisualStyleBackColor = true;
            // 
            // comboUsers
            // 
            comboUsers.FormattingEnabled = true;
            comboUsers.Location = new Point(149, 272);
            comboUsers.Margin = new Padding(3, 4, 3, 4);
            comboUsers.Name = "comboUsers";
            comboUsers.Size = new Size(138, 28);
            comboUsers.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 92);
            label1.Name = "label1";
            label1.Size = new Size(193, 41);
            label1.TabIndex = 29;
            label1.Text = "Assign Tasks";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.home;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(1, 1);
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
            button2.Location = new Point(345, 1);
            button2.Name = "button2";
            button2.Size = new Size(85, 88);
            button2.TabIndex = 53;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frm_Tasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboUsers);
            Controls.Add(stn_Assign);
            Controls.Add(dataGridView1);
            Controls.Add(tnm_Dete);
            Controls.Add(btn_Updater);
            Controls.Add(btn_Add);
            Controls.Add(txt_FName);
            Controls.Add(txt_ID);
            Controls.Add(lbl_AssignTo);
            Controls.Add(lbl_fName);
            Controls.Add(lbl_ID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Tasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign Tasks";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button tnm_Dete;
        private Button btn_Updater;
        private Button btn_Add;
        private TextBox txt_FName;
        private TextBox txt_ID;
        private Label lbl_AssignTo;
        private Label lbl_fName;
        private Label lbl_ID;
        private Button stn_Assign;
        private ComboBox comboUsers;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}