using EpistWinform.DAO;
using EpistWinform.DTO;
using FontAwesome.Sharp;
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
    public partial class inventoryForm : Form
    {
        private List<Game> gameList;
        public inventoryForm()
        {
            InitializeComponent();


        }
        #region method
        private void LoadGameList()
        {
            gameList = GamesDAO.Instance.LoadGamesList();
            foreach (Game game in gameList)
            {
                Button gameBtn = new Button() { Margin = new Padding(10, 0, 10, 0) };
                gameBtn.Width = ownGameLayoutPanel.Width - gameBtn.Margin.Left - gameBtn.Margin.Right;
                gameBtn.AutoSize = true;
                gameBtn.Text = game.GameName;
                gameBtn.TextAlign = ContentAlignment.MiddleCenter;
                gameBtn.Font = new Font("Tahoma", 10);
                gameBtn.ForeColor = Color.White;
                gameBtn.Click += GameButton_Click;
                ownGameLayoutPanel.Controls.Add(gameBtn);
            }

        }

        private void FilterButtons(string keyword)
        {
            foreach (Control control in ownGameLayoutPanel.Controls)
            {
                if (control is Button button)
                {
                    // Kiểm tra xem tên của button có chứa từ khóa không
                    bool isVisible = button.Text.ToLower().Contains(keyword.ToLower());
                    button.Visible = isVisible;
                }
            }
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                // Lấy tên game từ Button và thay đổi PictureBox tương ứng
                string gameName = clickedButton.Text;
                ChangePictureBoxByGameName(gameName);
            }
            if(installBtn.Visible == false)
            {
                installBtn.Visible = true;
            }
            if(uninstallBtn.Visible == false)
            {
                uninstallBtn.Visible = true;
            }
            if(downloadProcessBar.Visible == false)
            {
                downloadProcessBar.Visible = true;
            }
        }

        private void ChangePictureBoxByGameName(string gameName)
        {
            string bannerPath = "";
            foreach (Game game in gameList)
            {
                if (game.GameName == gameName)
                {
                    bannerPath = game.Picture1;
                    break;
                }

            }
            bannerPictureBox.Image = Image.FromFile(bannerPath);
        }


        #endregion

        #region events
        private void inventoryForm_Load(object sender, EventArgs e)
        {
            searchLabel.Width = ownGameLayoutPanel.Width;
            searchTextBox.Margin = new Padding(10, 0, 10, 0);
            searchTextBox.Width = ownGameLayoutPanel.Width - searchTextBox.Margin.Left - searchTextBox.Margin.Right;
            installBtn.Visible = false;
            uninstallBtn.Visible = false;
            downloadProcessBar.Visible = false;
            LoadGameList();

            //gamesPanel.Controls.Add(new Panel { BackColor = Color.Red, Width = gamesPanel.Width });
            //gamesPanel.Controls.Add(new Panel { BackColor = Color.Blue, Width = gamesPanel.Width });
            //gamesPanel.Controls.Add(new Panel { BackColor = Color.Orange, Width = gamesPanel.Width });
            //gamesPanel.Controls.Add(new Panel { BackColor = Color.Green, Width = gamesPanel.Width });
            //gamesPanel.Controls.Add(new Panel { BackColor = Color.Yellow, Width = gamesPanel.Width });
            //gamesPanel.Height = gamesPanel.Controls.Count * gamesPanel.Controls[0].Height + (gamesPanel.Controls.Count) * gamesPanel.Margin.Vertical;

            //spacePanel.Height = panel1.Height - gamesPanel.Height - panel3.Height - bannerPanel.Height;
            //if (spacePanel.Height < 0)
            //{
            //    spacePanel.Height = 1;
            //}
        }

        private void inventoryForm_Resize(object sender, EventArgs e)
        {
            bannerPictureBox.Height = ownGameLayoutPanel.Height / 2;
        }

        private void inventoryForm_SizeChanged(object sender, EventArgs e)
        {
            //gamesPanel.Height = panel1.Height - panel3.Height - bannerPanel.Height - spacePanel.Height;
            //foreach (Control item in gamesPanel.Controls)
            //{
            //    item.Width = gamesPanel.Width;
            //}

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterButtons(searchTextBox.Text);
        }

        #endregion


    }
}
