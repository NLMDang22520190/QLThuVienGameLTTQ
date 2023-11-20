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
        private Account currentUserAccount;
        public inventoryForm(Account currentUserAccount)
        {
            InitializeComponent();
            this.currentUserAccount = currentUserAccount;

        }
        #region method
        private void LoadGameList()
        {
            gameList = GamesDAO.Instance.LoadOwnGamesList(currentUserAccount.UserID);
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
            if (installBtn.Visible == false)
            {
                installBtn.Visible = true;
            }
            if (uninstallBtn.Visible == false)
            {
                uninstallBtn.Visible = true;
            }
            if (downloadProcessBar.Visible == false)
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

        private void ChangeInstallBtnStyleToInstall()
        {
            this.installBtn.ForeColor = Color.DodgerBlue;
            this.installBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.installBtn.IconColor = Color.DodgerBlue;
            //this.installBtn.Text = "Install";
        }
        private void ChangeInstallBtnStyleToPlay()
        {
            this.installBtn.ForeColor = Color.LimeGreen;
            this.installBtn.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.installBtn.IconColor = Color.LimeGreen;
            //this.installBtn.Text = "Install";
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
            if(installBtn.Text == "Install") 
                ChangeInstallBtnStyleToInstall();
            else
                ChangeInstallBtnStyleToPlay();
            LoadGameList();

            
        }

        private void inventoryForm_Resize(object sender, EventArgs e)
        {
            bannerPictureBox.Height = ownGameLayoutPanel.Height / 2;
        }

        private void inventoryForm_SizeChanged(object sender, EventArgs e)
        {
            

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterButtons(searchTextBox.Text);
        }

        #endregion


    }
}
