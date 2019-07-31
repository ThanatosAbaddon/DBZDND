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
    public partial class addValues : Form
    {
        String doing;
        String doingTo;
        MainForm mainRetrunForm;
        public addValues(String A, String B, MainForm returnForm)
        {
            InitializeComponent();
            doing = A;
            doingTo = B;
            mainRetrunForm = returnForm;
            lblMain.Text = "How many " + A + " do you want to " + B + "?";
            this.Show();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (doingTo == "credits")
            {
                if(doing == "take")
                {
                    mainRetrunForm.changeCredits(0 - nudValue.Value);
                }
                else if (doing == "add")
                {
                    mainRetrunForm.changeCredits(nudValue.Value);
                }
            }
            this.Close();
        }
    }
}
