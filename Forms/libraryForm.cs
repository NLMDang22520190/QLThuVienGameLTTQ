using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        FlowLayoutPanel[] flow_array;
        Button[] button_array;
        SqlConnection connection;
        int Number_of_types = 0;
        string[] types_name_array;
        PictureBox[] picturebox_array;
        int Number_games_on_server;
        int Number_games_on_device;
        List<int> gameID_with_tagID;
        List<int> tagID_with_gameID;
        private int flag = 0;
        private List<List<int>> tag_gameid;
        private List<string> list_all_game;
        private FlowLayoutPanel flow_games_search;
        
        private void create_list_all_games()
        {
            list_all_game = new List<string>();
            string selectQuery = "select gameName from Game order by gameID;";

            using (SqlCommand command = new SqlCommand(selectQuery, this.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Đọc dữ liệu từ cột Column1 và Column2
                        list_all_game.Add(reader.GetString(0));
                    }
                }
            }
        }
        public void connect_to_database()
        {
            string connectionString = "Data Source=lttqquanlygame.database.windows.net;Initial Catalog=quanlygame;User ID=quanlygameadmin;Password= Quanlygame123@";
            this.connection = new SqlConnection(connectionString);
            try
            {
                this.connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("connection open is error");
            }
        }
        public libraryForm()
        {
            flow_games_search = create_flowpanel();
            connect_to_database();
            count_all_games_on_server1();
            count_all_games_on_device();
            count_number_of_types_games();
            create_list_all_games();
            
            create_gameID_tagID();
            create_tag_game_id();
            InitializeComponent();
            create_combobox();
            assign_picture();
            create_flowpanel();
            create_flow_layout_panel_in_panel_game();
            complete_tags_flowpanel();
            set_events_for_button();
            this.comboBox2.SelectedValueChanged += display_games_searched;
        }

        public void display_games_searched(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string s = cb.SelectedItem.ToString();
            int indexPicturebox = getIndex_games_in_combobox(s);
            this.flow_games_search.Controls.Clear();
            this.flow_games_search.Controls.Add(picturebox_array[indexPicturebox]);
            this.panel_games.Controls.Clear();
            this.panel_games.Controls.Add(flow_games_search);
        }
        public int getIndex_games_in_combobox(string gameName)
        {
            for (int i = 0; i < list_all_game.Count(); i++)
            {
                if (gameName == list_all_game[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public void create_combobox()
        {
            for (int i = 0; i < list_all_game.Count(); i++)
            {
                this.comboBox2.Items.Add(list_all_game[i]);
            }
        }
        private void libraryForm_Shown(object sender, EventArgs e)
        {

        }

        private void bannerPictureBox_Click(object sender, EventArgs e)
        {

        }
        private void count_number_of_types_games()
        {
            string selectQuery = "select count(Tags.tagID) from Tags;";

            using (SqlCommand command = new SqlCommand(selectQuery, this.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Đọc dữ liệu từ cột Column1 và Column2
                        Number_of_types = reader.GetInt32(0);
                    }
                }
            }
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
        public PictureBox createPictureBox()
        {
            PictureBox picturebox = new PictureBox();
            picturebox.Size = new Size(443, 203);
            picturebox.Margin = new Padding(81, 81, 81, 81);
            return picturebox;
        }
        public Boolean check_update()
        {
            if (Number_games_on_device == Number_games_on_server)
            {
                return true;
            }
            return false;
        }
        private void assign_picture()
        {
            if (check_update() == true) // khoong co cap nhat
            {
                picturebox_array = new PictureBox[Number_games_on_server];
                for (int i = 0; i < Number_games_on_server; i++)
                {
                    picturebox_array[i] = createPictureBox();
                    string s = Application.StartupPath + "\\Resource\\GamesPicture\\" + (i + 1) + "\\Picture1.jpg";
                    picturebox_array[i].Image = new Bitmap(s);
                    this.flowlayoutpanel_games.Controls.Add(picturebox_array[i]);
                }
            }
            else
            {

            }
        }
        public void count_all_games_on_device()
        {
            int a = 0;
            string dir = Application.StartupPath + "\\Resource\\GamesPicture";
            try
            {
                // Lấy danh sách các thư mục con
                string[] subDirectories = Directory.GetDirectories(dir);

                a = subDirectories.Count();

            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Number_games_on_device = a;
        }
        public void count_all_games_on_server1()
        {
            int a = 0;
            string selectQuery = "select\r\n\tcount(*) as number_of_games\r\nfrom Game\r\n;";

            using (SqlCommand command = new SqlCommand(selectQuery, this.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Đọc dữ liệu từ cột Column1 và Column2
                        a = reader.GetInt32(0);
                    }
                }
            }
            Number_games_on_server = a;
        }
        public void create_flow_layout_panel_in_panel_game()
        {
            flow_array = new FlowLayoutPanel[Number_of_types];
            for (int i = 0; i < Number_of_types; i++)
            {
                flow_array[i] = create_flowpanel();
            }
        }
        public FlowLayoutPanel create_flowpanel()
        {
            FlowLayoutPanel obj = new FlowLayoutPanel();
            obj.AutoScroll = true;
            obj.Dock = DockStyle.Fill;
            obj.Location = new Point(0, 0);
            obj.Size = new Size(1354, 486);
            obj.Margin = new Padding(35);
            return obj;
        }
        public void create_list_types_name_array()
        {
            types_name_array = new string[Number_of_types];
            string query = "select tagName from Tags;";
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        // Đọc dữ liệu từ cột Column1 và Column2
                        types_name_array[i] = reader.GetString(0);
                        i++;
                    }
                }
            }
        }
        public void create_list_tag_button()
        {
            button_array = new Button[Number_of_types + 1];
            for (int i = 0; i < button_array.Count() - 1; i++)
            {
                button_array[i] = create_tag_button(types_name_array[i]);
            }
            button_array[button_array.Count() - 1] = create_tag_button("All");
        }
        public Button create_tag_button(string s)
        {
            Button obj = new Button();
            obj.BackColor = Color.FromArgb(0, 199, 139);
            obj.Dock = DockStyle.Top;
            obj.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            obj.ForeColor = Color.White;
            obj.Size = new Size((int)(0.8 * this.tagsFlowPanel.Size.Width), 50);
            obj.Text = s;
            obj.UseVisualStyleBackColor = false;
            return obj;
        }
        public void add_button_into_tagflowpanel()
        {
            for (int i = 0; i < button_array.Count(); i++)
            {
                this.tagsFlowPanel.Controls.Add(button_array[i]);
            }
        }
        public void complete_tags_flowpanel()
        {
            create_list_types_name_array();
            create_list_tag_button();
            add_button_into_tagflowpanel();
        }
        public void create_gameID_tagID()
        {
            gameID_with_tagID = new List<int>();
            tagID_with_gameID = new List<int>();

            string query = "select * from GameTags\r\norder by \r\n\ttagID;";
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int gameID = reader.GetInt32(0);
                        int tagID = reader.GetInt32(1);

                        // Thêm vào danh sách
                        gameID_with_tagID.Add(gameID);
                        tagID_with_gameID.Add(tagID);
                    }
                }
            }
        }
        public void set_events_for_button()
        {
            for (int i = 0; i < button_array.Count(); i++)
            {
                button_array[i].Click += button_events;
            }
        }
        private void button_events(object sender, EventArgs e)
        {
            Button obj = sender as Button;

            for (int i = 0; i < button_array.Count() - 1; i++)
            {
                if (obj == button_array[i])
                {
                    this.panel_games.Controls.Clear();
                    this.panel_games.Controls.Add(flow_array[i]);
                    for (int j = 0; j < tag_gameid[i].Count(); j++)
                    {
                        this.flow_array[i].Controls.Add(picturebox_array[tag_gameid[i][j]]);
                    }
                }
            }
            if (obj == button_array[button_array.Count() - 1])
            {
                this.panel_games.Controls.Clear();
                this.panel_games.Controls.Add(flowlayoutpanel_games);
                for (int i = 0; i < picturebox_array.Count(); i++)
                {
                    this.flowlayoutpanel_games.Controls.Add(picturebox_array[i]);
                }
            }
        }

        private void create_tag_game_id()
        {
            tag_gameid = new List<List<int>>();
            for (int i = 0; i < Number_of_types; i++)
            {
                tag_gameid.Add(new List<int>());
            }
            for (int i = 0; i < gameID_with_tagID.Count(); i++)
            {
                tag_gameid[tagID_with_gameID[i] - 1].Add(gameID_with_tagID[i] - 1);
            }
        }
    }


}

