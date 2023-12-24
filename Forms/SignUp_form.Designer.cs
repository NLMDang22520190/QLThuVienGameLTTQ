﻿namespace EpistWinform.Forms
{
    partial class SignUp_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_form));
            panel1 = new Panel();
            closeBtn = new FontAwesome.Sharp.IconButton();
            loginLabel = new Label();
            logoPictureBox = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            loginBtnPanel = new Panel();
            label_countdown = new Label();
            button_sendcode = new Button();
            Gmail_picturebox = new PictureBox();
            gmail_textfield = new TextBox();
            label3 = new Label();
            passWordPanel = new Panel();
            passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            userNamePanel = new Panel();
            DisplayName_Textfield = new TextBox();
            label5 = new Label();
            userNameIcon = new FontAwesome.Sharp.IconPictureBox();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            panel2 = new Panel();
            Code_picturebox = new PictureBox();
            code_textfield = new TextBox();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            loginBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Gmail_picturebox).BeginInit();
            passWordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            userNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userNameIcon).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Code_picturebox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 113, 84);
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(logoPictureBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 192);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
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
            closeBtn.Location = new Point(999, 0);
            closeBtn.Margin = new Padding(6);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(52, 51);
            closeBtn.TabIndex = 10;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.White;
            loginLabel.Location = new Point(355, 49);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(578, 84);
            loginLabel.TabIndex = 8;
            loginLabel.Text = "EPIST-SIGN UP";
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(55, 0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(195, 192);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 7;
            logoPictureBox.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(682, 73);
            label2.Name = "label2";
            label2.Size = new Size(176, 72);
            label2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 192);
            label1.TabIndex = 1;
            // 
            // loginBtnPanel
            // 
            loginBtnPanel.BackColor = Color.White;
            loginBtnPanel.Controls.Add(label_countdown);
            loginBtnPanel.Controls.Add(button_sendcode);
            loginBtnPanel.Controls.Add(Gmail_picturebox);
            loginBtnPanel.Controls.Add(gmail_textfield);
            loginBtnPanel.Controls.Add(label3);
            loginBtnPanel.Dock = DockStyle.Top;
            loginBtnPanel.Location = new Point(0, 480);
            loginBtnPanel.Name = "loginBtnPanel";
            loginBtnPanel.Size = new Size(1066, 131);
            loginBtnPanel.TabIndex = 6;
            // 
            // label_countdown
            // 
            label_countdown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_countdown.ForeColor = Color.FromArgb(58, 175, 131);
            label_countdown.Location = new Point(924, 17);
            label_countdown.Name = "label_countdown";
            label_countdown.Size = new Size(68, 44);
            label_countdown.TabIndex = 7;
            label_countdown.Text = "label5";
            // 
            // button_sendcode
            // 
            button_sendcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_sendcode.BackColor = Color.FromArgb(58, 175, 131);
            button_sendcode.Cursor = Cursors.Hand;
            button_sendcode.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button_sendcode.ForeColor = Color.White;
            button_sendcode.Location = new Point(836, 68);
            button_sendcode.Name = "button_sendcode";
            button_sendcode.Size = new Size(153, 59);
            button_sendcode.TabIndex = 6;
            button_sendcode.Text = "Send code";
            button_sendcode.UseVisualStyleBackColor = false;
            button_sendcode.Click += button_sendcode_Click;
            // 
            // Gmail_picturebox
            // 
            Gmail_picturebox.BackgroundImageLayout = ImageLayout.Stretch;
            Gmail_picturebox.Location = new Point(88, 68);
            Gmail_picturebox.Name = "Gmail_picturebox";
            Gmail_picturebox.Size = new Size(60, 59);
            Gmail_picturebox.TabIndex = 5;
            Gmail_picturebox.TabStop = false;
            // 
            // gmail_textfield
            // 
            gmail_textfield.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gmail_textfield.BackColor = Color.FromArgb(221, 216, 216);
            gmail_textfield.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            gmail_textfield.Location = new Point(185, 68);
            gmail_textfield.Name = "gmail_textfield";
            gmail_textfield.Size = new Size(633, 59);
            gmail_textfield.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(58, 175, 131);
            label3.Location = new Point(75, 3);
            label3.Name = "label3";
            label3.Size = new Size(167, 52);
            label3.TabIndex = 3;
            label3.Text = "GMAIL";
            // 
            // passWordPanel
            // 
            passWordPanel.BackColor = Color.White;
            passWordPanel.Controls.Add(passwordIcon);
            passWordPanel.Controls.Add(passwordTextBox);
            passWordPanel.Controls.Add(passwordLabel);
            passWordPanel.Dock = DockStyle.Top;
            passWordPanel.Location = new Point(0, 346);
            passWordPanel.Name = "passWordPanel";
            passWordPanel.Size = new Size(1066, 134);
            passWordPanel.TabIndex = 5;
            // 
            // passwordIcon
            // 
            passwordIcon.BackColor = Color.FromArgb(58, 175, 131);
            passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            passwordIcon.IconColor = Color.White;
            passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            passwordIcon.IconSize = 59;
            passwordIcon.Location = new Point(88, 68);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new Size(60, 59);
            passwordIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordIcon.TabIndex = 3;
            passwordIcon.TabStop = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.FromArgb(221, 216, 216);
            passwordTextBox.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(185, 68);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(806, 59);
            passwordTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(58, 175, 131);
            passwordLabel.Location = new Point(75, 3);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(274, 52);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "PASSWORD";
            // 
            // userNamePanel
            // 
            userNamePanel.BackColor = Color.White;
            userNamePanel.Controls.Add(DisplayName_Textfield);
            userNamePanel.Controls.Add(label5);
            userNamePanel.Controls.Add(userNameIcon);
            userNamePanel.Controls.Add(usernameTextBox);
            userNamePanel.Controls.Add(usernameLabel);
            userNamePanel.Dock = DockStyle.Top;
            userNamePanel.Location = new Point(0, 192);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(1066, 154);
            userNamePanel.TabIndex = 4;
            // 
            // DisplayName_Textfield
            // 
            DisplayName_Textfield.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DisplayName_Textfield.BackColor = Color.FromArgb(221, 216, 216);
            DisplayName_Textfield.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayName_Textfield.Location = new Point(612, 83);
            DisplayName_Textfield.Name = "DisplayName_Textfield";
            DisplayName_Textfield.Size = new Size(377, 59);
            DisplayName_Textfield.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(58, 175, 131);
            label5.Location = new Point(605, 15);
            label5.Name = "label5";
            label5.Size = new Size(307, 52);
            label5.TabIndex = 3;
            label5.Text = "DisplayName";
            // 
            // userNameIcon
            // 
            userNameIcon.BackColor = Color.FromArgb(58, 175, 131);
            userNameIcon.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            userNameIcon.IconColor = Color.White;
            userNameIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            userNameIcon.IconSize = 59;
            userNameIcon.Location = new Point(88, 83);
            userNameIcon.Name = "userNameIcon";
            userNameIcon.Size = new Size(60, 59);
            userNameIcon.TabIndex = 2;
            userNameIcon.TabStop = false;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameTextBox.BackColor = Color.FromArgb(221, 216, 216);
            usernameTextBox.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(185, 83);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(361, 59);
            usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.FromArgb(58, 175, 131);
            usernameLabel.Location = new Point(75, 15);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(264, 52);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "USERNAME";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Code_picturebox);
            panel2.Controls.Add(code_textfield);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 611);
            panel2.Name = "panel2";
            panel2.Size = new Size(1066, 252);
            panel2.TabIndex = 7;
            // 
            // Code_picturebox
            // 
            Code_picturebox.BackgroundImageLayout = ImageLayout.Stretch;
            Code_picturebox.Location = new Point(88, 70);
            Code_picturebox.Name = "Code_picturebox";
            Code_picturebox.Size = new Size(60, 59);
            Code_picturebox.TabIndex = 9;
            Code_picturebox.TabStop = false;
            // 
            // code_textfield
            // 
            code_textfield.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            code_textfield.BackColor = Color.FromArgb(221, 216, 216);
            code_textfield.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            code_textfield.Location = new Point(185, 70);
            code_textfield.Name = "code_textfield";
            code_textfield.Size = new Size(806, 59);
            code_textfield.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(58, 175, 131);
            label4.Location = new Point(75, 3);
            label4.Name = "label4";
            label4.Size = new Size(131, 52);
            label4.TabIndex = 7;
            label4.Text = "Code";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(58, 175, 131);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(290, 148);
            button1.Name = "button1";
            button1.Size = new Size(505, 54);
            button1.TabIndex = 1;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SignUp_form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 863);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(loginBtnPanel);
            Controls.Add(passWordPanel);
            Controls.Add(userNamePanel);
            Controls.Add(panel1);
            MaximumSize = new Size(1092, 934);
            MinimumSize = new Size(1092, 934);
            Name = "SignUp_form";
            Text = "   ";
            Load += SignUp_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            loginBtnPanel.ResumeLayout(false);
            loginBtnPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Gmail_picturebox).EndInit();
            passWordPanel.ResumeLayout(false);
            passWordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            userNamePanel.ResumeLayout(false);
            userNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userNameIcon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Code_picturebox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox logoPictureBox;
        private Label loginLabel;
        private Panel loginBtnPanel;
        private Panel passWordPanel;
        private FontAwesome.Sharp.IconButton showPassBtn;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Panel userNamePanel;
        private FontAwesome.Sharp.IconPictureBox userNameIcon;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Panel panel2;
        private Button button1;
        private TextBox gmail_textfield;
        private Label label3;
        private PictureBox Gmail_picturebox;
        private Button button_sendcode;
        private PictureBox Code_picturebox;
        private TextBox code_textfield;
        private Label label4;
        private Label label_countdown;
        private Label label5;
        private TextBox DisplayName_Textfield;
        private FontAwesome.Sharp.IconButton closeBtn;
    }
}