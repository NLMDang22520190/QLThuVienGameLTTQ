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
            mainPanel = new Panel();
            gameInfoFlowLayoutPanel = new FlowLayoutPanel();
            addGameButton = new Button();
            gameNameLabel = new Label();
            controlPanel = new Panel();
            leftPanel = new Panel();
            rightPanel = new Panel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            mainPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.MediumSpringGreen;
            mainPanel.Controls.Add(gameInfoFlowLayoutPanel);
            mainPanel.Controls.Add(gameNameLabel);
            mainPanel.Controls.Add(controlPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(563, 531);
            mainPanel.TabIndex = 3;
            // 
            // gameInfoFlowLayoutPanel
            // 
            gameInfoFlowLayoutPanel.AutoScroll = true;
            gameInfoFlowLayoutPanel.Dock = DockStyle.Fill;
            gameInfoFlowLayoutPanel.Location = new Point(0, 41);
            gameInfoFlowLayoutPanel.Name = "gameInfoFlowLayoutPanel";
            gameInfoFlowLayoutPanel.Size = new Size(563, 434);
            gameInfoFlowLayoutPanel.TabIndex = 3;
            // 
            // addGameButton
            // 
            addGameButton.Dock = DockStyle.Fill;
            addGameButton.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point);
            addGameButton.Location = new Point(0, 0);
            addGameButton.Name = "addGameButton";
            addGameButton.Size = new Size(563, 56);
            addGameButton.TabIndex = 0;
            addGameButton.Text = "ADD GAME";
            addGameButton.UseVisualStyleBackColor = true;
            // 
            // gameNameLabel
            // 
            gameNameLabel.BackColor = Color.Transparent;
            gameNameLabel.Dock = DockStyle.Top;
            gameNameLabel.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            gameNameLabel.Location = new Point(0, 0);
            gameNameLabel.Name = "gameNameLabel";
            gameNameLabel.Size = new Size(563, 41);
            gameNameLabel.TabIndex = 4;
            gameNameLabel.Text = "Game Name";
            gameNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(addGameButton);
            controlPanel.Dock = DockStyle.Bottom;
            controlPanel.Location = new Point(0, 475);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(563, 56);
            controlPanel.TabIndex = 2;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(0, 199, 139);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(214, 531);
            leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(0, 199, 139);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(210, 531);
            rightPanel.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(leftPanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(989, 531);
            splitContainer1.SplitterDistance = 214;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(mainPanel);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(rightPanel);
            splitContainer2.Size = new Size(774, 531);
            splitContainer2.SplitterDistance = 563;
            splitContainer2.SplitterWidth = 1;
            splitContainer2.TabIndex = 0;
            // 
            // gameInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 199, 139);
            ClientSize = new Size(989, 531);
            Controls.Add(splitContainer1);
            Name = "gameInfoForm";
            Text = "gameInfoForm";
            SizeChanged += gameInfoForm_SizeChanged;
            mainPanel.ResumeLayout(false);
            controlPanel.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel mainPanel;
        private Panel controlPanel;
        private Button addGameButton;
        private Label label1;
        private FlowLayoutPanel gameInfoFlowLayoutPanel;
        private Label gameNameLabel;
        private Panel leftPanel;
        private Panel rightPanel;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
    }
}