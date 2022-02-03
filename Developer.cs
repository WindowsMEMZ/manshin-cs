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
    public partial class Developer : Form
    {
        public Developer()
        {
            InitializeComponent();
        }

        private void Developer_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.common.form1x + 8, Form1.common.form1y + 30);
            this.TopMost = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.common.form1x + 8, Form1.common.form1y + 30);
        }
    }
}