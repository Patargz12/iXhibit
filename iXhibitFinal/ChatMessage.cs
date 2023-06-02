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
    public partial class ChatMessage : Form
    {
        public ChatMessage()
        {
            InitializeComponent();
        }
        int ChatCounter = 0;
        private void rndButton1_Click(object sender, EventArgs e)
        {

        }

        private void ChatMessage_Load(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (chat_txt.Text != "")
            {
                if (ChatCounter == 9)
                {
                    t1.Text = chat_txt.Text;
                    ChatCounter = 0;
                    t9.Text = null;

                    t9.Visible = false;
                    p9.Visible = false;

                    t8.Text = null;
                    t8.Visible = false;
                    p8.Visible = false;

                    t7.Text = null;
                    t7.Visible = false;
                    p7.Visible = false;

                    t6.Text = null;
                    t6.Visible = false;
                    p6.Visible = false;

                    t7.Text = null;
                    t7.Visible = false;
                    p7.Visible = false;

                    t7.Text = null;
                    t7.Visible = false;
                    p7.Visible = false;

                    t6.Text = null;
                    t6.Visible = false;
                    p6.Visible = false;

                    t5.Text = null;
                    t5.Visible = false;
                    p5.Visible = false;

                    t4.Text = null;
                    t4.Visible = false;
                    p4.Visible = false;

                    t3.Text = null;
                    t3.Visible = false;
                    p3.Visible = false;

                    t2.Text = null;
                    t2.Visible = false;
                    p2.Visible = false;

                }

                if (ChatCounter == 8)
                {
                    t9.Text = chat_txt.Text;
                    ChatCounter = 9;
                    t9.Visible = true;
                    p9.Visible = true;
                    chat_txt.Text = null;
                }

                if (ChatCounter == 7)
                {
                    t8.Text = chat_txt.Text;
                    ChatCounter = 8;
                    t8.Visible = true;
                    p8.Visible = true;
                    chat_txt.Text = null;
                }

                if (ChatCounter == 6)
                {
                    t7.Text = chat_txt.Text;
                    ChatCounter = 7;
                    t7.Visible = true;
                    p7.Visible = true;
                    chat_txt.Text = null;
                }

                if (ChatCounter == 5)
                {
                    t6.Text = chat_txt.Text;
                    ChatCounter = 6;
                    t6.Visible = true;
                    p6.Visible = true;
                    chat_txt.Text = null;
                }

                if (ChatCounter == 4)
                {
                    t5.Text = chat_txt.Text;
                    ChatCounter = 5;
                    t5.Visible = true;
                    p5.Visible = true;
                    chat_txt.Text = null;
                }

                if (ChatCounter == 3)
                {
                    t4.Text = chat_txt.Text;
                    ChatCounter = 4;
                    t4.Visible = true;
                    p4.Visible = true;
                    chat_txt.Text = null;
                }

                if (ChatCounter == 2)
                {
                    t3.Text = chat_txt.Text;
                    ChatCounter = 3;
                    t3.Visible = true;
                    p3.Visible = true;
                    chat_txt.Text = null;
                }

                if (ChatCounter == 1)
                {
                    t2.Text = chat_txt.Text;
                    ChatCounter = 2;
                    t2.Visible = true;
                    p2.Visible = true;
                    chat_txt.Text = null;
                }

                if (ChatCounter == 0)
                {
                    t1.Text = chat_txt.Text;
                    ChatCounter = 1;
                    t1.Visible = true;
                    p1.Visible = true;
                    chat_txt.Text = null;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageMenu home_form = new HomePageMenu();
            home_form.ShowDialog();
            this.Close();
        }
    }
}
