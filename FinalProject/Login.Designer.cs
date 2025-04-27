namespace FinalProject
{
    partial class Login
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
            BTNLogIn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BTNLogIn
            // 
            BTNLogIn.Location = new Point(237, 186);
            BTNLogIn.Name = "BTNLogIn";
            BTNLogIn.Size = new Size(75, 23);
            BTNLogIn.TabIndex = 2;
            BTNLogIn.Text = "Log-In";
            BTNLogIn.UseVisualStyleBackColor = true;
            BTNLogIn.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 221);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(BTNLogIn);
            MaximumSize = new Size(340, 260);
            MinimumSize = new Size(340, 260);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNLogIn;
        private TextBox textBox1;
        private Label label1;
    }
}