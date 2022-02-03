//Create by WindowsMEMZ
//Edit by WindowsMEMZ

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace manshin
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mail_Load(object sender, EventArgs e)
        {
            int totalLoopTimes = int.Parse(INIHelper.Read(Form1.common.uid, "mailsNum", "0", "./tmp/mail.ini"));
            int nowLoopTimes = 0;

            while (nowLoopTimes < totalLoopTimes)
            {
                listBox1.Items.Add(INIHelper.Read(Form1.common.uid, "title" + nowLoopTimes, "", "./tmp/mail.ini"));
                nowLoopTimes++;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(listBox1.SelectedItem);
            //textBox1.Text = INIHelper.Read(Form1.common.uid, "message" + (listBox1.SelectedItem + 1), "", "./tmp/mail.ini");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.CloseTap;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.CloseChoose;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.CloseNormal;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.CloseNormal;
        }
    }
}
