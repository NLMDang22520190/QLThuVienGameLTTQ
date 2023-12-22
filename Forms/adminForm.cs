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
    public partial class adminForm : Form
    {

        int tagButtonWidth;

        List<Game> gameList = GamesDAO.Instance.ListAllGames;
        List<Tag> tagsList = TagDAO.Instance.AllTagsList;
        List<GameTags> gameTagsList = GameTagsDAO.Instance.ListAllGameTags;

        public adminForm()
        {
            InitializeComponent();


            #region Tag
            LoadTags();
            EditPanel.Visible = false;
            tagsComboBox.SelectedItem = 0;
            #endregion

        }

     

































































































































































        // -------------Tag--------------
        #region Tags

        #region Method

        Button tagButton;
        void LoadTags()
        {
            tagsComboBox.DataSource = tagsList;
            tagsComboBox.DisplayMember = "tagName";

            foreach (Tag tag in tagsList)
            {
                tagButton = new Button() { Margin = new Padding(10, 0, 10, 0) };
                tagButton.Width = tagFlowLayoutPanel.Width - tagButton.Margin.Left - tagButton.Margin.Right;
                tagButton.AutoSize = true;
                tagButton.Text = tag.TagName;
                tagButton.TextAlign = ContentAlignment.MiddleCenter;
                tagButton.Font = new Font("Tahoma", 14);
                tagButton.ForeColor = Color.White;
                tagButton.Click += TagButton_Click;

                tagFlowLayoutPanel.Controls.Add(tagButton);
            }

            FixTagButtonSize();
        }

        // Modify the LoadTags method to accept a filter parameter
        void LoadTags(List<Tag> tagsList)
        {
            // Clear existing controls in the tagFlowLayoutPanel
            tagFlowLayoutPanel.Controls.Clear();

            foreach (Tag tag in tagsList)
            {
                tagButton = new Button() { Margin = new Padding(10, 0, 10, 0) };
                tagButton.Width = tagFlowLayoutPanel.Width - tagButton.Margin.Left - tagButton.Margin.Right;
                tagButton.AutoSize = true;
                tagButton.Text = tag.TagName;
                tagButton.TextAlign = ContentAlignment.MiddleCenter;
                tagButton.Font = new Font("Tahoma", 14);
                tagButton.ForeColor = Color.White;
                tagButton.Click += TagButton_Click;

                tagFlowLayoutPanel.Controls.Add(tagButton);
            }

            FixTagButtonSize();
        }



        // Modify LoadGamesWithTag to use LINQ for better readability
        int actualGamesFlowLayoutPanelSize;

        void LoadGamesWithTag(Tag tag)
        {
            // Clear existing controls in the gamesFlowLayoutPanel
            gamesFlowLayoutPanel.Controls.Clear();

            actualGamesFlowLayoutPanelSize = gamesFlowLayoutPanel.VerticalScroll.Visible ? gamesFlowLayoutPanel.Width - SystemInformation.VerticalScrollBarWidth : gamesFlowLayoutPanel.Width;

            var gamesWithTag = from gameTag in gameTagsList
                               join game in gameList on gameTag.GameID equals game.GameID
                               where gameTag.TagID == tag.TagID
                               select game;

            foreach (Game game in gamesWithTag)
            {
                Button gameButton = new Button();
                gameButton.Text = game.GameName;

                gameButton.AutoSize = true;
                gameButton.Width = (gamesFlowLayoutPanel.Width - 18) / 3;

                gamesFlowLayoutPanel.Controls.Add(gameButton);
            }
        }

        void FixTagButtonSize()
        {

            foreach (Control control in tagFlowLayoutPanel.Controls)
            {
                if (control is Button button)
                {
                    tagButtonWidth = tagFlowLayoutPanel.Width - button.Margin.Left - button.Margin.Right;
                    button.Width = tagFlowLayoutPanel.VerticalScroll.Visible ? tagButtonWidth - SystemInformation.VerticalScrollBarWidth : tagButtonWidth;

                }
            }
        }

        #endregion


        #region Event
        private void addTagButton_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;

            // Display a MessageBox with an input box
            string tagName = Microsoft.VisualBasic.Interaction.InputBox("Enter your text:", "Tag Name", "");
            string tagDescription = Microsoft.VisualBasic.Interaction.InputBox("Enter tag description:", "Tag Description", "");
            int tagID;

            if (!string.IsNullOrEmpty(tagName))
            {
                tagID = tagsList.Count() + 1;
                if (TagDAO.Instance.AddTag(tagID, tagName, tagDescription))
                {
                    MessageBox.Show("Add tag successfully!!!");
                    tagsList = TagDAO.Instance.LoadTagsList();
                    LoadTags();
                }
                else
                {
                    MessageBox.Show("Add tag failed...");
                }
            }
        }

        private void removeTagButton_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;

        }

        private void editTagButton_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = true;

        }
        private void allTagsButton_Click(object sender, EventArgs e)
        {
            tagFlowLayoutPanel.Controls.Clear();
            LoadTags();
            gamesFlowLayoutPanel.Controls.Clear();
        }

        private void TagButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button tagButton)
            {
                // Get the Tag object associated with the clicked button
                Tag selectedTag = tagsList.FirstOrDefault(tag => tag.TagName == tagButton.Text);

                if (selectedTag != null)
                {
                    // Load games associated with the selected tag
                    LoadGamesWithTag(selectedTag);

                    if (EditPanel.Visible)
                    {
                        // Bind the selected tag to the text boxes
                        tagNameTextBox.DataBindings.Clear();
                        tagNameTextBox.DataBindings.Add("Text", selectedTag, "TagName");

                        tagDescriptionTextBox.DataBindings.Clear();
                        tagDescriptionTextBox.DataBindings.Add("Text", selectedTag, "TagDescription");
                    }

                }
            }
        }

        private List<Tag> filteredTags;
        private void tagsComboBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = tagsComboBox.Text.ToLower();

            // Filter the gameList based on the entered text
            filteredTags = tagsList.Where(game => game.TagName.ToLower().Contains(searchText)).ToList();

            // Update the gamesFlowLayoutPanel with the filtered games
            LoadTags(filteredTags);
        }

        private void editGameTagButton_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
        }


        #endregion
        #endregion
    
    }
}
