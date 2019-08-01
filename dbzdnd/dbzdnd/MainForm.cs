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
            refreshForm();
        }

        //Refreshes the entire form
        public void refreshForm()
        {
            lblStimPills.Text = "Stimulation pills: " + dbzdnd.Properties.Settings.Default.StimCount;
            lblRecoveryPills.Text = "Recovery pills: " + dbzdnd.Properties.Settings.Default.RecoveryCount;
            lblEnergyPills.Text = "Energy pills: " + dbzdnd.Properties.Settings.Default.EnergyCount;
            lblCredits.Text = "Credits: " + dbzdnd.Properties.Settings.Default.Credits;
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

        private void nudLevel_ValueChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Level = (int) nudLevel.Value;
            dbzdnd.Properties.Settings.Default.Save();
        }

        private void btnAddStim_Click(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.StimCount += 1;
            lblStimPills.Text = "Stimulation pills: " + dbzdnd.Properties.Settings.Default.StimCount;
            dbzdnd.Properties.Settings.Default.Save();
        }

        private void btnRemStim_Click(object sender, EventArgs e)
        {
            if (dbzdnd.Properties.Settings.Default.StimCount <= 0)
            {
                MessageBox.Show("mate wat u doin?");
            }
            else
            {
                dbzdnd.Properties.Settings.Default.StimCount -= 1;
                lblStimPills.Text = "Stimulation pills: " + dbzdnd.Properties.Settings.Default.StimCount;
                dbzdnd.Properties.Settings.Default.Save();
            }

        }

        private void btnUseStim_Click(object sender, EventArgs e)
        {
            if (dbzdnd.Properties.Settings.Default.StimCount <= 0)
            {
                MessageBox.Show("ye nah fuck off mate");
            }
            else
            {
                dbzdnd.Properties.Settings.Default.StimCount -= 1;
                lblStimPills.Text = "Stimulation pills: " + dbzdnd.Properties.Settings.Default.StimCount;
                dbzdnd.Properties.Settings.Default.Save();
            }
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.RecoveryCount += 1;
            lblRecoveryPills.Text = "Recovery pills: " + dbzdnd.Properties.Settings.Default.RecoveryCount;
            dbzdnd.Properties.Settings.Default.Save();
        }

        private void btnRemRec_Click(object sender, EventArgs e)
        {
            if (dbzdnd.Properties.Settings.Default.RecoveryCount <= 0)
            {
                MessageBox.Show("mate wat u doin?");
            }
            else
            {
                dbzdnd.Properties.Settings.Default.RecoveryCount -= 1;
                lblRecoveryPills.Text = "Recovery pills: " + dbzdnd.Properties.Settings.Default.RecoveryCount;
                dbzdnd.Properties.Settings.Default.Save();
            }
        }

        private void btnUseRec_Click(object sender, EventArgs e)
        {
            if (dbzdnd.Properties.Settings.Default.RecoveryCount <= 0)
            {
                MessageBox.Show("ye nah fuck off mate");
            }
            else
            {
                dbzdnd.Properties.Settings.Default.RecoveryCount -= 1;
                lblRecoveryPills.Text = "Recovery pills: " + dbzdnd.Properties.Settings.Default.RecoveryCount;
                dbzdnd.Properties.Settings.Default.Save();
            }
        }

        private void btnAddEnergy_Click(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.EnergyCount += 1;
            lblEnergyPills.Text = "Energy pills: " + dbzdnd.Properties.Settings.Default.EnergyCount;
            dbzdnd.Properties.Settings.Default.Save();
        }

        private void btnRemEnergy_Click(object sender, EventArgs e)
        {
            if (dbzdnd.Properties.Settings.Default.EnergyCount <= 0)
            {
                MessageBox.Show("mate wat u doin?");
            }
            else
            {
                dbzdnd.Properties.Settings.Default.EnergyCount -= 1;
                lblEnergyPills.Text = "Energy pills: " + dbzdnd.Properties.Settings.Default.EnergyCount;
                dbzdnd.Properties.Settings.Default.Save();
            }
        }

        private void btnUseEnergy_Click(object sender, EventArgs e)
        {
            if (dbzdnd.Properties.Settings.Default.EnergyCount <= 0)
            {
                MessageBox.Show("ye nah fuck off mate");
            }
            else
            {
                dbzdnd.Properties.Settings.Default.EnergyCount -= 1;
                lblEnergyPills.Text = "Energy pills: " + dbzdnd.Properties.Settings.Default.EnergyCount;
                dbzdnd.Properties.Settings.Default.Save();
            }
        }

        private void btnAddCredits_Click(object sender, EventArgs e)
        {

            new addValues("add", "credits", this);
        }

        private void btnRemoveCredits_Click(object sender, EventArgs e)
        {
            new addValues("take", "credits", this);
        }

        public void changeCredits(decimal amount)
        {
            if (amount < 0 && dbzdnd.Properties.Settings.Default.Credits + amount < 0)
            {
                MessageBox.Show("yeah nah you're too poor");
            }
            else
            {
                dbzdnd.Properties.Settings.Default.Credits += amount;
                lblCredits.Text = "Credits: " + dbzdnd.Properties.Settings.Default.Credits;
                dbzdnd.Properties.Settings.Default.Save();
            }

        }

        private void btnFillHealth_Click(object sender, EventArgs e)
        {
            //other stuff
            //hello
        }
    }



    
}
