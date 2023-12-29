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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libraryForm_Alt_Ver_));
            TagsFlowLayoutPanel = new FlowLayoutPanel();
            tagLabel = new Label();
            gamesFlowLayoutPanel = new FlowLayoutPanel();
            splitContainer6 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            searchGameComboBox = new ComboBox();
            panel1 = new Panel();
            TagsFlowLayoutPanel.SuspendLayout();
            gamesFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TagsFlowLayoutPanel
            // 
            TagsFlowLayoutPanel.AutoScroll = true;
            TagsFlowLayoutPanel.BackColor = Color.FromArgb(0, 199, 139);
            TagsFlowLayoutPanel.Controls.Add(tagLabel);
            TagsFlowLayoutPanel.Dock = DockStyle.Fill;
            TagsFlowLayoutPanel.Location = new Point(0, 0);
            TagsFlowLayoutPanel.Name = "TagsFlowLayoutPanel";
            TagsFlowLayoutPanel.Size = new Size(292, 267);
            TagsFlowLayoutPanel.TabIndex = 1;
            // 
            // tagLabel
            // 
            tagLabel.Dock = DockStyle.Top;
            tagLabel.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tagLabel.ForeColor = Color.White;
            tagLabel.Location = new Point(3, 0);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(289, 43);
            tagLabel.TabIndex = 0;
            tagLabel.Text = "Tags";
            tagLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gamesFlowLayoutPanel
            // 
            gamesFlowLayoutPanel.AutoScroll = true;
            gamesFlowLayoutPanel.Controls.Add(splitContainer6);
            gamesFlowLayoutPanel.Dock = DockStyle.Fill;
            gamesFlowLayoutPanel.Location = new Point(292, 0);
            gamesFlowLayoutPanel.Name = "gamesFlowLayoutPanel";
            gamesFlowLayoutPanel.Size = new Size(697, 267);
            gamesFlowLayoutPanel.TabIndex = 2;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.Location = new Point(3, 3);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Size = new Size(188, 0);
            splitContainer6.SplitterDistance = 62;
            splitContainer6.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.Transparent;
            splitContainer2.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer2.Panel1.BackgroundImage");
            splitContainer2.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer2.Panel1.Controls.Add(searchGameComboBox);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(gamesFlowLayoutPanel);
            splitContainer2.Panel2.Controls.Add(panel1);
            splitContainer2.Size = new Size(989, 446);
            splitContainer2.SplitterDistance = 175;
            splitContainer2.TabIndex = 4;
            // 
            // searchGameComboBox
            // 
            searchGameComboBox.Anchor = AnchorStyles.Top;
            searchGameComboBox.FormattingEnabled = true;
            searchGameComboBox.Location = new Point(275, 12);
            searchGameComboBox.Name = "searchGameComboBox";
            searchGameComboBox.Size = new Size(481, 28);
            searchGameComboBox.TabIndex = 1;
            searchGameComboBox.DropDown += searchGameComboBox_DropDown;
            searchGameComboBox.TextChanged += searchGameComboBox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(TagsFlowLayoutPanel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 267);
            panel1.TabIndex = 0;
            // 
            // libraryForm_Alt_Ver_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 446);
            Controls.Add(splitContainer2);
            Name = "libraryForm_Alt_Ver_";
            Text = "libraryForm_Alt_Ver_";
            Resize += libraryForm_Alt_Ver__Resize;
            TagsFlowLayoutPanel.ResumeLayout(false);
            gamesFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel TagsFlowLayoutPanel;
        private FlowLayoutPanel gamesFlowLayoutPanel;
        private ComboBox searchGameComboBox;
        private Label tagsLabel;
        private Label tagLabel;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private SplitContainer splitContainer6;
        private Panel panel1;
    }
}