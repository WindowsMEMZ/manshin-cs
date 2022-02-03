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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            label2.Width = 1;
            label5.Width = 1;
            label6.Width = 1;
            label7.Width = 1;

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Width < 174)
            {
                label2.Width += 4;
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label2.Width > 1)
            {
                label2.Width -= 4;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer4.Enabled = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            timer4.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(label5.Width < 82)
            {
                label5.Width += 4; 
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (label5.Width > 1)
            {
                label5.Width -= 4;
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            timer5.Enabled = true;
            timer6.Enabled = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            timer5.Enabled = false;
            timer6.Enabled = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (label6.Width < 88)
            {
                label6.Width += 4;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (label6.Width > 1)
            {
                label6.Width -= 4;
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            timer7.Enabled = true;
            timer8.Enabled = false;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            timer7.Enabled = false;
            timer8.Enabled = true;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (label7.Width < 174)
            {
                label7.Width += 4;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (label7.Width > 1)
            {
                label7.Width -= 4;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thanks form = new Thanks();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
