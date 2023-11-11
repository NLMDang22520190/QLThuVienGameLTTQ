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
            controlBarPanel.Name = "controlBarPanel";
            controlBarPanel.Size = new Size(1258, 60);
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
            maximizeBtn.Location = new Point(1172, 5);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(40, 40);
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
            minimizeBtn.Location = new Point(1126, 5);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(40, 40);
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
            closeBtn.Location = new Point(1213, 5);
            closeBtn.Margin = new Padding(5);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(40, 40);
            closeBtn.TabIndex = 10;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(28, 0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(60, 60);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 6;
            logoPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(94, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(113, 39);
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
            navigationPanel.Location = new Point(0, 60);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(1258, 70);
            navigationPanel.TabIndex = 8;
            // 
            // adminBtn
            // 
            adminBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            adminBtn.FlatAppearance.BorderSize = 0;
            adminBtn.FlatStyle = FlatStyle.Flat;
            adminBtn.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            adminBtn.ForeColor = Color.White;
            adminBtn.IconChar = FontAwesome.Sharp.IconChar.CableCar;
            adminBtn.IconColor = Color.White;
            adminBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            adminBtn.ImageAlign = ContentAlignment.MiddleLeft;
            adminBtn.Location = new Point(932, 14);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(169, 42);
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
            exitBtn.IconChar = FontAwesome.Sharp.IconChar.CableCar;
            exitBtn.IconColor = Color.White;
            exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            exitBtn.Location = new Point(1107, 14);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(139, 42);
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
            userBtn.IconChar = FontAwesome.Sharp.IconChar.CableCar;
            userBtn.IconColor = Color.White;
            userBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            userBtn.ImageAlign = ContentAlignment.MiddleLeft;
            userBtn.Location = new Point(474, 14);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(147, 42);
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
            inventoryBtn.IconChar = FontAwesome.Sharp.IconChar.CableCar;
            inventoryBtn.IconColor = Color.White;
            inventoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            inventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.Location = new Point(228, 14);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Size = new Size(240, 42);
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
            libraryBtn.IconChar = FontAwesome.Sharp.IconChar.CableCar;
            libraryBtn.IconColor = Color.White;
            libraryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            libraryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            libraryBtn.Location = new Point(28, 14);
            libraryBtn.Name = "libraryBtn";
            libraryBtn.Size = new Size(194, 42);
            libraryBtn.TabIndex = 0;
            libraryBtn.Text = "LIBRARY";
            libraryBtn.TextAlign = ContentAlignment.MiddleRight;
            libraryBtn.UseVisualStyleBackColor = true;
            libraryBtn.Click += libraryBtn_Click;
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(navigationPanel);
            Controls.Add(controlBarPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindowForm";
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
    }
}