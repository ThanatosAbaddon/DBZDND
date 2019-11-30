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
            //MAKE THIS UNABLE TO BE EDITED LATER ON
            _AppData._PlayerName = txtPlayerName.Text;
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _AppData._Name = txtName.Text;
            _AppData.startTimer();
        }

        private void cbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            _AppData._Race = cbRace.Text;
            _AppData.startTimer();

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
            _AppData.startTimer();
        }

        private void cbAge_ValueChanged(object sender, EventArgs e)
        {
            _AppData._Age = (int) cbAge.Value;
            _AppData.startTimer();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            _AppData._Height = txtHeight.Text;
            _AppData.startTimer();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            _AppData._Weight = txtWeight.Text;
            _AppData.startTimer();
        }

        private void txtEyes_TextChanged(object sender, EventArgs e)
        {
            _AppData._Eyes = txtEyes.Text;
            _AppData.startTimer();
        }

        private void txtSkin_TextChanged(object sender, EventArgs e)
        {
            _AppData._Skin = txtSkin.Text;
            _AppData.startTimer();
        }

        private void txtAlignment_TextChanged(object sender, EventArgs e)
        {
            _AppData._Alignment = txtAlignment.Text;
            _AppData.startTimer();
        }

        private void txtFactions_TextChanged(object sender, EventArgs e)
        {
            _AppData._Faction = txtFactions.Text;
            _AppData.startTimer();
        }

        private void txtLanguages_TextChanged(object sender, EventArgs e)
        {
            _AppData._Languages = txtLanguages.Text;
            _AppData.startTimer();
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
