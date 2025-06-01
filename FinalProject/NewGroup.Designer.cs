namespace FinalProject
{
    partial class NewGroup
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
            BTNSave = new Button();
            BTNCancel = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // BTNSave
            // 
            BTNSave.Location = new Point(162, 78);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(75, 23);
            BTNSave.TabIndex = 2;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            BTNSave.Click += BTNSave_Click;
            // 
            // BTNCancel
            // 
            BTNCancel.Location = new Point(81, 78);
            BTNCancel.Name = "BTNCancel";
            BTNCancel.Size = new Size(75, 23);
            BTNCancel.TabIndex = 3;
            BTNCancel.Text = "Cancel";
            BTNCancel.UseVisualStyleBackColor = true;
            BTNCancel.Click += BTNCancel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 22);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // NewGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 121);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(BTNCancel);
            Controls.Add(BTNSave);
            Name = "NewGroup";
            Text = "DoYourTasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNSave;
        private Button BTNCancel;
        private TextBox textBox1;
        private Label label2;
    }
}