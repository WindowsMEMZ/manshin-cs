using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace manshin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.CloseChoose;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.CloseNormal;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.CloseTap;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.CloseNormal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.LoginChoose;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.LoginNormal;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.LoginTap;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.LoginNormal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                Form1.common.uid = textBox1.Text;
                INIHelper.Write("User", "uid", textBox1.Text, "./config.ini");
                Form1.common.password = textBox2.Text;
                Form1.common.loginDone = 1;
            }
            else
            {
                if (MD5.GetMD5(textBox2.Text) == INIHelper.Read("Password", Form1.common.uid, "", "./tmp/user.ini"))
                {
                    Form1.common.uid = textBox1.Text;
                    INIHelper.Write("User", "uid", textBox1.Text, "./config.ini");
                    Form1.common.password = textBox2.Text;
                    Form1.common.loginDone = 1;
                }
                else
                {

                }
            }
        }
    }
}
