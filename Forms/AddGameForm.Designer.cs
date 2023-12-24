namespace EpistWinform.Forms
{
    partial class AddGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGameForm));
            addGamePanel = new Panel();
            tagsFlowLayoutPanel = new FlowLayoutPanel();
            tagLabel = new Label();
            cancleBtn = new Button();
            saveBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gamePictureBox1 = new PictureBox();
            gamePictureBox2 = new PictureBox();
            gamePictureBox3 = new PictureBox();
            gameDecPanel = new Panel();
            gameDecTextBox = new TextBox();
            gameDecLabel = new Label();
            gameNamePanel = new Panel();
            label1 = new Label();
            gameNameTextBox = new TextBox();
            gameNameLabel = new Label();
            gameFilePanel = new Panel();
            openGameFileBtn = new Button();
            gameFileTextBox = new TextBox();
            gameFileLabel = new Label();
            addGamePanel.SuspendLayout();
            tagsFlowLayoutPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox3).BeginInit();
            gameDecPanel.SuspendLayout();
            gameNamePanel.SuspendLayout();
            gameFilePanel.SuspendLayout();
            SuspendLayout();
            // 
            // addGamePanel
            // 
            addGamePanel.Controls.Add(tagsFlowLayoutPanel);
            addGamePanel.Controls.Add(cancleBtn);
            addGamePanel.Controls.Add(saveBtn);
            addGamePanel.Controls.Add(flowLayoutPanel1);
            addGamePanel.Controls.Add(gameDecPanel);
            addGamePanel.Controls.Add(gameNamePanel);
            addGamePanel.Controls.Add(gameFilePanel);
            addGamePanel.Dock = DockStyle.Fill;
            addGamePanel.Location = new Point(0, 0);
            addGamePanel.Name = "addGamePanel";
            addGamePanel.Size = new Size(1032, 470);
            addGamePanel.TabIndex = 0;
            // 
            // tagsFlowLayoutPanel
            // 
            tagsFlowLayoutPanel.Controls.Add(tagLabel);
            tagsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            tagsFlowLayoutPanel.Location = new Point(873, 12);
            tagsFlowLayoutPanel.Name = "tagsFlowLayoutPanel";
            tagsFlowLayoutPanel.Size = new Size(156, 453);
            tagsFlowLayoutPanel.TabIndex = 6;
            // 
            // tagLabel
            // 
            tagLabel.Location = new Point(3, 0);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(153, 24);
            tagLabel.TabIndex = 0;
            tagLabel.Text = "Tags";
            tagLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancleBtn
            // 
            cancleBtn.Cursor = Cursors.Hand;
            cancleBtn.Location = new Point(716, 395);
            cancleBtn.Name = "cancleBtn";
            cancleBtn.Size = new Size(123, 59);
            cancleBtn.TabIndex = 5;
            cancleBtn.Text = "Cancel";
            cancleBtn.UseVisualStyleBackColor = true;
            cancleBtn.Click += cancleBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Location = new Point(556, 395);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(123, 59);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(gamePictureBox1);
            flowLayoutPanel1.Controls.Add(gamePictureBox2);
            flowLayoutPanel1.Controls.Add(gamePictureBox3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(530, 470);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // gamePictureBox1
            // 
            gamePictureBox1.BorderStyle = BorderStyle.FixedSingle;
            gamePictureBox1.Cursor = Cursors.Hand;
            gamePictureBox1.Image = (Image)resources.GetObject("gamePictureBox1.Image");
            gamePictureBox1.Location = new Point(3, 3);
            gamePictureBox1.Name = "gamePictureBox1";
            gamePictureBox1.Size = new Size(527, 150);
            gamePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox1.TabIndex = 2;
            gamePictureBox1.TabStop = false;
            gamePictureBox1.Click += gamePictureBox1_Click;
            // 
            // gamePictureBox2
            // 
            gamePictureBox2.BorderStyle = BorderStyle.FixedSingle;
            gamePictureBox2.Cursor = Cursors.Hand;
            gamePictureBox2.Image = (Image)resources.GetObject("gamePictureBox2.Image");
            gamePictureBox2.Location = new Point(3, 159);
            gamePictureBox2.Name = "gamePictureBox2";
            gamePictureBox2.Size = new Size(527, 150);
            gamePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox2.TabIndex = 3;
            gamePictureBox2.TabStop = false;
            gamePictureBox2.Click += gamePictureBox1_Click;
            // 
            // gamePictureBox3
            // 
            gamePictureBox3.BorderStyle = BorderStyle.FixedSingle;
            gamePictureBox3.Cursor = Cursors.Hand;
            gamePictureBox3.Image = (Image)resources.GetObject("gamePictureBox3.Image");
            gamePictureBox3.Location = new Point(3, 315);
            gamePictureBox3.Name = "gamePictureBox3";
            gamePictureBox3.Size = new Size(527, 150);
            gamePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePictureBox3.TabIndex = 4;
            gamePictureBox3.TabStop = false;
            gamePictureBox3.Click += gamePictureBox1_Click;
            // 
            // gameDecPanel
            // 
            gameDecPanel.Controls.Add(gameDecTextBox);
            gameDecPanel.Controls.Add(gameDecLabel);
            gameDecPanel.Location = new Point(537, 184);
            gameDecPanel.Name = "gameDecPanel";
            gameDecPanel.Size = new Size(330, 191);
            gameDecPanel.TabIndex = 2;
            // 
            // gameDecTextBox
            // 
            gameDecTextBox.Location = new Point(3, 27);
            gameDecTextBox.Multiline = true;
            gameDecTextBox.Name = "gameDecTextBox";
            gameDecTextBox.Size = new Size(324, 161);
            gameDecTextBox.TabIndex = 2;
            // 
            // gameDecLabel
            // 
            gameDecLabel.AutoSize = true;
            gameDecLabel.Location = new Point(3, 0);
            gameDecLabel.Name = "gameDecLabel";
            gameDecLabel.Size = new Size(156, 24);
            gameDecLabel.TabIndex = 2;
            gameDecLabel.Text = "Game decription";
            // 
            // gameNamePanel
            // 
            gameNamePanel.Controls.Add(label1);
            gameNamePanel.Controls.Add(gameNameTextBox);
            gameNamePanel.Controls.Add(gameNameLabel);
            gameNamePanel.Location = new Point(537, 11);
            gameNamePanel.Name = "gameNamePanel";
            gameNamePanel.Size = new Size(330, 85);
            gameNamePanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 84);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // gameNameTextBox
            // 
            gameNameTextBox.Location = new Point(3, 41);
            gameNameTextBox.Name = "gameNameTextBox";
            gameNameTextBox.Size = new Size(324, 32);
            gameNameTextBox.TabIndex = 0;
            // 
            // gameNameLabel
            // 
            gameNameLabel.Location = new Point(3, 10);
            gameNameLabel.Name = "gameNameLabel";
            gameNameLabel.Size = new Size(118, 24);
            gameNameLabel.TabIndex = 0;
            gameNameLabel.Text = "Game name";
            // 
            // gameFilePanel
            // 
            gameFilePanel.Controls.Add(openGameFileBtn);
            gameFilePanel.Controls.Add(gameFileTextBox);
            gameFilePanel.Controls.Add(gameFileLabel);
            gameFilePanel.Location = new Point(537, 102);
            gameFilePanel.Name = "gameFilePanel";
            gameFilePanel.Size = new Size(330, 77);
            gameFilePanel.TabIndex = 0;
            // 
            // openGameFileBtn
            // 
            openGameFileBtn.Cursor = Cursors.Hand;
            openGameFileBtn.Location = new Point(288, 33);
            openGameFileBtn.Name = "openGameFileBtn";
            openGameFileBtn.Size = new Size(33, 34);
            openGameFileBtn.TabIndex = 3;
            openGameFileBtn.TabStop = false;
            openGameFileBtn.Text = "o";
            openGameFileBtn.UseVisualStyleBackColor = true;
            openGameFileBtn.Click += openGameFileBtn_Click;
            // 
            // gameFileTextBox
            // 
            gameFileTextBox.Location = new Point(4, 35);
            gameFileTextBox.Name = "gameFileTextBox";
            gameFileTextBox.ReadOnly = true;
            gameFileTextBox.Size = new Size(278, 32);
            gameFileTextBox.TabIndex = 1;
            // 
            // gameFileLabel
            // 
            gameFileLabel.AutoSize = true;
            gameFileLabel.Location = new Point(4, 8);
            gameFileLabel.Name = "gameFileLabel";
            gameFileLabel.Size = new Size(95, 24);
            gameFileLabel.TabIndex = 1;
            gameFileLabel.Text = "Game file";
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 470);
            ControlBox = false;
            Controls.Add(addGamePanel);
            Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddGameForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddGameForm";
            Load += AddGameForm_Load;
            addGamePanel.ResumeLayout(false);
            tagsFlowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gamePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamePictureBox3).EndInit();
            gameDecPanel.ResumeLayout(false);
            gameDecPanel.PerformLayout();
            gameNamePanel.ResumeLayout(false);
            gameNamePanel.PerformLayout();
            gameFilePanel.ResumeLayout(false);
            gameFilePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addGamePanel;
        private Panel gameDecPanel;
        private Panel gameNamePanel;
        private Panel gameFilePanel;
        private Button cancleBtn;
        private Button saveBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox gamePictureBox1;
        private PictureBox gamePictureBox2;
        private PictureBox gamePictureBox3;
        private Label gameNameLabel;
        private Label gameDecLabel;
        private Label gameFileLabel;
        private TextBox gameDecTextBox;
        private TextBox gameNameTextBox;
        private Button openGameFileBtn;
        private TextBox gameFileTextBox;
        private Label label1;
        private FlowLayoutPanel tagsFlowLayoutPanel;
        private Label tagLabel;
    }
}