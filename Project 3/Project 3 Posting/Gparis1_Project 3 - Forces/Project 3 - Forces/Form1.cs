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
        double parseOut;

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
            vectors[0, n] = force * Math.Cos(ConvertDegToRad(theta));
            vectors[1, n] = force * Math.Sin(ConvertDegToRad(theta));
            used[n] = true;
        }


        private void txtWeight_TextChanged_1(object sender, EventArgs e)
        {
            SetVals(0);
        }

        private void txtMag1_TextChanged_1(object sender, EventArgs e)
        {
            SetVals(1);
        }

        private void txtDeg1_TextChanged_1(object sender, EventArgs e)
        {
            SetVals(1);
        }

        private void txtMag2_TextChanged_1(object sender, EventArgs e)
        {
            SetVals(2);
        }

        private void txtDeg2_TextChanged_1(object sender, EventArgs e)
        {
            SetVals(2);
        }

        private void txtMag3_TextChanged_1(object sender, EventArgs e)
        {
            SetVals(3);
        }

        private void txtDeg3_TextChanged_1(object sender, EventArgs e)
        {
            SetVals(3);
        }

        private void txtMag4_TextChanged_1(object sender, EventArgs e)
        {
            SetVals(4);
        }

        private void txtDeg4_TextChanged_1(object sender, EventArgs e)
        {
            SetVals(4);
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

        private void SetVals(int index)
        {
            switch(index)
            {
                case 0: // weight force
                    if (double.TryParse(txtWeight.Text, out parseOut))    // Check if the value in the holder is a double
                    {
                        addToVectors(Convert.ToDouble(txtWeight.Text)/0.2248, 270, index); // Pass to function to store values in cartesian (converts lbs to neutons beforehand)
                        SetVals(5); // set total vector
                        lblPoundsPolar.Text = "(" + Convert.ToString(Math.Abs(Math.Round(vectors[1, 0]))) + "N @ 270 degrees)";
                    }
                    break;
                case 1: // Force 1
                    if (double.TryParse(txtMag1.Text, out parseOut))    // Check if the value in the holder is a double
                    {
                        if (double.TryParse(txtDeg1.Text, out parseOut))// Another check for if the value is a double
                        {
                            addToVectors(Convert.ToDouble(txtMag1.Text), Convert.ToDouble(txtDeg1.Text), index); // Pass to function to store values in cartesian
                            SetVals(5); // set total vector
                        }
                    }
                    break;
                case 2: // force 2
                    if (double.TryParse(txtMag2.Text, out parseOut))    // Check if the value in the holder is a double
                    {
                        if (double.TryParse(txtDeg2.Text, out parseOut))// Another check for if the value is a double
                        {
                            addToVectors(Convert.ToDouble(txtMag2.Text), Convert.ToDouble(txtDeg2.Text), index); // Pass to function to store values in cartesian
                            SetVals(5); // set total vector
                        }
                    }
                    break;
                case 3: // force 3
                    if (double.TryParse(txtMag3.Text, out parseOut))    // Check if the value in the holder is a double
                    {
                        if (double.TryParse(txtDeg3.Text, out parseOut))// Another check for if the value is a double
                        {
                            addToVectors(Convert.ToDouble(txtMag3.Text), Convert.ToDouble(txtDeg3.Text), index); // Pass to function to store values in cartesian
                            SetVals(5); // set total vector
                        }
                    }
                    break;
                case 4: // force 4
                    if (double.TryParse(txtMag4.Text, out parseOut))    // Check if the value in the holder is a double
                    {
                        if (double.TryParse(txtDeg4.Text, out parseOut))// Another check for if the value is a double
                        {
                            addToVectors(Convert.ToDouble(txtMag4.Text), Convert.ToDouble(txtDeg4.Text), index); // Pass to function to store values in cartesian
                            SetVals(5); // set total vector
                        }
                    }
                    break;
                case 5: // Net force
                    for(int i = 0; i < 5; i++)  // for each force
                    {
                        if(used[i]) // check if force is being used
                        {
                            vectors[0, index] += vectors[0, i]; // add x force value to total
                            vectors[1, index] += vectors[1, i]; // add y force value to total
                        }
                    }
                    used[index] = true;
                    lblNet.Text = "Net Force: " + Convert.ToString(Math.Abs(Math.Round(vectors[1, 0])))

                    pnlDrawing.Invalidate();    // Update canvas drawing
                    break;
                case 6: // Acceleration
                    
                    break;
                default:    // invalid value passed
                    break;
            }
        }

        private double ConvertDegToRad(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        private double GetMag(int index)
        {
            return Math.Round(Math.Sqrt(vectors[0,index] + vectors[1,index]));
        }
    }
}
