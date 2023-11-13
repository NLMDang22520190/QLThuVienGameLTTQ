namespace EpistWinform
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            controlBarPanel = new Panel();
            maximizeBtn = new FontAwesome.Sharp.IconButton();
            minimizeBtn = new FontAwesome.Sharp.IconButton();
            closeBtn = new FontAwesome.Sharp.IconButton();
            logoPictureBox = new PictureBox();
            nameLabel = new Label();
            navigationPanel = new Panel();
            adminBtn = new FontAwesome.Sharp.IconButton();
            exitBtn = new FontAwesome.Sharp.IconButton();
            userBtn = new FontAwesome.Sharp.IconButton();
            inventoryBtn = new FontAwesome.Sharp.IconButton();
            libraryBtn = new FontAwesome.Sharp.IconButton();
            changeFormPanel = new Panel();
            controlBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            navigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // controlBarPanel
            // 
            controlBarPanel.BackColor = Color.FromArgb(0, 113, 84);
            controlBarPanel.Controls.Add(maximizeBtn);
            controlBarPanel.Controls.Add(minimizeBtn);
            controlBarPanel.Controls.Add(closeBtn);
            controlBarPanel.Controls.Add(logoPictureBox);
            controlBarPanel.Controls.Add(nameLabel);
            controlBarPanel.Dock = DockStyle.Top;
            controlBarPanel.Location = new Point(0, 0);
            controlBarPanel.Margin = new Padding(2);
            controlBarPanel.Name = "controlBarPanel";
            controlBarPanel.Size = new Size(1006, 48);
            controlBarPanel.TabIndex = 7;
            controlBarPanel.MouseDown += controlBarPanel_MouseDown;
            // 
            // maximizeBtn
            // 
            maximizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximizeBtn.FlatAppearance.BorderSize = 0;
            maximizeBtn.FlatStyle = FlatStyle.Flat;
            maximizeBtn.ForeColor = Color.White;
            maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            maximizeBtn.IconColor = Color.White;
            maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maximizeBtn.Location = new Point(920, 4);
            maximizeBtn.Margin = new Padding(2);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(44, 40);
            maximizeBtn.TabIndex = 12;
            maximizeBtn.UseVisualStyleBackColor = true;
            maximizeBtn.Click += maximizeBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            minimizeBtn.IconColor = Color.White;
            minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minimizeBtn.Location = new Point(890, 4);
            minimizeBtn.Margin = new Padding(2);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(32, 40);
            minimizeBtn.TabIndex = 11;
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
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
            closeBtn.Location = new Point(960, 4);
            closeBtn.Margin = new Padding(4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(42, 38);
            closeBtn.TabIndex = 10;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(22, 0);
            logoPictureBox.Margin = new Padding(2);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(48, 48);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 6;
            logoPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(75, 7);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(97, 33);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "EPIST";
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = Color.FromArgb(0, 113, 84);
            navigationPanel.Controls.Add(adminBtn);
            navigationPanel.Controls.Add(exitBtn);
            navigationPanel.Controls.Add(userBtn);
            navigationPanel.Controls.Add(inventoryBtn);
            navigationPanel.Controls.Add(libraryBtn);
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.Location = new Point(0, 48);
            navigationPanel.Margin = new Padding(2);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(1006, 56);
            navigationPanel.TabIndex = 8;
            // 
            // adminBtn
            // 
            adminBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            adminBtn.FlatAppearance.BorderSize = 0;
            adminBtn.FlatStyle = FlatStyle.Flat;
            adminBtn.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            adminBtn.ForeColor = Color.White;
            adminBtn.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            adminBtn.IconColor = Color.White;
            adminBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            adminBtn.ImageAlign = ContentAlignment.MiddleLeft;
            adminBtn.Location = new Point(703, 11);
            adminBtn.Margin = new Padding(2);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(148, 34);
            adminBtn.TabIndex = 4;
            adminBtn.Text = "ADMIN";
            adminBtn.TextAlign = ContentAlignment.MiddleRight;
            adminBtn.UseVisualStyleBackColor = true;
            adminBtn.Click += adminBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.ForeColor = Color.White;
            exitBtn.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingDashedLineArrowRight;
            exitBtn.IconColor = Color.White;
            exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            exitBtn.Location = new Point(872, 11);
            exitBtn.Margin = new Padding(2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(125, 34);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "EXIT";
            exitBtn.TextAlign = ContentAlignment.MiddleRight;
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // userBtn
            // 
            userBtn.FlatAppearance.BorderSize = 0;
            userBtn.FlatStyle = FlatStyle.Flat;
            userBtn.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            userBtn.ForeColor = Color.White;
            userBtn.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            userBtn.IconColor = Color.White;
            userBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            userBtn.ImageAlign = ContentAlignment.MiddleLeft;
            userBtn.Location = new Point(407, 11);
            userBtn.Margin = new Padding(2);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(126, 34);
            userBtn.TabIndex = 2;
            userBtn.Text = "USER";
            userBtn.TextAlign = ContentAlignment.MiddleRight;
            userBtn.UseVisualStyleBackColor = true;
            userBtn.Click += userBtn_Click;
            // 
            // inventoryBtn
            // 
            inventoryBtn.FlatAppearance.BorderSize = 0;
            inventoryBtn.FlatStyle = FlatStyle.Flat;
            inventoryBtn.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryBtn.ForeColor = Color.White;
            inventoryBtn.IconChar = FontAwesome.Sharp.IconChar.HardDrive;
            inventoryBtn.IconColor = Color.White;
            inventoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            inventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.Location = new Point(189, 11);
            inventoryBtn.Margin = new Padding(2);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Size = new Size(214, 34);
            inventoryBtn.TabIndex = 1;
            inventoryBtn.Text = "INVENTORY";
            inventoryBtn.TextAlign = ContentAlignment.MiddleRight;
            inventoryBtn.UseVisualStyleBackColor = true;
            inventoryBtn.Click += inventoryBtn_Click;
            // 
            // libraryBtn
            // 
            libraryBtn.FlatAppearance.BorderSize = 0;
            libraryBtn.FlatStyle = FlatStyle.Flat;
            libraryBtn.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            libraryBtn.ForeColor = Color.White;
            libraryBtn.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            libraryBtn.IconColor = Color.White;
            libraryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            libraryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            libraryBtn.Location = new Point(22, 11);
            libraryBtn.Margin = new Padding(2);
            libraryBtn.Name = "libraryBtn";
            libraryBtn.Size = new Size(170, 34);
            libraryBtn.TabIndex = 0;
            libraryBtn.Text = "LIBRARY";
            libraryBtn.TextAlign = ContentAlignment.MiddleRight;
            libraryBtn.UseVisualStyleBackColor = true;
            libraryBtn.Click += libraryBtn_Click;
            // 
            // changeFormPanel
            // 
            changeFormPanel.Dock = DockStyle.Fill;
            changeFormPanel.Location = new Point(0, 104);
            changeFormPanel.Margin = new Padding(2);
            changeFormPanel.Name = "changeFormPanel";
            changeFormPanel.Size = new Size(1006, 491);
            changeFormPanel.TabIndex = 9;
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 595);
            Controls.Add(changeFormPanel);
            Controls.Add(navigationPanel);
            Controls.Add(controlBarPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "MainWindowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindowForm";
            Load += MainWindowForm_Load;
            Resize += MainWindowForm_Resize;
            controlBarPanel.ResumeLayout(false);
            controlBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            navigationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel controlBarPanel;
        private PictureBox logoPictureBox;
        private Label nameLabel;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private Panel navigationPanel;
        private FontAwesome.Sharp.IconButton libraryBtn;
        private FontAwesome.Sharp.IconButton adminBtn;
        private FontAwesome.Sharp.IconButton exitBtn;
        private FontAwesome.Sharp.IconButton userBtn;
        private FontAwesome.Sharp.IconButton inventoryBtn;
        private Panel changeFormPanel;
    }
}