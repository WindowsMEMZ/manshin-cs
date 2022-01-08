using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;

namespace manshin
{
    public partial class Form1 : Form
    {
        public static class common //定义全局变量
        {
            public static int loginOpenWindow;
            public static string uid;
            public static string password;
            public static int loginDone;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            webClient.DownloadFile("https://fast.mgmango.tk:55558/ms/file/user.ini", Application.StartupPath + "\\tmp\\user.ini");
            webClient.DownloadFile("https://fast.mgmango.tk:55558/ms/file/mail.ini", Application.StartupPath + "\\tmp\\mail.ini");
            webClient.DownloadFile("https://fast.mgmango.tk:55558/ms/file/version.ini", Application.StartupPath + "\\tmp\\version.ini"); //下载所需的文件

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (label1.Visible == true)
            {
                timer2.Enabled = false;
            }

            if (common.loginOpenWindow == 1)
            {
                timer5.Enabled = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            common.loginOpenWindow = 1;
            Thread.Sleep(200);
            Login form = new Login();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
