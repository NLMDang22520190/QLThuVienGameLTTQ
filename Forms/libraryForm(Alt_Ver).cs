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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EpistWinform.Forms
{
    public partial class libraryForm_Alt_Ver_ : Form
    {
        public event EventHandler InventoryButtonClicked;

        public libraryForm_Alt_Ver_()
        {
            InitializeComponent();

            LoadGame();
            LoadTag();
        }

        #region Method
        private void LoadGame()
        {
            List<Game> gameList = GamesDAO.Instance.LoadGamesList();

            foreach (Game game in gameList)
            {
                Button gameButton = new Button();
                {
                    gameButton.Width = (gamesFlowLayoutPanel.Width - SystemInformation.VerticalScrollBarWidth) / 2;
                    gameButton.Height = gameButton.Width / 2;
                }

                gameButton.BackgroundImage = Image.FromFile(game.Picture1); // Assuming Picture1 is the path to the image
                gameButton.BackgroundImageLayout = ImageLayout.Stretch;

                gameButton.Click += (sender, e) =>
                {
                    // Handle button click event, and raise the InventoryButtonClicked event if needed
                    InventoryButtonClicked?.Invoke(this, EventArgs.Empty);
                };

                gamesFlowLayoutPanel.Controls.Add(gameButton);
            }
        }

        private void LoadTag()
        {
            List<Tag> tagList = TagDAO.Instance.LoadTagsList();

            foreach (Tag tag in tagList)
            {
                Button tagButton = new Button() { Margin = new Padding(10, 0, 10, 0) };
                tagButton.Width = TagsFlowLayoutPanel.Width - tagButton.Margin.Left - tagButton.Margin.Right - SystemInformation.VerticalScrollBarWidth;
                tagButton.AutoSize = true;
                tagButton.Text = tag.TagName;
                tagButton.TextAlign = ContentAlignment.MiddleCenter;
                tagButton.Font = new Font("Tahoma", 14);
                tagButton.ForeColor = Color.White;
                tagButton.Click += TagButton_Click; 

                TagsFlowLayoutPanel.Controls.Add(tagButton);
            }
        }

        //private void FixGameButtons()
        //{
        //    foreach (Control control in gamesFlowLayoutPanel.Controls)
        //    {
        //        if (control is Button button)
        //        {
        //            if (gamesFlowLayoutPanel.VerticalScroll.Visible == true)
        //            {
        //                button.Width = (gamesFlowLayoutPanel.Width - SystemInformation.VerticalScrollBarWidth) / 120 * 39;
        //                button.Height = button.Width / 2;
        //            }
        //            else
        //            {
        //                button.Width = gamesFlowLayoutPanel.Width / 120 * 39;
        //                button.Height = button.Width / 2;
        //            }
        //        }
        //    }
        //}

        private void FixTagButtons()
        {
            foreach (Control control in TagsFlowLayoutPanel.Controls)
            {
                if (control is Button button)
                {
                    if (TagsFlowLayoutPanel.VerticalScroll.Visible == true)
                    {
                        button.Width = TagsFlowLayoutPanel.Width - button.Margin.Left - button.Margin.Right - SystemInformation.VerticalScrollBarWidth;
                    }
                    else
                    {
                        button.Width = TagsFlowLayoutPanel.Width - button.Margin.Left - button.Margin.Right;

                    }
                }
            }
        }

        private void TagButton_Click(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private void libraryForm_Alt_Ver__Resize(object sender, EventArgs e)
        {
            FixTagButtons();
            //FixGameButtons();
        }
    }
}