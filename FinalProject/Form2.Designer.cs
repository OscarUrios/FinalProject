namespace FinalProject
{
    partial class ModForm
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
            label1 = new Label();
            SuspendLayout();
            // 
            // BTNSave
            // 
            BTNSave.Location = new Point(717, 416);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(75, 23);
            BTNSave.TabIndex = 2;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            // 
            // BTNCancel
            // 
            BTNCancel.Location = new Point(636, 416);
            BTNCancel.Name = "BTNCancel";
            BTNCancel.Size = new Size(75, 23);
            BTNCancel.TabIndex = 3;
            BTNCancel.Text = "Cancel";
            BTNCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 196);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "Still in work";
            // 
            // ModForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 451);
            Controls.Add(label1);
            Controls.Add(BTNCancel);
            Controls.Add(BTNSave);
            MaximumSize = new Size(820, 490);
            MinimumSize = new Size(820, 490);
            Name = "ModForm";
            Text = "DoYourTasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNSave;
        private Button BTNCancel;
        private Label label1;
    }
}