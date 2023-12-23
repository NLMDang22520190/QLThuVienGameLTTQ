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
        private string currentAddedGameFilePath;
        public event EventHandler<string> currentAddedGameChanged;
        public AddGameForm(ref Game currentGame, ref string currentGameFilePath)
        {
            InitializeComponent();
            currentAddedGame = currentGame;
            currentAddedGameFilePath = currentGameFilePath;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            currentAddedGame.GameName = gameNameTextBox.Text;
            currentAddedGame.GameInfo = gameDecTextBox.Text;
            currentAddedGame.Picture1 = gamePictureBox1.ImageLocation;
            currentAddedGame.Picture2 = gamePictureBox2.ImageLocation;
            currentAddedGame.Picture3 = gamePictureBox3.ImageLocation;
            
            currentAddedGameFilePath = gameFileTextBox.Text;
            currentAddedGameChanged?.Invoke(this, currentAddedGameFilePath);
            this.Close();
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
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

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
    }
}
