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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            controlBarPanel = new Panel();
            minimizeBtn = new FontAwesome.Sharp.IconButton();
            closeBtn = new FontAwesome.Sharp.IconButton();
            logoPictureBox = new PictureBox();
            loginLabel = new Label();
            userNamePanel = new Panel();
            userNameIcon = new FontAwesome.Sharp.IconPictureBox();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            passWordPanel = new Panel();
            showPassBtn = new FontAwesome.Sharp.IconButton();
            passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            loginBtnPanel = new Panel();
            loginBtn = new Button();
            forgotPassAndCreateAccPanel = new Panel();
            createAccountLabel = new Label();
            forgotpassLabel = new Label();
            controlBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            userNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userNameIcon).BeginInit();
            passWordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            loginBtnPanel.SuspendLayout();
            forgotPassAndCreateAccPanel.SuspendLayout();
            SuspendLayout();
            // 
            // controlBarPanel
            // 
            controlBarPanel.BackColor = Color.FromArgb(0, 113, 84);
            controlBarPanel.Controls.Add(minimizeBtn);
            controlBarPanel.Controls.Add(closeBtn);
            controlBarPanel.Controls.Add(logoPictureBox);
            controlBarPanel.Controls.Add(loginLabel);
            controlBarPanel.Dock = DockStyle.Top;
            controlBarPanel.Location = new Point(0, 0);
            controlBarPanel.Name = "controlBarPanel";
            controlBarPanel.Size = new Size(778, 150);
            controlBarPanel.TabIndex = 6;
            controlBarPanel.MouseDown += controlBarPanel_MouseDown;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            minimizeBtn.IconColor = Color.White;
            minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minimizeBtn.Location = new Point(685, 5);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(40, 40);
            minimizeBtn.TabIndex = 9;
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.ForeColor = Color.White;
            closeBtn.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            closeBtn.IconColor = Color.White;
            closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            closeBtn.Location = new Point(733, 5);
            closeBtn.Margin = new Padding(5);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(40, 40);
            closeBtn.TabIndex = 8;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(28, 0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(150, 150);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 6;
            logoPictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.White;
            loginLabel.Location = new Point(200, 48);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(372, 63);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "EPIST LOGIN";
            // 
            // userNamePanel
            // 
            userNamePanel.BackColor = Color.White;
            userNamePanel.Controls.Add(userNameIcon);
            userNamePanel.Controls.Add(usernameTextBox);
            userNamePanel.Controls.Add(usernameLabel);
            userNamePanel.Dock = DockStyle.Top;
            userNamePanel.Location = new Point(0, 150);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(778, 150);
            userNamePanel.TabIndex = 0;
            // 
            // userNameIcon
            // 
            userNameIcon.BackColor = Color.FromArgb(58, 175, 131);
            userNameIcon.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            userNameIcon.IconColor = Color.White;
            userNameIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            userNameIcon.IconSize = 50;
            userNameIcon.Location = new Point(68, 65);
            userNameIcon.Name = "userNameIcon";
            userNameIcon.Size = new Size(46, 46);
            userNameIcon.TabIndex = 2;
            userNameIcon.TabStop = false;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameTextBox.BackColor = Color.FromArgb(221, 216, 216);
            usernameTextBox.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(141, 65);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(568, 46);
            usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.FromArgb(58, 175, 131);
            usernameLabel.Location = new Point(59, 13);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(200, 39);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "USERNAME";
            // 
            // passWordPanel
            // 
            passWordPanel.BackColor = Color.White;
            passWordPanel.Controls.Add(showPassBtn);
            passWordPanel.Controls.Add(passwordIcon);
            passWordPanel.Controls.Add(passwordTextBox);
            passWordPanel.Controls.Add(passwordLabel);
            passWordPanel.Dock = DockStyle.Top;
            passWordPanel.Location = new Point(0, 300);
            passWordPanel.Name = "passWordPanel";
            passWordPanel.Size = new Size(778, 150);
            passWordPanel.TabIndex = 2;
            // 
            // showPassBtn
            // 
            showPassBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showPassBtn.BackColor = Color.FromArgb(58, 175, 131);
            showPassBtn.ForeColor = Color.White;
            showPassBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showPassBtn.IconColor = Color.White;
            showPassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showPassBtn.IconSize = 55;
            showPassBtn.Location = new Point(715, 71);
            showPassBtn.Name = "showPassBtn";
            showPassBtn.Size = new Size(46, 46);
            showPassBtn.TabIndex = 1;
            showPassBtn.UseVisualStyleBackColor = false;
            showPassBtn.Click += showPassBtn_Click;
            // 
            // passwordIcon
            // 
            passwordIcon.BackColor = Color.FromArgb(58, 175, 131);
            passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            passwordIcon.IconColor = Color.White;
            passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            passwordIcon.IconSize = 46;
            passwordIcon.Location = new Point(68, 71);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new Size(46, 46);
            passwordIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordIcon.TabIndex = 3;
            passwordIcon.TabStop = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.FromArgb(221, 216, 216);
            passwordTextBox.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(141, 71);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(568, 46);
            passwordTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(58, 175, 131);
            passwordLabel.Location = new Point(59, 20);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(205, 39);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "PASSWORD";
            // 
            // loginBtnPanel
            // 
            loginBtnPanel.BackColor = Color.White;
            loginBtnPanel.Controls.Add(loginBtn);
            loginBtnPanel.Dock = DockStyle.Top;
            loginBtnPanel.Location = new Point(0, 450);
            loginBtnPanel.Name = "loginBtnPanel";
            loginBtnPanel.Size = new Size(778, 100);
            loginBtnPanel.TabIndex = 3;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginBtn.BackColor = Color.FromArgb(58, 175, 131);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(68, 20);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(641, 62);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // forgotPassAndCreateAccPanel
            // 
            forgotPassAndCreateAccPanel.BackColor = Color.White;
            forgotPassAndCreateAccPanel.Controls.Add(createAccountLabel);
            forgotPassAndCreateAccPanel.Controls.Add(forgotpassLabel);
            forgotPassAndCreateAccPanel.Dock = DockStyle.Fill;
            forgotPassAndCreateAccPanel.Location = new Point(0, 550);
            forgotPassAndCreateAccPanel.Name = "forgotPassAndCreateAccPanel";
            forgotPassAndCreateAccPanel.Size = new Size(778, 94);
            forgotPassAndCreateAccPanel.TabIndex = 5;
            // 
            // createAccountLabel
            // 
            createAccountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createAccountLabel.AutoSize = true;
            createAccountLabel.Cursor = Cursors.Hand;
            createAccountLabel.Font = new Font("Tahoma", 11F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            createAccountLabel.Location = new Point(557, 7);
            createAccountLabel.Name = "createAccountLabel";
            createAccountLabel.Size = new Size(209, 27);
            createAccountLabel.TabIndex = 1;
            createAccountLabel.Text = "Create New Account";
            // 
            // forgotpassLabel
            // 
            forgotpassLabel.AutoSize = true;
            forgotpassLabel.Cursor = Cursors.Hand;
            forgotpassLabel.Font = new Font("Tahoma", 11F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            forgotpassLabel.Location = new Point(13, 7);
            forgotpassLabel.Name = "forgotpassLabel";
            forgotpassLabel.Size = new Size(183, 27);
            forgotpassLabel.TabIndex = 0;
            forgotpassLabel.Text = "Forgot Password?";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 113, 84);
            ClientSize = new Size(778, 644);
            ControlBox = false;
            Controls.Add(forgotPassAndCreateAccPanel);
            Controls.Add(loginBtnPanel);
            Controls.Add(passWordPanel);
            Controls.Add(userNamePanel);
            Controls.Add(controlBarPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(800, 700);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += loginForm_Load;
            controlBarPanel.ResumeLayout(false);
            controlBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            userNamePanel.ResumeLayout(false);
            userNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userNameIcon).EndInit();
            passWordPanel.ResumeLayout(false);
            passWordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            loginBtnPanel.ResumeLayout(false);
            forgotPassAndCreateAccPanel.ResumeLayout(false);
            forgotPassAndCreateAccPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel controlBarPanel;
        private PictureBox logoPictureBox;
        private Label loginLabel;
        private Panel userNamePanel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Panel passWordPanel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Panel loginBtnPanel;
        private Button loginBtn;
        private Panel forgotPassAndCreateAccPanel;
        private Label createAccountLabel;
        private Label forgotpassLabel;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconPictureBox userNameIcon;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private FontAwesome.Sharp.IconButton showPassBtn;
    }
}