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
            valueUpdate();
        }

        private void btnFillHealth_Click(object sender, EventArgs e)
        {
            _AppData._CurrentHealth = _AppData._Health;
            nudCurrentHealth.Value = _AppData._Health;
            valueUpdate();
        }
        private void btnFillChi_Click(object sender, EventArgs e)
        {
            _AppData._CurrentChi = _AppData._Chi;
            nudCurrentChi.Value = _AppData._CurrentChi;
            valueUpdate();
        }

        private void btnFillStamina_Click(object sender, EventArgs e)
        {
            _AppData._CurrentStamina = _AppData._Stamina;
            nudCurrentStamina.Value = _AppData._CurrentStamina;
            valueUpdate();
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
            valueUpdate();
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
                valueUpdate();
            }

        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            _AppData._RecoveryCount += 1;
            lblRecoveryPills.Text = "Recovery pills: " + _AppData._RecoveryCount;
            valueUpdate();
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
                valueUpdate();
            }
        }

        private void btnAddEnergy_Click(object sender, EventArgs e)
        {
            _AppData._EnergyCount += 1;
            lblEnergyPills.Text = "Energy pills: " + _AppData._EnergyCount;
            valueUpdate();
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
                valueUpdate();
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

        public void changeCredits(int amount)
        {
            if (amount < 0 && _AppData._Credits + amount < 0)
            {
                MessageBox.Show("yeah nah you're too poor");
            }
            else
            {
                _AppData._Credits += amount;
                lblCredits.Text = "Credits: " + _AppData._Credits;
                valueUpdate();
            }

        }
        #endregion

        #region "Form Stuff"
        //Refreshes the entire form
        public void refreshForm()
        {
            this.Text = _AppData._Name;
            lblName.Text = _AppData._Name;

            nudLevel.Value = _AppData._Level;
            nudStatPoints.Value = _AppData._StatPoints;
            nudSpecPoints.Value = _AppData._SpecPoints;
            nudCurrentHealth.Value = _AppData._CurrentHealth;
            nudEXP.Value = _AppData._CurrentEXP;
            nudCurrentChi.Value = _AppData._CurrentChi;
            nudCurrentStamina.Value = _AppData._CurrentStamina;
            lblStimPills.Text = "Stimulation pills: " + _AppData._StimCount;
            lblRecoveryPills.Text = "Recovery pills: " + _AppData._RecoveryCount;
            lblEnergyPills.Text = "Energy pills: " + _AppData._EnergyCount;
            lblCredits.Text = "Credits: " + _AppData._Credits;

            nudStrength.Value = _AppData._Strength;
            nudBasicAttack.Value = _AppData._BasicAttack;
            nudStrikeSupers.Value = _AppData._StrikeSupers;
            nudChiSupers.Value = _AppData._ChiBlastSupers;
            nudAthletics.Value = _AppData._Athletics;
            nudPower.Value = _AppData._Power;
            nudDexterity.Value = _AppData._Dexterity;
            nudAcrobatics.Value = _AppData._Acrobatics;
            nudStealth.Value = _AppData._Stealth;
            nudSpeed.Value = _AppData._Speed;
            nudEndurance.Value = _AppData._Endurance;
            nudConstitution.Value = _AppData._Constitution;
            nudHealth.Value = _AppData._Health;
            nudStamina.Value = _AppData._Stamina;
            nudChi.Value = _AppData._Chi;
            nudResistance.Value = _AppData._Resistance;
            nudIntelligence.Value = _AppData._Intelligence;
            nudTechnology.Value = _AppData._Technology;
            nudCombat.Value = _AppData._Combat;
            nudWisdom.Value = _AppData._Wisdom;
            nudInsight.Value = _AppData._Insight;
            nudMedicine.Value = _AppData._Medicine;
            nudPerception.Value = _AppData._Perception;
            nudCharisma.Value = _AppData._Charisma;
            nudDeception.Value = _AppData._Deception;
            nudIntimidation.Value = _AppData._Intimidation;
            nudPerformance.Value = _AppData._Performace;
            nudPersuasion.Value = _AppData._Persuasion;

            pbCharacterPicture.ImageLocation = "http://stellanova.ddns.net/DND/" + _AppData._PlayerName + ".png";
        }

        /// <summary>
        /// Ends the program when the main window is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppData.saveAppData();
            Application.Exit();
        }
        #endregion
        

        private void valueUpdate()
        {
            if (autoSave.Enabled)
            {
                autoSave.Stop();
                autoSave.Start();
            } else
            {
                autoSave.Start();
            }
            
        }

        public void startTimer()
        {
            valueUpdate();
        }

        private void autosave_Tick(object sender, EventArgs e)
        {
            AppData.saveAppData();

            autoSave.Stop();
        }

        #region "nud Changes"
        private void nudCurrentHealth_ValueChanged(object sender, EventArgs e)
        {
            _AppData._CurrentHealth = decimal.ToInt32(nudCurrentHealth.Value);
            nudCurrentHealth.Value = _AppData._CurrentHealth;
            valueUpdate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void nudStatPoints_ValueChanged(object sender, EventArgs e)
        {
            _AppData._StatPoints = decimal.ToInt32(nudStatPoints.Value);
            valueUpdate();
        }

        private void nudSpecPoints_ValueChanged(object sender, EventArgs e)
        {
            _AppData._SpecPoints = decimal.ToInt32(nudSpecPoints.Value);
            valueUpdate();
        }

        private void nudEXP_ValueChanged(object sender, EventArgs e)
        {
            _AppData._CurrentEXP = decimal.ToInt32(nudEXP.Value);
            valueUpdate();
        }

        private void nudCurrentChi_ValueChanged(object sender, EventArgs e)
        {
            _AppData._CurrentChi = decimal.ToInt32(nudCurrentChi.Value);
            nudCurrentChi.Value = _AppData._CurrentChi;
            valueUpdate();
        }

        private void nudCurrentStamina_ValueChanged(object sender, EventArgs e)
        {
            _AppData._CurrentStamina = decimal.ToInt32(nudCurrentStamina.Value);
            nudCurrentStamina.Value = _AppData._CurrentStamina;
            valueUpdate();
        }

        private void nudStrength_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Strength = decimal.ToInt32(nudStrength.Value);
            valueUpdate();
        }

        private void nudBasicAttack_ValueChanged(object sender, EventArgs e)
        {
            _AppData._BasicAttack = decimal.ToInt32(nudBasicAttack.Value);
            valueUpdate();
        }

        private void nudStrikeSupers_ValueChanged(object sender, EventArgs e)
        {
            _AppData._StrikeSupers = decimal.ToInt32(nudStrikeSupers.Value);
            valueUpdate();
        }

        private void nudChiSupers_ValueChanged(object sender, EventArgs e)
        {
            _AppData._ChiBlastSupers = decimal.ToInt32(nudChiSupers.Value);
            valueUpdate();
        }

        private void nudAthletics_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Athletics = decimal.ToInt32(nudAthletics.Value);
            valueUpdate();
        }

        private void nudPower_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Power = decimal.ToInt32(nudPower.Value);
            valueUpdate();
        }

        private void nudDexterity_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Dexterity = decimal.ToInt32(nudDexterity.Value);
            valueUpdate();
        }

        private void nudAcrobatics_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Acrobatics = decimal.ToInt32(nudAcrobatics.Value);
            valueUpdate();
        }

        private void nudStealth_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Stealth = decimal.ToInt32(nudStealth.Value);
            valueUpdate();
        }

        private void nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Speed = decimal.ToInt32(nudSpeed.Value);
            valueUpdate();
        }

        private void nudEndurance_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Endurance = decimal.ToInt32(nudEndurance.Value);
            valueUpdate();
        }

        private void nudConstitution_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Constitution = decimal.ToInt32(nudConstitution.Value);
            valueUpdate();
        }

        private void nudHealth_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Health = decimal.ToInt32(nudHealth.Value);
            valueUpdate();
        }

        private void nudStamina_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Stamina = decimal.ToInt32(nudStamina.Value);
            valueUpdate();
        }

        private void nudChi_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Chi = decimal.ToInt32(nudChi.Value);
            valueUpdate();
        }

        private void nudResistance_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Resistance = decimal.ToInt32(nudResistance.Value);
            valueUpdate();
        }

        private void nudIntelligence_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Intelligence = decimal.ToInt32(nudIntelligence.Value);
            valueUpdate();
        }

        private void nudTechnology_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Technology = decimal.ToInt32(nudTechnology.Value);
            valueUpdate();
        }

        private void nudCombat_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Combat = decimal.ToInt32(nudCombat.Value);
            valueUpdate();
        }

        private void nudWisdom_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Wisdom = decimal.ToInt32(nudWisdom.Value);
            valueUpdate();
        }

        private void nudInsight_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Insight = decimal.ToInt32(nudInsight.Value);
            valueUpdate();
        }

        private void nudMedicine_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Medicine = decimal.ToInt32(nudMedicine.Value);
            valueUpdate();
        }

        private void nudPerception_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Perception = decimal.ToInt32(nudPerception.Value);
            valueUpdate();
        }

        private void nudCharisma_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Charisma = decimal.ToInt32(nudCharisma.Value);
            valueUpdate();
        }

        private void nudDeception_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Deception = decimal.ToInt32(nudDeception.Value);
            valueUpdate();
        }

        private void nudIntimidation_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Intimidation = decimal.ToInt32(nudIntimidation.Value);
            valueUpdate();
        }

        private void nudPerformance_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Performace = decimal.ToInt32(nudPerformance.Value);
            valueUpdate();
        }

        private void nudPersuasion_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Persuasion = decimal.ToInt32(nudPersuasion.Value);
            valueUpdate();
        }
        #endregion
    }
}
