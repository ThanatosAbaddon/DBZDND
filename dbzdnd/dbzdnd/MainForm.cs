using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbzdnd
{
    public partial class MainForm : Form
    {
        private PlayerInfo infoWindow = new PlayerInfo();

        public MainForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void PlayerInfo_Click(object sender, EventArgs e)
        {
            if (infoWindow.IsDisposed == true)
            {
                infoWindow = new PlayerInfo();
            }
            if (infoWindow.Visible == false)
            {
                infoWindow.Show();
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
