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

        List<Game> gameList = GamesDAO.Instance.ListAllGames;
        List<Tag> tagsList = TagDAO.Instance.AllTagsList;
        List<GameTags> gameTagsList = GameTagsDAO.Instance.ListAllGameTags;
        List<Account> accountList = AccountDAO.Instance.ListAllAccounts;

        public adminForm()
        {
            InitializeComponent();
            LoadGameTab();

            #region User/Account
            LoadAccount();
            confirmButton.Visible = false;
            searchUserComboBox.SelectedItem = 0;
            SetUserInfoEnable(false);
            userInfoDataGridView.Enabled = false;

            #endregion

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

        #endregion

        private void adminForm_Resize(object sender, EventArgs e)
        {
            ChangeGameDataGridViewSize();
        }

        // ------------- User / Account --------------

        #region User

        #region Method

        #region Load

        void LoadAccount()
        {
            searchUserComboBox.DataSource = accountList;
            searchUserComboBox.DisplayMember = "Username";

            List<string> columnNames = new List<string> { "UserID", "UserName", "DisplayName", "Gmail" };
            searchUserByColumnComboBox.DataSource = columnNames;
            searchUserByColumnComboBox.DisplayMember = "UserName";

            userInfoDataGridView.DataSource = accountList;
            userInfoDataGridView.ReadOnly = true;
            AddAccountBinding();
            FixUserPanels();
        }

        string SetSearchUserByColumn()
        {
            // Check if an item is selected in the searchUserByColumnComboBox
            if (searchUserByColumnComboBox.SelectedItem != null)
            {
                // Retrieve the selected column name
                string column = searchUserByColumnComboBox.SelectedItem.ToString();
                return column;
            }
            else
            {
                // Handle the case where no item is selected (return a default column name or handle accordingly)
                return "DefaultColumnName"; // Change this to the default column name or handle as needed
            }
        }


        void SetUserInfoTextBoxToNull()
        {
            foreach (Control control in userInfoFlowLayoutPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        void SetUserInfoEnable(bool enable)
        {
            foreach (Control control in userInfoFlowLayoutPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = enable;
                }
            }
            adminCheckBox.Enabled = enable;
        }

        void AddAccountBinding()
        {
            // Clear existing bindings
            userIDTextBox.DataBindings.Clear();
            usernameTextBox.DataBindings.Clear();
            passwordTextBox.DataBindings.Clear();
            displayNameTextBox.DataBindings.Clear();
            gmailTextBox.DataBindings.Clear();
            adminCheckBox.DataBindings.Clear();

            // Add new bindings
            userIDTextBox.DataBindings.Add(new Binding("Text", userInfoDataGridView.DataSource, "UserID", true, DataSourceUpdateMode.Never));
            usernameTextBox.DataBindings.Add(new Binding("Text", userInfoDataGridView.DataSource, "Username", true, DataSourceUpdateMode.Never));
            passwordTextBox.DataBindings.Add(new Binding("Text", userInfoDataGridView.DataSource, "Password", true, DataSourceUpdateMode.Never));
            displayNameTextBox.DataBindings.Add(new Binding("Text", userInfoDataGridView.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            gmailTextBox.DataBindings.Add(new Binding("Text", userInfoDataGridView.DataSource, "Gmail", true, DataSourceUpdateMode.Never));

            Binding adminBinding = new Binding("Checked", userInfoDataGridView.DataSource, "isAdmin", true, DataSourceUpdateMode.Never);
            adminBinding.Format += (s, e) => e.Value = ((int)e.Value) == 1; // Convert int to bool
            adminCheckBox.DataBindings.Add(adminBinding);
        }

        #endregion

        void FixUserPanels()
        {

            foreach (Control control in userInfoFlowLayoutPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Width = userInfoFlowLayoutPanel.VerticalScroll.Visible ? userInfoFlowLayoutPanel.Width - SystemInformation.VerticalScrollBarWidth : userInfoFlowLayoutPanel.Width;
                }
            }
        }

        void FixUserDataGridView()
        {
            if (userInfoDataGridView.ColumnCount > 0)
            {
                for (int i = 0; i < userInfoDataGridView.ColumnCount; i++)
                {
                    userInfoDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    if (i == userInfoDataGridView.ColumnCount - 1)
                    {
                        userInfoDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }

                userInfoDataGridView.AutoResizeColumnHeadersHeight();
                userInfoDataGridView.AutoResizeRows();

            }
        }

        #region Tools

        int userToolsIndex;
        string username, password, displayName, gmail;
        int userID, isAdmin;

        void GetUserInfo()
        {
            // Check if userIDTextBox.Text can be parsed to an integer
            if (int.TryParse(userIDTextBox.Text, out int parsedUserID))
            {
                userID = parsedUserID;
            }
            else
            {
                // Handle the case where the input is not a valid integer
                // You may show an error message or take appropriate action
                MessageBox.Show("Invalid UserID. Please enter a valid integer.");
                return; // Exit the method
            }

            username = usernameTextBox.Text;
            password = passwordTextBox.Text;
            displayName = displayNameTextBox.Text;
            gmail = gmailTextBox.Text;

            if (adminCheckBox.CheckState == CheckState.Checked)
            {
                isAdmin = 1;
            }
            else
            {
                isAdmin = 0;
            }
        }


        #region Check ID
        bool IsUserIDInt(out int parsedUserID)
        {
            if (int.TryParse(userIDTextBox.Text, out parsedUserID))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid UserID. Please enter a valid integer.");
                return false;
            }
        }

        bool IsUserIDUnique(int userID)
        {
            return !accountList.Any(account => account.UserID == userID);
        }


        bool IsUserIDValidForAdd(int userID)
        {
            return IsUserIDInt(out _) && IsUserIDUnique(userID);
        }

        bool IsUserIDValidForRemove(int userID)
        {
            return true; // No specific conditions for removal
        }

        bool IsUserIDValidForEdit(int userID)
        {
            return IsUserIDInt(out _);
        }

        #endregion


        void AddUser()
        {
            GetUserInfo();
            if (AccountDAO.Instance.Add(userID, username, password, displayName, gmail, isAdmin))
            {
                MessageBox.Show("Add user successfully.");
                accountList = AccountDAO.Instance.LoadAccountList();
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        void RemoveUser()
        {
            GetUserInfo();
            if (!AccountDAO.Instance.RemoveAllGameFromUser(userID))
            {
                MessageBox.Show("Error: Remove games from user");
            }
            if (AccountDAO.Instance.Remove(userID))
            {
                MessageBox.Show("Remove user successfully.");
                accountList = AccountDAO.Instance.LoadAccountList();
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        void EditUser()
        {
            GetUserInfo();
            if (AccountDAO.Instance.Edit(userID, username, password, displayName, gmail, isAdmin))
            {
                MessageBox.Show("Edit user successfully.");
                accountList = AccountDAO.Instance.LoadAccountList();
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        void ViewUser()
        {

        }

        #endregion

        #endregion

        #region Event

        private void searchUserByColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchUserComboBox.DisplayMember = SetSearchUserByColumn();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            userToolsIndex = 0;
            confirmButton.Text = "ADD USER";
            confirmButton.Visible = true;
            userInfoDataGridView.Enabled = false;

            SetUserInfoTextBoxToNull();
            SetUserInfoEnable(true);
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            userToolsIndex = 1;
            confirmButton.Text = "REMOVE USER";
            confirmButton.Visible = true;
            userInfoDataGridView.Enabled = true;

            SetUserInfoTextBoxToNull();
            SetUserInfoEnable(false);
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            userToolsIndex = 2;
            confirmButton.Text = "EDIT USER";
            confirmButton.Visible = true;
            userInfoDataGridView.Enabled = true;

            SetUserInfoTextBoxToNull();
            SetUserInfoEnable(true);

            userIDTextBox.Enabled = false;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            userToolsIndex = 3;
            confirmButton.Visible = false;
            userInfoDataGridView.Enabled = true;

            SetUserInfoTextBoxToNull();
            SetUserInfoEnable(false);

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int parsedUserID;

            if (!IsUserIDInt(out parsedUserID))
            {
                return; // Exit if parsing failed
            }

            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (userToolsIndex)
            {
                case 0: // AddUser
                    if (IsUserIDValidForAdd(parsedUserID) && result == DialogResult.Yes)
                    {
                        AddUser();
                    }
                    break;
                case 1: // RemoveUser
                    if (IsUserIDValidForRemove(parsedUserID) && result == DialogResult.Yes)
                    {
                        RemoveUser();
                    }
                    break;
                case 2: // EditUser
                    if (IsUserIDValidForEdit(parsedUserID) && result == DialogResult.Yes)
                    {
                        EditUser();
                    }
                    break;
                case 3: // ViewUser
                    if (result == DialogResult.Yes)
                    {
                        ViewUser();
                    }
                    break;
                default:
                    break;
            }
        }

        private void searchUserComboBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchUserComboBox.Text.ToLower();

            string selectedColumnName = SetSearchUserByColumn();

            // Filter the accountList based on the selected column and entered text
            List<Account> filteredAccounts = accountList
                .Where(account =>
                {
                    object propertyValue = GetPropertyValue(account, selectedColumnName);
                    return propertyValue != null && propertyValue.ToString().ToLower().Contains(searchText);
                })
                .ToList();

            // Use BeginInvoke only if the form's handle has been created
            if (IsHandleCreated)
            {
                BeginInvoke(new Action(() =>
                {
                    // Update the userInfoDataGridView with the filtered accounts
                    userInfoDataGridView.DataSource = filteredAccounts;

                    // Reset the bindings to update the TextBoxes
                    AddAccountBinding();
                }));
            }
            else
            {
                // Update the userInfoDataGridView directly if the handle is not created yet
                userInfoDataGridView.DataSource = filteredAccounts;

                // Reset the bindings to update the TextBoxes
                AddAccountBinding();
            }
        }




        // Helper method to get the value of a property dynamically
        private object GetPropertyValue(object obj, string propertyName)
        {
            var prop = obj.GetType().GetProperty(propertyName);
            return prop != null ? prop.GetValue(obj) : null;
        }


        #endregion
        #endregion








    }
}
