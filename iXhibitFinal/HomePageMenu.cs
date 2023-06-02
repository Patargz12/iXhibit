using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.IO;


namespace iXhibitFinal
{
    public partial class HomePageMenu : Form
    {

        public static Image art;
        public static string artTitle;
        public static string artCategory;
        public static string artName;
        public static string artDesc;
        public static string artistName;
        public static string profileName;

        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Information> m_Collection;

        public HomePageMenu()
        {
            InitializeComponent();
            profileName = lblName.Text;

            m_Client = new MongoClient("mongodb+srv://iXhibit:iXhibit@ixhibitcluster.ohc3x.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("iXhibit_db");
            m_Collection = m_Database.GetCollection<Information>("iXhibit_col");
        }

        //int waiter = 0, panely = 365;
        int artworkIndex;

        public Image BytesToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        string title = UploadArtwork.artworkTitle;
        string category = UploadArtwork.artworkCategory;
        string description = UploadArtwork.artworkDesc;

        private void HomePageMenu_Load(object sender, EventArgs e)
        {
            txtBoxBio.Enabled = false;


            /*lblName.Text = RegForm.fName;
            lblSN.Text = RegForm.sName;
            lblProf.Text = RegForm.profession;
            lblUN.Text = RegForm.username;
            lblGender.Text = RegForm.gender;
            lblAge.Text = RegForm.age.ToString();
            lblBdate.Text = RegForm.birthdate;
            pictureBoxDP.Image = RegForm.dp;*/

            

            myArtworkBox1.Image = Draw.drawing;
            myArtworkBox2.Image = UploadArtwork.artwork;
            myArtworkBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            myArtworkBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            Information _con = m_Collection.Find(x => x.Username == (LoginForm.MongoName)).FirstOrDefault();
            pictureBoxDP.Image = BytesToImage(_con.Image);
            lblName.Text = _con.First_Name;
            lblSN.Text = _con.Surname;
            lblProf.Text = _con.Profession;
            lblUN.Text = _con.Username;
            lblGender.Text = _con.Gender;
            lblAge.Text = Convert.ToString(_con.Age);
            lblBdate.Text = _con.BirthDate;

            profileName = lblSN.Text;

            
        }

        private void btnUploadArt_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadArtwork upload = new UploadArtwork();
            upload.ShowDialog();
            this.Close();
        }

        private void chatTimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnBioEdit_Click(object sender, EventArgs e)
        {
            txtBoxBio.Enabled = true; 
        }

        private void btnBioSave_Click(object sender, EventArgs e)
        {
            txtBoxBio.Enabled = false; 
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Draw draw = new Draw();
            draw.ShowDialog();
            this.Close();
            
        }

        private void btnViewArtworks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyArtworks artworks = new MyArtworks();
            artworks.ShowDialog();
            this.Close();
        }

        private void txtBoxSearch_Enter(object sender, EventArgs e)
        {
            /*if (txtBoxSearch.Text == "123")
            {
                MessageBox.Show("Nice!!");
                txtBoxSearch.ForeColor = Color.Black;
                artworkBox2.Visible = false;
                artworkBox3.Visible = false;
                artworkBox4.Visible = false;
                artworkBox5.Visible = false;
            }*/
        }

        private void txtBoxSearch_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnLogoutHeader_Click(object sender, EventArgs e)
        {
            DialogResult logoutfrmconfirm = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (logoutfrmconfirm == DialogResult.Yes)
            {
                this.Hide();
                WelcomePage frm = new WelcomePage();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnDrawHeader_Click(object sender, EventArgs e)
        {
            this.Hide();
            Draw draw = new Draw();
            draw.ShowDialog();
            this.Close();
        }

        private void artworkBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            art = artworkBox1.Image;
            artTitle = "The Wave of Kaganawa";
            artistName = "Katsushika Hokusai";
            artDesc = "The threatening wave is pictured just moments before crashing " +
                "\n\tdown on to three fishing boats";
            artCategory = "History, Culture";
            view_artwork_form();
        }

        private void artworkBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            art = artworkBox2.Image;
            artTitle = "Starry Night";
            artistName = "Vincent Van Gogh";
            artDesc = "It depicts the view from the east-facing window of " +
                "\n\this asylum room at Saint-Rémy-de-Provence, just before sunrise.";
            artCategory = "Modern Art";
            view_artwork_form();
        }

        private void artworkBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            art = artworkBox3.Image;
            artTitle = "Christian Painters of Dancers";
            artistName = "Maria Magdalena Oosthuizen";
            artDesc = "A figurative portrait emanating innocence and hope that pay tribute both " +
                "\n\tto her devotion to God";
            artCategory = "Religion";
            view_artwork_form();
        }
        private void artworkBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            art = artworkBox4.Image;
            artTitle = "California Chrome";
            artistName = "James Zhao";
            artDesc = "This is a portrait of California Chrome, a famous thoroughbred " +
                "\n\tracing horse.";
            artCategory = "Animals";
            view_artwork_form();
        }

        private void artworkBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            art = artworkBox5.Image;
            artTitle = "She Used To Be Mine";
            artistName = "Katya Du Pond";
            artDesc = "The innocence that escapes, the internal beauty that we hide. We might " +
                "\n\tnot feel it, but everyone sees it. ";
            view_artwork_form();
        }

        public void view_artwork_form()
        {
            this.Hide();
            ViewArtwork view = new ViewArtwork();
            view.ShowDialog();
            this.Close();
        }

        public void view_my_artwork()
        {
            this.Hide();
            ViewMyArtwork view_my_artwork = new ViewMyArtwork();
            view_my_artwork.ShowDialog();
            this.Close();
        }

        private void myArtworkBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            UploadArtwork.artworkTitle = "My painting";
            UploadArtwork.artworkCategory = "Artistic";
            UploadArtwork.artworkDesc = "My artistic craft";
            art = myArtworkBox1.Image;
            artName = "My Painting";
            view_my_artwork();
        }

        private void myArtworkBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

            art = myArtworkBox2.Image;
            artName = lblName.Text;
            view_my_artwork();
        }

        private void chat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatMessage chat_form = new ChatMessage();
            chat_form.ShowDialog();
            this.Close();
        }

        private void pictureBoxDP_Click(object sender, EventArgs e)
        {

        }

        private void artworkBox1_Click(object sender, EventArgs e)
        {

        }

        string art1 = "THE WAVE OF KAGANAWA";
        string art2 = "STARRY NIGHT";
        string art3 = "CHRISTIAN PAINTERS OF DANCERS";
        string art4 = "CALIFORNIA CHROME";
        string art5 = "SHE USED TO BE MINE";

        private void rndButton1_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            string searchArt = search.ToUpper();
            

            if (searchArt == art1 || searchArt == art2 || searchArt == art3 || searchArt == art4 || searchArt == art5)
            {
                if (searchArt == art1)
                {
                    txtSearch.ForeColor = Color.Black;
                    artworkBox1.Visible = true;
                    artworkBox2.Visible = false;
                    artworkBox3.Visible = false;
                    artworkBox4.Visible = false;
                    artworkBox5.Visible = false;
                    txtSearch.Text = null;
                }

                if (searchArt == art2)
                {
                    txtSearch.ForeColor = Color.Black;
                    artworkBox1.Visible = false;
                    artworkBox2.Visible = true;
                    artworkBox3.Visible = false;
                    artworkBox4.Visible = false;
                    artworkBox5.Visible = false;
                    artworkBox2.Location = new Point(28, 19);
                    txtSearch.Text = null;
                }

                if (searchArt == art3)
                {
                    txtSearch.ForeColor = Color.Black;
                    artworkBox1.Visible = false;
                    artworkBox2.Visible = false;
                    artworkBox3.Visible = true;
                    artworkBox4.Visible = false;
                    artworkBox5.Visible = false;
                    artworkBox3.Location = new Point(28, 19);
                    txtSearch.Text = null;
                }

                if (searchArt == art4)
                {
                    txtSearch.ForeColor = Color.Black;
                    artworkBox1.Visible = false;
                    artworkBox2.Visible = false;
                    artworkBox3.Visible = false;
                    artworkBox4.Visible = true;
                    artworkBox5.Visible = false;
                    artworkBox4.Location = new Point(28, 19);
                    txtSearch.Text = null;
                }

                if (searchArt == art5)
                {
                    txtSearch.ForeColor = Color.Black;
                    artworkBox1.Visible = false;
                    artworkBox2.Visible = false;
                    artworkBox3.Visible = false;
                    artworkBox4.Visible = false;
                    artworkBox5.Visible = true;
                    artworkBox5.Location = new Point(28, 19);

                }
            }
            else
            {
                artworkBox1.Visible = true;
                artworkBox2.Visible = true;
                artworkBox3.Visible = true;
                artworkBox4.Visible = true;
                artworkBox5.Visible = true;
                artworkBox2.Location = new Point(176, 19);
                artworkBox3.Location = new Point(324, 19);
                artworkBox4.Location = new Point(473, 19);
                artworkBox5.Location = new Point(621, 19);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
        }
    }
}
