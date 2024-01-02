namespace EpistWinform.Forms
{
    partial class userForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            DisplayNameTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            EditButton = new Button();
            SaveButton = new Button();
            CancelButton = new Button();
            displayNamePanel = new Panel();
            displayNameIcon = new FontAwesome.Sharp.IconPictureBox();
            usernameLabel = new Label();
            userNamePanel = new Panel();
            userNameIcon = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            passwordPanel = new Panel();
            passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            displayNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displayNameIcon).BeginInit();
            userNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userNameIcon).BeginInit();
            passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayNameTextBox
            // 
            DisplayNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DisplayNameTextBox.BackColor = SystemColors.Control;
            DisplayNameTextBox.Location = new Point(98, 75);
            DisplayNameTextBox.Name = "DisplayNameTextBox";
            DisplayNameTextBox.Size = new Size(316, 27);
            DisplayNameTextBox.TabIndex = 0;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.BackColor = SystemColors.Control;
            UsernameTextBox.Location = new Point(98, 71);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(316, 27);
            UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.BackColor = SystemColors.Control;
            PasswordTextBox.Location = new Point(98, 73);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(316, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(58, 175, 131);
            EditButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(27, 26);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(155, 50);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click_1;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(58, 175, 131);
            SaveButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(6, 26);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(155, 50);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(58, 175, 131);
            CancelButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(0, 26);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(155, 50);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // displayNamePanel
            // 
            displayNamePanel.Controls.Add(displayNameIcon);
            displayNamePanel.Controls.Add(usernameLabel);
            displayNamePanel.Controls.Add(DisplayNameTextBox);
            displayNamePanel.Dock = DockStyle.Top;
            displayNamePanel.Location = new Point(0, 0);
            displayNamePanel.Margin = new Padding(2);
            displayNamePanel.Name = "displayNamePanel";
            displayNamePanel.Size = new Size(522, 129);
            displayNamePanel.TabIndex = 6;
            // 
            // displayNameIcon
            // 
            displayNameIcon.BackColor = Color.FromArgb(58, 175, 131);
            displayNameIcon.IconChar = FontAwesome.Sharp.IconChar.Display;
            displayNameIcon.IconColor = Color.White;
            displayNameIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            displayNameIcon.IconSize = 37;
            displayNameIcon.Location = new Point(42, 65);
            displayNameIcon.Name = "displayNameIcon";
            displayNameIcon.Size = new Size(37, 37);
            displayNameIcon.TabIndex = 2;
            displayNameIcon.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.FromArgb(58, 175, 131);
            usernameLabel.Location = new Point(34, 21);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(222, 33);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "DISPLAY NAME";
            // 
            // userNamePanel
            // 
            userNamePanel.Controls.Add(userNameIcon);
            userNamePanel.Controls.Add(label1);
            userNamePanel.Controls.Add(UsernameTextBox);
            userNamePanel.Dock = DockStyle.Top;
            userNamePanel.Location = new Point(0, 129);
            userNamePanel.Margin = new Padding(2);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(522, 139);
            userNamePanel.TabIndex = 7;
            // 
            // userNameIcon
            // 
            userNameIcon.BackColor = Color.FromArgb(58, 175, 131);
            userNameIcon.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            userNameIcon.IconColor = Color.White;
            userNameIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            userNameIcon.IconSize = 37;
            userNameIcon.Location = new Point(42, 61);
            userNameIcon.Margin = new Padding(2);
            userNameIcon.Name = "userNameIcon";
            userNameIcon.Size = new Size(37, 37);
            userNameIcon.TabIndex = 3;
            userNameIcon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(58, 175, 131);
            label1.Location = new Point(34, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 33);
            label1.TabIndex = 2;
            label1.Text = "USERNAME";
            // 
            // passwordPanel
            // 
            passwordPanel.Controls.Add(passwordIcon);
            passwordPanel.Controls.Add(label2);
            passwordPanel.Controls.Add(PasswordTextBox);
            passwordPanel.Dock = DockStyle.Top;
            passwordPanel.Location = new Point(0, 268);
            passwordPanel.Margin = new Padding(2);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(522, 142);
            passwordPanel.TabIndex = 8;
            // 
            // passwordIcon
            // 
            passwordIcon.BackColor = Color.FromArgb(58, 175, 131);
            passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            passwordIcon.IconColor = Color.White;
            passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            passwordIcon.IconSize = 37;
            passwordIcon.Location = new Point(42, 63);
            passwordIcon.Margin = new Padding(2);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new Size(37, 37);
            passwordIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordIcon.TabIndex = 4;
            passwordIcon.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(58, 175, 131);
            label2.Location = new Point(34, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 33);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1033, 647);
            splitContainer1.SplitterDistance = 261;
            splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(panel1);
            splitContainer2.Panel1.Controls.Add(passwordPanel);
            splitContainer2.Panel1.Controls.Add(userNamePanel);
            splitContainer2.Panel1.Controls.Add(displayNamePanel);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer2.Panel2.BackgroundImage");
            splitContainer2.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer2.Size = new Size(768, 647);
            splitContainer2.SplitterDistance = 522;
            splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 237);
            panel1.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(CancelButton);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(348, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(171, 237);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(SaveButton);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(182, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(166, 237);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(EditButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(182, 237);
            panel2.TabIndex = 0;
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // userForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1033, 647);
            Controls.Add(splitContainer1);
            Margin = new Padding(2);
            Name = "userForm";
            Text = "userForm";
            Load += userForm_Load;
            displayNamePanel.ResumeLayout(false);
            displayNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)displayNameIcon).EndInit();
            userNamePanel.ResumeLayout(false);
            userNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userNameIcon).EndInit();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox DisplayNameTextBox;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button EditButton;
        private Button SaveButton;
        private Button CancelButton;
        private Panel displayNamePanel;
        private Panel userNamePanel;
        private Panel passwordPanel;
        private Label usernameLabel;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox userNameIcon;
        private FontAwesome.Sharp.IconPictureBox displayNameIcon;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Panel panel1;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
    }
}