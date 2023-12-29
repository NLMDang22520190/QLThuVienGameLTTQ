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
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // adminTabControl
            // 
            adminTabControl.Controls.Add(GameTabPage);
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
    }
}