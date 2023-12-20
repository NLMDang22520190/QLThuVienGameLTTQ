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

namespace EpistWinform.Forms
{
    public partial class adminForm : Form
    {
        int descriptionTextBoxHeight;


        public adminForm()
        {
            InitializeComponent();

            descriptionTextBoxHeight = descriptionTextBox.Height;

            LoadGame();
            AddGameBinding();
            SetReadOnly();
            //ChangeDataGridViewSize();

        }

        #region Method

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

        }

        #endregion


        #region Event
        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void adminForm_Resize(object sender, EventArgs e)
        {
           ChangeDataGridViewSize();

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

        #endregion


        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

            //descriptionTextBox.Height = descriptionTextBox.GetLineFromCharIndex(int.MaxValue) * descriptionTextBoxHeight;
            //MessageBox.Show(descriptionTextBox.GetLineFromCharIndex(int.MaxValue).ToString());
        }

        void ChangeDataGridViewSize()
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
            ad
        }
    }
}
