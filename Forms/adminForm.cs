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
        int baseWidth = 1007;
        int minimumControlWidth = 1007;
        public adminForm()
        {
            InitializeComponent();
            LoadGame();

            AddGameBinding();
            SetReadOnly();
        }

        #region Method

        void LoadGame()
        {
            List<Game> gameList = GamesDAO.Instance.ListAllGames;
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
            //FixControl();
        }

        #endregion

        #region SetReadOnly

        void SetReadOnly()
        {
            //foreach (Control control in mainControl.Controls)
            //{
            //    if (control is TextBox textBox)
            //    {
            //        textBox.ReadOnly = true;
            //    }
            //}


            gameNameTextBox.ReadOnly = true;
            gameNameTextBox.TabStop = false;

            //DescriptionTextBox.ReadOnly = true;
        }

        #endregion


    }
}
