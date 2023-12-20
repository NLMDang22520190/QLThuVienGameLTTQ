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
    public partial class gameInfoForm : Form
    {
        int verticalScrollWidth;

        private Game game;
        // Declare an event
        public event EventHandler InventoryButtonClicked;

        // Trigger the event when the inventory button is clicked
        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public gameInfoForm(Game game)
        {
            InitializeComponent();

            this.game = game;
            InitializeGameDetails(game);
        }

        private void AddToInventoryButton_Click(object sender, EventArgs e)
        {
            // Handle add to inventory button click
            // You can add the game to the user's inventory here
        }

        private void MoreInfoButton_Click(object sender, EventArgs e)
        {
            // Handle more info button click
            // You can provide additional information or actions here
        }

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
                gameDetailLabel.AutoSize = true;
                gameDetailLabel.Text = game.GameInfo.ToString();

                gameInfoFlowLayoutPanel.Controls.Add(gameDetailLabel);
            }
            else MessageBox.Show("game is null");
        }

        private void gameInfoForm_SizeChanged(object sender, EventArgs e)
        {
            FixMainPanelSize();
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
    }
}
