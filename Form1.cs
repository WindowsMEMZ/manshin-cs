//Create by WindowsMEMZ
//Edit by WindowsMEMZ

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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
            public static int regReEnter; //登录相关

            public static bool keyWDown;
            public static bool keyADown;
            public static bool keySDown;
            public static bool keyDDown;
            public static bool keyEDown; //按键变量

            public static int form1x;
            public static int form1y; //记录form1的坐标

            public static string realName;
            public static string idNumber;
            public static bool isAdult;
            public static bool isVerify; //实名认证相关

            public static int arrowR;
            public static int arrowG;
            public static int arrowB;
            public static bool isSSRNone; //攻击、怪物系统相关

            public static string tipText;
            public static string tipTitle; //提示窗口相关
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("./tmp"))
            {
                Directory.CreateDirectory("./tmp");
            } //创建缓存文件夹

            if (INIHelper.Read("ID", "isAdult", "", "./config.ini") == "true")
            {
                common.isAdult = true;
            }
            else
            {
                if (INIHelper.Read("ID", "isAdult", "", "./config.ini") == "false")
                {
                    common.isAdult = false;
                }
            } //读取实名信息，判断是否成年

            common.uid = INIHelper.Read("User", "uid", "", "./config.ini"); //读取UID并写入到变量

            common.isSSRNone = false; //初始化此变量
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Setting form = new Setting();
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show(); //打开“设置”界面
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

        //时钟1，2，3控制开始时的“芒神”以及“Darock Studio”的显示与隐藏

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

            if (common.loginDone == 1)
            {
                timer6.Enabled = true;
            }

            if (common.regReEnter == 1)
            {
                common.regReEnter = 0;
                Login form = new Login();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }

            if (progressBar1.Value == 100)
            {
                INIHelper.Write("Version", "music", INIHelper.Read("Version", "music", "", "./tmp/version.ini"), "./version.ini");
                INIHelper.Write("Version", "all", INIHelper.Read("Version", "all", "", "./tmp/version.ini"), "./version.ini");
                label2.Text = "正在加载文件...";
                Thread.Sleep(400);
                label4.Visible = true;
                progressBar1.Visible = false;
                label2.Visible = false;
            }

            if (label3.Visible == true)
            {
                timer6.Enabled = false;
                common.loginDone = 0;
            }

            if (common.isVerify == true)
            {
                common.isVerify = false;
                LoadStart();
            }

            progressBar3.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 13);
            progressBar3.Size = new Size(pictureBox6.Size.Width, progressBar3.Size.Height);

            if (common.arrowR >= 250)
            {
                timer10.Enabled = false;
                label8.Visible = false;
            }

            if (progressBar3.Value == 0)
            {
                pictureBox6.Visible = false;
                progressBar3.Visible = false;
                common.isSSRNone = true;
            }

            if (pictureBox6.Location.X - pictureBox2.Location.X > -48 && pictureBox6.Location.X - pictureBox2.Location.X < 448 && pictureBox6.Location.Y - pictureBox2.Location.Y > -48 && pictureBox6.Location.Y - pictureBox2.Location.Y < 608) //距离怪物近时开启时钟
            {
                timer12.Enabled = true;
            }
            label6.Text = progressBar2.Value.ToString() + "/10000";
            if (common.isSSRNone == true)
            {
                Random random = new Random();
                int intervTime = random.Next(1000, 10000);
                timer13.Interval = intervTime;
                timer13.Enabled = true;
            }

            common.form1x = this.Location.X;
            common.form1y = this.Location.Y; //写入窗口位置

            if (progressBar3.Value <= 300)
            {
                progressBar3.ForeColor = Color.Red;
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

        private void timer6_Tick(object sender, EventArgs e) //检查更新
        {
            common.loginDone = 0;
            timer6.Enabled = false;

            if (INIHelper.Read("ID", "isDone", "false", "./config.ini") == "true") //实名认证相关
            {
                LoadStart();
                common.realName = INIHelper.Read("ID", "realName", "", "./config.ini");
                common.idNumber = INIHelper.Read("ID", "idNumber", "", "./config.ini");
            }
            else
            {
                if (common.uid == "0")
                {
                    LoadStart();
                }
                else
                {
                    id form = new id();
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog();
                }
            }
        }

        private void LoadStart()
        {
            progressBar1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox4.Visible = true;
            label11.Text = INIHelper.Read("Username", common.uid, "", "./tmp/user.ini") + "，欢迎进入游戏";
            label11.Visible = true;
            timer17.Enabled = true;

            Thread.Sleep(1000);
            label2.Text = "正在获取更新...";
            Thread.Sleep(400);
            if (INIHelper.Read("Version", "music", "", "./tmp/version.ini") == INIHelper.Read("Version", "music", "", "./version.ini"))
            {
                label2.Text = "正在加载文件...";
                Thread.Sleep(400);
                label4.Visible = true;
                progressBar1.Visible = false;
                label2.Visible = false;
            }
            else
            {
                progressBar1.Value = 100;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (label4.Visible == true)
            {
                LoadGame();
            }
        }

        private void LoadGame() //尝试载入游戏界面
        {
            if (common.isAdult == false) //判断是否成年
            { //如果未成年
                string week = string.Empty;
                switch ((int)DateTime.Now.DayOfWeek) //判断星期
                {
                    case 0:
                        week = "7";
                        break;

                    case 1:
                        week = "1";
                        break;

                    case 2:
                        week = "2";
                        break;

                    case 3:
                        week = "3";
                        break;

                    case 4:
                        week = "4";
                        break;

                    case 5:
                        week = "5";
                        break;

                    default:
                        week = "6";
                        break;
                }
                if (int.Parse(week) >= 5) //周五、周六、周日可玩
                {
                    if (DateTime.Now.Hour >= 20 && DateTime.Now.Hour <= 21) //判断时间是否在8点到9点之间
                    {
                        IntoGame(); //载入游戏界面
                    }
                    else //时间未到
                    {
                        common.tipTitle = "提示";
                        common.tipText = "亲爱的玩家，根据国家新闻出版署发布的《关于防止未成年人沉迷网络游戏的通知》《关于进一步严格管理 切实防止未成年人沉迷网络游戏的通知》，未成年玩家仅可在周五、周六、周日和法定节假日每日的20时至21时登录游戏。请合理安排游戏时间，注意休息。";
                        TipWindow form = new TipWindow();
                        form.StartPosition = FormStartPosition.CenterParent;
                        form.ShowDialog();
                    }
                }
                else //不为周五、周六、周日
                {
                    common.tipTitle = "提示";
                    common.tipText = "亲爱的玩家，根据国家新闻出版署发布的《关于防止未成年人沉迷网络游戏的通知》《关于进一步严格管理 切实防止未成年人沉迷网络游戏的通知》，未成年玩家仅可在周五、周六、周日和法定节假日每日的20时至21时登录游戏。请合理安排游戏时间，注意休息。";
                    TipWindow form = new TipWindow();
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog();
                }
            }
            else //如果已成年
            {
                IntoGame();
            }
        }

        private void IntoGame()
        {
            IntoLoading form = new IntoLoading();
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();

            //点击开始等组件不显示
            label3.Visible = false;
            label4.Visible = false;
            pictureBox4.Visible = false;

            //显示各种内容
            button1.Visible = true;
            button2.Visible = true;
            label5.Visible = true;
            progressBar2.Value = int.Parse(INIHelper.Read("PlayerInfo", "blood", "10000", "./config.ini"));
            progressBar2.Visible = true;
            label6.Visible = true;
            PicTran.ControlTrans(pictureBox2, Properties.Resources.manshinplayer);
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            progressBar3.Visible = true;
            label7.Visible = true;
            roundButton1.Visible = true;

            timer11.Enabled = true;
            timer16.Enabled = true; //开始检测网络是否连接

            if (INIHelper.Read("PlayerInfo", "isFirstPlay", "true", "./config.ini") == "true")
            {
                NewPlayerStudy(); //载入新手教程
            }
        }

        private void NewPlayerStudy()
        {
            label10.Text = "使用W,S,A,D移动";
            label10.Visible = true;
            timer15.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(e.KeyCode);
            switch (e.KeyValue)
            {
                case 'W':
                    if (common.keyWDown == false)
                        common.keyWDown = true;             // 按键"W"按下此标志为true，直到放开
                    break;

                case 'A':
                    if (common.keyADown == false)
                        common.keyADown = true;            // 按键"A"按下此标志为true，直到放开
                    break;

                case 'S':
                    if (common.keySDown == false)
                        common.keySDown = true;            // 按键"S"按下此标志为true，直到放开
                    break;

                case 'D':
                    if (common.keyDDown == false)
                        common.keyDDown = true;            // 按键"D"按下此标志为true，直到放开
                    break;

                case 'E':
                    if (common.keyEDown == false)
                        common.keyEDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 'W':
                    common.keyWDown = false;           // 按键"W"放开此标志为false
                    break;

                case 'A':
                    common.keyADown = false;          // 按键"A"放开此标志为false
                    break;

                case 'S':
                    common.keySDown = false;          // 按键"S"放开此标志为false
                    break;

                case 'D':
                    common.keyDDown = false;          // 按键"D"放开此标志为false
                    break;

                case 27:
                    Menu form = new Menu();
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog();
                    break;

                case 'E':
                    common.keyEDown = false;
                    break;
            }
        }

        private void timer7_Tick(object sender, EventArgs e) //时钟判断按键被按下
        {
            if (common.keyWDown == true)
            {
                pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 4);
                pictureBox3.Size = new Size(pictureBox3.Width + 4, pictureBox3.Height + 4);
                pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 4);
                pictureBox6.Size = new Size(pictureBox6.Width + 4, pictureBox6.Height + 4);
            }
            if (common.keySDown == true)
            {
                pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 4);
                pictureBox3.Size = new Size(pictureBox3.Width - 4, pictureBox3.Height - 4);
                pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 4);
                pictureBox6.Size = new Size(pictureBox6.Width - 4, pictureBox6.Height - 4);
            }
            if (common.keyADown == true)
            {
                pictureBox3.Location = new Point(pictureBox3.Location.X + 8, pictureBox3.Location.Y);
                pictureBox6.Location = new Point(pictureBox6.Location.X + 8, pictureBox6.Location.Y);
            }
            if (common.keyDDown == true)
            {
                pictureBox3.Location = new Point(pictureBox3.Location.X - 8, pictureBox3.Location.Y);
                pictureBox6.Location = new Point(pictureBox6.Location.X - 8, pictureBox6.Location.Y);
            }
            if (common.keyEDown == true)
            {
                if (pictureBox6.Location.X - pictureBox2.Location.X > -48 && pictureBox6.Location.X - pictureBox2.Location.X < 448 && pictureBox6.Location.Y - pictureBox2.Location.Y > -48 && pictureBox6.Location.Y - pictureBox2.Location.Y < 608) //攻击
                {
                    Debug.WriteLine("攻击");
                    if (progressBar3.Value > 0)
                    {
                        progressBar3.Value -= 2;
                        label8.Location = new Point(pictureBox6.Location.X + pictureBox6.Size.Width + 5, pictureBox6.Location.Y + 20);
                        label8.Visible = true;
                        common.arrowR = 0;
                        common.arrowG = 0;
                        common.arrowB = 0;
                        timer10.Enabled = true;
                        pictureBox7.Location = new Point(pictureBox6.Location.X - 10, pictureBox6.Location.Y + 5);
                        PicTran.ControlTrans(pictureBox7, Properties.Resources.arrow);
                        pictureBox7.Visible = true;
                        timer14.Enabled = true;
                    }
                }
            }
        }

        private void PingTest()
        {
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            PingTest();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            Form1_KeyDown(sender, e);
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            Form1_KeyUp(sender, e);
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            Form1_KeyDown(sender, e);
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            Form1_KeyUp(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AgeTip form = new AgeTip();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            INIHelper.Write("PlayerInfo", "blood", progressBar2.Value.ToString(), "./config.ini");

            if (File.Exists("./config.ini") == true)
            {
                //System.IO.File.Copy("./config.ini", "./tmp/config" + common.uid + ".ini", true);
                //FtpHelper.UploadFile("./tmp/", "config" + common.uid + ".ini");
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            label8.Location = new Point(label8.Location.X, label8.Location.Y - 2);
            label8.ForeColor = Color.FromArgb(common.arrowR, common.arrowG, common.arrowB);
            common.arrowR += 20;
            common.arrowG += 20;
            common.arrowB += 20;
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            //if (pictureBox6.Location.X > pictureBox2.Location.X && pictureBox6.Location.X - pictureBox2.Location.X < 300 && pictureBox6.Location.X - pictureBox2.Location.X > -300)
            //{
            //    pictureBox6.Location = new Point(pictureBox2.Location.X - 4, pictureBox6.Location.Y);
            //}
            //else
            //{
            //    if (pictureBox6.Location.X < pictureBox2.Location.X && pictureBox6.Location.X - pictureBox2.Location.X < 300 && pictureBox6.Location.X - pictureBox2.Location.X > -300)
            //    {
            //        pictureBox6.Location = new Point(pictureBox2.Location.X + 4, pictureBox6.Location.Y);
            //    }
            //}
            //if (pictureBox6.Location.Y > pictureBox2.Location.Y && pictureBox6.Location.Y - pictureBox2.Location.Y < 300 && pictureBox6.Location.Y - pictureBox2.Location.Y > -300)
            //
            //    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 4);
            //}
            //else
            //{
            //    if (pictureBox6.Location.Y < pictureBox2.Location.Y && pictureBox6.Location.Y - pictureBox2.Location.Y < 300 && pictureBox6.Location.Y - pictureBox2.Location.Y > -300)
            //    {
            //        pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 4);
            //    }
            //}
        }

        private void timer12_Tick(object sender, EventArgs e) //怪物攻击玩家
        {
            if (pictureBox6.Visible == true)
            {
                progressBar2.Value -= 2;
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            progressBar3.Value = 1000;
            progressBar3.Visible = true;
            pictureBox6.Visible = true;
            common.isSSRNone = false;
            timer13.Enabled = false;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Map form = new Map();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void roundButton1_KeyDown(object sender, KeyEventArgs e)
        {
            Form1_KeyDown(sender, e);
        }

        private void roundButton1_KeyUp(object sender, KeyEventArgs e)
        {
            Form1_KeyUp(sender, e);
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            timer14.Enabled = false;
            pictureBox7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            News form = new News();
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            label10.Visible = false;
            INIHelper.Write("PlayerInfo", "isFirstPlay", "false", "./config.ini");
            timer15.Enabled = false;
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            if (Networkconnect.IsConnectedInternet() == false)
            {
                ReconnectServer form = new ReconnectServer();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            timer17.Enabled = false;
            label11.Visible = false;
        }
    }
}