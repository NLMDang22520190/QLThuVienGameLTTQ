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
    public partial class MainWindowForm : Form
    {

        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            displayStoreFlowPanel.BringToFront();
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            displayLibraryFlowPanel.BringToFront();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            displayStoreFlowPanel.BringToFront();
        }
    }
}
