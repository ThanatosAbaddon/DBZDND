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
                Network newNetwork = new Network(txtIP.Text, (int)txtPort.Value);

                //Load player data from network
                string onlinePlayerDataString = newNetwork.Get(txtName.Text);
                
                //Test if online file exists
                if (onlinePlayerDataString != "") {
                    string[] onlinePlayerData = onlinePlayerDataString.Split('\n');

                    try
                    {
                        //Load local player file
                        string[] localPlayerData = File.ReadAllText(txtName.Text + ".json").Split('\n');

                        //If local file can be loaded. Compare write times.
                        if (System.Convert.ToInt32(localPlayerData[2]) > System.Convert.ToInt32(onlinePlayerData[2]))
                        {
                            AppData.Instance(txtName.Text, localPlayerData[1], newNetwork);
                        } else
                        {
                            AppData.Instance(txtName.Text, onlinePlayerData[1], newNetwork);
                        }

                    } catch
                    {
                        AppData.Instance(txtName.Text, onlinePlayerData[1], newNetwork);
                    }
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
                string playerData = File.ReadAllText(txtName.Text + ".json").Split('\n')[1]; ;
                
                AppData.Instance(txtName.Text, playerData);
                this.Hide();
            } catch (FileNotFoundException)
            {
                MessageBox.Show("Incorrect name");
            }
        }
    }
}
