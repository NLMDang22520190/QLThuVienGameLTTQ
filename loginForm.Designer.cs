namespace EpistWinform
{
    partial class loginForm
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
            panel1 = new Panel();
            panel5 = new Panel();
            createAccountLabel = new Label();
            forgotpassLabel = new Label();
            loginLabel = new Label();
            panel4 = new Panel();
            loginBtn = new Button();
            panel3 = new Panel();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            panel2 = new Panel();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 426);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(createAccountLabel);
            panel5.Controls.Add(forgotpassLabel);
            panel5.Location = new Point(6, 345);
            panel5.Name = "panel5";
            panel5.Size = new Size(495, 78);
            panel5.TabIndex = 5;
            // 
            // createAccountLabel
            // 
            createAccountLabel.AutoSize = true;
            createAccountLabel.Cursor = Cursors.Hand;
            createAccountLabel.Font = new Font("Tahoma", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            createAccountLabel.Location = new Point(323, 7);
            createAccountLabel.Name = "createAccountLabel";
            createAccountLabel.Size = new Size(169, 22);
            createAccountLabel.TabIndex = 1;
            createAccountLabel.Text = "Create New Account";
            // 
            // forgotpassLabel
            // 
            forgotpassLabel.AutoSize = true;
            forgotpassLabel.Cursor = Cursors.Hand;
            forgotpassLabel.Font = new Font("Tahoma", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            forgotpassLabel.Location = new Point(13, 7);
            forgotpassLabel.Name = "forgotpassLabel";
            forgotpassLabel.Size = new Size(150, 22);
            forgotpassLabel.TabIndex = 0;
            forgotpassLabel.Text = "Forgot Password?";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.Location = new Point(151, 22);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(174, 29);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "EPIST LOGIN";
            // 
            // panel4
            // 
            panel4.Controls.Add(loginBtn);
            panel4.Location = new Point(6, 254);
            panel4.Name = "panel4";
            panel4.Size = new Size(495, 85);
            panel4.TabIndex = 3;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.White;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.Location = new Point(59, 3);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(383, 59);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(passwordTextBox);
            panel3.Controls.Add(passwordLabel);
            panel3.Location = new Point(6, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(495, 85);
            panel3.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(145, 23);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(318, 31);
            passwordTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(28, 28);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(116, 22);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "PASSWORD";
            // 
            // panel2
            // 
            panel2.Controls.Add(usernameTextBox);
            panel2.Controls.Add(usernameLabel);
            panel2.Location = new Point(6, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 85);
            panel2.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(145, 26);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(318, 31);
            usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(28, 31);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(111, 22);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "USERNAME";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(panel1);
            Name = "loginForm";
            Text = "Login";
            Load += loginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Panel panel4;
        private Button loginBtn;
        private Label loginLabel;
        private Panel panel5;
        private Label createAccountLabel;
        private Label forgotpassLabel;
    }
}