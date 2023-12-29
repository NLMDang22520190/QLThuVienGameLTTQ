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
            adminTabControl = new TabControl();
            GameTabPage = new TabPage();
            gameDataGridView = new DataGridView();
            mainControlPanel = new Panel();
            gameComboBox = new ComboBox();
            editButton = new Button();
            addButton = new Button();
            InfoFlowLayoutPanel = new FlowLayoutPanel();
            gameNamePanel = new Panel();
            gameNameTextBox = new TextBox();
            nameLabel = new Label();
            gameDecPanel = new Panel();
            descriptionTextBox = new TextBox();
            gameDetailLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureLabel = new Label();
            gamePictureBox1 = new PictureBox();
            gamePictureBox2 = new PictureBox();
            gamePictureBox3 = new PictureBox();
            editPanel = new Panel();
            cancelBtn = new Button();
            saveBtn = new Button();
            tabPage1 = new TabPage();
            mainSplitContainer = new SplitContainer();
            userInfoDataGridView = new DataGridView();
            toolsPanel = new Panel();
            searchSplitContainer = new SplitContainer();
            searchUserComboBox = new ComboBox();
            searchUserByColumnComboBox = new ComboBox();
            mainToolsPanel = new Panel();
            toolsSplitContainer = new SplitContainer();
            addAndRemoveSplitContainer = new SplitContainer();
            addUserButton = new Button();
            removeUserButton = new Button();
            EditAndViewSplitContainer = new SplitContainer();
            editUserButton = new Button();
            userInfoFlowLayoutPanel = new FlowLayoutPanel();
            adminFlowLayoutPanel = new FlowLayoutPanel();
            userIDLabel = new Label();
            userIDTextBox = new TextBox();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            displayNameLabel = new Label();
            displayNameTextBox = new TextBox();
            gmailLabel = new Label();
            gmailTextBox = new TextBox();
            adminCheckBox = new CheckBox();
            confirmButton = new Button();
            OpenFileDialog = new OpenFileDialog();
            fileSystemWatcher1 = new FileSystemWatcher();
            adminTabControl.SuspendLayout();
            GameTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameDataGridView).BeginInit();
            mainControlPanel.SuspendLayout();
            InfoFlowLayoutPanel.SuspendLayout();
            gameNamePanel.SuspendLayout();
            gameDecPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox3).BeginInit();
            editPanel.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userInfoDataGridView).BeginInit();
            toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchSplitContainer).BeginInit();
            searchSplitContainer.Panel1.SuspendLayout();
            searchSplitContainer.Panel2.SuspendLayout();
            searchSplitContainer.SuspendLayout();
            mainToolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolsSplitContainer).BeginInit();
            toolsSplitContainer.Panel1.SuspendLayout();
            toolsSplitContainer.Panel2.SuspendLayout();
            toolsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addAndRemoveSplitContainer).BeginInit();
            addAndRemoveSplitContainer.Panel1.SuspendLayout();
            addAndRemoveSplitContainer.Panel2.SuspendLayout();
            addAndRemoveSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditAndViewSplitContainer).BeginInit();
            EditAndViewSplitContainer.Panel1.SuspendLayout();
            EditAndViewSplitContainer.SuspendLayout();
            userInfoFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // adminTabControl
            // 
            adminTabControl.Controls.Add(GameTabPage);
            adminTabControl.Controls.Add(tabPage1);
            adminTabControl.Dock = DockStyle.Fill;
            adminTabControl.Location = new Point(0, 0);
            adminTabControl.Margin = new Padding(4);
            adminTabControl.Name = "adminTabControl";
            adminTabControl.SelectedIndex = 0;
            adminTabControl.Size = new Size(1236, 558);
            adminTabControl.TabIndex = 0;
            // 
            // GameTabPage
            // 
            GameTabPage.Controls.Add(gameDataGridView);
            GameTabPage.Controls.Add(mainControlPanel);
            GameTabPage.Controls.Add(InfoFlowLayoutPanel);
            GameTabPage.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            GameTabPage.Location = new Point(4, 34);
            GameTabPage.Margin = new Padding(4);
            GameTabPage.Name = "GameTabPage";
            GameTabPage.Padding = new Padding(4);
            GameTabPage.Size = new Size(1228, 520);
            GameTabPage.TabIndex = 0;
            GameTabPage.Text = "Games";
            GameTabPage.UseVisualStyleBackColor = true;
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
            gameDataGridView.Size = new Size(805, 377);
            gameDataGridView.TabIndex = 3;
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
            mainControlPanel.Size = new Size(805, 135);
            mainControlPanel.TabIndex = 2;
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
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(97, 255, 116);
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
            // InfoFlowLayoutPanel
            // 
            InfoFlowLayoutPanel.AutoScroll = true;
            InfoFlowLayoutPanel.BackColor = Color.FromArgb(255, 254, 145);
            InfoFlowLayoutPanel.Controls.Add(gameNamePanel);
            InfoFlowLayoutPanel.Controls.Add(gameDecPanel);
            InfoFlowLayoutPanel.Controls.Add(flowLayoutPanel1);
            InfoFlowLayoutPanel.Controls.Add(editPanel);
            InfoFlowLayoutPanel.Dock = DockStyle.Right;
            InfoFlowLayoutPanel.Location = new Point(809, 4);
            InfoFlowLayoutPanel.Margin = new Padding(4);
            InfoFlowLayoutPanel.Name = "InfoFlowLayoutPanel";
            InfoFlowLayoutPanel.Size = new Size(415, 512);
            InfoFlowLayoutPanel.TabIndex = 0;
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
            // gameNameTextBox
            // 
            gameNameTextBox.Location = new Point(4, 41);
            gameNameTextBox.Margin = new Padding(4);
            gameNameTextBox.Name = "gameNameTextBox";
            gameNameTextBox.Size = new Size(399, 44);
            gameNameTextBox.TabIndex = 1;
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
            // gameDecPanel
            // 
            gameDecPanel.AutoSize = true;
            gameDecPanel.Controls.Add(descriptionTextBox);
            gameDecPanel.Controls.Add(gameDetailLabel);
            gameDecPanel.Location = new Point(4, 108);
            gameDecPanel.Margin = new Padding(4);
            gameDecPanel.Name = "gameDecPanel";
            gameDecPanel.Size = new Size(403, 345);
            gameDecPanel.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(5, 41);
            descriptionTextBox.Margin = new Padding(4);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(394, 300);
            descriptionTextBox.TabIndex = 1;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureLabel);
            flowLayoutPanel1.Controls.Add(gamePictureBox1);
            flowLayoutPanel1.Controls.Add(gamePictureBox2);
            flowLayoutPanel1.Controls.Add(gamePictureBox3);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 460);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(404, 433);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new Point(3, 0);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new Size(193, 36);
            pictureLabel.TabIndex = 0;
            pictureLabel.Text = "Game Picture";
            // 
            // gamePictureBox1
            // 
            gamePictureBox1.Location = new Point(3, 39);
            gamePictureBox1.Name = "gamePictureBox1";
            gamePictureBox1.Size = new Size(397, 124);
            gamePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox1.TabIndex = 1;
            gamePictureBox1.TabStop = false;
            // 
            // gamePictureBox2
            // 
            gamePictureBox2.Location = new Point(3, 169);
            gamePictureBox2.Name = "gamePictureBox2";
            gamePictureBox2.Size = new Size(397, 124);
            gamePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox2.TabIndex = 3;
            gamePictureBox2.TabStop = false;
            // 
            // gamePictureBox3
            // 
            gamePictureBox3.Location = new Point(3, 299);
            gamePictureBox3.Name = "gamePictureBox3";
            gamePictureBox3.Size = new Size(397, 124);
            gamePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox3.TabIndex = 2;
            gamePictureBox3.TabStop = false;
            // 
            // editPanel
            // 
            editPanel.Controls.Add(cancelBtn);
            editPanel.Controls.Add(saveBtn);
            editPanel.Location = new Point(3, 899);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(384, 64);
            editPanel.TabIndex = 7;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(205, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(163, 50);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "CANCEL";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(16, 6);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(163, 50);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(171, 253, 255);
            tabPage1.Controls.Add(mainSplitContainer);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1228, 520);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Users";
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
            mainSplitContainer.Size = new Size(1224, 516);
            mainSplitContainer.SplitterDistance = 812;
            mainSplitContainer.TabIndex = 0;
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
            userInfoDataGridView.Size = new Size(812, 338);
            userInfoDataGridView.TabIndex = 1;
            // 
            // toolsPanel
            // 
            toolsPanel.Controls.Add(searchSplitContainer);
            toolsPanel.Controls.Add(mainToolsPanel);
            toolsPanel.Dock = DockStyle.Top;
            toolsPanel.Location = new Point(0, 0);
            toolsPanel.Margin = new Padding(4);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(812, 178);
            toolsPanel.TabIndex = 0;
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
            searchSplitContainer.Size = new Size(812, 53);
            searchSplitContainer.SplitterDistance = 509;
            searchSplitContainer.TabIndex = 1;
            // 
            // searchUserComboBox
            // 
            searchUserComboBox.Dock = DockStyle.Fill;
            searchUserComboBox.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            searchUserComboBox.FormattingEnabled = true;
            searchUserComboBox.Location = new Point(0, 0);
            searchUserComboBox.Margin = new Padding(4);
            searchUserComboBox.Name = "searchUserComboBox";
            searchUserComboBox.Size = new Size(509, 42);
            searchUserComboBox.TabIndex = 0;
            // 
            // searchUserByColumnComboBox
            // 
            searchUserByColumnComboBox.Dock = DockStyle.Fill;
            searchUserByColumnComboBox.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            searchUserByColumnComboBox.FormattingEnabled = true;
            searchUserByColumnComboBox.Location = new Point(0, 0);
            searchUserByColumnComboBox.Margin = new Padding(4);
            searchUserByColumnComboBox.Name = "searchUserByColumnComboBox";
            searchUserByColumnComboBox.Size = new Size(299, 42);
            searchUserByColumnComboBox.TabIndex = 0;
            // 
            // mainToolsPanel
            // 
            mainToolsPanel.Controls.Add(toolsSplitContainer);
            mainToolsPanel.Dock = DockStyle.Top;
            mainToolsPanel.Location = new Point(0, 0);
            mainToolsPanel.Margin = new Padding(4);
            mainToolsPanel.Name = "mainToolsPanel";
            mainToolsPanel.Size = new Size(812, 125);
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
            toolsSplitContainer.Size = new Size(812, 125);
            toolsSplitContainer.SplitterDistance = 401;
            toolsSplitContainer.SplitterWidth = 5;
            toolsSplitContainer.TabIndex = 1;
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
            addAndRemoveSplitContainer.Size = new Size(401, 125);
            addAndRemoveSplitContainer.SplitterDistance = 195;
            addAndRemoveSplitContainer.TabIndex = 0;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.Cyan;
            addUserButton.Dock = DockStyle.Fill;
            addUserButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            addUserButton.Location = new Point(0, 0);
            addUserButton.Margin = new Padding(4);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(195, 125);
            addUserButton.TabIndex = 0;
            addUserButton.Text = "ADD";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            // 
            // removeUserButton
            // 
            removeUserButton.BackColor = Color.Cyan;
            removeUserButton.Dock = DockStyle.Fill;
            removeUserButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            removeUserButton.Location = new Point(0, 0);
            removeUserButton.Margin = new Padding(4);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(202, 125);
            removeUserButton.TabIndex = 0;
            removeUserButton.Text = "REMOVE";
            removeUserButton.UseVisualStyleBackColor = false;
            removeUserButton.Click += removeUserButton_Click;
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
            EditAndViewSplitContainer.Size = new Size(406, 125);
            EditAndViewSplitContainer.SplitterDistance = 198;
            EditAndViewSplitContainer.TabIndex = 0;
            // 
            // editUserButton
            // 
            editUserButton.BackColor = Color.Cyan;
            editUserButton.Dock = DockStyle.Fill;
            editUserButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            editUserButton.Location = new Point(0, 0);
            editUserButton.Margin = new Padding(4);
            editUserButton.Name = "editUserButton";
            editUserButton.Size = new Size(198, 125);
            editUserButton.TabIndex = 0;
            editUserButton.Text = "EDIT";
            editUserButton.UseVisualStyleBackColor = false;
            editUserButton.Click += editUserButton_Click;
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
            userInfoFlowLayoutPanel.Size = new Size(408, 431);
            userInfoFlowLayoutPanel.TabIndex = 0;
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
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Dock = DockStyle.Top;
            userIDLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            userIDLabel.Location = new Point(4, 8);
            userIDLabel.Margin = new Padding(4, 0, 4, 0);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(389, 36);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = "ID";
            // 
            // userIDTextBox
            // 
            userIDTextBox.Dock = DockStyle.Top;
            userIDTextBox.Location = new Point(4, 48);
            userIDTextBox.Margin = new Padding(4);
            userIDTextBox.Name = "userIDTextBox";
            userIDTextBox.Size = new Size(389, 31);
            userIDTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Dock = DockStyle.Top;
            usernameLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(4, 83);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(389, 36);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Top;
            usernameTextBox.Location = new Point(4, 123);
            usernameTextBox.Margin = new Padding(4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(389, 31);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Dock = DockStyle.Top;
            passwordLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(4, 158);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(389, 36);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Top;
            passwordTextBox.Location = new Point(4, 198);
            passwordTextBox.Margin = new Padding(4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(389, 31);
            passwordTextBox.TabIndex = 1;
            // 
            // displayNameLabel
            // 
            displayNameLabel.AutoSize = true;
            displayNameLabel.Dock = DockStyle.Top;
            displayNameLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            displayNameLabel.Location = new Point(4, 233);
            displayNameLabel.Margin = new Padding(4, 0, 4, 0);
            displayNameLabel.Name = "displayNameLabel";
            displayNameLabel.Size = new Size(389, 36);
            displayNameLabel.TabIndex = 0;
            displayNameLabel.Text = "Display Name";
            // 
            // displayNameTextBox
            // 
            displayNameTextBox.Dock = DockStyle.Top;
            displayNameTextBox.Location = new Point(4, 273);
            displayNameTextBox.Margin = new Padding(4);
            displayNameTextBox.Name = "displayNameTextBox";
            displayNameTextBox.Size = new Size(389, 31);
            displayNameTextBox.TabIndex = 1;
            // 
            // gmailLabel
            // 
            gmailLabel.AutoSize = true;
            gmailLabel.Dock = DockStyle.Top;
            gmailLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            gmailLabel.Location = new Point(4, 308);
            gmailLabel.Margin = new Padding(4, 0, 4, 0);
            gmailLabel.Name = "gmailLabel";
            gmailLabel.Size = new Size(389, 36);
            gmailLabel.TabIndex = 0;
            gmailLabel.Text = "Gmail";
            // 
            // gmailTextBox
            // 
            gmailTextBox.Location = new Point(4, 348);
            gmailTextBox.Margin = new Padding(4);
            gmailTextBox.Name = "gmailTextBox";
            gmailTextBox.Size = new Size(389, 31);
            gmailTextBox.TabIndex = 1;
            // 
            // adminCheckBox
            // 
            adminCheckBox.AutoSize = true;
            adminCheckBox.Dock = DockStyle.Top;
            adminCheckBox.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            adminCheckBox.Location = new Point(4, 387);
            adminCheckBox.Margin = new Padding(4);
            adminCheckBox.Name = "adminCheckBox";
            adminCheckBox.Size = new Size(389, 40);
            adminCheckBox.TabIndex = 2;
            adminCheckBox.Text = "Admin";
            adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            confirmButton.AutoSize = true;
            confirmButton.BackColor = Color.Cyan;
            confirmButton.Dock = DockStyle.Bottom;
            confirmButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.ForeColor = Color.MidnightBlue;
            confirmButton.Location = new Point(0, 431);
            confirmButton.Margin = new Padding(4);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(408, 85);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "CONFIRM CHANGE";
            confirmButton.UseVisualStyleBackColor = false;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 558);
            Controls.Add(adminTabControl);
            Margin = new Padding(2);
            Name = "adminForm";
            Text = "adminForm";
            Resize += adminForm_Resize;
            adminTabControl.ResumeLayout(false);
            GameTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gameDataGridView).EndInit();
            mainControlPanel.ResumeLayout(false);
            InfoFlowLayoutPanel.ResumeLayout(false);
            InfoFlowLayoutPanel.PerformLayout();
            gameNamePanel.ResumeLayout(false);
            gameNamePanel.PerformLayout();
            gameDecPanel.ResumeLayout(false);
            gameDecPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox3).EndInit();
            editPanel.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userInfoDataGridView).EndInit();
            toolsPanel.ResumeLayout(false);
            searchSplitContainer.Panel1.ResumeLayout(false);
            searchSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)searchSplitContainer).EndInit();
            searchSplitContainer.ResumeLayout(false);
            mainToolsPanel.ResumeLayout(false);
            toolsSplitContainer.Panel1.ResumeLayout(false);
            toolsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolsSplitContainer).EndInit();
            toolsSplitContainer.ResumeLayout(false);
            addAndRemoveSplitContainer.Panel1.ResumeLayout(false);
            addAndRemoveSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addAndRemoveSplitContainer).EndInit();
            addAndRemoveSplitContainer.ResumeLayout(false);
            EditAndViewSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditAndViewSplitContainer).EndInit();
            EditAndViewSplitContainer.ResumeLayout(false);
            userInfoFlowLayoutPanel.ResumeLayout(false);
            userInfoFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl adminTabControl;
        private TabPage GameTabPage;
        private FlowLayoutPanel InfoFlowLayoutPanel;
        private Panel gameNamePanel;
        private Panel picturePanel;
        private DataGridView gameDataGridView;
        private Panel mainControlPanel;
        private Button button5;
        private ComboBox gameComboBox;
        private Button viewButton;
        private Button editButton;
        private Button removeButton;
        private Button addButton;
        private TextBox gameNameTextBox;
        private Button searchButton;
        private Label nameLabel;
        private Label PictueFileLabel;
        private OpenFileDialog OpenFileDialog;
        private Panel panel2;
        private Label label1;
        private Panel gameDecPanel;
        private Label gameDetailLabel;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox DescriptionTextBox;
        private TextBox descriptionTextBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox gamePictureBox1;
        private Label pictureLabel;
        private PictureBox gamePictureBox2;
        private PictureBox gamePictureBox3;
        private Panel editPanel;
        private Button cancelBtn;
        private Button saveBtn;
        private TabPage tabPage1;
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
    }
}