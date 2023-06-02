using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iXhibitFinal
{
    public partial class ContactSeller : Form
    {
        public ContactSeller()
        {
            InitializeComponent();
        }

        private void ContactSeller_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewArtwork view = new ViewArtwork();
            view.ShowDialog();
            this.Close();
        }

        private void btnSubmitReq_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for submitting a form request!", "Form Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBoxFN.Clear(); txtBoxSN.Clear(); txtBoxEmail.Clear(); txtBoxPhone.Clear(); txtBoxDetails.Clear();
            artReq1.Checked = false; artReq2.Checked = false; artReq3.Checked = false; artReq4.Checked = false;
        }
    }
}
