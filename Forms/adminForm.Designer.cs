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
            TagsTabPage = new TabPage();
            gamesAndTagsPanel = new Panel();
            gamesPanel = new Panel();
            gamesFlowLayoutPanel = new FlowLayoutPanel();
            gameFakeLable = new Button();
            tagsPanel = new Panel();
            tagFlowLayoutPanel = new FlowLayoutPanel();
            allTagsButton = new Button();
            EditPanel = new Panel();
            tagDescriptionTextBox = new TextBox();
            tagNameTextBox = new TextBox();
            descriptionButton = new Button();
            tagNameButton = new Button();
            tagMainControlPanel = new Panel();
            editGameTagButton = new Button();
            removeTagButton = new Button();
            tagsComboBox = new ComboBox();
            editTagButton = new Button();
            addTagButton = new Button();
            UserTabPage = new TabPage();
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
            viewButton = new Button();
            userInfoFlowLayoutPanel = new FlowLayoutPanel();
            UserIDFlowLayoutPanel = new FlowLayoutPanel();
            userIDLabel = new Label();
            userIDTextBox = new TextBox();
            adminFlowLayoutPanel = new FlowLayoutPanel();
            userNameFlowLayoutPanel = new FlowLayoutPanel();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordFlowLayoutPanel = new FlowLayoutPanel();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            displayNameFlowLayoutPanel = new FlowLayoutPanel();
            displayNameLabel = new Label();
            displayNameTextBox = new TextBox();
            gmailFlowLayoutPanel = new FlowLayoutPanel();
            gmailLabel = new Label();
            gmailTextBox = new TextBox();
            adminCheckBox = new CheckBox();
            confirmButton = new Button();
            OpenFileDialog = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
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
            TagsTabPage.SuspendLayout();
            gamesAndTagsPanel.SuspendLayout();
            gamesPanel.SuspendLayout();
            tagsPanel.SuspendLayout();
            EditPanel.SuspendLayout();
            tagMainControlPanel.SuspendLayout();
            UserTabPage.SuspendLayout();
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
            EditAndViewSplitContainer.Panel2.SuspendLayout();
            EditAndViewSplitContainer.SuspendLayout();
            userInfoFlowLayoutPanel.SuspendLayout();
            UserIDFlowLayoutPanel.SuspendLayout();
            userNameFlowLayoutPanel.SuspendLayout();
            passwordFlowLayoutPanel.SuspendLayout();
            displayNameFlowLayoutPanel.SuspendLayout();
            gmailFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // adminTabControl
            // 
            adminTabControl.Controls.Add(GameTabPage);
            adminTabControl.Controls.Add(TagsTabPage);
            adminTabControl.Controls.Add(UserTabPage);
            adminTabControl.Dock = DockStyle.Fill;
            adminTabControl.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminTabControl.Location = new Point(0, 0);
            adminTabControl.Margin = new Padding(2);
            adminTabControl.Name = "adminTabControl";
            adminTabControl.SelectedIndex = 0;
            adminTabControl.Size = new Size(959, 446);
            adminTabControl.TabIndex = 0;
            // 
            // GameTabPage
            // 
            GameTabPage.Controls.Add(gameDataGridView);
            GameTabPage.Controls.Add(mainControlPanel);
            GameTabPage.Controls.Add(InfoFlowLayoutPanel);
            GameTabPage.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            GameTabPage.Location = new Point(4, 33);
            GameTabPage.Name = "GameTabPage";
            GameTabPage.Padding = new Padding(3);
            GameTabPage.Size = new Size(951, 409);
            GameTabPage.TabIndex = 0;
            GameTabPage.Text = "Games";
            GameTabPage.UseVisualStyleBackColor = true;
            // 
            // gameDataGridView
            // 
            gameDataGridView.BackgroundColor = Color.FromArgb(171, 239, 255);
            gameDataGridView.ColumnHeadersHeight = 29;
            gameDataGridView.Dock = DockStyle.Fill;
            gameDataGridView.Location = new Point(3, 111);
            gameDataGridView.Name = "gameDataGridView";
            gameDataGridView.RowHeadersWidth = 100;
            gameDataGridView.RowTemplate.Height = 29;
            gameDataGridView.Size = new Size(613, 295);
            gameDataGridView.TabIndex = 3;
            // 
            // mainControlPanel
            // 
            mainControlPanel.BackColor = Color.FromArgb(117, 250, 141);
            mainControlPanel.Controls.Add(gameComboBox);
            mainControlPanel.Controls.Add(editButton);
            mainControlPanel.Controls.Add(addButton);
            mainControlPanel.Dock = DockStyle.Top;
            mainControlPanel.Location = new Point(3, 3);
            mainControlPanel.Name = "mainControlPanel";
            mainControlPanel.Size = new Size(613, 108);
            mainControlPanel.TabIndex = 2;
            // 
            // gameComboBox
            // 
            gameComboBox.FormattingEnabled = true;
            gameComboBox.Location = new Point(3, 60);
            gameComboBox.Name = "gameComboBox";
            gameComboBox.Size = new Size(634, 38);
            gameComboBox.TabIndex = 4;
            // 
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(97, 255, 116);
            editButton.Enabled = false;
            editButton.FlatAppearance.BorderColor = Color.DarkGreen;
            editButton.FlatAppearance.BorderSize = 5;
            editButton.ForeColor = Color.FromArgb(23, 61, 28);
            editButton.Location = new Point(325, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(312, 51);
            editButton.TabIndex = 2;
            editButton.Text = "EDIT";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(97, 255, 116);
            addButton.ForeColor = Color.FromArgb(23, 61, 28);
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(316, 51);
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
            InfoFlowLayoutPanel.Dock = DockStyle.Right;
            InfoFlowLayoutPanel.Location = new Point(616, 3);
            InfoFlowLayoutPanel.Name = "InfoFlowLayoutPanel";
            InfoFlowLayoutPanel.Size = new Size(332, 403);
            InfoFlowLayoutPanel.TabIndex = 0;
            // 
            // gameNamePanel
            // 
            gameNamePanel.Controls.Add(gameNameTextBox);
            gameNamePanel.Controls.Add(nameLabel);
            gameNamePanel.Dock = DockStyle.Top;
            gameNamePanel.Location = new Point(3, 3);
            gameNamePanel.Name = "gameNamePanel";
            gameNamePanel.Size = new Size(326, 77);
            gameNamePanel.TabIndex = 0;
            // 
            // gameNameTextBox
            // 
            gameNameTextBox.Location = new Point(3, 33);
            gameNameTextBox.Name = "gameNameTextBox";
            gameNameTextBox.Size = new Size(320, 38);
            gameNameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(77, 30);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // gameDecPanel
            // 
            gameDecPanel.Controls.Add(descriptionTextBox);
            gameDecPanel.Controls.Add(gameDetailLabel);
            gameDecPanel.Location = new Point(3, 86);
            gameDecPanel.Name = "gameDecPanel";
            gameDecPanel.Size = new Size(323, 77);
            gameDecPanel.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(4, 33);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(316, 38);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // gameDetailLabel
            // 
            gameDetailLabel.AutoSize = true;
            gameDetailLabel.Location = new Point(3, 0);
            gameDetailLabel.Name = "gameDetailLabel";
            gameDetailLabel.Size = new Size(204, 30);
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
            flowLayoutPanel1.Location = new Point(2, 168);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(323, 346);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new Point(2, 0);
            pictureLabel.Margin = new Padding(2, 0, 2, 0);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new Size(161, 30);
            pictureLabel.TabIndex = 0;
            pictureLabel.Text = "Game Picture";
            // 
            // gamePictureBox1
            // 
            gamePictureBox1.Location = new Point(2, 32);
            gamePictureBox1.Margin = new Padding(2);
            gamePictureBox1.Name = "gamePictureBox1";
            gamePictureBox1.Size = new Size(318, 99);
            gamePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox1.TabIndex = 1;
            gamePictureBox1.TabStop = false;
            // 
            // gamePictureBox2
            // 
            gamePictureBox2.Location = new Point(2, 135);
            gamePictureBox2.Margin = new Padding(2);
            gamePictureBox2.Name = "gamePictureBox2";
            gamePictureBox2.Size = new Size(318, 99);
            gamePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox2.TabIndex = 3;
            gamePictureBox2.TabStop = false;
            // 
            // gamePictureBox3
            // 
            gamePictureBox3.Location = new Point(2, 238);
            gamePictureBox3.Margin = new Padding(2);
            gamePictureBox3.Name = "gamePictureBox3";
            gamePictureBox3.Size = new Size(318, 99);
            gamePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox3.TabIndex = 2;
            gamePictureBox3.TabStop = false;
            // 
            // TagsTabPage
            // 
            TagsTabPage.Controls.Add(gamesAndTagsPanel);
            TagsTabPage.Controls.Add(EditPanel);
            TagsTabPage.Controls.Add(tagMainControlPanel);
            TagsTabPage.Location = new Point(4, 33);
            TagsTabPage.Margin = new Padding(2);
            TagsTabPage.Name = "TagsTabPage";
            TagsTabPage.Padding = new Padding(2);
            TagsTabPage.Size = new Size(951, 409);
            TagsTabPage.TabIndex = 1;
            TagsTabPage.Text = "Tags";
            TagsTabPage.UseVisualStyleBackColor = true;
            // 
            // gamesAndTagsPanel
            // 
            gamesAndTagsPanel.BackColor = Color.Cyan;
            gamesAndTagsPanel.Controls.Add(gamesPanel);
            gamesAndTagsPanel.Controls.Add(tagsPanel);
            gamesAndTagsPanel.Dock = DockStyle.Fill;
            gamesAndTagsPanel.Location = new Point(2, 150);
            gamesAndTagsPanel.Margin = new Padding(2);
            gamesAndTagsPanel.Name = "gamesAndTagsPanel";
            gamesAndTagsPanel.Size = new Size(947, 257);
            gamesAndTagsPanel.TabIndex = 5;
            // 
            // gamesPanel
            // 
            gamesPanel.Controls.Add(gamesFlowLayoutPanel);
            gamesPanel.Controls.Add(gameFakeLable);
            gamesPanel.Dock = DockStyle.Fill;
            gamesPanel.Location = new Point(210, 0);
            gamesPanel.Margin = new Padding(2);
            gamesPanel.Name = "gamesPanel";
            gamesPanel.Size = new Size(737, 257);
            gamesPanel.TabIndex = 1;
            // 
            // gamesFlowLayoutPanel
            // 
            gamesFlowLayoutPanel.Dock = DockStyle.Fill;
            gamesFlowLayoutPanel.Location = new Point(0, 34);
            gamesFlowLayoutPanel.Margin = new Padding(2);
            gamesFlowLayoutPanel.Name = "gamesFlowLayoutPanel";
            gamesFlowLayoutPanel.Size = new Size(737, 223);
            gamesFlowLayoutPanel.TabIndex = 1;
            // 
            // gameFakeLable
            // 
            gameFakeLable.BackColor = Color.FromArgb(128, 255, 255);
            gameFakeLable.Dock = DockStyle.Top;
            gameFakeLable.Location = new Point(0, 0);
            gameFakeLable.Margin = new Padding(2);
            gameFakeLable.Name = "gameFakeLable";
            gameFakeLable.Size = new Size(737, 34);
            gameFakeLable.TabIndex = 0;
            gameFakeLable.Text = "GAMES";
            gameFakeLable.UseVisualStyleBackColor = false;
            // 
            // tagsPanel
            // 
            tagsPanel.Controls.Add(tagFlowLayoutPanel);
            tagsPanel.Controls.Add(allTagsButton);
            tagsPanel.Dock = DockStyle.Left;
            tagsPanel.Location = new Point(0, 0);
            tagsPanel.Margin = new Padding(2);
            tagsPanel.Name = "tagsPanel";
            tagsPanel.Size = new Size(210, 257);
            tagsPanel.TabIndex = 0;
            // 
            // tagFlowLayoutPanel
            // 
            tagFlowLayoutPanel.AutoScroll = true;
            tagFlowLayoutPanel.Dock = DockStyle.Fill;
            tagFlowLayoutPanel.Location = new Point(0, 34);
            tagFlowLayoutPanel.Margin = new Padding(2);
            tagFlowLayoutPanel.Name = "tagFlowLayoutPanel";
            tagFlowLayoutPanel.Size = new Size(210, 223);
            tagFlowLayoutPanel.TabIndex = 1;
            // 
            // allTagsButton
            // 
            allTagsButton.BackColor = Color.FromArgb(128, 255, 255);
            allTagsButton.Dock = DockStyle.Top;
            allTagsButton.Location = new Point(0, 0);
            allTagsButton.Margin = new Padding(2);
            allTagsButton.Name = "allTagsButton";
            allTagsButton.Size = new Size(210, 34);
            allTagsButton.TabIndex = 0;
            allTagsButton.Text = "TAGS";
            allTagsButton.UseVisualStyleBackColor = false;
            // 
            // EditPanel
            // 
            EditPanel.BackColor = Color.FromArgb(255, 253, 104);
            EditPanel.Controls.Add(tagDescriptionTextBox);
            EditPanel.Controls.Add(tagNameTextBox);
            EditPanel.Controls.Add(descriptionButton);
            EditPanel.Controls.Add(tagNameButton);
            EditPanel.Dock = DockStyle.Top;
            EditPanel.Location = new Point(2, 80);
            EditPanel.Margin = new Padding(2);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(947, 70);
            EditPanel.TabIndex = 4;
            // 
            // tagDescriptionTextBox
            // 
            tagDescriptionTextBox.Location = new Point(136, 38);
            tagDescriptionTextBox.Margin = new Padding(2);
            tagDescriptionTextBox.Name = "tagDescriptionTextBox";
            tagDescriptionTextBox.Size = new Size(640, 32);
            tagDescriptionTextBox.TabIndex = 3;
            // 
            // tagNameTextBox
            // 
            tagNameTextBox.Location = new Point(136, 6);
            tagNameTextBox.Margin = new Padding(2);
            tagNameTextBox.Name = "tagNameTextBox";
            tagNameTextBox.Size = new Size(640, 32);
            tagNameTextBox.TabIndex = 2;
            // 
            // descriptionButton
            // 
            descriptionButton.BackColor = Color.FromArgb(255, 254, 145);
            descriptionButton.Location = new Point(4, 35);
            descriptionButton.Margin = new Padding(2);
            descriptionButton.Name = "descriptionButton";
            descriptionButton.Size = new Size(127, 30);
            descriptionButton.TabIndex = 1;
            descriptionButton.Text = "Description";
            descriptionButton.UseVisualStyleBackColor = false;
            // 
            // tagNameButton
            // 
            tagNameButton.BackColor = Color.FromArgb(255, 254, 145);
            tagNameButton.Location = new Point(4, 2);
            tagNameButton.Margin = new Padding(2);
            tagNameButton.Name = "tagNameButton";
            tagNameButton.Size = new Size(127, 30);
            tagNameButton.TabIndex = 0;
            tagNameButton.Text = "Name";
            tagNameButton.UseVisualStyleBackColor = false;
            // 
            // tagMainControlPanel
            // 
            tagMainControlPanel.BackColor = Color.FromArgb(117, 250, 141);
            tagMainControlPanel.Controls.Add(editGameTagButton);
            tagMainControlPanel.Controls.Add(removeTagButton);
            tagMainControlPanel.Controls.Add(tagsComboBox);
            tagMainControlPanel.Controls.Add(editTagButton);
            tagMainControlPanel.Controls.Add(addTagButton);
            tagMainControlPanel.Dock = DockStyle.Top;
            tagMainControlPanel.Location = new Point(2, 2);
            tagMainControlPanel.Margin = new Padding(2);
            tagMainControlPanel.Name = "tagMainControlPanel";
            tagMainControlPanel.Size = new Size(947, 78);
            tagMainControlPanel.TabIndex = 3;
            // 
            // editGameTagButton
            // 
            editGameTagButton.BackColor = Color.FromArgb(97, 255, 116);
            editGameTagButton.FlatAppearance.BorderColor = Color.DarkGreen;
            editGameTagButton.FlatAppearance.BorderSize = 5;
            editGameTagButton.ForeColor = Color.FromArgb(23, 61, 28);
            editGameTagButton.Location = new Point(586, 2);
            editGameTagButton.Margin = new Padding(2);
            editGameTagButton.Name = "editGameTagButton";
            editGameTagButton.Size = new Size(189, 41);
            editGameTagButton.TabIndex = 6;
            editGameTagButton.Text = "EDIT GAME TAG";
            editGameTagButton.UseVisualStyleBackColor = false;
            editGameTagButton.Click += editGameTagButton_Click;
            // 
            // removeTagButton
            // 
            removeTagButton.BackColor = Color.FromArgb(97, 255, 116);
            removeTagButton.FlatAppearance.BorderColor = Color.DarkGreen;
            removeTagButton.FlatAppearance.BorderSize = 5;
            removeTagButton.ForeColor = Color.FromArgb(23, 61, 28);
            removeTagButton.Location = new Point(196, 2);
            removeTagButton.Margin = new Padding(2);
            removeTagButton.Name = "removeTagButton";
            removeTagButton.Size = new Size(189, 41);
            removeTagButton.TabIndex = 5;
            removeTagButton.Text = "REMOVE";
            removeTagButton.UseVisualStyleBackColor = false;
            removeTagButton.Click += removeTagButton_Click;
            // 
            // tagsComboBox
            // 
            tagsComboBox.FormattingEnabled = true;
            tagsComboBox.Location = new Point(2, 48);
            tagsComboBox.Margin = new Padding(2);
            tagsComboBox.Name = "tagsComboBox";
            tagsComboBox.Size = new Size(774, 32);
            tagsComboBox.TabIndex = 4;
            tagsComboBox.TextChanged += tagsComboBox_TextChanged;
            // 
            // editTagButton
            // 
            editTagButton.BackColor = Color.FromArgb(97, 255, 116);
            editTagButton.FlatAppearance.BorderColor = Color.DarkGreen;
            editTagButton.FlatAppearance.BorderSize = 5;
            editTagButton.ForeColor = Color.FromArgb(23, 61, 28);
            editTagButton.Location = new Point(393, 2);
            editTagButton.Margin = new Padding(2);
            editTagButton.Name = "editTagButton";
            editTagButton.Size = new Size(189, 41);
            editTagButton.TabIndex = 2;
            editTagButton.Text = "EDIT TAG";
            editTagButton.UseVisualStyleBackColor = false;
            editTagButton.Click += editTagButton_Click;
            // 
            // addTagButton
            // 
            addTagButton.BackColor = Color.FromArgb(97, 255, 116);
            addTagButton.ForeColor = Color.FromArgb(23, 61, 28);
            addTagButton.Location = new Point(2, 2);
            addTagButton.Margin = new Padding(2);
            addTagButton.Name = "addTagButton";
            addTagButton.Size = new Size(189, 41);
            addTagButton.TabIndex = 0;
            addTagButton.Text = "ADD";
            addTagButton.UseVisualStyleBackColor = false;
            addTagButton.Click += addTagButton_Click;
            // 
            // UserTabPage
            // 
            UserTabPage.BackColor = Color.FromArgb(171, 253, 255);
            UserTabPage.Controls.Add(mainSplitContainer);
            UserTabPage.Location = new Point(4, 33);
            UserTabPage.Margin = new Padding(2);
            UserTabPage.Name = "UserTabPage";
            UserTabPage.Padding = new Padding(2);
            UserTabPage.Size = new Size(951, 409);
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
            mainSplitContainer.Size = new Size(947, 405);
            mainSplitContainer.SplitterDistance = 629;
            mainSplitContainer.SplitterWidth = 3;
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
            userInfoDataGridView.Location = new Point(0, 142);
            userInfoDataGridView.Name = "userInfoDataGridView";
            userInfoDataGridView.RowHeadersWidth = 51;
            userInfoDataGridView.RowTemplate.Height = 29;
            userInfoDataGridView.Size = new Size(629, 263);
            userInfoDataGridView.TabIndex = 1;
            // 
            // toolsPanel
            // 
            toolsPanel.Controls.Add(searchSplitContainer);
            toolsPanel.Controls.Add(mainToolsPanel);
            toolsPanel.Dock = DockStyle.Top;
            toolsPanel.Location = new Point(0, 0);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(629, 142);
            toolsPanel.TabIndex = 0;
            // 
            // searchSplitContainer
            // 
            searchSplitContainer.Dock = DockStyle.Fill;
            searchSplitContainer.Location = new Point(0, 100);
            searchSplitContainer.Name = "searchSplitContainer";
            // 
            // searchSplitContainer.Panel1
            // 
            searchSplitContainer.Panel1.Controls.Add(searchUserComboBox);
            // 
            // searchSplitContainer.Panel2
            // 
            searchSplitContainer.Panel2.Controls.Add(searchUserByColumnComboBox);
            searchSplitContainer.Size = new Size(629, 42);
            searchSplitContainer.SplitterDistance = 395;
            searchSplitContainer.SplitterWidth = 3;
            searchSplitContainer.TabIndex = 1;
            // 
            // searchUserComboBox
            // 
            searchUserComboBox.Dock = DockStyle.Fill;
            searchUserComboBox.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            searchUserComboBox.FormattingEnabled = true;
            searchUserComboBox.Location = new Point(0, 0);
            searchUserComboBox.Name = "searchUserComboBox";
            searchUserComboBox.Size = new Size(395, 36);
            searchUserComboBox.TabIndex = 0;
            // 
            // searchUserByColumnComboBox
            // 
            searchUserByColumnComboBox.Dock = DockStyle.Fill;
            searchUserByColumnComboBox.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            searchUserByColumnComboBox.FormattingEnabled = true;
            searchUserByColumnComboBox.Location = new Point(0, 0);
            searchUserByColumnComboBox.Name = "searchUserByColumnComboBox";
            searchUserByColumnComboBox.Size = new Size(231, 36);
            searchUserByColumnComboBox.TabIndex = 0;
            searchUserByColumnComboBox.SelectedIndexChanged += searchUserByColumnComboBox_SelectedIndexChanged;
            // 
            // mainToolsPanel
            // 
            mainToolsPanel.Controls.Add(toolsSplitContainer);
            mainToolsPanel.Dock = DockStyle.Top;
            mainToolsPanel.Location = new Point(0, 0);
            mainToolsPanel.Name = "mainToolsPanel";
            mainToolsPanel.Size = new Size(629, 100);
            mainToolsPanel.TabIndex = 0;
            // 
            // toolsSplitContainer
            // 
            toolsSplitContainer.Dock = DockStyle.Fill;
            toolsSplitContainer.IsSplitterFixed = true;
            toolsSplitContainer.Location = new Point(0, 0);
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
            toolsSplitContainer.Size = new Size(629, 100);
            toolsSplitContainer.SplitterDistance = 312;
            toolsSplitContainer.TabIndex = 1;
            // 
            // addAndRemoveSplitContainer
            // 
            addAndRemoveSplitContainer.Dock = DockStyle.Fill;
            addAndRemoveSplitContainer.IsSplitterFixed = true;
            addAndRemoveSplitContainer.Location = new Point(0, 0);
            addAndRemoveSplitContainer.Name = "addAndRemoveSplitContainer";
            // 
            // addAndRemoveSplitContainer.Panel1
            // 
            addAndRemoveSplitContainer.Panel1.Controls.Add(addUserButton);
            // 
            // addAndRemoveSplitContainer.Panel2
            // 
            addAndRemoveSplitContainer.Panel2.Controls.Add(removeUserButton);
            addAndRemoveSplitContainer.Size = new Size(312, 100);
            addAndRemoveSplitContainer.SplitterDistance = 153;
            addAndRemoveSplitContainer.SplitterWidth = 3;
            addAndRemoveSplitContainer.TabIndex = 0;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.Cyan;
            addUserButton.Dock = DockStyle.Fill;
            addUserButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            addUserButton.Location = new Point(0, 0);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(153, 100);
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
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(156, 100);
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
            EditAndViewSplitContainer.Name = "EditAndViewSplitContainer";
            // 
            // EditAndViewSplitContainer.Panel1
            // 
            EditAndViewSplitContainer.Panel1.Controls.Add(editUserButton);
            // 
            // EditAndViewSplitContainer.Panel2
            // 
            EditAndViewSplitContainer.Panel2.Controls.Add(viewButton);
            EditAndViewSplitContainer.Size = new Size(313, 100);
            EditAndViewSplitContainer.SplitterDistance = 154;
            EditAndViewSplitContainer.SplitterWidth = 3;
            EditAndViewSplitContainer.TabIndex = 0;
            // 
            // editUserButton
            // 
            editUserButton.BackColor = Color.Cyan;
            editUserButton.Dock = DockStyle.Fill;
            editUserButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            editUserButton.Location = new Point(0, 0);
            editUserButton.Name = "editUserButton";
            editUserButton.Size = new Size(154, 100);
            editUserButton.TabIndex = 0;
            editUserButton.Text = "EDIT";
            editUserButton.UseVisualStyleBackColor = false;
            editUserButton.Click += editUserButton_Click;
            // 
            // viewButton
            // 
            viewButton.BackColor = Color.Cyan;
            viewButton.Dock = DockStyle.Fill;
            viewButton.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            viewButton.Location = new Point(0, 0);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(156, 100);
            viewButton.TabIndex = 5;
            viewButton.Text = "VIEW";
            viewButton.UseVisualStyleBackColor = false;
            viewButton.Click += viewButton_Click;
            // 
            // userInfoFlowLayoutPanel
            // 
            userInfoFlowLayoutPanel.AutoScroll = true;
            userInfoFlowLayoutPanel.Controls.Add(UserIDFlowLayoutPanel);
            userInfoFlowLayoutPanel.Controls.Add(adminFlowLayoutPanel);
            userInfoFlowLayoutPanel.Controls.Add(userNameFlowLayoutPanel);
            userInfoFlowLayoutPanel.Controls.Add(passwordFlowLayoutPanel);
            userInfoFlowLayoutPanel.Controls.Add(displayNameFlowLayoutPanel);
            userInfoFlowLayoutPanel.Controls.Add(gmailFlowLayoutPanel);
            userInfoFlowLayoutPanel.Controls.Add(adminCheckBox);
            userInfoFlowLayoutPanel.Dock = DockStyle.Fill;
            userInfoFlowLayoutPanel.Location = new Point(0, 0);
            userInfoFlowLayoutPanel.Name = "userInfoFlowLayoutPanel";
            userInfoFlowLayoutPanel.Size = new Size(315, 337);
            userInfoFlowLayoutPanel.TabIndex = 0;
            // 
            // UserIDFlowLayoutPanel
            // 
            UserIDFlowLayoutPanel.Controls.Add(userIDLabel);
            UserIDFlowLayoutPanel.Controls.Add(userIDTextBox);
            UserIDFlowLayoutPanel.Dock = DockStyle.Top;
            UserIDFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UserIDFlowLayoutPanel.Location = new Point(3, 3);
            UserIDFlowLayoutPanel.Name = "UserIDFlowLayoutPanel";
            UserIDFlowLayoutPanel.Size = new Size(318, 68);
            UserIDFlowLayoutPanel.TabIndex = 2;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            userIDLabel.Location = new Point(3, 0);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(39, 30);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = "ID";
            // 
            // userIDTextBox
            // 
            userIDTextBox.Location = new Point(3, 33);
            userIDTextBox.Name = "userIDTextBox";
            userIDTextBox.Size = new Size(312, 32);
            userIDTextBox.TabIndex = 1;
            // 
            // adminFlowLayoutPanel
            // 
            adminFlowLayoutPanel.AutoSize = true;
            adminFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            adminFlowLayoutPanel.Location = new Point(3, 77);
            adminFlowLayoutPanel.Name = "adminFlowLayoutPanel";
            adminFlowLayoutPanel.Size = new Size(0, 0);
            adminFlowLayoutPanel.TabIndex = 4;
            // 
            // userNameFlowLayoutPanel
            // 
            userNameFlowLayoutPanel.Controls.Add(usernameLabel);
            userNameFlowLayoutPanel.Controls.Add(usernameTextBox);
            userNameFlowLayoutPanel.Dock = DockStyle.Top;
            userNameFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            userNameFlowLayoutPanel.Location = new Point(3, 83);
            userNameFlowLayoutPanel.Name = "userNameFlowLayoutPanel";
            userNameFlowLayoutPanel.Size = new Size(318, 68);
            userNameFlowLayoutPanel.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(3, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(123, 30);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(3, 33);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(312, 32);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordFlowLayoutPanel
            // 
            passwordFlowLayoutPanel.Controls.Add(passwordLabel);
            passwordFlowLayoutPanel.Controls.Add(passwordTextBox);
            passwordFlowLayoutPanel.Dock = DockStyle.Top;
            passwordFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            passwordFlowLayoutPanel.Location = new Point(3, 157);
            passwordFlowLayoutPanel.Name = "passwordFlowLayoutPanel";
            passwordFlowLayoutPanel.Size = new Size(318, 68);
            passwordFlowLayoutPanel.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(3, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(118, 30);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(3, 33);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(312, 32);
            passwordTextBox.TabIndex = 1;
            // 
            // displayNameFlowLayoutPanel
            // 
            displayNameFlowLayoutPanel.Controls.Add(displayNameLabel);
            displayNameFlowLayoutPanel.Controls.Add(displayNameTextBox);
            displayNameFlowLayoutPanel.Dock = DockStyle.Top;
            displayNameFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            displayNameFlowLayoutPanel.Location = new Point(3, 231);
            displayNameFlowLayoutPanel.Name = "displayNameFlowLayoutPanel";
            displayNameFlowLayoutPanel.Size = new Size(318, 68);
            displayNameFlowLayoutPanel.TabIndex = 2;
            // 
            // displayNameLabel
            // 
            displayNameLabel.AutoSize = true;
            displayNameLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            displayNameLabel.Location = new Point(3, 0);
            displayNameLabel.Name = "displayNameLabel";
            displayNameLabel.Size = new Size(164, 30);
            displayNameLabel.TabIndex = 0;
            displayNameLabel.Text = "Display Name";
            // 
            // displayNameTextBox
            // 
            displayNameTextBox.Location = new Point(3, 33);
            displayNameTextBox.Name = "displayNameTextBox";
            displayNameTextBox.Size = new Size(312, 32);
            displayNameTextBox.TabIndex = 1;
            // 
            // gmailFlowLayoutPanel
            // 
            gmailFlowLayoutPanel.Controls.Add(gmailLabel);
            gmailFlowLayoutPanel.Controls.Add(gmailTextBox);
            gmailFlowLayoutPanel.Dock = DockStyle.Top;
            gmailFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            gmailFlowLayoutPanel.Location = new Point(3, 305);
            gmailFlowLayoutPanel.Name = "gmailFlowLayoutPanel";
            gmailFlowLayoutPanel.Size = new Size(318, 68);
            gmailFlowLayoutPanel.TabIndex = 3;
            // 
            // gmailLabel
            // 
            gmailLabel.AutoSize = true;
            gmailLabel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            gmailLabel.Location = new Point(3, 0);
            gmailLabel.Name = "gmailLabel";
            gmailLabel.Size = new Size(76, 30);
            gmailLabel.TabIndex = 0;
            gmailLabel.Text = "Gmail";
            // 
            // gmailTextBox
            // 
            gmailTextBox.Location = new Point(3, 33);
            gmailTextBox.Name = "gmailTextBox";
            gmailTextBox.Size = new Size(312, 32);
            gmailTextBox.TabIndex = 1;
            // 
            // adminCheckBox
            // 
            adminCheckBox.AutoSize = true;
            adminCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            adminCheckBox.Dock = DockStyle.Left;
            adminCheckBox.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            adminCheckBox.Location = new Point(3, 379);
            adminCheckBox.Name = "adminCheckBox";
            adminCheckBox.Size = new Size(105, 34);
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
            confirmButton.Location = new Point(0, 337);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(315, 68);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "CONFIRM CHANGE";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog";
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 446);
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
            gameNamePanel.ResumeLayout(false);
            gameNamePanel.PerformLayout();
            gameDecPanel.ResumeLayout(false);
            gameDecPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox3).EndInit();
            TagsTabPage.ResumeLayout(false);
            gamesAndTagsPanel.ResumeLayout(false);
            gamesPanel.ResumeLayout(false);
            tagsPanel.ResumeLayout(false);
            EditPanel.ResumeLayout(false);
            EditPanel.PerformLayout();
            tagMainControlPanel.ResumeLayout(false);
            UserTabPage.ResumeLayout(false);
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
            EditAndViewSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditAndViewSplitContainer).EndInit();
            EditAndViewSplitContainer.ResumeLayout(false);
            userInfoFlowLayoutPanel.ResumeLayout(false);
            userInfoFlowLayoutPanel.PerformLayout();
            UserIDFlowLayoutPanel.ResumeLayout(false);
            UserIDFlowLayoutPanel.PerformLayout();
            userNameFlowLayoutPanel.ResumeLayout(false);
            userNameFlowLayoutPanel.PerformLayout();
            passwordFlowLayoutPanel.ResumeLayout(false);
            passwordFlowLayoutPanel.PerformLayout();
            displayNameFlowLayoutPanel.ResumeLayout(false);
            displayNameFlowLayoutPanel.PerformLayout();
            gmailFlowLayoutPanel.ResumeLayout(false);
            gmailFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl adminTabControl;
        private TabPage GameTabPage;
        private TabPage TagsTabPage;
        private FlowLayoutPanel InfoFlowLayoutPanel;
        private Panel gameNamePanel;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage UserTabPage;
        private Panel picturePanel;
        private DataGridView gameDataGridView;
        private Panel mainControlPanel;
        private Button button5;
        private ComboBox gameComboBox;
        private Button viewButton;
        private Button editButton;
        private Button removeTagButton;
        private Button addButton;
        private TextBox gameNameTextBox;
        private Button searchButton;
        private Label nameLabel;
        private Label PictueFileLabel;
        private OpenFileDialog OpenFileDialog;
        private Panel gameDecPanel;
        private Label gameDetailLabel;
        private TextBox DescriptionTextBox;
        private TextBox descriptionTextBox;
        private Button editTagButton;
        private Button addTagButton;
        private Panel panel7;
        private Panel panel6;
        private Button TagsFakeLabel;
        private FlowLayoutPanel displayNameFlowLayoutPanel;
        private Button gameFakeLable;
        private Panel tagMainControlPanel;
        private Panel gamesWithTagsPanel;
        private Panel gamesWithTagPanel;
        private Panel gamesAndTagsPanel;
        private Panel gamesPanel;
        private FlowLayoutPanel gamesFlowLayoutPanel;
        private Panel tagsPanel;
        private FlowLayoutPanel tagFlowLayoutPanel;
        private ComboBox tagsComboBox;
        private Button allTagsButton;
        private Panel EditPanel;
        private Button descriptionButton;
        private Button tagNameButton;
        private TextBox tagDescriptionTextBox;
        private TextBox tagNameTextBox;
        private Button editGameTagButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox gamePictureBox1;
        private Label pictureLabel;
        private PictureBox gamePictureBox2;
        private PictureBox gamePictureBox3;
        private SplitContainer mainSplitContainer;
        private FlowLayoutPanel userInfoFlowLayoutPanel;
        private SaveFileDialog saveFileDialog1;
        private FlowLayoutPanel passwordFlowLayoutPanel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label displayNameLabel;
        private TextBox displayNameTextBox;
        private FlowLayoutPanel gmailFlowLayoutPanel;
        private Label gmailLabel;
        private TextBox gmailTextBox;
        private FlowLayoutPanel adminFlowLayoutPanel;
        private CheckBox adminCheckBox;
        private Panel toolsPanel;
        private DataGridView userInfoDataGridView;
        private Button addUserButton;
        private Button removeUserButton;
        private Button editUserButton;
        private Panel mainToolsPanel;
        private SplitContainer toolsSplitContainer;
        private SplitContainer removeAndEditSplitContainer;
        private SplitContainer searchSplitContainer;
        private ComboBox searchUserComboBox;
        private ComboBox searchUserByColumnComboBox;
        private SplitContainer splitContainer1;
        private SplitContainer addAndRemoveSplitContainer;
        private SplitContainer EditAndViewSplitContainer;
        private FlowLayoutPanel UserIDFlowLayoutPanel;
        private Label userIDLabel;
        private TextBox userIDTextBox;
        private FlowLayoutPanel userNameFlowLayoutPanel;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Button confirmButton;
    }
}