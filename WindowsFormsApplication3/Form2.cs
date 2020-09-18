using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        int price;
        public Form2()

        {
            InitializeComponent();
            
        }

        private void 鱼香肉丝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("鱼香肉丝28元", "请点菜", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                listBox1.Items.Add(鱼香肉丝ToolStripMenuItem.Text);
                price = price + 28;
                label1.Text = "您本次消费的总价钱：" + price.ToString() + "\n" + "全体员工祝您开心用餐！";
            }
        }

        private void 宫保鸡丁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("宫保鸡丁26元", "请点菜", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {

                listBox1.Items.Add(宫保鸡丁ToolStripMenuItem.Text);
                price = price + 26;
                label1.Text = "您本次消费的总价钱：" + price.ToString() + "\n" + "全体员工祝您开心用餐！";

            }
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            label1.Text = "";
        }

        private void 文本字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fontDialog1.Font = textBox1.Font;



            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.Font = fontDialog1.Font;


            }
        }

        private void 文本颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = textBox1.ForeColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {



                textBox1.ForeColor = colorDialog1.Color;

            }
        }

        private void 点菜系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            label1.Visible = true;
            textBox1.Visible = false;
            webBrowser1.Visible = false;

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
           
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = colorDialog1.Color;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            webBrowser1.Visible = false;
        }

        private void 文本设计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            label1.Visible = false;
            textBox1.Visible = true;
            webBrowser1.Visible = false;
        }

        private void 浏览器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             listBox1.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            webBrowser1.Visible = true;
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            listBox1.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            webBrowser1.Visible = false;
            Form1 d = new Form1();
            d.Show();
            this.Hide();
        }

        private void 清空ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void 看烟花ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        }
    }

