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
            picturePanel = new Panel();
            panel2 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            PictueFileLabel = new Label();
            panel1 = new Panel();
            gameFiletextBox = new TextBox();
            gameFilelabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            descriptionTextBox = new TextBox();
            gameDetailLabel = new Label();
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
            picturePanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            GameTabPage.Location = new Point(4, 33);
            GameTabPage.Name = "GameTabPage";
            GameTabPage.Padding = new Padding(3);
            GameTabPage.Size = new Size(981, 409);
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
            gameDataGridView.Size = new Size(643, 295);
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
            mainControlPanel.Size = new Size(643, 108);
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
            // 
            // InfoFlowLayoutPanel
            // 
            InfoFlowLayoutPanel.AutoScroll = true;
            InfoFlowLayoutPanel.BackColor = Color.FromArgb(255, 254, 145);
            InfoFlowLayoutPanel.Controls.Add(gameNamePanel);
            InfoFlowLayoutPanel.Controls.Add(picturePanel);
            InfoFlowLayoutPanel.Controls.Add(panel1);
            InfoFlowLayoutPanel.Controls.Add(flowLayoutPanel1);
            InfoFlowLayoutPanel.Controls.Add(panel3);
            InfoFlowLayoutPanel.Dock = DockStyle.Right;
            InfoFlowLayoutPanel.Location = new Point(646, 3);
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
            // picturePanel
            // 
            picturePanel.Controls.Add(panel2);
            picturePanel.Controls.Add(PictueFileLabel);
            picturePanel.Dock = DockStyle.Top;
            picturePanel.Location = new Point(3, 86);
            picturePanel.Name = "picturePanel";
            picturePanel.Size = new Size(326, 172);
            picturePanel.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 166);
            panel2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 38);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 38);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 38);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 0;
            label1.Text = "Pictures";
            // 
            // PictueFileLabel
            // 
            PictueFileLabel.Location = new Point(3, 0);
            PictueFileLabel.Name = "PictueFileLabel";
            PictueFileLabel.Size = new Size(320, 30);
            PictueFileLabel.TabIndex = 0;
            PictueFileLabel.Text = "Pictures";
            // 
            // panel1
            // 
            panel1.Controls.Add(gameFiletextBox);
            panel1.Controls.Add(gameFilelabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 264);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 76);
            panel1.TabIndex = 3;
            // 
            // gameFiletextBox
            // 
            gameFiletextBox.Location = new Point(3, 33);
            gameFiletextBox.Name = "gameFiletextBox";
            gameFiletextBox.Size = new Size(320, 38);
            gameFiletextBox.TabIndex = 5;
            // 
            // gameFilelabel
            // 
            gameFilelabel.AutoSize = true;
            gameFilelabel.Location = new Point(4, 0);
            gameFilelabel.Name = "gameFilelabel";
            gameFilelabel.Size = new Size(123, 30);
            gameFilelabel.TabIndex = 0;
            gameFilelabel.Text = "Game File";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Location = new Point(3, 346);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(descriptionTextBox);
            panel3.Controls.Add(gameDetailLabel);
            panel3.Location = new Point(3, 352);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 125);
            panel3.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(4, 33);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(316, 38);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.WordWrap = false;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 446);
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
            picturePanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private TextBox gameFiletextBox;
        private Label gameFilelabel;
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
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel3;
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
    }
}