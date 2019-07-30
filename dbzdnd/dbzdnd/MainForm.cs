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
        private Transformations transformWindow = new Transformations();
        private Skills skillWindow = new Skills();
        private Inventory inventoryWindow = new Inventory();

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void openWindow(Form Window)
        {

            if (Window.Visible == false)
            {
                Window.Show();
            }
            else
            {
                Window.BringToFront();
            }
        }

        private void PlayerInfo_Click(object sender, EventArgs e)
        {
            if (infoWindow.IsDisposed == true)
            {
                infoWindow = new PlayerInfo();
            }
            openWindow(infoWindow);

        }


        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (inventoryWindow.IsDisposed == true)
            {
                inventoryWindow = new Inventory();
            }
            openWindow(inventoryWindow);
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            
            if (transformWindow.IsDisposed == true)
            {
                transformWindow = new Transformations();
            }
            openWindow(transformWindow);

        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            if (skillWindow.IsDisposed == true)
            {
                skillWindow = new Skills();
            }
            openWindow(skillWindow);
        }
    }
}
