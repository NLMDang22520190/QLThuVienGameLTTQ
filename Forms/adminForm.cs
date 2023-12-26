using EpistWinform.DAO;
using EpistWinform.DTO;
using EpistWinform.Properties;
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
    public partial class adminForm : Form
    {
        private string currentAddedGameFilePath;
        private List<int> currentAddGameTagsList = new List<int>();
        private bool isEditing = false;
        public adminForm()
        {
            InitializeComponent();
            LoadGameTab();
        }

        #region GameTab
        #region Method

        void LoadGameTab()
        {
            LoadGame();
            AddGameBinding();
            SetReadOnly();
            editPanel.Visible = false;
            gameDataGridView.SelectionChanged += gameDataGridView_SelectionChanged;
      
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

        void ChangeCurrentGameAddedPath(object sender, string currentGameAddedPath)
        {
            currentAddedGameFilePath = currentGameAddedPath;
        }

        void ChangeCurrentGameAddedTagsList(object sender, List<int> selectedTagsList)
        {
            currentAddGameTagsList = selectedTagsList;
        }

        #endregion


        #region Event
        private void addButton_Click(object sender, EventArgs e)
        {
            Game newGame = new Game(gameDataGridView.Rows.Count + 1);
            newGame.Picture1 = $".\\Resource\\GamesPicture\\{newGame.GameID}\\Picture1.jpg";
            newGame.Picture2 = $".\\Resource\\GamesPicture\\{newGame.GameID}\\Picture2.jpg";
            newGame.Picture3 = $".\\Resource\\GamesPicture\\{newGame.GameID}\\Picture3.jpg";


            AddGameForm form = new AddGameForm(ref newGame);
            form.currentAddedGameChanged += ChangeCurrentGameAddedPath;
            form.currentAddedGameTagsListChanged += ChangeCurrentGameAddedTagsList;
            form.FormBorderStyle = FormBorderStyle.None;
            form.ShowDialog();

            if (!string.IsNullOrEmpty(newGame.GameName))
            {
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
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SetEditPanelEnable(true);
        }


        #endregion

        #region SetReadOnly

        void SetReadOnly()
        {

            gameNameTextBox.ReadOnly = true;
            gameNameTextBox.Enabled = false;

            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.Enabled = false;
        }

        void SetEditPanelEnable(bool enable)
        {
            isEditing = enable;
            editPanel.Visible = enable;
            addButton.Enabled = !enable;
            gameDataGridView.Enabled = !enable;
            SetGameNameAndDecPanelEnable(!enable);
        }

        void SetGameNameAndDecPanelEnable(bool enable)
        {
            gameNameTextBox.ReadOnly = enable;
            gameNameTextBox.Enabled = !enable;

            descriptionTextBox.ReadOnly = enable;
            descriptionTextBox.Enabled = !enable;
        }


        private void gameDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Prevent selecting another game while editing
                gameDataGridView.ClearSelection();
            }
        }

        #endregion


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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update the current information?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                // Get the selected game
                Game selectedGame = (Game)gameDataGridView.CurrentRow.DataBoundItem;

                // Perform the update in the database
                bool isUpdated = GamesDAO.Instance.EditGame(selectedGame.GameID, gameNameTextBox.Text, descriptionTextBox.Text);

                if (isUpdated)
                {
                    MessageBox.Show("Information has been updated. Changes will take effect after restarting the app.", "Success");
                    SetEditPanelEnable(false);
                }
                else
                {
                    MessageBox.Show("Failed to update information.", "Error");
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            SetEditPanelEnable(false);
        }


    }
}
