using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3___Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int NVECTORS = 6;
        const int INPUTERROR = -999;
        double[,] vectors = new double[2,6];
        bool[] used = new bool[6] {false, false, false, false, false, false };
        System.Drawing.Color[] colour = new System.Drawing.Color[6] {Color.Green, Color.Blue, Color.Red, Color.Indigo, Color.Brown, Color.Black};
        double weight = 0, angle = 0, secs = 0;
        bool clearing = false;

        private double ConvertToDouble(String text, String errorMsg)
        {
            try
            {
                double local = Convert.ToDouble(text);
                return local;
            }
            catch 
			{
                MessageBox.Show("Invalid entry for " + errorMsg);
                return -999;
            }
            }

        private void UpdateAll()
        {
           // Your Code Here
        }

        private void addToVectors(double force, double theta, int n)
        {
            vectors[0, n] = force * Math.Cos(theta * Math.PI / 180.0);
            vectors[1, n] = force * Math.Sin(theta * Math.PI / 180.0);
            used[n] = true;
        }


        private void txtWeight_TextChanged_1(object sender, EventArgs e)
        {
            vectors[]
            // Your Code Here
        }

        private void txtMag1_TextChanged_1(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void txtDeg1_TextChanged_1(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void txtMag2_TextChanged_1(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void txtDeg2_TextChanged_1(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void txtMag3_TextChanged_1(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void txtDeg3_TextChanged_1(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void txtMag4_TextChanged_1(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void txtDeg4_TextChanged_1(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void txtTime_TextChanged_1(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlDrawing_Paint(object sender, PaintEventArgs e)
        {
            double maxPxy = pnlDrawing.Width / 2 - 10; // Half the distance less 10
            int centreX = pnlDrawing.Width / 2;
            int centreY = pnlDrawing.Height / 2;
            double pixelFactor = 1;
            Point pt2 = new Point();
            Point pt1 = new Point(centreX, centreY);

            // To make sure they will fit, check for the longest in each direction
            double maxXY = 0;
            for (int i = 0; i < NVECTORS; i++)
            {
                if (used[i])
                {
                    if (Math.Abs(vectors[0, i]) > maxXY) maxXY = Math.Abs(vectors[0, i]);
                    if (Math.Abs(vectors[1, i]) > maxXY) maxXY = Math.Abs(vectors[1, i]);
                }
            }

            //Now determine the pixels/unit of force factor.

            pixelFactor = maxPxy / maxXY;

            // Draw the original weight - stored in vector 0.

            // Create rectangle.
            Rectangle rect = new Rectangle(0, 0, 200, 200);
            rect.X = centreX - 14;
            rect.Y = centreY - 8;
            rect.Width = 28;
            rect.Height = 16;
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.MediumSeaGreen);
            e.Graphics.FillRectangle(myBrush, rect);

            Pen thisPen = new Pen(Color.Black, 2.0f);

            for (int i = 0; i < NVECTORS; i++)
            {
                if (used[i])
                {
                    pt2.X = (int)Math.Round((vectors[0, i] * pixelFactor + centreX));
                    pt2.Y = pnlDrawing.Height - (int)Math.Round((vectors[1, i] * pixelFactor + centreY));
                    thisPen.Color = colour[i];
                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                    thisPen.CustomEndCap = bigArrow;
                    if (i == 5) thisPen.Width = 3.0f;
                    e.Graphics.DrawLine(thisPen, pt1, pt2);
                }
            }
        }

       
        private void button1_Click(System.Object  sender, System.EventArgs  e)
        {
            clearing = true;
            
            // Your Code Here


        }
    }
}
