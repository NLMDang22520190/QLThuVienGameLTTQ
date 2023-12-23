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
            removeTagButton = new Button();
            tagsComboBox = new ComboBox();
            editTagButton = new Button();
            addTagButton = new Button();
            UserTabPage = new TabPage();
            OpenFileDialog = new OpenFileDialog();
            fileSystemWatcher1 = new FileSystemWatcher();
            editGameTagButton = new Button();
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
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
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
            adminTabControl.Name = "adminTabControl";
            adminTabControl.SelectedIndex = 0;
            adminTabControl.Size = new Size(989, 446);
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
            gameDecPanel.Controls.Add(descriptionTextBox);
            gameDecPanel.Controls.Add(gameDetailLabel);
            gameDecPanel.Location = new Point(4, 108);
            gameDecPanel.Margin = new Padding(4);
            gameDecPanel.Name = "gameDecPanel";
            gameDecPanel.Size = new Size(404, 96);
            gameDecPanel.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(5, 41);
            descriptionTextBox.Margin = new Padding(4);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(394, 46);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
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
            flowLayoutPanel1.Location = new Point(3, 211);
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
            // TagsTabPage
            // 
            TagsTabPage.Controls.Add(gamesAndTagsPanel);
            TagsTabPage.Controls.Add(EditPanel);
            TagsTabPage.Controls.Add(tagMainControlPanel);
            TagsTabPage.Location = new Point(4, 33);
            TagsTabPage.Name = "TagsTabPage";
            TagsTabPage.Padding = new Padding(3);
            TagsTabPage.Size = new Size(981, 409);
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
            gamesAndTagsPanel.Location = new Point(3, 189);
            gamesAndTagsPanel.Name = "gamesAndTagsPanel";
            gamesAndTagsPanel.Size = new Size(975, 217);
            gamesAndTagsPanel.TabIndex = 5;
            // 
            // gamesPanel
            // 
            gamesPanel.Controls.Add(gamesFlowLayoutPanel);
            gamesPanel.Controls.Add(gameFakeLable);
            gamesPanel.Dock = DockStyle.Fill;
            gamesPanel.Location = new Point(262, 0);
            gamesPanel.Name = "gamesPanel";
            gamesPanel.Size = new Size(713, 217);
            gamesPanel.TabIndex = 1;
            // 
            // gamesFlowLayoutPanel
            // 
            gamesFlowLayoutPanel.Dock = DockStyle.Fill;
            gamesFlowLayoutPanel.Location = new Point(0, 42);
            gamesFlowLayoutPanel.Name = "gamesFlowLayoutPanel";
            gamesFlowLayoutPanel.Size = new Size(713, 175);
            gamesFlowLayoutPanel.TabIndex = 1;
            // 
            // gameFakeLable
            // 
            gameFakeLable.BackColor = Color.FromArgb(128, 255, 255);
            gameFakeLable.Dock = DockStyle.Top;
            gameFakeLable.Location = new Point(0, 0);
            gameFakeLable.Name = "gameFakeLable";
            gameFakeLable.Size = new Size(713, 42);
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
            tagsPanel.Name = "tagsPanel";
            tagsPanel.Size = new Size(262, 217);
            tagsPanel.TabIndex = 0;
            // 
            // tagFlowLayoutPanel
            // 
            tagFlowLayoutPanel.AutoScroll = true;
            tagFlowLayoutPanel.Dock = DockStyle.Fill;
            tagFlowLayoutPanel.Location = new Point(0, 42);
            tagFlowLayoutPanel.Name = "tagFlowLayoutPanel";
            tagFlowLayoutPanel.Size = new Size(262, 175);
            tagFlowLayoutPanel.TabIndex = 1;
            // 
            // allTagsButton
            // 
            allTagsButton.BackColor = Color.FromArgb(128, 255, 255);
            allTagsButton.Dock = DockStyle.Top;
            allTagsButton.Location = new Point(0, 0);
            allTagsButton.Name = "allTagsButton";
            allTagsButton.Size = new Size(262, 42);
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
            EditPanel.Location = new Point(3, 101);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(975, 88);
            EditPanel.TabIndex = 4;
            // 
            // tagDescriptionTextBox
            // 
            tagDescriptionTextBox.Location = new Point(170, 48);
            tagDescriptionTextBox.Name = "tagDescriptionTextBox";
            tagDescriptionTextBox.Size = new Size(799, 32);
            tagDescriptionTextBox.TabIndex = 3;
            // 
            // tagNameTextBox
            // 
            tagNameTextBox.Location = new Point(170, 7);
            tagNameTextBox.Name = "tagNameTextBox";
            tagNameTextBox.Size = new Size(799, 32);
            tagNameTextBox.TabIndex = 2;
            // 
            // descriptionButton
            // 
            descriptionButton.BackColor = Color.FromArgb(255, 254, 145);
            descriptionButton.Location = new Point(5, 44);
            descriptionButton.Name = "descriptionButton";
            descriptionButton.Size = new Size(159, 38);
            descriptionButton.TabIndex = 1;
            descriptionButton.Text = "Description";
            descriptionButton.UseVisualStyleBackColor = false;
            // 
            // tagNameButton
            // 
            tagNameButton.BackColor = Color.FromArgb(255, 254, 145);
            tagNameButton.Location = new Point(5, 3);
            tagNameButton.Name = "tagNameButton";
            tagNameButton.Size = new Size(159, 38);
            tagNameButton.TabIndex = 0;
            tagNameButton.Text = "Name";
            tagNameButton.UseVisualStyleBackColor = false;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(310, 90);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(10, 10);
            tabControl1.TabIndex = 0;
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
            tagMainControlPanel.Location = new Point(3, 3);
            tagMainControlPanel.Name = "tagMainControlPanel";
            tagMainControlPanel.Size = new Size(975, 98);
            tagMainControlPanel.TabIndex = 3;
            // 
            // removeTagButton
            // 
            removeTagButton.BackColor = Color.FromArgb(97, 255, 116);
            removeTagButton.FlatAppearance.BorderColor = Color.DarkGreen;
            removeTagButton.FlatAppearance.BorderSize = 5;
            removeTagButton.ForeColor = Color.FromArgb(23, 61, 28);
            removeTagButton.Location = new Point(245, 3);
            removeTagButton.Name = "removeTagButton";
            removeTagButton.Size = new Size(236, 51);
            removeTagButton.TabIndex = 5;
            removeTagButton.Text = "REMOVE";
            removeTagButton.UseVisualStyleBackColor = false;
            removeTagButton.Click += removeTagButton_Click;
            // 
            // tagsComboBox
            // 
            tagsComboBox.FormattingEnabled = true;
            tagsComboBox.Location = new Point(3, 60);
            tagsComboBox.Name = "tagsComboBox";
            tagsComboBox.Size = new Size(966, 32);
            tagsComboBox.TabIndex = 4;
            tagsComboBox.TextChanged += tagsComboBox_TextChanged;
            // 
            // editTagButton
            // 
            editTagButton.BackColor = Color.FromArgb(97, 255, 116);
            editTagButton.FlatAppearance.BorderColor = Color.DarkGreen;
            editTagButton.FlatAppearance.BorderSize = 5;
            editTagButton.ForeColor = Color.FromArgb(23, 61, 28);
            editTagButton.Location = new Point(491, 3);
            editTagButton.Name = "editTagButton";
            editTagButton.Size = new Size(236, 51);
            editTagButton.TabIndex = 2;
            editTagButton.Text = "EDIT TAG";
            editTagButton.UseVisualStyleBackColor = false;
            editTagButton.Click += editTagButton_Click;
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(2, 0);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // addTagButton
            // 
            addTagButton.BackColor = Color.FromArgb(97, 255, 116);
            addTagButton.ForeColor = Color.FromArgb(23, 61, 28);
            addTagButton.Location = new Point(3, 3);
            addTagButton.Name = "addTagButton";
            addTagButton.Size = new Size(236, 51);
            addTagButton.TabIndex = 0;
            addTagButton.Text = "ADD";
            addTagButton.UseVisualStyleBackColor = false;
            addTagButton.Click += addTagButton_Click;
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(2, 0);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // UserTabPage
            // 
            UserTabPage.Location = new Point(4, 33);
            UserTabPage.Name = "UserTabPage";
            UserTabPage.Padding = new Padding(3);
            UserTabPage.Size = new Size(981, 409);
            UserTabPage.TabIndex = 2;
            UserTabPage.Text = "Users";
            UserTabPage.UseVisualStyleBackColor = true;
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
            // editGameTagButton
            // 
            editGameTagButton.BackColor = Color.FromArgb(97, 255, 116);
            editGameTagButton.FlatAppearance.BorderColor = Color.DarkGreen;
            editGameTagButton.FlatAppearance.BorderSize = 5;
            editGameTagButton.ForeColor = Color.FromArgb(23, 61, 28);
            editGameTagButton.Location = new Point(733, 3);
            editGameTagButton.Name = "editGameTagButton";
            editGameTagButton.Size = new Size(236, 51);
            editGameTagButton.TabIndex = 6;
            editGameTagButton.Text = "EDIT GAME TAG";
            editGameTagButton.UseVisualStyleBackColor = false;
            editGameTagButton.Click += editGameTagButton_Click;
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
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
        private Panel panel2;
        private Label label1;
        private Panel gameDecPanel;
        private Label gameDetailLabel;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox DescriptionTextBox;
        private TextBox descriptionTextBox;
        private Panel panel4;
        private ComboBox comboBox1;
        private Button editTagButton;
        private Button addTagButton;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Button TagsFakeLabel;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button gameFakeLable;
        private FlowLayoutPanel flowLayoutPanel2;
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
    }
}