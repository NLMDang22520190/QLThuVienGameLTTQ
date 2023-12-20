namespace EpistWinform.Forms
{
    partial class gameInfoForm
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
            leftPanel = new Panel();
            rightPanel = new Panel();
            mainPanel = new Panel();
            gameInfoFlowLayoutPanel = new FlowLayoutPanel();
            gameNameLabel = new Label();
            controlPanel = new Panel();
            moreInfoButton = new Button();
            addGameButton = new Button();
            mainPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(0, 199, 139);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(140, 531);
            leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(0, 199, 139);
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(849, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(140, 531);
            rightPanel.TabIndex = 2;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.MediumSpringGreen;
            mainPanel.Controls.Add(gameInfoFlowLayoutPanel);
            mainPanel.Controls.Add(gameNameLabel);
            mainPanel.Controls.Add(controlPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(140, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(709, 531);
            mainPanel.TabIndex = 3;
            // 
            // gameInfoFlowLayoutPanel
            // 
            gameInfoFlowLayoutPanel.AutoScroll = true;
            gameInfoFlowLayoutPanel.Dock = DockStyle.Fill;
            gameInfoFlowLayoutPanel.Location = new Point(0, 41);
            gameInfoFlowLayoutPanel.Name = "gameInfoFlowLayoutPanel";
            gameInfoFlowLayoutPanel.Size = new Size(709, 434);
            gameInfoFlowLayoutPanel.TabIndex = 3;
            // 
            // gameNameLabel
            // 
            gameNameLabel.BackColor = Color.Transparent;
            gameNameLabel.Dock = DockStyle.Top;
            gameNameLabel.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            gameNameLabel.Location = new Point(0, 0);
            gameNameLabel.Name = "gameNameLabel";
            gameNameLabel.Size = new Size(709, 41);
            gameNameLabel.TabIndex = 4;
            gameNameLabel.Text = "Game Name";
            gameNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(moreInfoButton);
            controlPanel.Controls.Add(addGameButton);
            controlPanel.Dock = DockStyle.Bottom;
            controlPanel.Location = new Point(0, 475);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(709, 56);
            controlPanel.TabIndex = 2;
            // 
            // moreInfoButton
            // 
            moreInfoButton.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point);
            moreInfoButton.Location = new Point(356, 3);
            moreInfoButton.Name = "moreInfoButton";
            moreInfoButton.Size = new Size(344, 50);
            moreInfoButton.TabIndex = 1;
            moreInfoButton.Text = "MORE INFO";
            moreInfoButton.UseVisualStyleBackColor = true;
            moreInfoButton.Click += MoreInfoButton_Click;
            // 
            // addGameButton
            // 
            addGameButton.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point);
            addGameButton.Location = new Point(3, 3);
            addGameButton.Name = "addGameButton";
            addGameButton.Size = new Size(347, 50);
            addGameButton.TabIndex = 0;
            addGameButton.Text = "ADD GAME";
            addGameButton.UseVisualStyleBackColor = true;
            addGameButton.Click += AddToInventoryButton_Click;
            // 
            // gameInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 531);
            Controls.Add(mainPanel);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "gameInfoForm";
            Text = "gameInfoForm";
            SizeChanged += gameInfoForm_SizeChanged;
            mainPanel.ResumeLayout(false);
            controlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel rightPanel;
        private Panel mainPanel;
        private Panel controlPanel;
        private Button moreInfoButton;
        private Button addGameButton;
        private Label label1;
        private FlowLayoutPanel gameInfoFlowLayoutPanel;
        private Label gameNameLabel;
    }
}