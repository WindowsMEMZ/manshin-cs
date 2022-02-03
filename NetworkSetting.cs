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
    public partial class NetworkSetting : Form
    {
        public NetworkSetting()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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