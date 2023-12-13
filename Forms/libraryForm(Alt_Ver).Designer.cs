namespace EpistWinform.Forms
{
    partial class libraryForm_Alt_Ver_
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
            bannerPictureBox = new PictureBox();
            TagsFlowLayoutPanel = new FlowLayoutPanel();
            gamesFlowLayoutPanel = new FlowLayoutPanel();
            searchGameComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bannerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // bannerPictureBox
            // 
            bannerPictureBox.Dock = DockStyle.Top;
            bannerPictureBox.Location = new Point(0, 0);
            bannerPictureBox.Name = "bannerPictureBox";
            bannerPictureBox.Size = new Size(989, 198);
            bannerPictureBox.TabIndex = 0;
            bannerPictureBox.TabStop = false;
            // 
            // TagsFlowLayoutPanel
            // 
            TagsFlowLayoutPanel.AutoScroll = true;
            TagsFlowLayoutPanel.BackColor = Color.FromArgb(0, 199, 139);
            TagsFlowLayoutPanel.Dock = DockStyle.Left;
            TagsFlowLayoutPanel.Location = new Point(0, 198);
            TagsFlowLayoutPanel.Name = "TagsFlowLayoutPanel";
            TagsFlowLayoutPanel.Size = new Size(274, 248);
            TagsFlowLayoutPanel.TabIndex = 1;
            // 
            // gamesFlowLayoutPanel
            // 
            gamesFlowLayoutPanel.AutoScroll = true;
            gamesFlowLayoutPanel.Dock = DockStyle.Fill;
            gamesFlowLayoutPanel.Location = new Point(274, 198);
            gamesFlowLayoutPanel.Name = "gamesFlowLayoutPanel";
            gamesFlowLayoutPanel.Size = new Size(715, 248);
            gamesFlowLayoutPanel.TabIndex = 2;
            // 
            // searchGameComboBox
            // 
            searchGameComboBox.FormattingEnabled = true;
            searchGameComboBox.Location = new Point(250, 12);
            searchGameComboBox.Name = "searchGameComboBox";
            searchGameComboBox.Size = new Size(451, 28);
            searchGameComboBox.TabIndex = 0;
            // 
            // libraryForm_Alt_Ver_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 446);
            Controls.Add(searchGameComboBox);
            Controls.Add(gamesFlowLayoutPanel);
            Controls.Add(TagsFlowLayoutPanel);
            Controls.Add(bannerPictureBox);
            Name = "libraryForm_Alt_Ver_";
            Text = "libraryForm_Alt_Ver_";
            Resize += libraryForm_Alt_Ver__Resize;
            ((System.ComponentModel.ISupportInitialize)bannerPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox bannerPictureBox;
        private FlowLayoutPanel TagsFlowLayoutPanel;
        private FlowLayoutPanel gamesFlowLayoutPanel;
        private ComboBox searchGameComboBox;
        private Label tagsLabel;
    }
}