using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a =int.Parse( textBox1.Text);
            if( a==123456)
                MessageBox.Show("欢迎" + (Char)13 + "光临");
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
