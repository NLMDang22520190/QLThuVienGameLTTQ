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
            LoadGameTab();

            #region Tag
            LoadTags();
            EditPanel.Visible = false;
            tagsComboBox.SelectedItem = 0;
            #endregion

        }

        #region GameTab
        #region Method

        void LoadGameTab()
        {
            LoadGame();
            AddGameBinding();
            SetReadOnly();
        }
        void LoadGame()
        {
            List<Game> gameList = GamesDAO.Instance.ListAllGames;
            gameComboBox.DataSource = gameList;
            gameComboBox.DisplayMember = "gameName";
            gameDataGridView.DataSource = gameList;
            gameDataGridView.ReadOnly = true;
        }

        void AddGameBinding()
        {
            gameNameTextBox.DataBindings.Add(new Binding("Text", gameDataGridView.DataSource, "GameName"));
            descriptionTextBox.DataBindings.Add(new Binding("Text", gameDataGridView.DataSource, "GameInfo"));
            gamePictureBox1.DataBindings.Add(new Binding("ImageLocation", gameDataGridView.DataSource, "Picture1"));
            gamePictureBox2.DataBindings.Add(new Binding("ImageLocation", gameDataGridView.DataSource, "Picture2"));
            gamePictureBox3.DataBindings.Add(new Binding("ImageLocation", gameDataGridView.DataSource, "Picture3"));
        }

        void

        #endregion


        #region Event
        private void addButton_Click(object sender, EventArgs e)
        {
            Game newGame = new Game(gameDataGridView.Rows.Count + 1);
            string filePath = "";
            AddGameForm form = new AddGameForm(ref newGame, ref filePath);
            form.currentAddedGameChanged +=
            form.ShowDialog();
            MessageBox.Show(newGame.GameName + " " + newGame.GameInfo + " " + filePath);
            SetEnable(true);
            // Tạo một đối tượng Game mới

            // Thêm đối tượng mới vào danh sách và DataGridView
            List<Game> gameList = (List<Game>)gameDataGridView.DataSource;
            gameList.Add(newGame);
            gameDataGridView.DataSource = null;
            gameDataGridView.DataSource = gameList;

            // Tự động chọn dòng mới được thêm
            int rowIndex = gameDataGridView.Rows.Count - 1;
            gameDataGridView.CurrentCell = gameDataGridView.Rows[rowIndex].Cells[0];

            // Thực hiện binding để hiển thị thông tin của đối tượng mới
            gameNameTextBox.DataBindings[0].ReadValue();
            descriptionTextBox.DataBindings[0].ReadValue();
            ChangeGameDataGridViewSize();

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region SetReadOnly

        void SetReadOnly()
        {

            gameNameTextBox.ReadOnly = true;
            gameNameTextBox.Enabled = false;

            descriptionTextBox.ReadOnly = true;
            //descriptionTextBox.AutoSize = false;
            //descriptionTextBox.WordWrap = true;
            //descriptionTextBox.Multiline = true;
            descriptionTextBox.Enabled = false;
        }

        void SetEnable(bool enable)
        {
            gameNameTextBox.ReadOnly = !enable;
            descriptionTextBox.ReadOnly = !enable;

            gameNameTextBox.Enabled = enable;
            descriptionTextBox.Enabled = enable;

        }

        #endregion


        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

            //descriptionTextBox.Height = descriptionTextBox.GetLineFromCharIndex(int.MaxValue) * descriptionTextBoxHeight;
            //MessageBox.Show(descriptionTextBox.GetLineFromCharIndex(int.MaxValue).ToString());
        }

        void ChangeGameDataGridViewSize()
        {
            if (gameDataGridView.ColumnCount > 0)
            {
                for (int i = 0; i < gameDataGridView.ColumnCount; i++)
                {
                    if (i == 2)
                        continue;
                    gameDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            gameDataGridView.AutoResizeColumnHeadersHeight();
            gameDataGridView.AutoResizeRows();
        }
        #endregion

        private void adminForm_Resize(object sender, EventArgs e)
        {
            ChangeGameDataGridViewSize();
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
