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
    public partial class usercontrol_type9_games : UserControl
    {
        public usercontrol_type9_games()
        {
            InitializeComponent();
            add_game();
        }
        public void add_game()
        {
            libraryForm obj = new libraryForm();
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox4);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox1);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox1);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox6);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox10);
            this.flowlayoutpanel_usercontroll_type1.Controls.Add(obj.pictureBox9);
        }
    }
}
