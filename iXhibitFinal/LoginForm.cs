using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace iXhibitFinal
{
    public partial class LoginForm : Form
    {
        public static String MongoName;

        public LoginForm()
        {
            InitializeComponent();
        }

        RegForm reg = new RegForm();
        HomePageMenu hpm = new HomePageMenu();

        private void LoginForm_Load(object sender, EventArgs e)
        {
           panel2.BackColor = Color.FromArgb(75, Color.DimGray);
        }



        private void btnSignup_Click(object sender, EventArgs e)
        {
           
            MongoClient dbClient = new MongoClient("mongodb+srv://iXhibit:iXhibit@ixhibitcluster.ohc3x.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var database = dbClient.GetDatabase("iXhibit_db");
            var collection = database.GetCollection<BsonDocument>("iXhibit_col");

            try
            {
                var filter_usr = Builders<BsonDocument>.Filter.Eq("Username", txt_usr.Text);
                var usr = collection.Find(filter_usr).FirstOrDefault();

                if (usr["Password"] == txt_pwd.Text)
                {
                    MongoName = txt_usr.Text;
                    this.Hide();
                    hpm.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("LOGIN CREDENTIALS INVALID", "SYSTEM MESSAGE",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_usr.Text = null;
                    txt_pwd.Text = null; 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN CREDENTIALS INVALID", "SYSTEM MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        private void openPass_Click(object sender, EventArgs e)
        {
            if (txt_pwd.PasswordChar == '●')
            {
                hidePass.BringToFront();
                txt_pwd.PasswordChar = '\0';
            }
        }

        private void hidePass_Click(object sender, EventArgs e)
        {
            if (txt_pwd.PasswordChar == '\0')
            {
                openPass.BringToFront();
                txt_pwd.PasswordChar = '●';
            }
        }
    }
}
    