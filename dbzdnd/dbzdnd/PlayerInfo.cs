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
        private AppData _AppData;
        public PlayerInfo()
        {
            InitializeComponent();
            _AppData = AppData.Instance();
            txtPlayerName.Text = _AppData._PlayerName;
            txtName.Text = _AppData._Name;
            if (_AppData._Male == true)
            {
                cbGender.Text = "Male";
            }
            else
            {
                cbGender.Text = "Female";
            }
            
            cbRace.Text = _AppData._Race;
            cbAge.Value = _AppData._Age;
            txtHeight.Text = _AppData._Height;
            txtWeight.Text = _AppData._Weight;
            txtEyes.Text = _AppData._Eyes;
            txtSkin.Text = _AppData._Skin;
            txtAlignment.Text = _AppData._Alignment;
            txtFactions.Text = _AppData._Faction;
            txtLanguages.Text = _AppData._Languages;
        }

        #region "things changed"
        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            _AppData._PlayerName = txtPlayerName.Text;
            Properties.Settings.Default.PlayerName = _AppData._PlayerName;
            Properties.Settings.Default.Save();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _AppData._Name = txtName.Text;
            
        }

        private void cbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            _AppData._Race = cbRace.Text;
            
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPlayerName.Text.ToUpper() == "MALE")
            {
                _AppData._Male = true;
            }
            else if(txtPlayerName.Text.ToUpper() == "FEMALE")
            {
                _AppData._Male = false;
            }
            
        }

        private void cbAge_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Age = (int) cbAge.Value;
            
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            _AppData._Height = txtHeight.Text;
            
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            _AppData._Weight = txtWeight.Text;
            
        }

        private void txtEyes_TextChanged(object sender, EventArgs e)
        {
            _AppData._Eyes = txtEyes.Text;
            
        }

        private void txtSkin_TextChanged(object sender, EventArgs e)
        {
            _AppData._Skin = txtSkin.Text;
            
        }

        private void txtAlignment_TextChanged(object sender, EventArgs e)
        {
            _AppData._Alignment = txtAlignment.Text;
            
        }

        private void txtFactions_TextChanged(object sender, EventArgs e)
        {
            _AppData._Faction = txtFactions.Text;
            
        }

        private void txtLanguages_TextChanged(object sender, EventArgs e)
        {
            _AppData._Languages = txtLanguages.Text;
            
        }

        private void cbRace_TextChanged(object sender, EventArgs e)
        {
            //plz dont cuck me
        }

        private void cbGender_TextChanged(object sender, EventArgs e)
        {
            //^
        }
        #endregion
    }
}
