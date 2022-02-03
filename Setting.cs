using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manshin
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.common.form1x + 8, Form1.common.form1y + 30);
            this.TopMost = true;
            if (Form1.common.uid == "1")
            {
                button4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            UpdateLog form = new UpdateLog();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            About form = new About();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            ScreenSetting form = new ScreenSetting();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            NetworkSetting form = new NetworkSetting();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void roundButton1_MouseDown(object sender, MouseEventArgs e)
        {
            roundButton1.ImageNormal = Properties.Resources.CloseTap;
        }

        private void roundButton1_MouseEnter(object sender, EventArgs e)
        {
            roundButton1.ImageNormal = Properties.Resources.CloseChoose;
        }

        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            roundButton1.ImageNormal = Properties.Resources.CloseNormal;
        }

        private void roundButton1_MouseUp(object sender, MouseEventArgs e)
        {
            roundButton1.ImageNormal = Properties.Resources.CloseNormal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.common.form1x + 8, Form1.common.form1y + 30);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            Developer form = new Developer();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}