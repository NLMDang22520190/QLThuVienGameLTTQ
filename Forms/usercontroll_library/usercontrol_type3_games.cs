using EpistWinform.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpistWinform
{
    public partial class usercontrol_type3_games : UserControl
    {
        public usercontrol_type3_games()
        {
            InitializeComponent();
            add_game();
        }
        private void add_game()
        {
            libraryForm obj = new libraryForm();
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox2);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox1);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox7);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox6);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox9);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox8);
        }
    }
}
