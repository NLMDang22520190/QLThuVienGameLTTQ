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
            controlPanel = new Panel();
            moreInfoButton = new Button();
            addGameButton = new Button();
            detailFlowLayoutPanel = new FlowLayoutPanel();
            mainPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            leftPanel.BackColor = Color.FromArgb(0, 199, 139);
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(140, 531);
            leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rightPanel.BackColor = Color.FromArgb(0, 199, 139);
            rightPanel.Location = new Point(849, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(140, 531);
            rightPanel.TabIndex = 2;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.MediumSpringGreen;
            mainPanel.Controls.Add(controlPanel);
            mainPanel.Controls.Add(detailFlowLayoutPanel);
            mainPanel.Location = new Point(140, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(710, 536);
            mainPanel.TabIndex = 3;
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(moreInfoButton);
            controlPanel.Controls.Add(addGameButton);
            controlPanel.Location = new Point(3, 474);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(701, 56);
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
            // 
            // detailFlowLayoutPanel
            // 
            detailFlowLayoutPanel.AutoScroll = true;
            detailFlowLayoutPanel.Location = new Point(3, 43);
            detailFlowLayoutPanel.Name = "detailFlowLayoutPanel";
            detailFlowLayoutPanel.Size = new Size(704, 425);
            detailFlowLayoutPanel.TabIndex = 1;
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
            mainPanel.ResumeLayout(false);
            controlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel rightPanel;
        private Panel mainPanel;
        private Panel controlPanel;
        private FlowLayoutPanel detailFlowLayoutPanel;
        private Button moreInfoButton;
        private Button addGameButton;
    }
}