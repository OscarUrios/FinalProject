namespace FinalProject
{
    partial class Form1
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
            Groups = new ListBox();
            Tasks = new ListBox();
            BTNDelTask = new Button();
            BTNNewGroup = new Button();
            BTNDelGroup = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            BTNMarkDO = new Button();
            BTNMarkUNDO = new Button();
            BTNModTask = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BTNAddTask
            // 
            BTNAddTask.Location = new Point(400, 322);
            BTNAddTask.Name = "BTNAddTask";
            BTNAddTask.Size = new Size(103, 23);
            BTNAddTask.TabIndex = 0;
            BTNAddTask.Text = "Add Task";
            BTNAddTask.UseVisualStyleBackColor = true;
            BTNAddTask.Click += AddTask_Click;
            // 
            // BTNDelTask
            // 
            BTNDelTask.Location = new Point(400, 351);
            BTNDelTask.Name = "BTNDelTask";
            BTNDelTask.Size = new Size(103, 23);
            BTNDelTask.TabIndex = 1;
            BTNDelTask.Text = "Delete Task";
            BTNDelTask.UseVisualStyleBackColor = true;
            // 
            // BTNModTask
            // 
            BTNModTask.Location = new Point(400, 380);
            BTNModTask.Name = "BTNModTask";
            BTNModTask.Size = new Size(103, 23);
            BTNModTask.TabIndex = 2;
            BTNModTask.Text = "Modify Task";
            BTNModTask.UseVisualStyleBackColor = true;
            // 
            // BTNMarkDO
            // 
            BTNMarkDO.Location = new Point(509, 322);
            BTNMarkDO.Name = "BTNMarkDO";
            BTNMarkDO.Size = new Size(103, 23);
            BTNMarkDO.TabIndex = 3;
            BTNMarkDO.Text = "Mark As Done";
            BTNMarkDO.UseVisualStyleBackColor = true;
            // 
            // BTNMarkUNDO
            // 
            BTNMarkUNDO.Location = new Point(509, 351);
            BTNMarkUNDO.Name = "BTNMarkUNDO";
            BTNMarkUNDO.Size = new Size(103, 23);
            BTNMarkUNDO.TabIndex = 4;
            BTNMarkUNDO.Text = "Mark As Undone";
            BTNMarkUNDO.UseVisualStyleBackColor = true;
            // 
            // BTNNewGroup
            // 
            BTNNewGroup.Location = new Point(618, 322);
            BTNNewGroup.Name = "BTNNewGroup";
            BTNNewGroup.Size = new Size(103, 23);
            BTNNewGroup.TabIndex = 5;
            BTNNewGroup.Text = "Add Group";
            BTNNewGroup.UseVisualStyleBackColor = true;
            // 
            // BTNDelGroup
            // 
            BTNDelGroup.Location = new Point(618, 351);
            BTNDelGroup.Name = "BTNDelGroup";
            BTNDelGroup.Size = new Size(103, 23);
            BTNDelGroup.TabIndex = 6;
            BTNDelGroup.Text = "Delete Group";
            BTNDelGroup.UseVisualStyleBackColor = true;
            // 
            // Groups
            // 
            Groups.FormattingEnabled = true;
            Groups.ItemHeight = 15;
            Groups.Location = new Point(12, 12);
            Groups.Name = "Groups";
            Groups.Size = new Size(361, 199);
            Groups.TabIndex = 7;
            // 
            // Tasks
            // 
            Tasks.FormattingEnabled = true;
            Tasks.ItemHeight = 15;
            Tasks.Location = new Point(12, 239);
            Tasks.Name = "Tasks";
            Tasks.Size = new Size(361, 199);
            Tasks.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(400, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 304);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(376, 23);
            textBox2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 177);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "Notes";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 195);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(376, 103);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNModTask);
            Controls.Add(BTNMarkUNDO);
            Controls.Add(BTNMarkDO);
            Controls.Add(groupBox1);
            Controls.Add(BTNDelGroup);
            Controls.Add(BTNNewGroup);
            Controls.Add(BTNDelTask);
            Controls.Add(Tasks);
            Controls.Add(Groups);
            Controls.Add(BTNAddTask);
            Name = "Form1";
            Text = "DoYourTasks";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BTNAddTask;
        private ListBox Groups;
        private ListBox Tasks;
        private Button BTNDelTask;
        private Button BTNNewGroup;
        private Button BTNDelGroup;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button BTNMarkDO;
        private Button BTNMarkUNDO;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button BTNModTask;
    }
}
