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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.common.form1x, Form1.common.form1y);
            label1.Text = INIHelper.Read("Username", Form1.common.uid, "", "./tmp/user.ini");
            label3.Text = INIHelper.Read("Level", Form1.common.uid, "", "./tmp/user.ini");
            label4.Text = "UID " + Form1.common.uid;
        }

        private void Menu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Setting form = new Setting();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mail form = new Mail();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button8_Click(object sender, EventArgs e)
        {
        }
    }
}