namespace LP_5
{
    partial class Form4
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
            username_create = new TextBox();
            password_create = new TextBox();
            submitt = new Button();
            SuspendLayout();
            // 
            // username_create
            // 
            username_create.Location = new Point(328, 100);
            username_create.Name = "username_create";
            username_create.Size = new Size(150, 31);
            username_create.TabIndex = 0;
            // 
            // password_create
            // 
            password_create.Location = new Point(328, 175);
            password_create.Name = "password_create";
            password_create.Size = new Size(150, 31);
            password_create.TabIndex = 1;
            // 
            // submitt
            // 
            submitt.Location = new Point(345, 253);
            submitt.Name = "submitt";
            submitt.Size = new Size(112, 34);
            submitt.TabIndex = 2;
            submitt.Text = "Submitt";
            submitt.UseVisualStyleBackColor = true;
            submitt.Click += submitt_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitt);
            Controls.Add(password_create);
            Controls.Add(username_create);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_create;
        private TextBox password_create;
        private Button submitt;
    }
}