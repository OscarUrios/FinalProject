namespace FinalProject
{
    partial class ModTask
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
            label2 = new Label();
            label1 = new Label();
            domainUpDown2 = new DomainUpDown();
            domainUpDown1 = new DomainUpDown();
            checkBox1 = new CheckBox();
            labelDate = new Label();
            dateTimePickerNewTask = new DateTimePicker();
            comboBoxGroup = new ComboBox();
            textBoxName = new TextBox();
            textBoxNotes = new TextBox();
            labelNotes = new Label();
            labelGroup = new Label();
            labelName = new Label();
            BTNSave = new Button();
            BTNCancel = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 101);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 30;
            label2.Text = "Minutes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 101);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 29;
            label1.Text = "Hour";
            // 
            // domainUpDown2
            // 
            domainUpDown2.Location = new Point(309, 119);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(75, 23);
            domainUpDown2.TabIndex = 28;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(230, 119);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(73, 23);
            domainUpDown1.TabIndex = 27;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(76, 177);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "Repeat";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(8, 101);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 22;
            labelDate.Text = "Date";
            // 
            // dateTimePickerNewTask
            // 
            dateTimePickerNewTask.Location = new Point(8, 119);
            dateTimePickerNewTask.Name = "dateTimePickerNewTask";
            dateTimePickerNewTask.Size = new Size(216, 23);
            dateTimePickerNewTask.TabIndex = 23;
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Location = new Point(8, 75);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new Size(376, 23);
            comboBoxGroup.TabIndex = 21;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(8, 31);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(376, 23);
            textBoxName.TabIndex = 19;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(412, 31);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ScrollBars = ScrollBars.Vertical;
            textBoxNotes.Size = new Size(376, 166);
            textBoxNotes.TabIndex = 25;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(412, 13);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(38, 15);
            labelNotes.TabIndex = 24;
            labelNotes.Text = "Notes";
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(8, 57);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(40, 15);
            labelGroup.TabIndex = 20;
            labelGroup.Text = "Group";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(8, 13);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 18;
            labelName.Text = "Name";
            // 
            // BTNSave
            // 
            BTNSave.Location = new Point(309, 174);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(75, 23);
            BTNSave.TabIndex = 17;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            BTNSave.Click += BTNSave_Click;
            // 
            // BTNCancel
            // 
            BTNCancel.Location = new Point(228, 174);
            BTNCancel.Name = "BTNCancel";
            BTNCancel.Size = new Size(75, 23);
            BTNCancel.TabIndex = 16;
            BTNCancel.Text = "Cancel";
            BTNCancel.UseVisualStyleBackColor = true;
            BTNCancel.Click += BTNCancel_Click;
            // 
            // ModTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 218);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(domainUpDown2);
            Controls.Add(domainUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(labelDate);
            Controls.Add(dateTimePickerNewTask);
            Controls.Add(comboBoxGroup);
            Controls.Add(textBoxName);
            Controls.Add(textBoxNotes);
            Controls.Add(labelNotes);
            Controls.Add(labelGroup);
            Controls.Add(labelName);
            Controls.Add(BTNSave);
            Controls.Add(BTNCancel);
            Name = "ModTask";
            Text = "ModifyTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DomainUpDown domainUpDown2;
        private DomainUpDown domainUpDown1;
        private CheckBox checkBox1;
        private Label labelDate;
        private DateTimePicker dateTimePickerNewTask;
        private ComboBox comboBoxGroup;
        private TextBox textBoxName;
        private TextBox textBoxNotes;
        private Label labelNotes;
        private Label labelGroup;
        private Label labelName;
        private Button BTNSave;
        private Button BTNCancel;
    }
}