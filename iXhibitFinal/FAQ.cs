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
    public partial class FAQ : Form
    {
        public FAQ()
        {
            InitializeComponent();
        }

        private void btnReturnWP_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage wcp = new WelcomePage();
            wcp.ShowDialog();
            this.Close();
        }
    }
}
