using Microsoft.VisualBasic.ApplicationServices;

namespace EpistWinform.Forms
{
    partial class Forgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot));
            panel1 = new Panel();
            closeBtn = new FontAwesome.Sharp.IconButton();
            loginLabel = new Label();
            logoPictureBox = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            userNamePanel = new Panel();
            label_countdown = new Label();
            button_sendcode = new Button();
            userNameIcon = new FontAwesome.Sharp.IconPictureBox();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            passWordPanel = new Panel();
            reenter = new TextBox();
            label3 = new Label();
            passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            panel2 = new Panel();
            Code_picturebox = new PictureBox();
            code_textfield = new TextBox();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            userNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userNameIcon).BeginInit();
            passWordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
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
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 150);
            panel1.TabIndex = 1;
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
            closeBtn.Location = new Point(862, 5);
            closeBtn.Margin = new Padding(5, 5, 5, 5);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(40, 40);
            closeBtn.TabIndex = 9;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.White;
            loginLabel.Location = new Point(222, 35);
            loginLabel.Margin = new Padding(2, 0, 2, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(599, 63);
            loginLabel.TabIndex = 8;
            loginLabel.Text = "Forgot your password";
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(42, 0);
            logoPictureBox.Margin = new Padding(2, 2, 2, 2);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(150, 150);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 7;
            logoPictureBox.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(525, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 56);
            label2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 150);
            label1.TabIndex = 1;
            // 
            // userNamePanel
            // 
            userNamePanel.BackColor = Color.White;
            userNamePanel.Controls.Add(label_countdown);
            userNamePanel.Controls.Add(button_sendcode);
            userNamePanel.Controls.Add(userNameIcon);
            userNamePanel.Controls.Add(usernameTextBox);
            userNamePanel.Controls.Add(usernameLabel);
            userNamePanel.Dock = DockStyle.Top;
            userNamePanel.Location = new Point(0, 150);
            userNamePanel.Margin = new Padding(2, 2, 2, 2);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(914, 120);
            userNamePanel.TabIndex = 5;
            // 
            // label_countdown
            // 
            label_countdown.ForeColor = Color.FromArgb(58, 175, 131);
            label_countdown.Location = new Point(816, 25);
            label_countdown.Margin = new Padding(2, 0, 2, 0);
            label_countdown.Name = "label_countdown";
            label_countdown.Size = new Size(52, 34);
            label_countdown.TabIndex = 9;
            label_countdown.Text = "label5";
            // 
            // button_sendcode
            // 
            button_sendcode.AutoSize = true;
            button_sendcode.BackColor = Color.FromArgb(58, 175, 131);
            button_sendcode.Cursor = Cursors.Hand;
            button_sendcode.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button_sendcode.ForeColor = Color.White;
            button_sendcode.Location = new Point(750, 65);
            button_sendcode.Margin = new Padding(2, 2, 2, 2);
            button_sendcode.Name = "button_sendcode";
            button_sendcode.Size = new Size(123, 44);
            button_sendcode.TabIndex = 8;
            button_sendcode.Text = "Send code";
            button_sendcode.UseVisualStyleBackColor = false;
            button_sendcode.Click += button_sendcode_Click;
            // 
            // userNameIcon
            // 
            userNameIcon.BackColor = Color.FromArgb(58, 175, 131);
            userNameIcon.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            userNameIcon.IconColor = Color.White;
            userNameIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            userNameIcon.IconSize = 46;
            userNameIcon.Location = new Point(68, 65);
            userNameIcon.Margin = new Padding(2, 2, 2, 2);
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
            usernameTextBox.Location = new Point(142, 65);
            usernameTextBox.Margin = new Padding(2, 2, 2, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(565, 46);
            usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.FromArgb(58, 175, 131);
            usernameLabel.Location = new Point(58, 12);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(200, 39);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "USERNAME";
            // 
            // passWordPanel
            // 
            passWordPanel.BackColor = Color.White;
            passWordPanel.Controls.Add(reenter);
            passWordPanel.Controls.Add(label3);
            passWordPanel.Controls.Add(passwordIcon);
            passWordPanel.Controls.Add(passwordTextBox);
            passWordPanel.Controls.Add(passwordLabel);
            passWordPanel.Dock = DockStyle.Top;
            passWordPanel.Location = new Point(0, 270);
            passWordPanel.Margin = new Padding(2, 2, 2, 2);
            passWordPanel.Name = "passWordPanel";
            passWordPanel.Size = new Size(914, 105);
            passWordPanel.TabIndex = 6;
            // 
            // reenter
            // 
            reenter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reenter.BackColor = Color.FromArgb(221, 216, 216);
            reenter.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            reenter.Location = new Point(509, 53);
            reenter.Margin = new Padding(2, 2, 2, 2);
            reenter.Name = "reenter";
            reenter.Size = new Size(302, 46);
            reenter.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(58, 175, 131);
            label3.Location = new Point(468, 2);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(437, 39);
            label3.TabIndex = 4;
            label3.Text = "Re-Enter New PASSWORD";
            // 
            // passwordIcon
            // 
            passwordIcon.BackColor = Color.FromArgb(58, 175, 131);
            passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            passwordIcon.IconColor = Color.White;
            passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            passwordIcon.IconSize = 46;
            passwordIcon.Location = new Point(68, 53);
            passwordIcon.Margin = new Padding(2, 2, 2, 2);
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
            passwordTextBox.Location = new Point(142, 53);
            passwordTextBox.Margin = new Padding(2, 2, 2, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(282, 46);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(58, 175, 131);
            passwordLabel.Location = new Point(58, 2);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(292, 39);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "NEW PASSWORD";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Code_picturebox);
            panel2.Controls.Add(code_textfield);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 375);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 282);
            panel2.TabIndex = 8;
            // 
            // Code_picturebox
            // 
            Code_picturebox.BackgroundImageLayout = ImageLayout.Stretch;
            Code_picturebox.Location = new Point(68, 55);
            Code_picturebox.Margin = new Padding(2, 2, 2, 2);
            Code_picturebox.Name = "Code_picturebox";
            Code_picturebox.Size = new Size(46, 46);
            Code_picturebox.TabIndex = 9;
            Code_picturebox.TabStop = false;
            // 
            // code_textfield
            // 
            code_textfield.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            code_textfield.BackColor = Color.FromArgb(221, 216, 216);
            code_textfield.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            code_textfield.Location = new Point(142, 55);
            code_textfield.Margin = new Padding(2, 2, 2, 2);
            code_textfield.Name = "code_textfield";
            code_textfield.Size = new Size(670, 46);
            code_textfield.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(58, 175, 131);
            label4.Location = new Point(58, 2);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 39);
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
            button1.Location = new Point(259, 148);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(402, 83);
            button1.TabIndex = 1;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Forgot
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 657);
            Controls.Add(panel2);
            Controls.Add(passWordPanel);
            Controls.Add(userNamePanel);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(936, 713);
            MinimumSize = new Size(936, 713);
            Name = "Forgot";
            Text = "    ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            userNamePanel.ResumeLayout(false);
            userNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userNameIcon).EndInit();
            passWordPanel.ResumeLayout(false);
            passWordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Code_picturebox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label loginLabel;
        private PictureBox logoPictureBox;
        private Label label2;
        private Label label1;
        private Panel userNamePanel;
        private FontAwesome.Sharp.IconPictureBox userNameIcon;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Panel passWordPanel;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Panel panel2;
        private PictureBox Code_picturebox;
        private TextBox code_textfield;
        private Label label4;
        private Button button1;
        private TextBox reenter;
        private Label label3;
        private Label label_countdown;
        private Button button_sendcode;
        private FontAwesome.Sharp.IconButton closeBtn;
    }
}