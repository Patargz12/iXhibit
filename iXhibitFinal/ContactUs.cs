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
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void btnBackCntcUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage wcp = new WelcomePage();
            wcp.ShowDialog();
            this.Close();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for submitting a form request!", "Form Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBoxEmail.Clear(); txtBoxFN.Clear(); txtBoxMssg.Clear();


        }
    }
}
