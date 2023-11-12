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
    public partial class libraryForm : Form
    {
        private int currentRandomIndex;
        private int lastRandomIndex;
        public libraryForm()
        {
            InitializeComponent();
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
    }
}
