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
    public partial class usercontrol_type6_games : UserControl
    {
        public usercontrol_type6_games()
        {
            InitializeComponent();
            add_game();
        }
        public void add_game()
        {
            libraryForm obj = new libraryForm();
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox8);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox11);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox12);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox5);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox4);
        }
    }
}
