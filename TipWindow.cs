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
    public partial class TipWindow : Form
    {
        public TipWindow()
        {
            InitializeComponent();
        }

        private void TipWindow_Load(object sender, EventArgs e)
        {
            if (Form1.common.tipText != "" || Form1.common.tipText != null && Form1.common.tipTitle != "" || Form1.common.tipTitle != null) //确定标题和内容不为空
            {
                label1.Text = Form1.common.tipTitle;
                textBox1.Text = Form1.common.tipText; //设置标题和内容
            }
            else
            {
                this.Close(); //如果有一项为空立刻关闭窗口
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}