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
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EpistWinform.Forms
{
    public partial class libraryForm_Alt_Ver_ : Form
    {
        public event EventHandler<Game> InventoryButtonClicked;
        private List<Game> filteredGames;

        List<Game> gameList = GamesDAO.Instance.LoadGamesList();
        List<Tag> tagList = TagDAO.Instance.LoadTagsList();
        List<GameTags> gameTagsList = GameTagsDAO.Instance.LoadGameTagsList();

        public libraryForm_Alt_Ver_()
        {
            InitializeComponent();  

            LoadGame();
            LoadTag();
        }

        #region Method
        private void LoadGame()
        {
            foreach (Tag tag in tagList)
            {
                FlowLayoutPanel tagFlowLayoutPanel = new FlowLayoutPanel();
                tagFlowLayoutPanel.Dock = DockStyle.Top;
                tagFlowLayoutPanel.WrapContents = false; // Set to true if you want items to wrap to the next row
                tagFlowLayoutPanel.AutoScroll = true;
                tagFlowLayoutPanel.Width = gamesFlowLayoutPanel.Width;
                tagFlowLayoutPanel.Height = 250;
                tagFlowLayoutPanel.BackColor = Color.FromArgb(0, 199, 139);
                tagFlowLayoutPanel.Tag = tag;

                Label tagLabel = new Label();
                tagLabel.Text = tag.TagName.ToString();
                tagLabel.AutoSize = false;
                tagLabel.Width = 250;
                tagLabel.Height = 150;
                tagLabel.TextAlign = ContentAlignment.MiddleCenter;
                tagLabel.Font = new Font("Tahoma", 14);
                tagLabel.ForeColor = Color.White;

                tagFlowLayoutPanel.Controls.Add(tagLabel);


                foreach (GameTags gameTags in gameTagsList)
                {
                    if (tag.TagID == gameTags.TagID)
                    {
                        foreach (Game game in gameList)
                        {
                            if (gameTags.GameID == game.GameID)
                            {
                                Button gameButton = new Button();
                                gameButton.Height = 250;
                                gameButton.Width = gameButton.Height * 2;
                                gameButton.BackgroundImage = Image.FromFile(game.Picture1); // Assuming Picture1 is the path to the image
                                gameButton.BackgroundImageLayout = ImageLayout.Stretch;

                                gameButton.Click += GameButton_Click;
                                gameButton.Tag = game;

                                tagFlowLayoutPanel.Controls.Add(gameButton);
                            }
                        }
                        // Add the tagFlowLayoutPanel to its parent container (assuming tagFlowLayoutPanel has a parent container)
                        gamesFlowLayoutPanel.Controls.Add(tagFlowLayoutPanel);
                    }
                }
            }
        }

        private void GameButton_Click(object? sender, EventArgs e)
        {
            // Access the game details from the Tag property
            Button clickedButton = (Button)sender;
            Game clickedGame = (Game)clickedButton.Tag;

            // Open the GameDetailForm with the clicked game
            //gameInfoForm gameInfoForm = new gameInfoForm(clickedGame);
            //gameInfoForm.ShowDialog(); // Use ShowDialog to make it a modal form
            InventoryButtonClicked?.Invoke(this, clickedGame);
        }

        private void LoadTag()
        {
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

        private void FixGameButtons()
        {
            foreach (Control control in gamesFlowLayoutPanel.Controls)
            {
                if (control is FlowLayoutPanel tagFlowLayoutPanel)
                {
                    int scrollBarHeight = tagFlowLayoutPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0;
                    int scrollBarWidth = gamesFlowLayoutPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0;
                    int buttonHeight = 250;

                    tagFlowLayoutPanel.Height = buttonHeight + 6 + scrollBarHeight;

                    tagFlowLayoutPanel.Width = gamesFlowLayoutPanel.Width + scrollBarWidth;
                }
            }
        }

        private void FixTagButtons()
        {
            foreach (Control control in TagsFlowLayoutPanel.Controls)
            {
                if (control is Button button)
                {
                    if (TagsFlowLayoutPanel.VerticalScroll.Visible == true)
                    {
                        tagLabel.Width = TagsFlowLayoutPanel.Width - button.Margin.Left - button.Margin.Right - SystemInformation.VerticalScrollBarWidth;
                        button.Width = TagsFlowLayoutPanel.Width - button.Margin.Left - button.Margin.Right - SystemInformation.VerticalScrollBarWidth;
                    }
                    else
                    {
                        tagLabel.Width = TagsFlowLayoutPanel.Width - button.Margin.Left - button.Margin.Right;
                        button.Width = TagsFlowLayoutPanel.Width - button.Margin.Left - button.Margin.Right;

                    }
                }
            }
        }

        private void TagButton_Click(object? sender, EventArgs e)
        {
            ResetGamesFlowLayoutPanel();
            FixGameButtons();

            if (sender is Button clickedButton)
            {
                // Find the corresponding tagFlowLayoutPanel
                FlowLayoutPanel targetTagPanel = gamesFlowLayoutPanel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault(panel => panel.Tag is Tag && ((Tag)panel.Tag).TagName == clickedButton.Text);

                // Scroll gamesFlowLayoutPanel to make the targetTagPanel at the top
                if (targetTagPanel != null)
                {
                    gamesFlowLayoutPanel.ScrollControlIntoView(targetTagPanel);
                }
            }

        }

        #endregion

        private void libraryForm_Alt_Ver__Resize(object sender, EventArgs e)
        {
            FixTagButtons();
            FixGameButtons();
        }

        #region Search
        private void searchGameComboBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchGameComboBox.Text.ToLower();

            // Filter the gameList based on the entered text
            filteredGames = gameList.Where(game => game.GameName.ToLower().Contains(searchText)).ToList();

            // Update the gamesFlowLayoutPanel with the filtered games
            UpdateGamesFlowLayoutPanel(filteredGames);
        }

        private void UpdateGamesFlowLayoutPanel(List<Game> games)
        {
            // Clear the current controls in gamesFlowLayoutPanel
            gamesFlowLayoutPanel.Controls.Clear();

            foreach (Game game in games)
            {
                // Create and configure gameButton for each game
                Button gameButton = new Button();
                gameButton.Height = 250;
                gameButton.Width = gameButton.Height * 2;
                gameButton.BackgroundImage = Image.FromFile(game.Picture1); // Assuming Picture1 is the path to the image
                gameButton.BackgroundImageLayout = ImageLayout.Stretch;

                // Attach game details to the Tag property
                gameButton.Tag = game;

                // Handle button click event
                //gameButton.Click += (sender, e) =>
                //{
                //    // Access the game details from the Tag property
                //    Game clickedGame = (Game)gameButton.Tag;

                //    // Handle the button click event, and raise the InventoryButtonClicked event if needed
                //    InventoryButtonClicked?.Invoke(this, EventArgs.Empty);

                //    // You can also use 'clickedGame' to perform additional actions based on the clicked game.
                //};

                gameButton.Click += GameButton_Click;

                // Add the gameButton to gamesFlowLayoutPanel
                gamesFlowLayoutPanel.Controls.Add(gameButton);
            }
        }

        private void ResetGamesFlowLayoutPanel()
        {
            // Clear the current controls in gamesFlowLayoutPanel
            gamesFlowLayoutPanel.Controls.Clear();

            // Re-populate gamesFlowLayoutPanel with the original buttons
            LoadGame();
        }

        private void searchGameComboBox_DropDown(object sender, EventArgs e)
        {
            // Clear existing items
            searchGameComboBox.Items.Clear();

            // If the ComboBox is empty, show all game names
            if (string.IsNullOrWhiteSpace(searchGameComboBox.Text))
            {
                foreach (Game game in gameList)
                {
                    searchGameComboBox.Items.Add(game.GameName);
                }
            }
            else
            {
                // Show filtered game names based on user input
                foreach (Game game in filteredGames)
                {
                    searchGameComboBox.Items.Add(game.GameName);
                }
            }
        }
        #endregion
    }
}