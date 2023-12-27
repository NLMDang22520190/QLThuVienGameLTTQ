using EpistWinform.DAO;
using EpistWinform.DTO;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class gameInfoForm : Form
    {
        int verticalScrollWidth;

        private Game game;
        private Account account;
        private inventoryForm inventoryForm;

        // Declare an event
        public event EventHandler InventoryButtonClicked;

        // Trigger the event when the inventory button is clicked
        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public gameInfoForm(Game game, Account account)
        {
            InitializeComponent();

            this.game = game;
            this.account = account;
            InitializeGameDetails(game);
        }


        #region Method

        private void InitializeGameDetails(Game game)
        {
            gameNameLabel.Text = game.GameName;

            if (game != null)
            {
                List<PictureBox> gamePictureBoxes = new List<PictureBox>();

                for (int i = 0; i < 3; i++)
                {
                    verticalScrollWidth = gameInfoFlowLayoutPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0;
                    gamePictureBoxes.Add(new PictureBox());
                    gamePictureBoxes[i].Width = gameInfoFlowLayoutPanel.Width - verticalScrollWidth;
                    gamePictureBoxes[i].Height = gamePictureBoxes[i].Width / 2;
                    gamePictureBoxes[i].BackgroundImageLayout = ImageLayout.Stretch;
                    gameInfoFlowLayoutPanel.Controls.Add(gamePictureBoxes[i]);
                }

                gamePictureBoxes[0].BackgroundImage = Image.FromFile(game.Picture1);
                gamePictureBoxes[1].BackgroundImage = Image.FromFile(game.Picture2);
                gamePictureBoxes[2].BackgroundImage = Image.FromFile(game.Picture3);

                Label gameDetailLabel = new Label();
                verticalScrollWidth = gameInfoFlowLayoutPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0;
                gameDetailLabel.Width = gameInfoFlowLayoutPanel.Width - verticalScrollWidth;
                gameDetailLabel.Font = new Font(gameDetailLabel.Font.FontFamily, 14);
                gameDetailLabel.AutoSize = true;
                gameDetailLabel.Text = game.GameInfo.ToString();

                gameInfoFlowLayoutPanel.Controls.Add(gameDetailLabel);

                // Check if the game is already in the user's inventory
                bool isInInventory = GamesDAO.Instance.IsGameInOwnedGames(game.GameID, account.UserID);

                // Clear existing event handlers
                addGameButton.Click -= OpenInventoryButton_Click;
                addGameButton.Click -= AddToInventoryButton_Click;

                if (isInInventory)
                {
                    // If the game is in the inventory, change button text and functionality
                    addGameButton.Text = "OPEN INVENTORY";
                    addGameButton.Click += OpenInventoryButton_Click;
                }
                else
                {
                    // If the game is not in the inventory, keep the default button text and functionality
                    addGameButton.Text = "ADD GAME";
                    addGameButton.Click += AddToInventoryButton_Click;
                }
            }
            else
            {
                MessageBox.Show("game is null");
            }
        }



        private void FixMainPanelSize()
        {
            foreach (Control control in gameInfoFlowLayoutPanel.Controls)
            {
                if (control is PictureBox gamePictureBox)
                {
                    verticalScrollWidth = gameInfoFlowLayoutPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0;
                    gamePictureBox.Width = gameInfoFlowLayoutPanel.Width - verticalScrollWidth;
                    gamePictureBox.Height = gamePictureBox.Width / 2;
                    gameInfoFlowLayoutPanel.HorizontalScroll.Visible = false;
                }
            }
        }

        #endregion


        #region Event

        private void AddToInventoryButton_Click(object sender, EventArgs e)
        {
            // Handle add to inventory button click
            // You can add the game to the user's inventory here
            if (GamesDAO.Instance.InsertGameToOwnedGames(game.GameID, account.UserID))
            {
                MessageBox.Show("Game was added into your Inventory.");
                addGameButton.Click -= AddToInventoryButton_Click;
                addGameButton.Text = "OPEN INVENTORY";
                addGameButton.Click += OpenInventoryButton_Click;
            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        public event EventHandler OpenInventoryClicked;
        private void OpenInventoryButton_Click(object sender, EventArgs e)
        {
            // Assuming inventoryForm is an instance variable of gameInfoForm
            inventoryForm = new inventoryForm(account);

            // Trigger the event to notify MainWindowForm about the button click
            OpenInventoryClicked?.Invoke(this, EventArgs.Empty);

            // Close the current gameInfoForm when opening the inventoryForm
            this.Close();
        }

        private void gameInfoForm_SizeChanged(object sender, EventArgs e)
        {
            FixMainPanelSize();
        }

        #endregion
    }
}
