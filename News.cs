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
    public partial class News : Form
    {
        public News()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void News_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.common.form1x + 8, Form1.common.form1y + 30);
            this.TopMost = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.common.form1x + 8, Form1.common.form1y + 30);
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
    }
}