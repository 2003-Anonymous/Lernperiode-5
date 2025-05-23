namespace LP_5
{
    partial class Form3
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
            button1 = new Button();
            txtBox_password = new TextBox();
            txtBox_username = new TextBox();
            label1 = new Label();
            Create_btn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(352, 277);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBox_password
            // 
            txtBox_password.Location = new Point(335, 195);
            txtBox_password.Name = "txtBox_password";
            txtBox_password.Size = new Size(150, 31);
            txtBox_password.TabIndex = 1;
            txtBox_password.Text = "Password";
            // 
            // txtBox_username
            // 
            txtBox_username.Location = new Point(335, 118);
            txtBox_username.Name = "txtBox_username";
            txtBox_username.Size = new Size(150, 31);
            txtBox_username.TabIndex = 2;
            txtBox_username.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 47);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // Create_btn
            // 
            Create_btn.Location = new Point(352, 337);
            Create_btn.Name = "Create_btn";
            Create_btn.Size = new Size(112, 34);
            Create_btn.TabIndex = 4;
            Create_btn.Text = "Create";
            Create_btn.UseVisualStyleBackColor = true;
            Create_btn.Click += Create_btn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Create_btn);
            Controls.Add(label1);
            Controls.Add(txtBox_username);
            Controls.Add(txtBox_password);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtBox_password;
        private TextBox txtBox_username;
        private Label label1;
        private Button Create_btn;
    }
}