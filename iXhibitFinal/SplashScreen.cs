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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progBarYellow.Width += 3;

            if (progBarYellow.Width >= progBarBrown.Width)
            {
                timer.Stop();
                this.Hide();
                WelcomePage wcp = new WelcomePage();
                wcp.ShowDialog();
                this.Close();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
