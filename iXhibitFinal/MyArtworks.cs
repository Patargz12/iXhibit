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
    public partial class MyArtworks : Form
    {
        public MyArtworks()
        {
            InitializeComponent();
        }

        private void btnScrollUp_Click(object sender, EventArgs e)
        {
            int change = flowLayoutPanel1.VerticalScroll.Value - flowLayoutPanel1.VerticalScroll.SmallChange * 30;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, change);
        }

        private void btnScrollDown_Click(object sender, EventArgs e)
        {
            int change = flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.VerticalScroll.SmallChange * 30;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, change);
        }

        private void MyArtworks_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Draw.drawing;
            pictureBox2.Image = UploadArtwork.artwork;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageMenu view = new HomePageMenu();
            view.ShowDialog();
            this.Close();
        }
    }
}
