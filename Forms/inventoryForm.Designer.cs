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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryForm));
            panel1 = new Panel();
            spacePanel = new Panel();
            gamesPanel = new FlowLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            bannerPanel = new Panel();
            searchTextBox = new TextBox();
            bannerPictureBox = new PictureBox();
            panel1.SuspendLayout();
            bannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bannerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(0, 558);
            panel1.Controls.Add(spacePanel);
            panel1.Controls.Add(gamesPanel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(bannerPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 558);
            panel1.TabIndex = 0;
            // 
            // spacePanel
            // 
            spacePanel.Dock = DockStyle.Fill;
            spacePanel.Location = new Point(300, 530);
            spacePanel.Name = "spacePanel";
            spacePanel.Size = new Size(936, 28);
            spacePanel.TabIndex = 4;
            // 
            // gamesPanel
            // 
            gamesPanel.BackColor = Color.Lime;
            gamesPanel.Dock = DockStyle.Top;
            gamesPanel.Location = new Point(300, 380);
            gamesPanel.Name = "gamesPanel";
            gamesPanel.Size = new Size(936, 150);
            gamesPanel.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Salmon;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(300, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(936, 150);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 328);
            panel2.TabIndex = 2;
            // 
            // bannerPanel
            // 
            bannerPanel.BackgroundImageLayout = ImageLayout.Stretch;
            bannerPanel.Controls.Add(searchTextBox);
            bannerPanel.Controls.Add(bannerPictureBox);
            bannerPanel.Dock = DockStyle.Top;
            bannerPanel.Location = new Point(0, 0);
            bannerPanel.Name = "bannerPanel";
            bannerPanel.Size = new Size(1236, 230);
            bannerPanel.TabIndex = 1;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top;
            searchTextBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(345, 43);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(602, 36);
            searchTextBox.TabIndex = 0;
            // 
            // bannerPictureBox
            // 
            bannerPictureBox.Dock = DockStyle.Fill;
            bannerPictureBox.Image = (Image)resources.GetObject("bannerPictureBox.Image");
            bannerPictureBox.Location = new Point(0, 0);
            bannerPictureBox.Name = "bannerPictureBox";
            bannerPictureBox.Size = new Size(1236, 230);
            bannerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bannerPictureBox.TabIndex = 2;
            bannerPictureBox.TabStop = false;
            // 
            // inventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1236, 558);
            Controls.Add(panel1);
            Name = "inventoryForm";
            Text = "inventoryForm";
            Load += inventoryForm_Load;
            SizeChanged += inventoryForm_SizeChanged;
            Resize += inventoryForm_Resize;
            panel1.ResumeLayout(false);
            bannerPanel.ResumeLayout(false);
            bannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bannerPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel bannerPanel;
        private TextBox searchTextBox;
        private PictureBox bannerPictureBox;
        private FlowLayoutPanel allGamesFlowPanel;
        private Panel panel3;
        private Panel panel2;
        private Panel spacePanel;
        private FlowLayoutPanel gamesPanel;
    }
}