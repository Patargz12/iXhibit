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
    public partial class ViewArtwork : Form
    {
        public ViewArtwork()
        {
            InitializeComponent();
        }

        private void ViewArtwork_Load(object sender, EventArgs e)
        {

            viewArtworkBox.Image = HomePageMenu.art;
            lblArtTitle.Text = HomePageMenu.artTitle;
            lblArtworkArtist.Text = HomePageMenu.artistName;
            lblCategory.Text = HomePageMenu.artCategory;
            lblArtDesc.Text = HomePageMenu.artDesc;
        }

        private void btnContact_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ContactSeller contact = new ContactSeller();
            contact.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageMenu hpm = new HomePageMenu();
            hpm.ShowDialog();
            this.Close();
        }

        private void txt_comment_Click(object sender, EventArgs e)
        {
            txt_comment.Text = "";
        }

        int cmtCount = 0;
        private void btn_comment_Click(object sender, EventArgs e)
        {
            if (cmtCount == 4)
            {
                t5.Text = txt_comment.Text;
                p5.Visible = true;
                t5.Visible = true;
                cmtCount = 5;
                txt_comment.Text = null;
            }

            if (cmtCount == 3)
            {
                t4.Text = txt_comment.Text;
                p4.Visible = true;
                t4.Visible = true;
                cmtCount = 4;
                txt_comment.Text = null;
            }

            if (cmtCount == 2)
            {
                t3.Text = txt_comment.Text;
                p3.Visible = true;
                t3.Visible = true;
                cmtCount = 3;
                txt_comment.Text = null;
            }

            if (cmtCount == 1)
            {
                t2.Text = txt_comment.Text;
                p2.Visible = true;
                t2.Visible = true;
                cmtCount = 2;
                txt_comment.Text = null;
            }

            if (cmtCount == 0)
            {
                t1.Text = txt_comment.Text;
                p1.Visible = true;
                t1.Visible = true;
                cmtCount = 1;
                txt_comment.Text = null;
            }

            


        }
    }
}
