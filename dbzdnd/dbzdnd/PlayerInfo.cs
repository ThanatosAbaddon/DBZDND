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
    public partial class PlayerInfo : Form
    {
        public PlayerInfo()
        {
            InitializeComponent();
            txtPlayerName.Text = dbzdnd.Properties.Settings.Default.PlayerName;
            txtName.Text = dbzdnd.Properties.Settings.Default.Name;
            if (dbzdnd.Properties.Settings.Default.Male == true)
            {
                cbGender.Text = "Male";
            }
            else
            {
                cbGender.Text = "Female";
            }
            
            cbRace.Text = dbzdnd.Properties.Settings.Default.Race;
            cbAge.Value = dbzdnd.Properties.Settings.Default.Age;
            txtHeight.Text = dbzdnd.Properties.Settings.Default.Height;
            txtWeight.Text = dbzdnd.Properties.Settings.Default.Weight;
            txtEyes.Text = dbzdnd.Properties.Settings.Default.Eyes;
            txtSkin.Text = dbzdnd.Properties.Settings.Default.Skin;
            txtAlignment.Text = dbzdnd.Properties.Settings.Default.Alignment;
            txtFactions.Text = dbzdnd.Properties.Settings.Default.Faction;
            txtLanguages.Text = dbzdnd.Properties.Settings.Default.Languages;
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.PlayerName = txtPlayerName.Text;
            Properties.Settings.Default.Save();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Name = txtName.Text;
            Properties.Settings.Default.Save();
        }

        private void cbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Race = cbRace.Text;
            Properties.Settings.Default.Save();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPlayerName.Text.ToUpper() == "MALE")
            {
                dbzdnd.Properties.Settings.Default.Male = true;
            }
            else if(txtPlayerName.Text.ToUpper() == "FEMALE")
            {
                dbzdnd.Properties.Settings.Default.Male = false;
            }
            Properties.Settings.Default.Save();
        }

        private void cbAge_ValueChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Age = (int) cbAge.Value;
            Properties.Settings.Default.Save();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Height = txtHeight.Text;
            Properties.Settings.Default.Save();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Weight = txtWeight.Text;
            Properties.Settings.Default.Save();
        }

        private void txtEyes_TextChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Eyes = txtEyes.Text;
            Properties.Settings.Default.Save();
        }

        private void txtSkin_TextChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Skin = txtSkin.Text;
            Properties.Settings.Default.Save();
        }

        private void txtAlignment_TextChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Alignment = txtAlignment.Text;
            Properties.Settings.Default.Save();
        }

        private void txtFactions_TextChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Faction = txtFactions.Text;
            Properties.Settings.Default.Save();
        }

        private void txtLanguages_TextChanged(object sender, EventArgs e)
        {
            dbzdnd.Properties.Settings.Default.Languages = txtLanguages.Text;
            Properties.Settings.Default.Save();
        }

        private void cbRace_TextChanged(object sender, EventArgs e)
        {
            //plz dont cuck me
        }

        private void cbGender_TextChanged(object sender, EventArgs e)
        {
            //^
        }
    }
}
