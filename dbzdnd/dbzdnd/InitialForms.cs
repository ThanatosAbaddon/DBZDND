using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                //Load player data from network
                string playerData = newNetwork.Get(txtName.Text);

                if (playerData != "") {
                    AppData.Instance(txtName.Text, playerData, newNetwork);
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
            try
            {
                //Load player data from file
                string playerData = File.ReadAllText(txtName.Text + ".json");
                
                AppData.Instance(txtName.Text, playerData);
                this.Hide();
            } catch (FileNotFoundException)
            {
                MessageBox.Show("Incorrect name");
            }
        }
    }
}
