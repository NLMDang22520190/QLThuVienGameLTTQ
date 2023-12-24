namespace EpistWinform.Forms
{
    partial class userForm
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
            DisplayNameTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            EditButton = new Button();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // DisplayNameTextBox
            // 
            DisplayNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DisplayNameTextBox.Location = new Point(285, 94);
            DisplayNameTextBox.Name = "DisplayNameTextBox";
            DisplayNameTextBox.Size = new Size(285, 27);
            DisplayNameTextBox.TabIndex = 0;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.Location = new Point(285, 157);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(285, 27);
            UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(285, 227);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(285, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(285, 293);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(285, 350);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(476, 350);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // userForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 446);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(EditButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(DisplayNameTextBox);
            Margin = new Padding(2);
            Name = "userForm";
            Text = "userForm";
            Load += userForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DisplayNameTextBox;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button EditButton;
        private Button SaveButton;
        private Button CancelButton;
    }
}