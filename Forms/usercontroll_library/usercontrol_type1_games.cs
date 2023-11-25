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
    public partial class usercontrol_type1_games : UserControl
    {
        
        public usercontrol_type1_games()
        {
            InitializeComponent();
            add_picture();
        }
        private void add_picture()
        {
            libraryForm obj = new libraryForm();
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox1);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox4);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox6);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox8);
            this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox9);
        }
    }
}
