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
        int baseSize = 1007;
        public adminForm()
        {
            InitializeComponent();
            LoadGame();

            AddGameBinding();
        }

        #region Method

        void LoadGame()
        {
            List<Game> gameList = GamesDAO.Instance.LoadGamesList();
            gameComboBox.DataSource = gameList;
            gameComboBox.DisplayMember = "gameName";
            gameDataGridView.DataSource = gameList;


        }

        void AddGameBinding()
        {
            gameNameTextBox.DataBindings.Add(new Binding("Text", gameDataGridView.DataSource, "GameName"));
            DescriptionTextBox.DataBindings.Add(new Binding("Text", gameDataGridView.DataSource, "GameInfo"));

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
            FixControl();
        }

        #endregion

        #region FixUI

        void FixControl()
        {
            int sizeMultiplier = this.Width / baseSize;
            foreach (Control control in this.Controls)
            {
                control.Width = (int)control.Width * sizeMultiplier;
            }
        }
        #endregion


    }
}
