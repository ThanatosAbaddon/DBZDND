using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbzdnd
{
    /// <summary>
    /// This class is just here to represent the initializing forms for now. It will be changed.
    /// </summary>
    public partial class InitialForms : Form
    {
        public InitialForms()
        {
            InitializeComponent();
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            try
            {
                Network newNetwork = new Network(txtIP.Text, Decimal.ToInt32(txtPort.Value));

                string playerData = newNetwork.Get(txtName.Text);

                if (playerData != "") {
                    //Removes headder from player data
                    playerData = playerData.Substring(playerData.IndexOf("\n") + 1, playerData.Length - txtName.Text.Length - 1);

                    AppData.Instance(txtName.Text, true, newNetwork, playerData);
                    this.Hide();
                } else
                {
                    MessageBox.Show("Incorrect name");
                }

            } catch (SocketException)
            {
                MessageBox.Show("Incorrect IP or Port");
            }
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            //CHECK THAT THERE IS A FILE WITH THE GIVEN NAME
            AppData.Instance(txtName.Text, false);
            this.Hide();
        }
    }
}
