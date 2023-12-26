using EpistWinform.DAO;
using EpistWinform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpistWinform.Forms
{
    public partial class AddGameForm : Form
    {
        private Game currentAddedGame = new Game();
        private List<Tag> listTags = new List<Tag>();
        private List<int> listSelectedTags = new List<int>();
        private string currentAddedGameFilePath;
        public event EventHandler<string> currentAddedGameChanged;
        public event EventHandler<List<int>> currentAddedGameTagsListChanged;
        public AddGameForm(ref Game currentGame)
        {
            InitializeComponent();
            currentAddedGame = currentGame;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gameNameTextBox.Text) ||
            string.IsNullOrWhiteSpace(gameDecTextBox.Text) ||
            string.IsNullOrWhiteSpace(gameFileTextBox.Text) ||
            string.IsNullOrWhiteSpace(gamePictureBox1.ImageLocation) ||
            string.IsNullOrWhiteSpace(gamePictureBox2.ImageLocation) ||
            string.IsNullOrWhiteSpace(gamePictureBox3.ImageLocation))
            {
                MessageBox.Show("Please fill in all required information (GameName, GameInfo, GameFile, and images).", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            addGameTag();

            if (listSelectedTags.Count < 3)
            {
                MessageBox.Show("Please select at least 3 tags.", "Insufficient Tags", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to save the game with the provided information? After saving, you won't be able to change the game file, game tag, and game pictures.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // If the user clicks "OK", set the userConfirmed flag to true and proceed to save the game
            if (result == DialogResult.OK)
            {
                SaveGame();
            }
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gamePictureBox1_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox picture)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picture.ImageLocation = openFileDialog.FileName;
                }
            }

        }

        private void openGameFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Zip Files|*.zip";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file zip
                string zipFilePath = openFileDialog.FileName;
                gameFileTextBox.Text = zipFilePath;
                // Thực hiện xử lý của bạn với đường dẫn file zip
            }
        }

        private void gameNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu kí tự không phải là chữ, số, khoảng trắng, hoặc phím Backspace, và không có tổ hợp phím Ctrl
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && !ModifierKeys.HasFlag(Keys.Control))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only alphanumeric characters and spaces.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddGameForm_Load(object sender, EventArgs e)
        {
            LoadTag();
        }

        void LoadTag()
        {
            listTags = TagDAO.Instance.LoadTagsList();
            foreach (Tag tag in listTags)
            {
                CheckBox tags = new CheckBox { Margin = new Padding(10, 0, 10, 0) };
                tags.Width = tagsFlowLayoutPanel.Width - tags.Margin.Left - tags.Margin.Right;
                tags.AutoSize = true;
                tags.Text = tag.TagName;
                tags.TextAlign = ContentAlignment.MiddleCenter;
                tags.Font = new Font("Tahoma", 10);
                tags.ForeColor = Color.Black;
                tagsFlowLayoutPanel.Controls.Add(tags);
            }
        }

        void addGameTag()
        {
            listSelectedTags.Clear();
            foreach (Control control in tagsFlowLayoutPanel.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    foreach (Tag tag in listTags)
                    {
                        if (checkBox.Text == tag.TagName)
                            listSelectedTags.Add(tag.TagID);
                    }
                }
            }
        }
        private void SaveGame()
        {
            // The rest of your existing save logic goes here...
            currentAddedGame.GameName = gameNameTextBox.Text;
            currentAddedGame.GameInfo = gameDecTextBox.Text;
            currentAddedGame.Picture1 = $".\\Resource\\GamesPicture\\{currentAddedGame.GameID}\\Picture1.jpg";
            currentAddedGame.Picture2 = $".\\Resource\\GamesPicture\\{currentAddedGame.GameID}\\Picture2.jpg";
            currentAddedGame.Picture3 = $".\\Resource\\GamesPicture\\{currentAddedGame.GameID}\\Picture3.jpg";
            currentAddedGameFilePath = gameFileTextBox.Text;

            currentAddedGameChanged?.Invoke(this, currentAddedGameFilePath);
            currentAddedGameTagsListChanged?.Invoke(this, listSelectedTags);

            FileUploader.Instance.UploadPictureFile(gamePictureBox1.ImageLocation, "Picture1", currentAddedGame.GameID.ToString());
            FileUploader.Instance.UploadPictureFile(gamePictureBox2.ImageLocation, "Picture2", currentAddedGame.GameID.ToString());
            FileUploader.Instance.UploadPictureFile(gamePictureBox3.ImageLocation, "Picture3", currentAddedGame.GameID.ToString());

            FileUploader.Instance.UploadGameFile(gameFileTextBox.Text, currentAddedGame.GameID.ToString());

            GamesDAO.Instance.InsertGame(currentAddedGame.GameName, currentAddedGame.GameInfo, currentAddedGame.Picture1, currentAddedGame.Picture2, currentAddedGame.Picture3);

            GameTagsDAO.Instance.InsertGameTags(currentAddedGame.GameID, listSelectedTags);

            MessageBox.Show("Game added successfully!\n\nGames added will show up when the app is restarted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
