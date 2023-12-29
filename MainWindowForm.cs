using EpistWinform.DAO;
using EpistWinform.DTO;
using EpistWinform.Forms;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace EpistWinform
{

    public partial class MainWindowForm : Form
    {
        #region privateProperty
        private IconButton currentBtn;
        private Panel downBorderBtn;
        private Color pressColor;
        private Form currentChildForm;
        private FormWindowState lastWindowState = FormWindowState.Normal;
        private libraryForm_Alt_Ver_ libraryForm;
        private gameInfoForm gameInfoForm;
        private inventoryForm inventoryForm;
        private userForm userForm;
        private adminForm adminForm;
        private Account currentUserAccount;
        private List<Game> listAllGames = GamesDAO.Instance.ListAllGames;
        private loginForm parentForm;
        #endregion

        #region other
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        public MainWindowForm(Account currentUserAccount, loginForm parentForm)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            downBorderBtn = new Panel();
            navigationPanel.Controls.Add(downBorderBtn);
            pressColor = Color.LightPink;

            libraryForm = new libraryForm_Alt_Ver_(currentUserAccount);
            inventoryForm = new inventoryForm(currentUserAccount);

            userForm = new userForm(currentUserAccount);
            adminForm = new adminForm();
            this.currentUserAccount = currentUserAccount;
            this.parentForm = parentForm;

            if(currentUserAccount.IsAdmin == 0)
                adminBtn.Visible = false;
            else
                adminBtn.Visible = true;

            userBtn.Text = currentUserAccount.DisplayName;


            this.DoubleBuffered = true;
            //MessageBox.Show(currentUserAccount.UserID.ToString() + " " + currentUserAccount.UserName.ToString());
        }

        #region privateMethods
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Visible = false;
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            changeFormPanel.Controls.Add(childForm);
            changeFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;

                downBorderBtn.BackColor = color;
                downBorderBtn.Location = new Point(currentBtn.Location.X, this.navigationPanel.Location.Y);
                downBorderBtn.Visible = true;
                downBorderBtn.Size = new Size(currentBtn.Width, 7);
                downBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
            }
        }

        private void LibraryForm_InventoryButtonClicked(object sender, Game currentGame)
        {
            gameInfoForm gameInfoForm = new gameInfoForm(currentGame, currentUserAccount);
            gameInfoForm.OpenInventoryClicked += GameInfoForm_OpenInventoryClicked;
            OpenChildForm(gameInfoForm);


            // Mở inventoryForm trong changeFormPanel
            //OpenChildForm(inventoryForm);

            // Hoặc thực hiện các hành động khác tùy thuộc vào yêu cầu của bạn
        }

        private void CheckAndDownloadImagesForGames(List<Game> games)
        {
            foreach (Game game in games)
            {
                string gameFolderPath = $".\\Resource\\GamesPicture\\{game.GameID}";

                // Check if the folder for the game exists, if not, create it
                if (!System.IO.Directory.Exists(gameFolderPath))
                {
                    System.IO.Directory.CreateDirectory(gameFolderPath);
                }

                // Check if all three images exist for the game, if not, download them
                string[] imageNames = { "Picture1.jpg", "Picture2.jpg", "Picture3.jpg" };
                foreach (string imageName in imageNames)
                {
                    string imagePath = $"{gameFolderPath}\\{imageName}";

                    if (!System.IO.File.Exists(imagePath))
                    {
                        // Download the image from Azure Blob Storage
                        FileUploader.Instance.DownloadImageFromBlobStorage(game, imageName, imagePath);
                    }
                }
            }
        }
        #endregion

        #region events

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.parentForm.Close();
            this.Close();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void controlBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MainWindowForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != this.lastWindowState)
            {
                lastWindowState = WindowState;


                if (WindowState == FormWindowState.Maximized)
                {

                    maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;

                }
                if (WindowState == FormWindowState.Normal)
                {

                    maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;

                }
            }
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, pressColor);
            OpenChildForm(libraryForm);
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, pressColor);
            OpenChildForm(inventoryForm);
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, pressColor);
            OpenChildForm(userForm);
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, pressColor);
            OpenChildForm(adminForm);
        }
        private void MainWindowForm_Load(object sender, EventArgs e)
        {

            float width_ratio = (Screen.PrimaryScreen.Bounds.Width / 1920);
            float heigh_ratio = (Screen.PrimaryScreen.Bounds.Height / 1080);

            SizeF scale = new SizeF(width_ratio, heigh_ratio);
            this.Scale(scale);

            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Tahoma", control.Font.SizeInPoints * heigh_ratio * width_ratio);
            }

            currentBtn = libraryBtn;
            currentBtn.ForeColor = pressColor;
            currentBtn.IconColor = pressColor;

            downBorderBtn.BackColor = pressColor;
            downBorderBtn.Location = new Point(currentBtn.Location.X, this.navigationPanel.Location.Y);
            downBorderBtn.Visible = true;
            downBorderBtn.Size = new Size(currentBtn.Width, 7);
            downBorderBtn.BringToFront();

            OpenChildForm(libraryForm);

            libraryForm.InventoryButtonClicked += LibraryForm_InventoryButtonClicked;

            CheckAndDownloadImagesForGames(listAllGames);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameInfoForm_OpenInventoryClicked(object sender, EventArgs e)
        {
            // Handle the event, e.g., open the inventoryForm
            ActivateButton(inventoryBtn, pressColor);
            OpenChildForm(inventoryForm);
        }


        #endregion




    }
}
