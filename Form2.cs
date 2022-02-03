using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows.Forms;

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
            label5.Visible = true;
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            try
            {
                webClient.DownloadFile("http://http.mgmango.tk:55550/ms/file/user.ini", Application.StartupPath + "\\tmp\\user.ini");
                webClient.DownloadFile("http://http.mgmango.tk:55550/ms/file/mail.ini", Application.StartupPath + "\\tmp\\mail.ini");
                webClient.DownloadFile("http://http.mgmango.tk:55550/ms/file/version.ini", Application.StartupPath + "\\tmp\\version.ini"); //下载所需的文件
            }
            catch (Exception err)
            {
                MessageBox.Show("网络错误，错误详情：" + err.Message + "。请稍后重试");
                Application.Exit();
                throw err; //网络错误时弹出窗口并关闭程序
            }

            if (textBox1.Text == "0")
            {
                Form1.common.uid = textBox1.Text;
                INIHelper.Write("User", "uid", textBox1.Text, "./config.ini");
                Form1.common.password = textBox2.Text;
                Form1.common.loginDone = 1;
            }
            else
            {
                Debug.WriteLine(MD5.GetMD5(textBox2.Text));
                if (MD5.GetMD5(textBox2.Text) == INIHelper.Read("Password", textBox1.Text, "", "./tmp/user.ini"))
                {
                    Form1.common.uid = textBox1.Text;
                    INIHelper.Write("User", "uid", textBox1.Text, "./config.ini");
                    Form1.common.password = textBox2.Text;
                    Form1.common.loginDone = 1;
                }
                else
                {
                    LoginError form = new LoginError();
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog();
                }
            }
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Text = INIHelper.Read("User", "uid", "", "./config.ini");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("1");
            System.Diagnostics.Process.Start("explorer.exe", "http://http.darock.tk:55550/ms/privacy.html");
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}