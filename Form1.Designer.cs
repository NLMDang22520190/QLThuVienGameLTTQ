namespace EpistWinform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            forgotPassAndCreateAccPanel = new Panel();
            createAccountLabel = new Label();
            forgotpassLabel = new Label();
            loginBtnPanel = new Panel();
            loginBtn = new Button();
            passWordPanel = new Panel();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            userNamePanel = new Panel();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            controlBarPanel = new Panel();
            minimizeBtn = new FontAwesome.Sharp.IconButton();
            closeBtn = new FontAwesome.Sharp.IconButton();
            maximizeBtn = new FontAwesome.Sharp.IconButton();
            logoPictureBox = new PictureBox();
            loginLabel = new Label();
            forgotPassAndCreateAccPanel.SuspendLayout();
            loginBtnPanel.SuspendLayout();
            passWordPanel.SuspendLayout();
            userNamePanel.SuspendLayout();
            controlBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // forgotPassAndCreateAccPanel
            // 
            forgotPassAndCreateAccPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            forgotPassAndCreateAccPanel.Controls.Add(createAccountLabel);
            forgotPassAndCreateAccPanel.Controls.Add(forgotpassLabel);
            forgotPassAndCreateAccPanel.Location = new Point(0, 372);
            forgotPassAndCreateAccPanel.Name = "forgotPassAndCreateAccPanel";
            forgotPassAndCreateAccPanel.Size = new Size(256, 78);
            forgotPassAndCreateAccPanel.TabIndex = 10;
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
            // loginBtnPanel
            // 
            loginBtnPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginBtnPanel.Controls.Add(loginBtn);
            loginBtnPanel.Location = new Point(0, 287);
            loginBtnPanel.Name = "loginBtnPanel";
            loginBtnPanel.Size = new Size(256, 85);
            loginBtnPanel.TabIndex = 9;
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
            // passWordPanel
            // 
            passWordPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passWordPanel.Controls.Add(passwordTextBox);
            passWordPanel.Controls.Add(passwordLabel);
            passWordPanel.Location = new Point(0, 202);
            passWordPanel.Name = "passWordPanel";
            passWordPanel.Size = new Size(256, 85);
            passWordPanel.TabIndex = 8;
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
            // userNamePanel
            // 
            userNamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userNamePanel.Controls.Add(usernameTextBox);
            userNamePanel.Controls.Add(usernameLabel);
            userNamePanel.Location = new Point(0, 104);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(528, 98);
            userNamePanel.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameTextBox.Location = new Point(145, 26);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(374, 31);
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
            // controlBarPanel
            // 
            controlBarPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            controlBarPanel.AutoSize = true;
            controlBarPanel.BackColor = Color.FromArgb(0, 113, 84);
            controlBarPanel.Controls.Add(minimizeBtn);
            controlBarPanel.Controls.Add(closeBtn);
            controlBarPanel.Controls.Add(maximizeBtn);
            controlBarPanel.Controls.Add(logoPictureBox);
            controlBarPanel.Controls.Add(loginLabel);
            controlBarPanel.Location = new Point(0, 1);
            controlBarPanel.Name = "controlBarPanel";
            controlBarPanel.Size = new Size(528, 103);
            controlBarPanel.TabIndex = 11;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            minimizeBtn.IconColor = Color.White;
            minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minimizeBtn.Location = new Point(423, 3);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(30, 30);
            minimizeBtn.TabIndex = 9;
            minimizeBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.ForeColor = Color.White;
            closeBtn.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            closeBtn.IconColor = Color.White;
            closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            closeBtn.Location = new Point(495, 3);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(30, 30);
            closeBtn.TabIndex = 8;
            closeBtn.UseVisualStyleBackColor = true;
            // 
            // maximizeBtn
            // 
            maximizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            maximizeBtn.FlatAppearance.BorderSize = 0;
            maximizeBtn.FlatStyle = FlatStyle.Flat;
            maximizeBtn.ForeColor = Color.White;
            maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            maximizeBtn.IconColor = Color.White;
            maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maximizeBtn.Location = new Point(459, 3);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(30, 30);
            maximizeBtn.TabIndex = 7;
            maximizeBtn.UseVisualStyleBackColor = true;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(28, 0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(100, 100);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 6;
            logoPictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.White;
            loginLabel.Location = new Point(159, 34);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(174, 29);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "EPIST LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(forgotPassAndCreateAccPanel);
            Controls.Add(loginBtnPanel);
            Controls.Add(passWordPanel);
            Controls.Add(userNamePanel);
            Controls.Add(controlBarPanel);
            Name = "Form1";
            Text = "Form1";
            forgotPassAndCreateAccPanel.ResumeLayout(false);
            forgotPassAndCreateAccPanel.PerformLayout();
            loginBtnPanel.ResumeLayout(false);
            passWordPanel.ResumeLayout(false);
            passWordPanel.PerformLayout();
            userNamePanel.ResumeLayout(false);
            userNamePanel.PerformLayout();
            controlBarPanel.ResumeLayout(false);
            controlBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel forgotPassAndCreateAccPanel;
        private Label createAccountLabel;
        private Label forgotpassLabel;
        private Panel loginBtnPanel;
        private Button loginBtn;
        private Panel passWordPanel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Panel userNamePanel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Panel controlBarPanel;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private PictureBox logoPictureBox;
        private Label loginLabel;
    }
}