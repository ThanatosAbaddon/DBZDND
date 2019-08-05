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


        private void button1_Click(object sender, EventArgs e)
        {
            AppData.Instance(1, true, dbzdnd.Properties.Settings.Default.PlayerName, "Online");
            this.Hide();
        }
    }
}
