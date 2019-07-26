using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 碰撞模拟
{
    public partial class Form1 : Form
    {
        int centerX = 50;
        int centerY = 50;
        int radius = 20;
        Point speed = new Point(0, 5);

        Brush brush = new SolidBrush(Color.Red);

        public Form1()
        {
            InitializeComponent();            
        }
        
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        void DrawBall(Graphics g)
        {
            g.FillEllipse(brush, new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius));
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            int panelWidth = panel1.Size.Width;
            int panelHeight = panel1.Size.Height;

            
            //碰撞到四壁后改变方向 即speed
            if (centerX<radius || centerX > panelWidth - radius)
            {
                speed.X = -speed.X;
            }
            if(centerY<radius || centerY>panelHeight-radius)
            {
                speed.Y = -speed.Y;
            }
            if (checkBox1.Checked == true && centerY< panelHeight-radius)
            {
                speed.Y += (int)(2 * timer1.Interval / 100);
            }

            centerX += speed.X;
            centerY += speed.Y;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawBall(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speed.X =(int)numericUpDown1.Value;
            speed.Y =(int)numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            speed.X = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            speed.Y = (int)numericUpDown2.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
