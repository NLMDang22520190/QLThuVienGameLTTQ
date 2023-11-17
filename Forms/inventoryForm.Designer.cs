namespace EpistWinform.Forms
{
    partial class inventoryForm
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
            inventoryPanel = new Panel();
            installGamePanel = new Panel();
            installPanel = new Panel();
            downloadProcessBar = new ProgressBar();
            uninstallBtn = new FontAwesome.Sharp.IconButton();
            installBtn = new FontAwesome.Sharp.IconButton();
            bannerPictureBox = new PictureBox();
            ownGameLayoutPanel = new FlowLayoutPanel();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            inventoryPanel.SuspendLayout();
            installGamePanel.SuspendLayout();
            installPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bannerPictureBox).BeginInit();
            ownGameLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // inventoryPanel
            // 
            inventoryPanel.Controls.Add(installGamePanel);
            inventoryPanel.Controls.Add(ownGameLayoutPanel);
            inventoryPanel.Dock = DockStyle.Fill;
            inventoryPanel.Location = new Point(0, 0);
            inventoryPanel.Name = "inventoryPanel";
            inventoryPanel.Size = new Size(1236, 558);
            inventoryPanel.TabIndex = 0;
            // 
            // installGamePanel
            // 
            installGamePanel.BackColor = Color.FromArgb(140, 231, 196);
            installGamePanel.Controls.Add(installPanel);
            installGamePanel.Controls.Add(bannerPictureBox);
            installGamePanel.Dock = DockStyle.Fill;
            installGamePanel.Location = new Point(300, 0);
            installGamePanel.Name = "installGamePanel";
            installGamePanel.Size = new Size(936, 558);
            installGamePanel.TabIndex = 1;
            // 
            // installPanel
            // 
            installPanel.Controls.Add(downloadProcessBar);
            installPanel.Controls.Add(uninstallBtn);
            installPanel.Controls.Add(installBtn);
            installPanel.Dock = DockStyle.Top;
            installPanel.Location = new Point(0, 274);
            installPanel.Name = "installPanel";
            installPanel.Size = new Size(936, 74);
            installPanel.TabIndex = 3;
            // 
            // downloadProcessBar
            // 
            downloadProcessBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            downloadProcessBar.ForeColor = Color.FromArgb(255, 192, 255);
            downloadProcessBar.Location = new Point(349, 20);
            downloadProcessBar.Name = "downloadProcessBar";
            downloadProcessBar.Size = new Size(560, 34);
            downloadProcessBar.TabIndex = 3;
            // 
            // uninstallBtn
            // 
            uninstallBtn.AutoSize = true;
            uninstallBtn.Dock = DockStyle.Left;
            uninstallBtn.FlatStyle = FlatStyle.Flat;
            uninstallBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uninstallBtn.ForeColor = Color.White;
            uninstallBtn.IconChar = FontAwesome.Sharp.IconChar.TrashCanArrowUp;
            uninstallBtn.IconColor = Color.White;
            uninstallBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            uninstallBtn.ImageAlign = ContentAlignment.MiddleLeft;
            uninstallBtn.Location = new Point(146, 0);
            uninstallBtn.Name = "uninstallBtn";
            uninstallBtn.Size = new Size(170, 74);
            uninstallBtn.TabIndex = 2;
            uninstallBtn.Text = "Uninstall";
            uninstallBtn.TextAlign = ContentAlignment.MiddleRight;
            uninstallBtn.UseVisualStyleBackColor = true;
            // 
            // installBtn
            // 
            installBtn.AutoSize = true;
            installBtn.Dock = DockStyle.Left;
            installBtn.FlatStyle = FlatStyle.Flat;
            installBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            installBtn.ForeColor = Color.White;
            installBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            installBtn.IconColor = Color.White;
            installBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            installBtn.ImageAlign = ContentAlignment.MiddleLeft;
            installBtn.Location = new Point(0, 0);
            installBtn.Name = "installBtn";
            installBtn.Size = new Size(146, 74);
            installBtn.TabIndex = 1;
            installBtn.Text = "Install";
            installBtn.TextAlign = ContentAlignment.MiddleRight;
            installBtn.UseVisualStyleBackColor = true;
            // 
            // bannerPictureBox
            // 
            bannerPictureBox.Dock = DockStyle.Top;
            bannerPictureBox.Location = new Point(0, 0);
            bannerPictureBox.Name = "bannerPictureBox";
            bannerPictureBox.Size = new Size(936, 274);
            bannerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bannerPictureBox.TabIndex = 0;
            bannerPictureBox.TabStop = false;
            // 
            // ownGameLayoutPanel
            // 
            ownGameLayoutPanel.BackColor = Color.FromArgb(0, 199, 139);
            ownGameLayoutPanel.Controls.Add(searchLabel);
            ownGameLayoutPanel.Controls.Add(searchTextBox);
            ownGameLayoutPanel.Dock = DockStyle.Left;
            ownGameLayoutPanel.Location = new Point(0, 0);
            ownGameLayoutPanel.Name = "ownGameLayoutPanel";
            ownGameLayoutPanel.Size = new Size(300, 558);
            ownGameLayoutPanel.TabIndex = 0;
            // 
            // searchLabel
            // 
            searchLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchLabel.ForeColor = Color.White;
            searchLabel.Location = new Point(3, 0);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(179, 29);
            searchLabel.TabIndex = 1;
            searchLabel.Text = "Search games";
            searchLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchTextBox
            // 
            searchTextBox.Dock = DockStyle.Top;
            searchTextBox.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(3, 32);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(256, 34);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // inventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1236, 558);
            Controls.Add(inventoryPanel);
            Name = "inventoryForm";
            Text = "inventoryForm";
            Load += inventoryForm_Load;
            SizeChanged += inventoryForm_SizeChanged;
            Resize += inventoryForm_Resize;
            inventoryPanel.ResumeLayout(false);
            installGamePanel.ResumeLayout(false);
            installPanel.ResumeLayout(false);
            installPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bannerPictureBox).EndInit();
            ownGameLayoutPanel.ResumeLayout(false);
            ownGameLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel allGamesFlowPanel;
        private Panel inventoryPanel;
        private Panel installGamePanel;
        private FlowLayoutPanel ownGameLayoutPanel;
        private Label searchLabel;
        private TextBox searchTextBox;
        private PictureBox bannerPictureBox;
        private FontAwesome.Sharp.IconButton installBtn;
        private Panel installPanel;
        private FontAwesome.Sharp.IconButton uninstallBtn;
        private ProgressBar downloadProcessBar;
    }
}