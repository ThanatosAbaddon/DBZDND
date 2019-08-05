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
        #region "variables"
        private PlayerInfo infoWindow = new PlayerInfo();
        private Transformations transformWindow = new Transformations();
        private Skills skillWindow = new Skills();
        private Inventory inventoryWindow = new Inventory();
        private AppData _AppData = AppData.Instance();
        #endregion

        public MainForm()
        {
            InitializeComponent();
            refreshForm();
        }

        #region "buttons"
        private void nudLevel_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Level = (int)nudLevel.Value;
            //call Countdown
        }

        private void btnFillHealth_Click(object sender, EventArgs e)
        {
            //other stuff
            //hello
        }
        #endregion

        #region "windows"

        /// <summary>
        /// generic window showing.
        /// </summary>
        /// <param name="Window"></param>
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
        #endregion

        #region "itemUsing"
        private void btnAddStim_Click(object sender, EventArgs e)
        {
            _AppData._StimCount += 1;
            lblStimPills.Text = "Stimulation pills: " + _AppData._StimCount;
            //Call Save Countdown
        }

        private void btnRemStim_Click(object sender, EventArgs e)
        {
            if (_AppData._StimCount <= 0)
            {
                MessageBox.Show("mate wat u doin?");
            }
            else
            {
                _AppData._StimCount -= 1;
                lblStimPills.Text = "Stimulation pills: " + _AppData._StimCount;
                //Call Save Countdown
            }

        }

        private void btnUseStim_Click(object sender, EventArgs e)
        {
            if (_AppData._StimCount <= 0)
            {
                MessageBox.Show("ye nah fuck off mate");
            }
            else
            {
                _AppData._StimCount -= 1;
                lblStimPills.Text = "Stimulation pills: " + _AppData._StimCount;
                //Call Save Countdown
            }
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            _AppData._RecoveryCount += 1;
            lblRecoveryPills.Text = "Recovery pills: " + _AppData._RecoveryCount;
            //Call Save Countdown
        }

        private void btnRemRec_Click(object sender, EventArgs e)
        {
            if (_AppData._RecoveryCount <= 0)
            {
                MessageBox.Show("mate wat u doin?");
            }
            else
            {
                _AppData._RecoveryCount -= 1;
                lblRecoveryPills.Text = "Recovery pills: " + _AppData._RecoveryCount;
                //Call Save Countdown
            }
        }

        private void btnUseRec_Click(object sender, EventArgs e)
        {
            if (_AppData._RecoveryCount <= 0)
            {
                MessageBox.Show("ye nah fuck off mate");
            }
            else
            {
                _AppData._RecoveryCount -= 1;
                lblRecoveryPills.Text = "Recovery pills: " + _AppData._RecoveryCount;
                //Call Save Countdown
            }
        }

        private void btnAddEnergy_Click(object sender, EventArgs e)
        {
            _AppData._EnergyCount += 1;
            lblEnergyPills.Text = "Energy pills: " + _AppData._EnergyCount;
            //Call Save Countdown
        }

        private void btnRemEnergy_Click(object sender, EventArgs e)
        {
            if (_AppData._EnergyCount <= 0)
            {
                MessageBox.Show("mate wat u doin?");
            }
            else
            {
                _AppData._EnergyCount -= 1;
                lblEnergyPills.Text = "Energy pills: " + _AppData._EnergyCount;
                //Call Save Countdown
            }
        }

        private void btnUseEnergy_Click(object sender, EventArgs e)
        {
            if (_AppData._EnergyCount <= 0)
            {
                MessageBox.Show("ye nah fuck off mate");
            }
            else
            {
                _AppData._EnergyCount -= 1;
                lblEnergyPills.Text = "Energy pills: " + _AppData._EnergyCount;
                //Call Save Countdown
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
            if (amount < 0 && _AppData._Credits + amount < 0)
            {
                MessageBox.Show("yeah nah you're too poor");
            }
            else
            {
                _AppData._Credits += amount;
                lblCredits.Text = "Credits: " + _AppData._Credits;
                //Call Save Countdown
            }

        }
        #endregion

        #region "Form Stuff"
        //Refreshes the entire form
        public void refreshForm()
        {
            lblStimPills.Text = "Stimulation pills: " + _AppData._StimCount;
            lblRecoveryPills.Text = "Recovery pills: " + _AppData._RecoveryCount;
            lblEnergyPills.Text = "Energy pills: " + _AppData._EnergyCount;
            lblCredits.Text = "Credits: " + _AppData._Credits;
        }

        /// <summary>
        /// Ends the program when the main window is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Save First
            Application.Exit();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Network test = new Network("127.0.0.1", 25000);
            test.Save();
            Console.WriteLine(test.Get("test"));
        }
    }




}
