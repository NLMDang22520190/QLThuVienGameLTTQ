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
    public partial class usercontrol_type2_games : UserControl
    {
        public usercontrol_type2_games()
        {
            InitializeComponent();
            add_Picture();
        }
        private void add_Picture()
        {
            libraryForm obj = new libraryForm();
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox13);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox7);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox2);
        }
    }
}
