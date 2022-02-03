//Create by WindowsMEMZ 2022/01/14
//Edit by WindowsMEMZ 2022/01/14

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
    public partial class id : Form
    {
        public id()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://http.darock.tk:55550/ms/privacy.html");
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

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.OKTap;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.OKChoose;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.OKNormal;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.OKNormal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 2 && textBox1.Text.Length < 20)
            {
                if (textBox2.Text.Length == 18)
                {
                    IDCardValidation card = new IDCardValidation();
                    if (card.CheckIDCard(textBox2.Text))
                    {
                        INIHelper.Write("ID", "realName", textBox1.Text, "./config.ini");
                        INIHelper.Write("ID", "idNumber", textBox2.Text, "./config.ini");
                        INIHelper.Write("ID", "isDone", "true", "./config.ini");

                        string birthNumber = textBox2.Text;
                        birthNumber = birthNumber.Remove(0, 6);
                        birthNumber = birthNumber.Substring(0, birthNumber.Length - 4);

                        string birthYear = birthNumber.Substring(0, birthNumber.Length - 4);
                        if (int.Parse(birthYear) > 2003)
                        {
                            Form1.common.isAdult = false;
                            INIHelper.Write("ID", "isAdult", "false", "./config.ini");
                        }
                        else
                        {
                            Form1.common.isAdult = true;
                            INIHelper.Write("ID", "isAdult", "true", "./config.ini");
                        }
                        Form1.common.isVerify = true;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("身份证号有误，请检查身份证号!", "错误");
                    }
                }
                else
                {
                    MessageBox.Show("身份证号有误，请检查身份证号!", "错误");

                }
            }
            else
            {
                MessageBox.Show("姓名有误，请输入真实姓名!", "错误");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 && (int)e.KeyChar != 8) || ((int)e.KeyChar > 57))
            {
                e.Handled = true;

            }
            
        }

        private void id_Load(object sender, EventArgs e)
        {
            //MARK: 测试代码
            //Debug.WriteLine();
        }
    }
}
