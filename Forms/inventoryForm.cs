using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpistWinform.Forms
{
    public partial class inventoryForm : Form
    {
        public inventoryForm()
        {
            InitializeComponent();


        }

        private void inventoryForm_Load(object sender, EventArgs e)
        {

            gamesPanel.Controls.Add(new Panel { BackColor = Color.Red, Width = gamesPanel.Width });
            gamesPanel.Controls.Add(new Panel { BackColor = Color.Blue, Width = gamesPanel.Width });
            gamesPanel.Controls.Add(new Panel { BackColor = Color.Orange, Width = gamesPanel.Width });
            gamesPanel.Controls.Add(new Panel { BackColor = Color.Green, Width = gamesPanel.Width });
            gamesPanel.Controls.Add(new Panel { BackColor = Color.Yellow, Width = gamesPanel.Width });
            gamesPanel.Height = gamesPanel.Controls.Count * gamesPanel.Controls[0].Height + (gamesPanel.Controls.Count) * gamesPanel.Margin.Vertical;

            //spacePanel.Height = panel1.Height - gamesPanel.Height - panel3.Height - bannerPanel.Height;
            //if (spacePanel.Height < 0)
            //{
            //    spacePanel.Height = 1;
            //}
        }

        private void inventoryForm_Resize(object sender, EventArgs e)
        {

        }

        private void inventoryForm_SizeChanged(object sender, EventArgs e)
        {
            //gamesPanel.Height = panel1.Height - panel3.Height - bannerPanel.Height - spacePanel.Height;
            foreach (Control item in gamesPanel.Controls)
            {
                item.Width = gamesPanel.Width;
            }
        }
    }
}
