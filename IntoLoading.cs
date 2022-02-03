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
    public partial class IntoLoading : Form
    {
        public IntoLoading()
        {
            InitializeComponent();
        }

        private void IntoLoading_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.common.form1x + 8, Form1.common.form1y + 30);
            this.TopMost = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            timer1.Interval = random.Next(100, 500);
            if (progressBar1.Value != 100)
            {
                progressBar1.Value += 5;
            }
            else
            {
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.common.form1x + 8, Form1.common.form1y + 30);
        }
    }
}