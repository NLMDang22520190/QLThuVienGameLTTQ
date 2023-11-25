using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpistWinform.Forms
{
    public partial class libraryForm : Form
    {
        private int currentRandomIndex;
        private int lastRandomIndex;
        public event EventHandler InventoryButtonClicked;
        public static int Selected_game = 0;
        public libraryForm()
        {
            InitializeComponent();
            assign_picture();
        }
        private void libraryForm_Shown(object sender, EventArgs e)
        {

        }

        private void bannerPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void libraryForm_VisibleChanged(object sender, EventArgs e)
        {
            var random = new Random();
            currentRandomIndex = random.Next(1, 8);

            while (currentRandomIndex == lastRandomIndex)
            {
                currentRandomIndex = random.Next(1, 8);
            }

            lastRandomIndex = currentRandomIndex;

            string bannerImagePath = $"./Resource/Banner/banner{currentRandomIndex}.jpg";
            this.bannerPictureBox.Image = Image.FromFile(bannerImagePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InventoryButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void add_user_control(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            this.panel_games.Controls.Clear();
            this.panel_games.Controls.Add(user);
            user.BringToFront();
        }
        private void button_gametag1_Click(object sender, EventArgs e)
        {
            usercontrol_type1_games obj = new usercontrol_type1_games();
            add_user_control(obj);
        }

        private void button_gametag2_Click(object sender, EventArgs e)
        {
            usercontrol_type2_games obj = new usercontrol_type2_games();
            add_user_control(obj);
        }

        private void button_gametag3_Click(object sender, EventArgs e)
        {
            usercontrol_type3_games obj = new usercontrol_type3_games();
            add_user_control(obj);
        }

        private void assign_picture()
        {
            this.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\1\\Picture1.jpg");
            this.pictureBox2.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\2\\Picture1.jpg");
            this.pictureBox3.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\3\\Picture1.jpg");
            this.pictureBox4.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\4\\Picture1.jpg");
            this.pictureBox5.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\5\\Picture1.jpg");
            this.pictureBox6.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\6\\Picture1.jpg");
            this.pictureBox7.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\7\\Picture1.jpg");
            this.pictureBox8.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\8\\Picture1.jpg");
            this.pictureBox9.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\9\\Picture1.jpg");
            this.pictureBox10.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\10\\Picture1.jpg");
            this.pictureBox11.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\11\\Picture1.jpg");
            this.pictureBox12.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\12\\Picture1.jpg");
            this.pictureBox13.Image = new Bitmap(Application.StartupPath + "\\Resource\\GamesPicture\\13\\Picture1.jpg");
        }

        private void label_gametag_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.panel_games.Controls.Clear();
            this.panel_games.Controls.Add(this.flowlayoutpanel_games);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            usercontrol_type4_games obj = new usercontrol_type4_games();
            add_user_control(obj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usercontrol_type5_games obj = new usercontrol_type5_games();
            add_user_control(obj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usercontrol_type6_games obj = new usercontrol_type6_games();
            add_user_control(obj);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usercontrol_type7_games obj = new usercontrol_type7_games();
            add_user_control(obj);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            usercontrol_type8_games obj = new usercontrol_type8_games();
            add_user_control(obj);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            usercontrol_type9_games obj = new usercontrol_type9_games();
            add_user_control(obj);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            usercontrol_type10_games obj = new usercontrol_type10_games();
            add_user_control(obj);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            usercontrol_type11_games obj = new usercontrol_type11_games();
            add_user_control(obj);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            usercontrol_type12_games obj = new usercontrol_type12_games();
            add_user_control(obj);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            usercontrol_type13_games obj = new usercontrol_type13_games();
            add_user_control(obj);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            usercontrol_type14_games obj = new usercontrol_type14_games();
            add_user_control(obj);
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {

            ComboBox cb = sender as ComboBox;
            string s = cb.SelectedItem.ToString();
            if (s == "Endoparasitic")
            {
                Selected_game = 1;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);

            }
            if (s == "Thronefall")
            {
                Selected_game = 2;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "MMORPG Tycoon 2")
            {

                Selected_game = 3;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "Stoneshard")
            {
                Selected_game = 4;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "Desktop Dungeons: Rewind")
            {
                Selected_game = 5;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "Neon Abyss")
            {
                Selected_game = 6;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "Brothers in Hell")
            {
                Selected_game = 7;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "A Dance of Fire and Ice")
            {
                Selected_game = 8;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "Halls of Torment")
            {
                Selected_game = 9;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "WorldBox - God Simulator")
            {
                Selected_game = 10;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "Poly Bridge")
            {
                Selected_game = 11;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "Poly Bridge 2")
            {
                Selected_game = 12;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "Poly Bridge 3")
            {
                Selected_game = 13;
                usercontrol_search obj = new usercontrol_search();
                add_user_control(obj);
            }
            if (s == "All")
            {
                this.panel_games.Controls.Clear();
                this.panel_games.Controls.Add(this.flowlayoutpanel_games);
            }

        }

        private void libraryForm_MouseEnter(object sender, EventArgs e)
        {
            PictureBox obj = sender as PictureBox;
            obj.BorderStyle = BorderStyle.Fixed3D;
            obj.Cursor = Cursors.Hand;
        }

        private void libraryForm_MouseLeave(object sender, EventArgs e)
        {
            PictureBox obj = sender as PictureBox;
            obj.BorderStyle = BorderStyle.None;
        }
    }
}
