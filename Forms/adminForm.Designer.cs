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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            UserTabPage = new TabPage();
            OpenFileDialog = new OpenFileDialog();
            fileSystemWatcher1 = new FileSystemWatcher();
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
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // adminTabControl
            // 
            adminTabControl.Controls.Add(GameTabPage);
            adminTabControl.Controls.Add(TagsTabPage);
            adminTabControl.Controls.Add(UserTabPage);
            adminTabControl.Dock = DockStyle.Fill;
            adminTabControl.Location = new Point(0, 0);
            adminTabControl.Margin = new Padding(4, 4, 4, 4);
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
            GameTabPage.Margin = new Padding(4, 4, 4, 4);
            GameTabPage.Name = "GameTabPage";
            GameTabPage.Padding = new Padding(4, 4, 4, 4);
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
            gameDataGridView.Margin = new Padding(4, 4, 4, 4);
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
            mainControlPanel.Margin = new Padding(4, 4, 4, 4);
            mainControlPanel.Name = "mainControlPanel";
            mainControlPanel.Size = new Size(805, 135);
            mainControlPanel.TabIndex = 2;
            // 
            // gameComboBox
            // 
            gameComboBox.FormattingEnabled = true;
            gameComboBox.Location = new Point(4, 75);
            gameComboBox.Margin = new Padding(4, 4, 4, 4);
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
            editButton.Margin = new Padding(4, 4, 4, 4);
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
            addButton.Margin = new Padding(4, 4, 4, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(395, 64);
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
            InfoFlowLayoutPanel.Location = new Point(809, 4);
            InfoFlowLayoutPanel.Margin = new Padding(4, 4, 4, 4);
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
            gameNamePanel.Margin = new Padding(4, 4, 4, 4);
            gameNamePanel.Name = "gameNamePanel";
            gameNamePanel.Size = new Size(408, 96);
            gameNamePanel.TabIndex = 0;
            // 
            // gameNameTextBox
            // 
            gameNameTextBox.Location = new Point(4, 41);
            gameNameTextBox.Margin = new Padding(4, 4, 4, 4);
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
            // picturePanel
            // 
            picturePanel.Controls.Add(panel2);
            picturePanel.Controls.Add(PictueFileLabel);
            picturePanel.Dock = DockStyle.Top;
            picturePanel.Location = new Point(4, 108);
            picturePanel.Margin = new Padding(4, 4, 4, 4);
            picturePanel.Name = "picturePanel";
            picturePanel.Size = new Size(408, 215);
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
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 208);
            panel2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(4, 151);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(399, 44);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(4, 96);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(399, 44);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 41);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 44);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 36);
            label1.TabIndex = 0;
            label1.Text = "Pictures";
            // 
            // PictueFileLabel
            // 
            PictueFileLabel.Location = new Point(4, 0);
            PictueFileLabel.Margin = new Padding(4, 0, 4, 0);
            PictueFileLabel.Name = "PictueFileLabel";
            PictueFileLabel.Size = new Size(400, 38);
            PictueFileLabel.TabIndex = 0;
            PictueFileLabel.Text = "Pictures";
            // 
            // panel1
            // 
            panel1.Controls.Add(gameFiletextBox);
            panel1.Controls.Add(gameFilelabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(4, 331);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 95);
            panel1.TabIndex = 3;
            // 
            // gameFiletextBox
            // 
            gameFiletextBox.Location = new Point(4, 41);
            gameFiletextBox.Margin = new Padding(4, 4, 4, 4);
            gameFiletextBox.Name = "gameFiletextBox";
            gameFiletextBox.Size = new Size(399, 44);
            gameFiletextBox.TabIndex = 5;
            // 
            // gameFilelabel
            // 
            gameFilelabel.AutoSize = true;
            gameFilelabel.Location = new Point(5, 0);
            gameFilelabel.Margin = new Padding(4, 0, 4, 0);
            gameFilelabel.Name = "gameFilelabel";
            gameFilelabel.Size = new Size(147, 36);
            gameFilelabel.TabIndex = 0;
            gameFilelabel.Text = "Game File";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Location = new Point(4, 434);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(descriptionTextBox);
            panel3.Controls.Add(gameDetailLabel);
            panel3.Location = new Point(4, 442);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(404, 156);
            panel3.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(5, 41);
            descriptionTextBox.Margin = new Padding(4, 4, 4, 4);
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
            // TagsTabPage
            // 
            TagsTabPage.Controls.Add(tabControl1);
            TagsTabPage.Location = new Point(4, 34);
            TagsTabPage.Margin = new Padding(4, 4, 4, 4);
            TagsTabPage.Name = "TagsTabPage";
            TagsTabPage.Padding = new Padding(4, 4, 4, 4);
            TagsTabPage.Size = new Size(1228, 520);
            TagsTabPage.TabIndex = 1;
            TagsTabPage.Text = "Tags";
            TagsTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(310, 90);
            tabControl1.Margin = new Padding(4, 4, 4, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(10, 10);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 4, 4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 4, 4, 4);
            tabPage2.Size = new Size(2, 0);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4, 4, 4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 4, 4, 4);
            tabPage3.Size = new Size(2, 0);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // UserTabPage
            // 
            UserTabPage.Location = new Point(4, 34);
            UserTabPage.Margin = new Padding(4, 4, 4, 4);
            UserTabPage.Name = "UserTabPage";
            UserTabPage.Padding = new Padding(4, 4, 4, 4);
            UserTabPage.Size = new Size(1228, 520);
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
            picturePanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            TagsTabPage.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
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
        private Button removeButton;
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
    }
}