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
    public partial class usercontrol_search : UserControl
    {
        
        public usercontrol_search()
        {
            InitializeComponent();
            add_picture();
        }
        private void add_picture()
        {
            this.flowlayoutpanel_usercontroll_type2.Controls.Clear();
            libraryForm obj = new libraryForm();
            if (libraryForm.Selected_game == 1)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox1);
            }
            if (libraryForm.Selected_game == 2)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox2);
            }
            if (libraryForm.Selected_game == 3)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox3);
            }
            if (libraryForm.Selected_game == 4)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox4);
            }
            if (libraryForm.Selected_game == 5)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox5);
            }
            if (libraryForm.Selected_game == 6)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox6);
            }
            if (libraryForm.Selected_game == 7)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox7);
            }
            if (libraryForm.Selected_game == 8)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox8);
            }
            if (libraryForm.Selected_game == 9)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox9);
            }
            if (libraryForm.Selected_game == 10)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox10);
            }
            if (libraryForm.Selected_game == 11)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox11);
            }
            if (libraryForm.Selected_game == 12)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox12);
            }
            if (libraryForm.Selected_game == 13)
            {
                this.flowlayoutpanel_usercontroll_type2.Controls.Add(obj.pictureBox13);
            }
        }
    }
}
