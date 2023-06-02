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
    public partial class UploadArtwork : Form
    {
        public static Image artwork;
        public static string artworkTitle;
        public static string artworkCategory;
        public static string artworkDesc;

        public UploadArtwork()
        {
            InitializeComponent();
        }

        private void UploadArtwork_Load(object sender, EventArgs e)
        {
            //bgPanel.BackColor = Color.FromArgb(150, 52, 51, 48);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageMenu view = new HomePageMenu();
            view.ShowDialog();
            this.Close();
        }

        private void btnSelectArtwork_Click(object sender, EventArgs e)
        {
            String imageLoc = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLoc = dialog.FileName;

                    artworkBox.ImageLocation = imageLoc;
                    artworkBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    artworkBox.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnSaveUpload_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxArtTitle.Text) || String.IsNullOrEmpty(txtBoxArtDesc.Text) ||
                comboBoxArtCat.SelectedIndex != -1 && artworkBox.Image == null)
            {
                MessageBox.Show("Please do not leave empty fields inluding photo upload.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                artwork = artworkBox.Image;
                artworkTitle = txtBoxArtTitle.Text;
                artworkCategory = comboBoxArtCat.Texts;
                artworkDesc = txtBoxArtDesc.Text;

                MessageBox.Show("Artwork saved and uploaded.", "Artwork Uploaed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                artworkBox.Image = null; txtBoxArtDesc.Clear(); txtBoxArtTitle.Clear();
                comboBoxArtCat.SelectedIndex = -1;
            }
                    
        }

        private void artworkBox_Click(object sender, EventArgs e)
        {

        }
    }
}
