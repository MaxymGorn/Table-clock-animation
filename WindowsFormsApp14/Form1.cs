using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace WindowsFormsApp14
{//
    public partial class Form1 : Form
    {
        int a=180, b=170;
        Pen p3 = new Pen(Color.Red, 4);
        Point cp;
        Matrix m3;
        Matrix m4,m5;
        DateTime DateTime;
  
        public Form1()
        {
            InitializeComponent();
            p3 = new Pen(Color.Red,4);
            cp = new Point(a,b);
            m3 = new Matrix();
            m4 = new Matrix();
            m5 = new Matrix();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            DateTime= DateTime.Now;
            
            int s = DateTime.Second;
            float a3 = s*6;

            m3.RotateAt(a3, cp);
            graphics.Transform = m3;
            graphics.DrawLine(p3,a,b,a+100,b-140);
            m3.Reset();



            int m = DateTime.Minute;
            m4.RotateAt(21*m, cp);
            graphics.Transform = m4;
            graphics.DrawLine(new Pen(Color.Blue, 4), a, b, a + 100, b - 14);
            m4.Reset();

            int h = DateTime.Hour;
            m5.RotateAt(h * 24, cp);
            graphics.Transform = m5;
            graphics.DrawLine(new Pen(Color.Green, 4), a, b, a + 50, b - 7);
            m5.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
