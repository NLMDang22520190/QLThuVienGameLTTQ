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
            panel_games = new Panel();
            flowlayoutpanel_games = new FlowLayoutPanel();
            tagsFlowPanel = new FlowLayoutPanel();
            panel_gametag = new Panel();
            label_gametag = new Label();
            bannerPanel = new Panel();
            comboBox2 = new ComboBox();
            bannerPictureBox = new PictureBox();
            comboBox1 = new ComboBox();
            libraryPanel.SuspendLayout();
            panel_games.SuspendLayout();
            tagsFlowPanel.SuspendLayout();
            bannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bannerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // libraryPanel
            // 
            libraryPanel.Controls.Add(panel_games);
            libraryPanel.Controls.Add(tagsFlowPanel);
            libraryPanel.Controls.Add(bannerPanel);
            libraryPanel.Dock = DockStyle.Fill;
            libraryPanel.Location = new Point(0, 0);
            libraryPanel.Name = "libraryPanel";
            libraryPanel.Size = new Size(1854, 826);
            libraryPanel.TabIndex = 0;
            // 
            // panel_games
            // 
            panel_games.Controls.Add(flowlayoutpanel_games);
            panel_games.Dock = DockStyle.Fill;
            panel_games.Location = new Point(500, 340);
            panel_games.Name = "panel_games";
            panel_games.Size = new Size(1354, 486);
            panel_games.TabIndex = 3;
            // 
            // flowlayoutpanel_games
            // 
            flowlayoutpanel_games.AutoScroll = true;
            flowlayoutpanel_games.Dock = DockStyle.Fill;
            flowlayoutpanel_games.Location = new Point(0, 0);
            flowlayoutpanel_games.Margin = new Padding(35);
            flowlayoutpanel_games.Name = "flowlayoutpanel_games";
            flowlayoutpanel_games.Size = new Size(1354, 486);
            flowlayoutpanel_games.TabIndex = 2;
            // 
            // tagsFlowPanel
            // 
            tagsFlowPanel.AutoScroll = true;
            tagsFlowPanel.BackColor = Color.FromArgb(0, 199, 139);
            tagsFlowPanel.Controls.Add(panel_gametag);
            tagsFlowPanel.Controls.Add(label_gametag);
            tagsFlowPanel.Dock = DockStyle.Left;
            tagsFlowPanel.Location = new Point(0, 340);
            tagsFlowPanel.Name = "tagsFlowPanel";
            tagsFlowPanel.Size = new Size(500, 486);
            tagsFlowPanel.TabIndex = 1;
            // 
            // panel_gametag
            // 
            panel_gametag.Dock = DockStyle.Fill;
            panel_gametag.Location = new Point(3, 3);
            panel_gametag.Name = "panel_gametag";
            panel_gametag.Size = new Size(336, 0);
            panel_gametag.TabIndex = 0;
            // 
            // label_gametag
            // 
            label_gametag.Dock = DockStyle.Top;
            label_gametag.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label_gametag.ForeColor = SystemColors.ButtonHighlight;
            label_gametag.Location = new Point(3, 6);
            label_gametag.Name = "label_gametag";
            label_gametag.Size = new Size(440, 74);
            label_gametag.TabIndex = 0;
            label_gametag.Text = "Gametag";
            label_gametag.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bannerPanel
            // 
            bannerPanel.Controls.Add(comboBox2);
            bannerPanel.Controls.Add(bannerPictureBox);
            bannerPanel.Controls.Add(comboBox1);
            bannerPanel.Dock = DockStyle.Top;
            bannerPanel.Location = new Point(0, 0);
            bannerPanel.Margin = new Padding(2);
            bannerPanel.Name = "bannerPanel";
            bannerPanel.Size = new Size(1854, 340);
            bannerPanel.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(565, 67);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(711, 44);
            comboBox2.TabIndex = 16;
            // 
            // bannerPictureBox
            // 
            bannerPictureBox.Dock = DockStyle.Fill;
            bannerPictureBox.Location = new Point(0, 0);
            bannerPictureBox.Name = "bannerPictureBox";
            bannerPictureBox.Size = new Size(1854, 340);
            bannerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bannerPictureBox.TabIndex = 15;
            bannerPictureBox.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Endoparasitic", "Thronefall", "MMORPG Tycoon 2", "Stoneshard", "Desktop Dungeons: Rewind", "Neon Abyss", "Brothers in Hell", "A Dance of Fire and Ice", "Halls of Torment", "WorldBox - God Simulator", "Poly Bridge", "Poly Bridge 2", "Poly Bridge 3" });
            comboBox1.Location = new Point(579, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(684, 44);
            comboBox1.TabIndex = 14;
            // 
            // libraryForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1854, 826);
            Controls.Add(libraryPanel);
            ForeColor = Color.White;
            Name = "libraryForm";
            Text = "libraryForm";
            Shown += libraryForm_Shown;
            VisibleChanged += libraryForm_VisibleChanged;
            libraryPanel.ResumeLayout(false);
            panel_games.ResumeLayout(false);
            tagsFlowPanel.ResumeLayout(false);
            bannerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bannerPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel libraryPanel;
        private FlowLayoutPanel flowlayoutpanel_games;
        private FlowLayoutPanel tagsFlowPanel;
        private Panel panel_gametag;
        private Label label_gametag;
        private Panel panel_games;
        private Panel bannerPanel;
        private ComboBox comboBox1;
        private PictureBox bannerPictureBox;
        private ComboBox comboBox2;
    }
}