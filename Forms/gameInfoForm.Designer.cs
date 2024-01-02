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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameInfoForm));
            mainPanel = new Panel();
            gameInfoFlowLayoutPanel = new FlowLayoutPanel();
            gameNameLabel = new Label();
            controlPanel = new Panel();
            addGameButton = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            mainPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Teal;
            mainPanel.Controls.Add(gameInfoFlowLayoutPanel);
            mainPanel.Controls.Add(gameNameLabel);
            mainPanel.Controls.Add(controlPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(921, 850);
            mainPanel.TabIndex = 3;
            // 
            // gameInfoFlowLayoutPanel
            // 
            gameInfoFlowLayoutPanel.AutoScroll = true;
            gameInfoFlowLayoutPanel.BackColor = Color.Teal;
            gameInfoFlowLayoutPanel.Dock = DockStyle.Fill;
            gameInfoFlowLayoutPanel.Location = new Point(0, 66);
            gameInfoFlowLayoutPanel.Margin = new Padding(5);
            gameInfoFlowLayoutPanel.Name = "gameInfoFlowLayoutPanel";
            gameInfoFlowLayoutPanel.Size = new Size(921, 694);
            gameInfoFlowLayoutPanel.TabIndex = 3;
            // 
            // gameNameLabel
            // 
            gameNameLabel.BackColor = Color.Transparent;
            gameNameLabel.Dock = DockStyle.Top;
            gameNameLabel.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            gameNameLabel.ForeColor = Color.MintCream;
            gameNameLabel.Location = new Point(0, 0);
            gameNameLabel.Margin = new Padding(5, 0, 5, 0);
            gameNameLabel.Name = "gameNameLabel";
            gameNameLabel.Size = new Size(921, 66);
            gameNameLabel.TabIndex = 4;
            gameNameLabel.Text = "Game Name";
            gameNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(addGameButton);
            controlPanel.Dock = DockStyle.Bottom;
            controlPanel.Location = new Point(0, 760);
            controlPanel.Margin = new Padding(5);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(921, 90);
            controlPanel.TabIndex = 2;
            // 
            // addGameButton
            // 
            addGameButton.BackColor = Color.PaleTurquoise;
            addGameButton.Dock = DockStyle.Fill;
            addGameButton.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point);
            addGameButton.ForeColor = Color.DarkGreen;
            addGameButton.Location = new Point(0, 0);
            addGameButton.Margin = new Padding(5);
            addGameButton.Name = "addGameButton";
            addGameButton.Size = new Size(921, 90);
            addGameButton.TabIndex = 0;
            addGameButton.Text = "ADD GAME";
            addGameButton.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.None;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1607, 850);
            splitContainer1.SplitterDistance = 341;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.Transparent;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(5);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(mainPanel);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer2.Panel2.BackgroundImage");
            splitContainer2.Panel2.BackgroundImageLayout = ImageLayout.None;
            splitContainer2.Size = new Size(1264, 850);
            splitContainer2.SplitterDistance = 921;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
            // 
            // gameInfoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1607, 850);
            Controls.Add(splitContainer1);
            Margin = new Padding(5);
            Name = "gameInfoForm";
            Text = "gameInfoForm";
            SizeChanged += gameInfoForm_SizeChanged;
            mainPanel.ResumeLayout(false);
            controlPanel.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
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