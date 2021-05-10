using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_space_arcanoid
{
    public partial class Form1 : Form
    {
        
        double sx = 17, sy = 12, bx, by, sin = 1, cos = 0;



        float LX, LY;
        bool BallIsBottom = true;

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                cos += 0.02;
            }
            if(e.KeyCode == Keys.Left)
            {
                sin -= 0.02;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

    

        public Form1()
        {
            InitializeComponent();
            bx = BallImg.Left;
            by = BallImg.Top;
            LX = panel1.Width / 2;
            LY = panel1.Height - 120;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double radius = (panel1.Height - 120);
            LX = (float)((panel1.Width / 2) + radius * Math.Cos(cos));
            LY = (float)((panel1.Height) - radius * Math.Sin(sin));
            bx += sx;
            by += sy;

            BallImg.Left = (int)bx;
            BallImg.Top = (int)by;


            if ((BallImg.Top + BallImg.Height >= panel1.Height)||(BallImg.Top <= 0))
            {
                sy *= -1;
            }
            if ((BallImg.Right >= panel1.Width)||(BallImg.Left <= 0))
            {
                sx *= -1;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;



            
            g.DrawLine(new Pen(Color.Black, 2), panel1.Width/2, panel1.Height, panel1.Width/2, panel1.Height-120);
            
        }
    }
}
