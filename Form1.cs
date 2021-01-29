using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 幸运者抽奖
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //定义动态数组
        ArrayList myName = new ArrayList();
        int i;
        string input;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i==myName.Count)
            {
                i = 0;
            }
                this.txLuck.Text = myName[i].ToString();
                i++;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            MessageBox.Show(this.txLuck.Text+"\n中奖了！");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myName.Add("梁国兵");myName.Add("刘智杰");myName.Add("王晨骅");myName.Add("陈心乐");
            myName.Add("金垚灿");myName.Add("杨旭");myName.Add("刘泳伸"); myName.Add("彭智强");
            myName.Add("彭耀德");myName.Add("彭辛荑");myName.Add("周博涵");myName.Add("李蔚");
            myName.Add("刘念祖");myName.Add("李玉");myName.Add("漆香");myName.Add("邓湘晴");
            myName.Add("廖安琪");myName.Add("罗震宇");myName.Add("王韦诺");myName.Add("刘念祖"); myName.Add("周黎晓珂");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //refreash
            //this.richTextBox_show.Clear();
            foreach (object name in myName)
            {
                this.richTextBox_show.Text += name + "  ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add
            input = this.tx_input.Text;
           myName.Add(input);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.richTextBox_show.Text = "";
            myName.Remove(input);
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("制作者:vapts\n欢迎使用本程序！\n\n赌狗赌狗，赌到最后一无所有");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.lb_systemtime.Text = DateTime.Now.ToString();
        }
    }
}
