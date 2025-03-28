namespace FinalProject
{
    partial class NewTask
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
            BTNCancel = new Button();
            BTNSave = new Button();
            labelName = new Label();
            labelGroup = new Label();
            labelNotes = new Label();
            textBoxNotes = new TextBox();
            textBoxName = new TextBox();
            comboBoxGroup = new ComboBox();
            dateTimePickerNewTask = new DateTimePicker();
            labelDate = new Label();
            SuspendLayout();
            // 
            // BTNCancel
            // 
            BTNCancel.Location = new Point(111, 189);
            BTNCancel.Name = "BTNCancel";
            BTNCancel.Size = new Size(75, 23);
            BTNCancel.TabIndex = 0;
            BTNCancel.Text = "Cancel";
            BTNCancel.UseVisualStyleBackColor = true;
            BTNCancel.Click += BTNCancel_Click;
            // 
            // BTNSave
            // 
            BTNSave.Location = new Point(192, 189);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(75, 23);
            BTNSave.TabIndex = 1;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            BTNSave.Click += BTNSave_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 28);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 46);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(376, 23);
            textBoxName.TabIndex = 3;
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(12, 72);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(40, 15);
            labelGroup.TabIndex = 4;
            labelGroup.Text = "Group";
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Location = new Point(12, 90);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new Size(376, 23);
            comboBoxGroup.TabIndex = 5;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 116);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 6;
            labelDate.Text = "Date";
            // 
            // dateTimePickerNewTask
            // 
            dateTimePickerNewTask.Location = new Point(12, 134);
            dateTimePickerNewTask.Name = "dateTimePickerNewTask";
            dateTimePickerNewTask.Size = new Size(376, 23);
            dateTimePickerNewTask.TabIndex = 7;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(412, 28);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(38, 15);
            labelNotes.TabIndex = 8;
            labelNotes.Text = "Notes";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(412, 46);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ScrollBars = ScrollBars.Vertical;
            textBoxNotes.Size = new Size(376, 166);
            textBoxNotes.TabIndex = 9;
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 238);
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
            Name = "NewTask";
            Text = "NewTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNCancel;
        private Button BTNSave;
        private Label labelName;
        private Label labelGroup;
        private Label labelNotes;
        private TextBox textBoxNotes;
        private TextBox textBoxName;
        private ComboBox comboBoxGroup;
        private DateTimePicker dateTimePickerNewTask;
        private Label labelDate;
    }
}