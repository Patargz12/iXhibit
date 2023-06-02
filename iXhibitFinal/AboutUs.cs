using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iXhibitFinal
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void btnBackAbtUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage wcp = new WelcomePage();
            wcp.ShowDialog();
            this.Close();
        }
    }
}
