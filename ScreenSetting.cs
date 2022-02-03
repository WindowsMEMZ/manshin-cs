using System;
using System.Windows.Forms;

namespace manshin
{
    public partial class ScreenSetting : Form
    {
        public ScreenSetting()
        {
            InitializeComponent();
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

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScreenSetting_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}