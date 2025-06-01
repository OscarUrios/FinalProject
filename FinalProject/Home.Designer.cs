namespace FinalProject
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTNAddTask = new Button();
            listBoxGroups = new ListBox();
            listBoxTasks = new ListBox();
            BTNDelTask = new Button();
            BTNNewGroup = new Button();
            BTNDelGroup = new Button();
            groupBoxTaskInfo = new GroupBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            labelDeadline = new Label();
            textBoxDeadline = new TextBox();
            textBoxName = new TextBox();
            labelName = new Label();
            labelNotes = new Label();
            textBoxNotes = new TextBox();
            BTNMarkDO = new Button();
            BTNMarkUNDO = new Button();
            BTNModTask = new Button();
            BTNDelUser = new Button();
            BTNCloseApp = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBoxTaskInfo.SuspendLayout();
            SuspendLayout();
            // 
            // BTNAddTask
            // 
            BTNAddTask.Location = new Point(429, 333);
            BTNAddTask.Name = "BTNAddTask";
            BTNAddTask.Size = new Size(103, 23);
            BTNAddTask.TabIndex = 0;
            BTNAddTask.Text = "Add Task";
            BTNAddTask.UseVisualStyleBackColor = true;
            BTNAddTask.Click += AddTask_Click;
            // 
            // listBoxGroups
            // 
            listBoxGroups.FormattingEnabled = true;
            listBoxGroups.ItemHeight = 15;
            listBoxGroups.Location = new Point(12, 30);
            listBoxGroups.Name = "listBoxGroups";
            listBoxGroups.Size = new Size(361, 184);
            listBoxGroups.TabIndex = 9;
            listBoxGroups.SelectedIndexChanged += listBoxGroups_SelectedIndexChanged;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(12, 255);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(361, 184);
            listBoxTasks.TabIndex = 10;
            listBoxTasks.SelectedIndexChanged += listBoxTasks_SelectedIndexChanged;
            // 
            // BTNDelTask
            // 
            BTNDelTask.Location = new Point(429, 362);
            BTNDelTask.Name = "BTNDelTask";
            BTNDelTask.Size = new Size(103, 23);
            BTNDelTask.TabIndex = 1;
            BTNDelTask.Text = "Delete Task";
            BTNDelTask.UseVisualStyleBackColor = true;
            BTNDelTask.Click += BTNDelTask_Click;
            // 
            // BTNNewGroup
            // 
            BTNNewGroup.Location = new Point(647, 333);
            BTNNewGroup.Name = "BTNNewGroup";
            BTNNewGroup.Size = new Size(103, 23);
            BTNNewGroup.TabIndex = 5;
            BTNNewGroup.Text = "Add Group";
            BTNNewGroup.UseVisualStyleBackColor = true;
            BTNNewGroup.Click += BTNNewGroup_Click;
            // 
            // BTNDelGroup
            // 
            BTNDelGroup.Location = new Point(647, 362);
            BTNDelGroup.Name = "BTNDelGroup";
            BTNDelGroup.Size = new Size(103, 23);
            BTNDelGroup.TabIndex = 6;
            BTNDelGroup.Text = "Delete Group";
            BTNDelGroup.UseVisualStyleBackColor = true;
            BTNDelGroup.Click += BTNDelGroup_Click;
            // 
            // groupBoxTaskInfo
            // 
            groupBoxTaskInfo.Controls.Add(checkBox1);
            groupBoxTaskInfo.Controls.Add(label3);
            groupBoxTaskInfo.Controls.Add(labelDeadline);
            groupBoxTaskInfo.Controls.Add(textBoxDeadline);
            groupBoxTaskInfo.Controls.Add(textBoxName);
            groupBoxTaskInfo.Controls.Add(labelName);
            groupBoxTaskInfo.Controls.Add(labelNotes);
            groupBoxTaskInfo.Controls.Add(textBoxNotes);
            groupBoxTaskInfo.Location = new Point(400, 12);
            groupBoxTaskInfo.Name = "groupBoxTaskInfo";
            groupBoxTaskInfo.Size = new Size(388, 291);
            groupBoxTaskInfo.TabIndex = 11;
            groupBoxTaskInfo.TabStop = false;
            groupBoxTaskInfo.Text = "Task Info";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(48, 74);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 19;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 73);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 18;
            label3.Text = "Done";
            // 
            // labelDeadline
            // 
            labelDeadline.AutoSize = true;
            labelDeadline.Location = new Point(8, 103);
            labelDeadline.Name = "labelDeadline";
            labelDeadline.Size = new Size(33, 15);
            labelDeadline.TabIndex = 17;
            labelDeadline.Text = "Time";
            // 
            // textBoxDeadline
            // 
            textBoxDeadline.Location = new Point(7, 121);
            textBoxDeadline.Name = "textBoxDeadline";
            textBoxDeadline.Size = new Size(376, 23);
            textBoxDeadline.TabIndex = 16;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(6, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(376, 23);
            textBoxName.TabIndex = 13;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 12;
            labelName.Text = "Name";
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(7, 161);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(38, 15);
            labelNotes.TabIndex = 14;
            labelNotes.Text = "Notes";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(7, 179);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ScrollBars = ScrollBars.Vertical;
            textBoxNotes.Size = new Size(376, 103);
            textBoxNotes.TabIndex = 15;
            // 
            // BTNMarkDO
            // 
            BTNMarkDO.Location = new Point(538, 333);
            BTNMarkDO.Name = "BTNMarkDO";
            BTNMarkDO.Size = new Size(103, 23);
            BTNMarkDO.TabIndex = 3;
            BTNMarkDO.Text = "Mark As Done";
            BTNMarkDO.UseVisualStyleBackColor = true;
            BTNMarkDO.Click += BTNMarkDO_Click;
            // 
            // BTNMarkUNDO
            // 
            BTNMarkUNDO.Location = new Point(538, 362);
            BTNMarkUNDO.Name = "BTNMarkUNDO";
            BTNMarkUNDO.Size = new Size(103, 23);
            BTNMarkUNDO.TabIndex = 4;
            BTNMarkUNDO.Text = "Mark As Undone";
            BTNMarkUNDO.UseVisualStyleBackColor = true;
            BTNMarkUNDO.Click += BTNMarkUNDO_Click;
            // 
            // BTNModTask
            // 
            BTNModTask.Location = new Point(429, 391);
            BTNModTask.Name = "BTNModTask";
            BTNModTask.Size = new Size(103, 23);
            BTNModTask.TabIndex = 2;
            BTNModTask.Text = "Modify Task";
            BTNModTask.UseVisualStyleBackColor = true;
            BTNModTask.Click += BTNModTask_Click;
            // 
            // BTNDelUser
            // 
            BTNDelUser.Location = new Point(538, 391);
            BTNDelUser.Name = "BTNDelUser";
            BTNDelUser.Size = new Size(103, 23);
            BTNDelUser.TabIndex = 12;
            BTNDelUser.Text = "Delete User";
            BTNDelUser.UseVisualStyleBackColor = true;
            BTNDelUser.Click += DelUser_Click;
            // 
            // BTNCloseApp
            // 
            BTNCloseApp.Location = new Point(647, 391);
            BTNCloseApp.Name = "BTNCloseApp";
            BTNCloseApp.Size = new Size(103, 23);
            BTNCloseApp.TabIndex = 8;
            BTNCloseApp.Text = "Save and Quit";
            BTNCloseApp.UseVisualStyleBackColor = true;
            BTNCloseApp.Click += CloseApp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 13;
            label1.Text = "Groups";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 237);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 14;
            label2.Text = "Tasks";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 451);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTNCloseApp);
            Controls.Add(BTNDelUser);
            Controls.Add(BTNModTask);
            Controls.Add(BTNMarkUNDO);
            Controls.Add(BTNMarkDO);
            Controls.Add(groupBoxTaskInfo);
            Controls.Add(BTNDelGroup);
            Controls.Add(BTNNewGroup);
            Controls.Add(BTNDelTask);
            Controls.Add(listBoxTasks);
            Controls.Add(listBoxGroups);
            Controls.Add(BTNAddTask);
            MaximumSize = new Size(820, 490);
            MinimumSize = new Size(820, 490);
            Name = "Home";
            Text = "DoYourTasks";
            FormClosing += Home_FormClosing;
            groupBoxTaskInfo.ResumeLayout(false);
            groupBoxTaskInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNAddTask;
        private ListBox listBoxGroups;
        private ListBox listBoxTasks;
        private Button BTNDelTask;
        private Button BTNNewGroup;
        private Button BTNDelGroup;
        private GroupBox groupBoxTaskInfo;
        private TextBox textBoxNotes;
        private Button BTNMarkDO;
        private Button BTNMarkUNDO;
        private Label labelNotes;
        private Label labelName;
        private TextBox textBoxName;
        private Button BTNModTask;
        private Label labelDeadline;
        private TextBox textBoxDeadline;
        private Button BTNDelUser;
        private Button BTNCloseApp;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Label label3;
    }
}
