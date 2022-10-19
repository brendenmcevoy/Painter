using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painter
{
    public partial class PainterForm : Form
    {
        bool ShouldPaint { get; set; } = false;
        Color cr;
        int a = 0;
        int b = 0;
        public PainterForm()
        {
            InitializeComponent();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint)
            {
                using (Graphics graphics = canvas.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(cr), e.X, e.Y, a, b);
                }
            }
        }

        private void red_CheckedChanged(object sender, EventArgs e)
        {
             if (sender == red)
            {
                cr = Color.Red;
            }
        }

        private void blue_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == blue)
            {
                cr = Color.Blue;
            }
        }

        private void green_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == green)
            {
                cr = Color.Green;
            }
        }
        private void black_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == black)
            {
                cr = Color.Black;
            }
        }

        private void small_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == small)
            {
                a = 5;
                b = 5;
            }
        }

        private void medium_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == medium)
            {
                a = 10;
                b = 10;
            }
        }

        private void large_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == large)
            {
                a = 15;
                b = 15;
            }
        }
    }
}
