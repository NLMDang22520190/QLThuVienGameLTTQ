namespace EpistWinform.Forms
{
    partial class libraryForm
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
            libraryPanel = new Panel();
            spacePanel = new Panel();
            allGamesFlowPanel = new FlowLayoutPanel();
            tagsFlowPanel = new FlowLayoutPanel();
            bannerPanel = new Panel();
            textBox1 = new TextBox();
            bannerPictureBox = new PictureBox();
            libraryPanel.SuspendLayout();
            bannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bannerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // libraryPanel
            // 
            libraryPanel.Controls.Add(spacePanel);
            libraryPanel.Controls.Add(allGamesFlowPanel);
            libraryPanel.Controls.Add(tagsFlowPanel);
            libraryPanel.Controls.Add(bannerPanel);
            libraryPanel.Dock = DockStyle.Fill;
            libraryPanel.Location = new Point(0, 0);
            libraryPanel.Margin = new Padding(2, 2, 2, 2);
            libraryPanel.Name = "libraryPanel";
            libraryPanel.Size = new Size(989, 446);
            libraryPanel.TabIndex = 0;
            // 
            // spacePanel
            // 
            spacePanel.BackColor = Color.FromArgb(140, 231, 196);
            spacePanel.Dock = DockStyle.Fill;
            spacePanel.Location = new Point(240, 310);
            spacePanel.Margin = new Padding(2, 2, 2, 2);
            spacePanel.Name = "spacePanel";
            spacePanel.Size = new Size(749, 136);
            spacePanel.TabIndex = 4;
            // 
            // allGamesFlowPanel
            // 
            allGamesFlowPanel.BackColor = Color.FromArgb(140, 231, 196);
            allGamesFlowPanel.Dock = DockStyle.Top;
            allGamesFlowPanel.Location = new Point(240, 184);
            allGamesFlowPanel.Margin = new Padding(2, 2, 2, 2);
            allGamesFlowPanel.Name = "allGamesFlowPanel";
            allGamesFlowPanel.Size = new Size(749, 126);
            allGamesFlowPanel.TabIndex = 3;
            // 
            // tagsFlowPanel
            // 
            tagsFlowPanel.BackColor = Color.FromArgb(0, 199, 139);
            tagsFlowPanel.Dock = DockStyle.Left;
            tagsFlowPanel.Location = new Point(0, 184);
            tagsFlowPanel.Margin = new Padding(2, 2, 2, 2);
            tagsFlowPanel.Name = "tagsFlowPanel";
            tagsFlowPanel.Size = new Size(240, 262);
            tagsFlowPanel.TabIndex = 1;
            // 
            // bannerPanel
            // 
            bannerPanel.Controls.Add(textBox1);
            bannerPanel.Controls.Add(bannerPictureBox);
            bannerPanel.Dock = DockStyle.Top;
            bannerPanel.Location = new Point(0, 0);
            bannerPanel.Margin = new Padding(2, 2, 2, 2);
            bannerPanel.Name = "bannerPanel";
            bannerPanel.Size = new Size(989, 184);
            bannerPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(228, 240, 255);
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(269, 40);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 32);
            textBox1.TabIndex = 1;
            // 
            // bannerPictureBox
            // 
            bannerPictureBox.Dock = DockStyle.Fill;
            bannerPictureBox.Location = new Point(0, 0);
            bannerPictureBox.Margin = new Padding(2, 2, 2, 2);
            bannerPictureBox.Name = "bannerPictureBox";
            bannerPictureBox.Size = new Size(989, 184);
            bannerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bannerPictureBox.TabIndex = 0;
            bannerPictureBox.TabStop = false;
            bannerPictureBox.Click += bannerPictureBox_Click;
            // 
            // libraryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 446);
            Controls.Add(libraryPanel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "libraryForm";
            Text = "libraryForm";
            Shown += libraryForm_Shown;
            VisibleChanged += libraryForm_VisibleChanged;
            libraryPanel.ResumeLayout(false);
            bannerPanel.ResumeLayout(false);
            bannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bannerPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel libraryPanel;
        private Panel bannerPanel;
        private PictureBox bannerPictureBox;
        private TextBox textBox1;
        private FlowLayoutPanel tagsFlowPanel;
        private Panel spacePanel;
        private FlowLayoutPanel allGamesFlowPanel;
    }
}