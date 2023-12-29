namespace EpistWinform.Forms
{
    partial class adminForm
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
            OpenFileDialog = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            UserTabPage = new TabPage();
            mainSplitContainer = new SplitContainer();
            confirmButton = new Button();
            userInfoFlowLayoutPanel = new FlowLayoutPanel();
            adminCheckBox = new CheckBox();
            gmailTextBox = new TextBox();
            gmailLabel = new Label();
            displayNameTextBox = new TextBox();
            displayNameLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            userIDTextBox = new TextBox();
            userIDLabel = new Label();
            adminFlowLayoutPanel = new FlowLayoutPanel();
            toolsPanel = new Panel();
            mainToolsPanel = new Panel();
            toolsSplitContainer = new SplitContainer();
            EditAndViewSplitContainer = new SplitContainer();
            viewButton = new Button();
            editUserButton = new Button();
            addAndRemoveSplitContainer = new SplitContainer();
            removeUserButton = new Button();
            addUserButton = new Button();
            searchSplitContainer = new SplitContainer();
            searchUserByColumnComboBox = new ComboBox();
            searchUserComboBox = new ComboBox();
            userInfoDataGridView = new DataGridView();
            GameTabPage = new TabPage();
            InfoFlowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gamePictureBox3 = new PictureBox();
            gamePictureBox2 = new PictureBox();
            gamePictureBox1 = new PictureBox();
            pictureLabel = new Label();
            gameDecPanel = new Panel();
            gameDetailLabel = new Label();
            gameNamePanel = new Panel();
            nameLabel = new Label();
            gameNameTextBox = new TextBox();
            mainControlPanel = new Panel();
            addButton = new Button();
            editButton = new Button();
            gameComboBox = new ComboBox();
            gameDataGridView = new DataGridView();
            adminTabControl = new TabControl();
            UserTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            userInfoFlowLayoutPanel.SuspendLayout();
            toolsPanel.SuspendLayout();
            mainToolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolsSplitContainer).BeginInit();
            toolsSplitContainer.Panel1.SuspendLayout();
            toolsSplitContainer.Panel2.SuspendLayout();
            toolsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditAndViewSplitContainer).BeginInit();
            EditAndViewSplitContainer.Panel1.SuspendLayout();
            EditAndViewSplitContainer.Panel2.SuspendLayout();
            EditAndViewSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addAndRemoveSplitContainer).BeginInit();
            addAndRemoveSplitContainer.Panel1.SuspendLayout();
            addAndRemoveSplitContainer.Panel2.SuspendLayout();
            addAndRemoveSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchSplitContainer).BeginInit();
            searchSplitContainer.Panel1.SuspendLayout();
            searchSplitContainer.Panel2.SuspendLayout();
            searchSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userInfoDataGridView).BeginInit();
            GameTabPage.SuspendLayout();
            InfoFlowLayoutPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox1).BeginInit();
            gameDecPanel.SuspendLayout();
            gameNamePanel.SuspendLayout();
            mainControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameDataGridView).BeginInit();
            adminTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog";
            // 
            // UserTabPage
            // 
            UserTabPage.BackColor = Color.FromArgb(171, 253, 255);
            UserTabPage.Controls.Add(mainSplitContainer);
            UserTabPage.Location = new Point(4, 38);
            UserTabPage.Margin = new Padding(2);
            UserTabPage.Name = "UserTabPage";
            UserTabPage.Padding = new Padding(2);
            UserTabPage.Size = new Size(1191, 516);
            UserTabPage.TabIndex = 2;
            UserTabPage.Text = "Users";
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(2, 2);
            mainSplitContainer.Margin = new Padding(2);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(userInfoDataGridView);
            mainSplitContainer.Panel1.Controls.Add(toolsPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(userInfoFlowLayoutPanel);
            mainSplitContainer.Panel2.Controls.Add(confirmButton);
            mainSplitContainer.Panel2MinSize = 100;
            mainSplitContainer.Size = new Size(1187, 512);
            mainSplitContainer.SplitterDistance = 788;
            mainSplitContainer.TabIndex = 0;
            // 
            // confirmButton
            // 
            confirmButton.AutoSize = true;
            confirmButton.BackColor = Color.Cyan;
            confirmButton.Dock = DockStyle.Bottom;
            confirmButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.ForeColor = Color.MidnightBlue;
            confirmButton.Location = new Point(0, 427);
            confirmButton.Margin = new Padding(4);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(395, 85);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "CONFIRM CHANGE";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // userInfoFlowLayoutPanel
            // 
            userInfoFlowLayoutPanel.AutoScroll = true;
            userInfoFlowLayoutPanel.Controls.Add(adminFlowLayoutPanel);
            userInfoFlowLayoutPanel.Controls.Add(userIDLabel);
            userInfoFlowLayoutPanel.Controls.Add(userIDTextBox);
            userInfoFlowLayoutPanel.Controls.Add(usernameLabel);
            userInfoFlowLayoutPanel.Controls.Add(usernameTextBox);
            userInfoFlowLayoutPanel.Controls.Add(passwordLabel);
            userInfoFlowLayoutPanel.Controls.Add(passwordTextBox);
            userInfoFlowLayoutPanel.Controls.Add(displayNameLabel);
            userInfoFlowLayoutPanel.Controls.Add(displayNameTextBox);
            userInfoFlowLayoutPanel.Controls.Add(gmailLabel);
            userInfoFlowLayoutPanel.Controls.Add(gmailTextBox);
            userInfoFlowLayoutPanel.Controls.Add(adminCheckBox);
            userInfoFlowLayoutPanel.Dock = DockStyle.Fill;
            userInfoFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            userInfoFlowLayoutPanel.Location = new Point(0, 0);
            userInfoFlowLayoutPanel.Margin = new Padding(4);
            userInfoFlowLayoutPanel.Name = "userInfoFlowLayoutPanel";
            userInfoFlowLayoutPanel.Size = new Size(395, 427);
            userInfoFlowLayoutPanel.TabIndex = 0;
            // 
            // adminCheckBox
            // 
            adminCheckBox.AutoSize = true;
            adminCheckBox.Dock = DockStyle.Top;
            adminCheckBox.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            adminCheckBox.Location = new Point(208, 48);
            adminCheckBox.Margin = new Padding(4);
            adminCheckBox.Name = "adminCheckBox";
            adminCheckBox.Size = new Size(389, 40);
            adminCheckBox.TabIndex = 2;
            adminCheckBox.Text = "Admin";
            adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // gmailTextBox
            // 
            gmailTextBox.Location = new Point(208, 4);
            gmailTextBox.Margin = new Padding(4);
            gmailTextBox.Name = "gmailTextBox";
            gmailTextBox.Size = new Size(389, 36);
            gmailTextBox.TabIndex = 1;
            // 
            // gmailLabel
            // 
            gmailLabel.AutoSize = true;
            gmailLabel.Dock = DockStyle.Top;
            gmailLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            gmailLabel.Location = new Point(4, 328);
            gmailLabel.Margin = new Padding(4, 0, 4, 0);
            gmailLabel.Name = "gmailLabel";
            gmailLabel.Size = new Size(196, 36);
            gmailLabel.TabIndex = 0;
            gmailLabel.Text = "Gmail";
            // 
            // displayNameTextBox
            // 
            displayNameTextBox.Dock = DockStyle.Top;
            displayNameTextBox.Location = new Point(4, 288);
            displayNameTextBox.Margin = new Padding(4);
            displayNameTextBox.Name = "displayNameTextBox";
            displayNameTextBox.Size = new Size(196, 36);
            displayNameTextBox.TabIndex = 1;
            // 
            // displayNameLabel
            // 
            displayNameLabel.AutoSize = true;
            displayNameLabel.Dock = DockStyle.Top;
            displayNameLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            displayNameLabel.Location = new Point(4, 248);
            displayNameLabel.Margin = new Padding(4, 0, 4, 0);
            displayNameLabel.Name = "displayNameLabel";
            displayNameLabel.Size = new Size(196, 36);
            displayNameLabel.TabIndex = 0;
            displayNameLabel.Text = "Display Name";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Top;
            passwordTextBox.Location = new Point(4, 208);
            passwordTextBox.Margin = new Padding(4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(196, 36);
            passwordTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Dock = DockStyle.Top;
            passwordLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(4, 168);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(196, 36);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Top;
            usernameTextBox.Location = new Point(4, 128);
            usernameTextBox.Margin = new Padding(4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(196, 36);
            usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Dock = DockStyle.Top;
            usernameLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(4, 88);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(196, 36);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // userIDTextBox
            // 
            userIDTextBox.Dock = DockStyle.Top;
            userIDTextBox.Location = new Point(4, 48);
            userIDTextBox.Margin = new Padding(4);
            userIDTextBox.Name = "userIDTextBox";
            userIDTextBox.Size = new Size(196, 36);
            userIDTextBox.TabIndex = 1;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Dock = DockStyle.Top;
            userIDLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            userIDLabel.Location = new Point(4, 8);
            userIDLabel.Margin = new Padding(4, 0, 4, 0);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(196, 36);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = "ID";
            // 
            // adminFlowLayoutPanel
            // 
            adminFlowLayoutPanel.AutoSize = true;
            adminFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            adminFlowLayoutPanel.Location = new Point(4, 4);
            adminFlowLayoutPanel.Margin = new Padding(4);
            adminFlowLayoutPanel.Name = "adminFlowLayoutPanel";
            adminFlowLayoutPanel.Size = new Size(0, 0);
            adminFlowLayoutPanel.TabIndex = 4;
            // 
            // toolsPanel
            // 
            toolsPanel.Controls.Add(searchSplitContainer);
            toolsPanel.Controls.Add(mainToolsPanel);
            toolsPanel.Dock = DockStyle.Top;
            toolsPanel.Location = new Point(0, 0);
            toolsPanel.Margin = new Padding(4);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(788, 178);
            toolsPanel.TabIndex = 0;
            // 
            // mainToolsPanel
            // 
            mainToolsPanel.Controls.Add(toolsSplitContainer);
            mainToolsPanel.Dock = DockStyle.Top;
            mainToolsPanel.Location = new Point(0, 0);
            mainToolsPanel.Margin = new Padding(4);
            mainToolsPanel.Name = "mainToolsPanel";
            mainToolsPanel.Size = new Size(788, 125);
            mainToolsPanel.TabIndex = 0;
            // 
            // toolsSplitContainer
            // 
            toolsSplitContainer.Dock = DockStyle.Fill;
            toolsSplitContainer.IsSplitterFixed = true;
            toolsSplitContainer.Location = new Point(0, 0);
            toolsSplitContainer.Margin = new Padding(4);
            toolsSplitContainer.Name = "toolsSplitContainer";
            // 
            // toolsSplitContainer.Panel1
            // 
            toolsSplitContainer.Panel1.BackColor = Color.FromArgb(171, 253, 255);
            toolsSplitContainer.Panel1.Controls.Add(addAndRemoveSplitContainer);
            // 
            // toolsSplitContainer.Panel2
            // 
            toolsSplitContainer.Panel2.Controls.Add(EditAndViewSplitContainer);
            toolsSplitContainer.Size = new Size(788, 125);
            toolsSplitContainer.SplitterDistance = 390;
            toolsSplitContainer.SplitterWidth = 5;
            toolsSplitContainer.TabIndex = 1;
            // 
            // EditAndViewSplitContainer
            // 
            EditAndViewSplitContainer.Dock = DockStyle.Fill;
            EditAndViewSplitContainer.IsSplitterFixed = true;
            EditAndViewSplitContainer.Location = new Point(0, 0);
            EditAndViewSplitContainer.Margin = new Padding(4);
            EditAndViewSplitContainer.Name = "EditAndViewSplitContainer";
            // 
            // EditAndViewSplitContainer.Panel1
            // 
            EditAndViewSplitContainer.Panel1.Controls.Add(editUserButton);
            // 
            // EditAndViewSplitContainer.Panel2
            // 
            EditAndViewSplitContainer.Panel2.Controls.Add(viewButton);
            EditAndViewSplitContainer.Size = new Size(393, 125);
            EditAndViewSplitContainer.SplitterDistance = 193;
            EditAndViewSplitContainer.TabIndex = 0;
            // 
            // viewButton
            // 
            viewButton.BackColor = Color.Cyan;
            viewButton.Dock = DockStyle.Fill;
            viewButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            viewButton.Location = new Point(0, 0);
            viewButton.Margin = new Padding(4);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(196, 125);
            viewButton.TabIndex = 5;
            viewButton.Text = "VIEW";
            viewButton.UseVisualStyleBackColor = false;
            viewButton.Click += viewButton_Click;
            // 
            // editUserButton
            // 
            editUserButton.BackColor = Color.Cyan;
            editUserButton.Dock = DockStyle.Fill;
            editUserButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            editUserButton.Location = new Point(0, 0);
            editUserButton.Margin = new Padding(4);
            editUserButton.Name = "editUserButton";
            editUserButton.Size = new Size(193, 125);
            editUserButton.TabIndex = 0;
            editUserButton.Text = "EDIT";
            editUserButton.UseVisualStyleBackColor = false;
            editUserButton.Click += editUserButton_Click;
            // 
            // addAndRemoveSplitContainer
            // 
            addAndRemoveSplitContainer.Dock = DockStyle.Fill;
            addAndRemoveSplitContainer.IsSplitterFixed = true;
            addAndRemoveSplitContainer.Location = new Point(0, 0);
            addAndRemoveSplitContainer.Margin = new Padding(4);
            addAndRemoveSplitContainer.Name = "addAndRemoveSplitContainer";
            // 
            // addAndRemoveSplitContainer.Panel1
            // 
            addAndRemoveSplitContainer.Panel1.Controls.Add(addUserButton);
            // 
            // addAndRemoveSplitContainer.Panel2
            // 
            addAndRemoveSplitContainer.Panel2.Controls.Add(removeUserButton);
            addAndRemoveSplitContainer.Size = new Size(390, 125);
            addAndRemoveSplitContainer.SplitterDistance = 191;
            addAndRemoveSplitContainer.TabIndex = 0;
            // 
            // removeUserButton
            // 
            removeUserButton.BackColor = Color.Cyan;
            removeUserButton.Dock = DockStyle.Fill;
            removeUserButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            removeUserButton.Location = new Point(0, 0);
            removeUserButton.Margin = new Padding(4);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(195, 125);
            removeUserButton.TabIndex = 0;
            removeUserButton.Text = "REMOVE";
            removeUserButton.UseVisualStyleBackColor = false;
            removeUserButton.Click += removeUserButton_Click;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.Cyan;
            addUserButton.Dock = DockStyle.Fill;
            addUserButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            addUserButton.Location = new Point(0, 0);
            addUserButton.Margin = new Padding(4);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(191, 125);
            addUserButton.TabIndex = 0;
            addUserButton.Text = "ADD";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            // 
            // searchSplitContainer
            // 
            searchSplitContainer.Dock = DockStyle.Fill;
            searchSplitContainer.Location = new Point(0, 125);
            searchSplitContainer.Margin = new Padding(4);
            searchSplitContainer.Name = "searchSplitContainer";
            // 
            // searchSplitContainer.Panel1
            // 
            searchSplitContainer.Panel1.Controls.Add(searchUserComboBox);
            // 
            // searchSplitContainer.Panel2
            // 
            searchSplitContainer.Panel2.Controls.Add(searchUserByColumnComboBox);
            searchSplitContainer.Size = new Size(788, 53);
            searchSplitContainer.SplitterDistance = 494;
            searchSplitContainer.TabIndex = 1;
            // 
            // searchUserByColumnComboBox
            // 
            searchUserByColumnComboBox.Dock = DockStyle.Fill;
            searchUserByColumnComboBox.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            searchUserByColumnComboBox.FormattingEnabled = true;
            searchUserByColumnComboBox.Location = new Point(0, 0);
            searchUserByColumnComboBox.Margin = new Padding(4);
            searchUserByColumnComboBox.Name = "searchUserByColumnComboBox";
            searchUserByColumnComboBox.Size = new Size(290, 42);
            searchUserByColumnComboBox.TabIndex = 0;
            searchUserByColumnComboBox.SelectedIndexChanged += searchUserByColumnComboBox_SelectedIndexChanged;
            // 
            // searchUserComboBox
            // 
            searchUserComboBox.Dock = DockStyle.Fill;
            searchUserComboBox.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            searchUserComboBox.FormattingEnabled = true;
            searchUserComboBox.Location = new Point(0, 0);
            searchUserComboBox.Margin = new Padding(4);
            searchUserComboBox.Name = "searchUserComboBox";
            searchUserComboBox.Size = new Size(494, 42);
            searchUserComboBox.TabIndex = 0;
            searchUserComboBox.TextChanged += searchUserComboBox_TextChanged;
            // 
            // userInfoDataGridView
            // 
            userInfoDataGridView.AllowUserToAddRows = false;
            userInfoDataGridView.AllowUserToDeleteRows = false;
            userInfoDataGridView.AllowUserToOrderColumns = true;
            userInfoDataGridView.BackgroundColor = Color.FromArgb(171, 253, 255);
            userInfoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userInfoDataGridView.Dock = DockStyle.Fill;
            userInfoDataGridView.Location = new Point(0, 178);
            userInfoDataGridView.Margin = new Padding(4);
            userInfoDataGridView.Name = "userInfoDataGridView";
            userInfoDataGridView.RowHeadersWidth = 51;
            userInfoDataGridView.RowTemplate.Height = 29;
            userInfoDataGridView.Size = new Size(788, 334);
            userInfoDataGridView.TabIndex = 1;
            // 
            // GameTabPage
            // 
            GameTabPage.Controls.Add(gameDataGridView);
            GameTabPage.Controls.Add(mainControlPanel);
            GameTabPage.Controls.Add(InfoFlowLayoutPanel);
            GameTabPage.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            GameTabPage.Location = new Point(4, 38);
            GameTabPage.Margin = new Padding(4);
            GameTabPage.Name = "GameTabPage";
            GameTabPage.Padding = new Padding(4);
            GameTabPage.Size = new Size(1191, 516);
            GameTabPage.TabIndex = 0;
            GameTabPage.Text = "Games";
            GameTabPage.UseVisualStyleBackColor = true;
            // 
            // InfoFlowLayoutPanel
            // 
            InfoFlowLayoutPanel.AutoScroll = true;
            InfoFlowLayoutPanel.BackColor = Color.FromArgb(255, 254, 145);
            InfoFlowLayoutPanel.Controls.Add(gameNamePanel);
            InfoFlowLayoutPanel.Controls.Add(gameDecPanel);
            InfoFlowLayoutPanel.Controls.Add(flowLayoutPanel1);
            InfoFlowLayoutPanel.Dock = DockStyle.Right;
            InfoFlowLayoutPanel.Location = new Point(772, 4);
            InfoFlowLayoutPanel.Margin = new Padding(4);
            InfoFlowLayoutPanel.Name = "InfoFlowLayoutPanel";
            InfoFlowLayoutPanel.Size = new Size(415, 508);
            InfoFlowLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureLabel);
            flowLayoutPanel1.Controls.Add(gamePictureBox1);
            flowLayoutPanel1.Controls.Add(gamePictureBox2);
            flowLayoutPanel1.Controls.Add(gamePictureBox3);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(2, 210);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(404, 432);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // gamePictureBox3
            // 
            gamePictureBox3.Location = new Point(2, 294);
            gamePictureBox3.Margin = new Padding(2);
            gamePictureBox3.Name = "gamePictureBox3";
            gamePictureBox3.Size = new Size(398, 124);
            gamePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox3.TabIndex = 2;
            gamePictureBox3.TabStop = false;
            // 
            // gamePictureBox2
            // 
            gamePictureBox2.Location = new Point(2, 166);
            gamePictureBox2.Margin = new Padding(2);
            gamePictureBox2.Name = "gamePictureBox2";
            gamePictureBox2.Size = new Size(398, 124);
            gamePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox2.TabIndex = 3;
            gamePictureBox2.TabStop = false;
            // 
            // gamePictureBox1
            // 
            gamePictureBox1.Location = new Point(2, 38);
            gamePictureBox1.Margin = new Padding(2);
            gamePictureBox1.Name = "gamePictureBox1";
            gamePictureBox1.Size = new Size(398, 124);
            gamePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox1.TabIndex = 1;
            gamePictureBox1.TabStop = false;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new Point(2, 0);
            pictureLabel.Margin = new Padding(2, 0, 2, 0);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new Size(193, 36);
            pictureLabel.TabIndex = 0;
            pictureLabel.Text = "Game Picture";
            // 
            // gameDecPanel
            // 
            gameDecPanel.Controls.Add(gameDetailLabel);
            gameDecPanel.Location = new Point(4, 108);
            gameDecPanel.Margin = new Padding(4);
            gameDecPanel.Name = "gameDecPanel";
            gameDecPanel.Size = new Size(404, 96);
            gameDecPanel.TabIndex = 5;
            // 
            // gameDetailLabel
            // 
            gameDetailLabel.AutoSize = true;
            gameDetailLabel.Location = new Point(4, 0);
            gameDetailLabel.Margin = new Padding(4, 0, 4, 0);
            gameDetailLabel.Name = "gameDetailLabel";
            gameDetailLabel.Size = new Size(243, 36);
            gameDetailLabel.TabIndex = 0;
            gameDetailLabel.Text = "Game Decripition";
            // 
            // gameNamePanel
            // 
            gameNamePanel.Controls.Add(gameNameTextBox);
            gameNamePanel.Controls.Add(nameLabel);
            gameNamePanel.Dock = DockStyle.Top;
            gameNamePanel.Location = new Point(4, 4);
            gameNamePanel.Margin = new Padding(4);
            gameNamePanel.Name = "gameNamePanel";
            gameNamePanel.Size = new Size(408, 96);
            gameNamePanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(5, 0);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(92, 36);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // gameNameTextBox
            // 
            gameNameTextBox.Location = new Point(4, 41);
            gameNameTextBox.Margin = new Padding(4);
            gameNameTextBox.Name = "gameNameTextBox";
            gameNameTextBox.Size = new Size(399, 44);
            gameNameTextBox.TabIndex = 1;
            // 
            // mainControlPanel
            // 
            mainControlPanel.BackColor = Color.FromArgb(117, 250, 141);
            mainControlPanel.Controls.Add(gameComboBox);
            mainControlPanel.Controls.Add(editButton);
            mainControlPanel.Controls.Add(addButton);
            mainControlPanel.Dock = DockStyle.Top;
            mainControlPanel.Location = new Point(4, 4);
            mainControlPanel.Margin = new Padding(4);
            mainControlPanel.Name = "mainControlPanel";
            mainControlPanel.Size = new Size(768, 135);
            mainControlPanel.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(97, 255, 116);
            addButton.ForeColor = Color.FromArgb(23, 61, 28);
            addButton.Location = new Point(4, 4);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(395, 64);
            addButton.TabIndex = 0;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(97, 255, 116);
            editButton.Enabled = false;
            editButton.FlatAppearance.BorderColor = Color.DarkGreen;
            editButton.FlatAppearance.BorderSize = 5;
            editButton.ForeColor = Color.FromArgb(23, 61, 28);
            editButton.Location = new Point(406, 4);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(390, 64);
            editButton.TabIndex = 2;
            editButton.Text = "EDIT";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // gameComboBox
            // 
            gameComboBox.FormattingEnabled = true;
            gameComboBox.Location = new Point(4, 75);
            gameComboBox.Margin = new Padding(4);
            gameComboBox.Name = "gameComboBox";
            gameComboBox.Size = new Size(792, 44);
            gameComboBox.TabIndex = 4;
            // 
            // gameDataGridView
            // 
            gameDataGridView.BackgroundColor = Color.FromArgb(171, 239, 255);
            gameDataGridView.ColumnHeadersHeight = 29;
            gameDataGridView.Dock = DockStyle.Fill;
            gameDataGridView.Location = new Point(4, 139);
            gameDataGridView.Margin = new Padding(4);
            gameDataGridView.Name = "gameDataGridView";
            gameDataGridView.RowHeadersWidth = 100;
            gameDataGridView.RowTemplate.Height = 29;
            gameDataGridView.Size = new Size(768, 373);
            gameDataGridView.TabIndex = 3;
            // 
            // adminTabControl
            // 
            adminTabControl.Controls.Add(GameTabPage);
            adminTabControl.Controls.Add(UserTabPage);
            adminTabControl.Dock = DockStyle.Fill;
            adminTabControl.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminTabControl.Location = new Point(0, 0);
            adminTabControl.Margin = new Padding(2);
            adminTabControl.Name = "adminTabControl";
            adminTabControl.SelectedIndex = 0;
            adminTabControl.Size = new Size(1199, 558);
            adminTabControl.TabIndex = 0;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 558);
            Controls.Add(adminTabControl);
            Margin = new Padding(2);
            Name = "adminForm";
            Text = "adminForm";
            Resize += adminForm_Resize;
            UserTabPage.ResumeLayout(false);
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            userInfoFlowLayoutPanel.ResumeLayout(false);
            userInfoFlowLayoutPanel.PerformLayout();
            toolsPanel.ResumeLayout(false);
            mainToolsPanel.ResumeLayout(false);
            toolsSplitContainer.Panel1.ResumeLayout(false);
            toolsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolsSplitContainer).EndInit();
            toolsSplitContainer.ResumeLayout(false);
            EditAndViewSplitContainer.Panel1.ResumeLayout(false);
            EditAndViewSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditAndViewSplitContainer).EndInit();
            EditAndViewSplitContainer.ResumeLayout(false);
            addAndRemoveSplitContainer.Panel1.ResumeLayout(false);
            addAndRemoveSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addAndRemoveSplitContainer).EndInit();
            addAndRemoveSplitContainer.ResumeLayout(false);
            searchSplitContainer.Panel1.ResumeLayout(false);
            searchSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)searchSplitContainer).EndInit();
            searchSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userInfoDataGridView).EndInit();
            GameTabPage.ResumeLayout(false);
            InfoFlowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox1).EndInit();
            gameDecPanel.ResumeLayout(false);
            gameDecPanel.PerformLayout();
            gameNamePanel.ResumeLayout(false);
            gameNamePanel.PerformLayout();
            mainControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gameDataGridView).EndInit();
            adminTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Panel picturePanel;
        private Button button5;
        private Button searchButton;
        private Label PictueFileLabel;
        private OpenFileDialog OpenFileDialog;
        private TextBox DescriptionTextBox;
        private TextBox descriptionTextBox;
        private Panel panel7;
        private Panel panel6;
        private Button TagsFakeLabel;
        private FlowLayoutPanel displayNameFlowLayoutPanel;
        private Panel gamesWithTagsPanel;
        private Panel gamesWithTagPanel;
        private SaveFileDialog saveFileDialog1;
        private FlowLayoutPanel passwordFlowLayoutPanel;
        private FlowLayoutPanel gmailFlowLayoutPanel;
        private SplitContainer removeAndEditSplitContainer;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel UserIDFlowLayoutPanel;
        private FlowLayoutPanel userNameFlowLayoutPanel;
        private TabPage UserTabPage;
        private SplitContainer mainSplitContainer;
        private DataGridView userInfoDataGridView;
        private Panel toolsPanel;
        private SplitContainer searchSplitContainer;
        private ComboBox searchUserComboBox;
        private ComboBox searchUserByColumnComboBox;
        private Panel mainToolsPanel;
        private SplitContainer toolsSplitContainer;
        private SplitContainer addAndRemoveSplitContainer;
        private Button addUserButton;
        private Button removeUserButton;
        private SplitContainer EditAndViewSplitContainer;
        private Button editUserButton;
        private Button viewButton;
        private FlowLayoutPanel userInfoFlowLayoutPanel;
        private FlowLayoutPanel adminFlowLayoutPanel;
        private Label userIDLabel;
        private TextBox userIDTextBox;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label displayNameLabel;
        private TextBox displayNameTextBox;
        private Label gmailLabel;
        private TextBox gmailTextBox;
        private CheckBox adminCheckBox;
        private Button confirmButton;
        private TabPage GameTabPage;
        private DataGridView gameDataGridView;
        private Panel mainControlPanel;
        private ComboBox gameComboBox;
        private Button editButton;
        private Button addButton;
        private FlowLayoutPanel InfoFlowLayoutPanel;
        private Panel gameNamePanel;
        private TextBox gameNameTextBox;
        private Label nameLabel;
        private Panel gameDecPanel;
        private Label gameDetailLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label pictureLabel;
        private PictureBox gamePictureBox1;
        private PictureBox gamePictureBox2;
        private PictureBox gamePictureBox3;
        private TabControl adminTabControl;
    }
}