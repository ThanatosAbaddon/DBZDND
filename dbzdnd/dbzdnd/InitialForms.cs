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
            Network newNetwork = new Network(txtIP.Text, 1234);
            //TEST IF A CONNECTION CAN BE MADE
            AppData.Instance(txtName.Text, true, newNetwork);
            this.Hide();
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            //CHECK THAT THERE IS A FILE WITH THE GIVEN NAME
            AppData.Instance(txtName.Text, false);
            this.Hide();
        }
    }
}
