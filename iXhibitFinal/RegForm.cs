using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;
using System.IO;
using MongoDB.Bson;


namespace iXhibitFinal
{
    public partial class RegForm : Form
    {
        public static Image dp;
        public static string fName;
        public static string sName;
        public static string profession;
        public static string gender;
        public static int age;
        public static string birthdate;
        public static string username;
        public static string password;
        public static string repass;

        //DB INITIALIZATION
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Information> m_Collection;

        public RegForm()
        {
            InitializeComponent();

            m_Client = new MongoClient("mongodb+srv://iXhibit:iXhibit@ixhibitcluster.ohc3x.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("iXhibit_db");
            m_Collection = m_Database.GetCollection<Information>("iXhibit_col");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage wcp = new WelcomePage();
            wcp.ShowDialog();
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {


            

            //dp = picBox.Image;

            try
            {
                string dbFname = txtBoxFN.Text;
                string dbSname = txtBoxSN.Text;
                string dbUsername = txtBoxSN.Text;
                string dbGender = gender;
                string dbProfession = comboBoxProfession.Texts;
                string dbBdate = datePickerBdate.Text;
                string dbEmail = txtBoxEmail.Text;
                string dbPassword = txtBoxPass.Text;
                string dbRePass = txtBoxRePass.Text;
                int dbAge = int.Parse(txtBoxAge.Text);

                if (String.IsNullOrEmpty(dbFname) || String.IsNullOrEmpty(dbSname) || dbAge.Equals(null) || String.IsNullOrEmpty(dbEmail) || String.IsNullOrEmpty(dbUsername) || String.IsNullOrEmpty(dbPassword))
                {
                    MessageBox.Show("Please fill all information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (String.IsNullOrEmpty(dbProfession) || comboBoxProfession.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a profession.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (dbAge < 11 && dbAge > 90)
                {
                    MessageBox.Show("Age must not be below 18 and higher than 98.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //else if (comboBoxProfession.SelectedIndex == -1)
                //{
                //    MessageBox.Show("Please fill all information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                else if (String.IsNullOrEmpty(dbRePass))
                {
                    MessageBox.Show("Please re-enter your password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (dbRePass != dbPassword)
                {
                    MessageBox.Show("Password and re-password doesn't match.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        Information information = new Information();

                        if (genderMale.Checked == true)
                        {
                            information.Gender = "Male";
                        }

                        if (genderFemale.Checked == true)
                        {
                            information.Gender = "Female";
                        }

                        information.First_Name = txtBoxFN.Text;
                        information.Surname = txtBoxSN.Text;
                        information.Profession = comboBoxProfession.Texts;
                        information.Age = int.Parse(txtBoxAge.Text);
                        information.BirthDate = datePickerBdate.Text;
                        information.Email = txtBoxEmail.Text;
                        information.Username = txtBoxUsername.Text;
                        information.Password = txtBoxRePass.Text;
                        information.Image = ImageToBytes(picBox.Image);

                        m_Collection.InsertOne(information);

                        MessageBox.Show("REGISTERED SUCCESSFULY","SYSTEM MESSAGE",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        //Code ni Estras
                        fName = dbFname;
                        sName = dbSname;
                        profession = dbProfession;
                        gender = dbGender;
                        age = dbAge;
                        birthdate = dbBdate;
                        username = dbUsername;

                        this.Hide();
                        LoginForm login = new LoginForm();
                        login.ShowDialog();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("PLEASE INPUT AN IMAGE", "SYSTEM MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }

        private void openPass_Click(object sender, EventArgs e)
        {
            if (txtBoxRePass.PasswordChar == '●')
            {
                hidePass.BringToFront();
                txtBoxPass.PasswordChar = '\0';
                txtBoxRePass.PasswordChar = '\0';
            }
        }

        private void hidePass_Click(object sender, EventArgs e)
        {
            if (txtBoxRePass.PasswordChar == '\0')
            {
                openPass.BringToFront();
                txtBoxPass.PasswordChar = '●';
                txtBoxRePass.PasswordChar = '●';
            }
        }

        public byte[] ImageToBytes(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public Image BytesToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }



        private void btnBrowsePic_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";
                
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picBox.Image = new Bitmap(dlg.FileName);
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void genderFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void genderMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }
    }
}
