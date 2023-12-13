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
    public partial class gameInfoForm : Form
    {
        public gameInfoForm(string gameName, Image[] gamePictures, string gameDetail)
        {
            InitializeComponent();

            // Game Name Label
            Label nameLabel = new Label
            {
                Text = "Game Name: " + gameName,
                Font = new Font("Tahoma", 12, FontStyle.Bold),
                AutoSize = true
            };

            // Game Pictures PictureBoxes
            PictureBox[] pictureBoxes = new PictureBox[gamePictures.Length];
            for (int i = 0; i < gamePictures.Length; i++)
            {
                pictureBoxes[i] = new PictureBox
                {
                    Image = gamePictures[i],
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(100, 100),
                    Margin = new Padding(5)
                };
            }

            // Game Detail Label
            Label detailLabel = new Label
            {
                Text = "Game Detail: " + gameDetail,
                Font = new Font("Tahoma", 10),
                AutoSize = true
            };

            // Add to Inventory Button
            Button addToInventoryButton = new Button
            {
                Text = "Add to Inventory",
                Size = new Size(150, 30),
                Margin = new Padding(10)
            };
            addToInventoryButton.Click += AddToInventoryButton_Click;

            // More Info Button
            Button moreInfoButton = new Button
            {
                Text = "More Info",
                Size = new Size(150, 30),
                Margin = new Padding(10)
            };
            moreInfoButton.Click += MoreInfoButton_Click;

            // Flow Layout Panel
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Controls.Add(nameLabel);
            flowLayoutPanel.Controls.AddRange(pictureBoxes);
            flowLayoutPanel.Controls.Add(detailLabel);
            flowLayoutPanel.Controls.Add(addToInventoryButton);
            flowLayoutPanel.Controls.Add(moreInfoButton);

            this.Controls.Add(flowLayoutPanel);
        }

        private void AddToInventoryButton_Click(object sender, EventArgs e)
        {
            // Handle add to inventory button click
            // You can add the game to the user's inventory here
        }

        private void MoreInfoButton_Click(object sender, EventArgs e)
        {
            // Handle more info button click
            // You can provide additional information or actions here
        }
    }
}
