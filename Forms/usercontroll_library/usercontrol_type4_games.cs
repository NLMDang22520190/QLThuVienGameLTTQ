﻿using EpistWinform.Forms;
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
    public partial class usercontrol_type4_games : UserControl
    {
        public usercontrol_type4_games()
        {
            InitializeComponent();
            add_game();
        }
        private void add_game()
        {
            libraryForm obj = new libraryForm();
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox10);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox11);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox13);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox12);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox3);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox2);
        }
    }
}
