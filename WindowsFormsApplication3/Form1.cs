using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
      

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if(1>0)
            {
                this.ControlBox = false;
                System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
                player2.SoundLocation = "66.wav";
                player2.Load();
                player2.Play();
                
            }
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            this.button10.BackColor =System.Drawing.Color.White;
        }
        private void button10_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button10, "要显示的文字");

        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
                  ToolTip q = new ToolTip();
            q.ShowAlways = true;
            q.SetToolTip(this.button9, "要显示的文字");
           
        
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
        this.button9.BackColor =System.Drawing.Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);	
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = label2.Text.Substring(1) + label2.Text.Substring(0, 1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label3.Text = label3.Text.Substring(1) + label3.Text.Substring(0, 1);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label4.Text = label4.Text.Substring(1) + label4.Text.Substring(0, 1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Thread.Sleep(1000); 
            Form4 f = new Form4();
            f.Show();
            this.Hide();
            
        
           
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            Thread.Sleep(100); 
            this.BackgroundImage = Image.FromFile("tu2.PNG");
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            Thread.Sleep(100); 
            this.BackgroundImage = Image.FromFile("tu3.PNG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            Thread.Sleep(100); 
            this.BackgroundImage = Image.FromFile("tu4.PNG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            Thread.Sleep(100); 
            this.BackgroundImage = Image.FromFile("tu5.PNG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            Thread.Sleep(100); 
            this.BackgroundImage = Image.FromFile("tu6.PNG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            Thread.Sleep(100); 
            this.BackgroundImage = Image.FromFile("tu7.PNG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            Thread.Sleep(100); 
            this.BackgroundImage = Image.FromFile("tu8.PNG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void button9_MouseMove_1(object sender, MouseEventArgs e)
        {
            Thread.Sleep(100); 
            this.BackgroundImage = Image.FromFile("tu9.PNG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void button10_MouseMove_1(object sender, MouseEventArgs e)
        {
            Thread.Sleep(100); 
            this.BackgroundImage = Image.FromFile("tu10.PNG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        }
    
        
    }

