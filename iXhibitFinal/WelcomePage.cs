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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm regform = new RegForm();
            regform.ShowDialog();
            this.Close();
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.FromArgb(175, 52, 51, 48); btnAbout.ForeColor = Color.FromArgb(216, 168, 78);
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.Transparent; btnAbout.ForeColor = Color.FromArgb(204, 92, 40);
        }

        private void btnContact_MouseHover(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.FromArgb(175, 52, 51, 48); btnContact.ForeColor = Color.FromArgb(216, 168, 78);
        }

        private void btnContact_MouseLeave(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.Transparent; btnContact.ForeColor = Color.FromArgb(204, 92, 40);
        }

        private void btnFAQ_MouseHover(object sender, EventArgs e)
        {
            btnFAQ.BackColor = Color.FromArgb(175, 52, 51, 48); btnFAQ.ForeColor = Color.FromArgb(216, 168, 78);
        }

        private void btnFAQ_MouseLeave(object sender, EventArgs e)
        {
            btnFAQ.BackColor = Color.Transparent; btnFAQ.ForeColor = Color.FromArgb(204, 92, 40);
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(175, 52, 51, 48); btnLogin.ForeColor = Color.FromArgb(216, 168, 78);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent; btnLogin.ForeColor = Color.FromArgb(216, 168, 78);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs abtus = new AboutUs();
            abtus.ShowDialog();
            this.Close();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contact = new ContactUs();
            contact.ShowDialog();
            this.Close();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAQ faq = new FAQ();
            faq.ShowDialog();
            this.Close();
        }
    }
}
