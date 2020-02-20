///-----------------------------------------------------------------------------------------------------------------///
//|	Name: Gerad Paris											                                                    |//
//|	Due Date: 01/28/2020										                                                    |//
//|	Instructor: Steven MacNaughton  							                                                    |//
//| Purpose: Using the given form, we will create a program that will update the position of the ball based on      |//
//|          variables passed into the program, and the gravity acceleration of Earth (-9.8 m/s^2). The program will|//
//|          calculate the total pixel distance of the drop, the pixel acceleration, the pixel drop distance at each|//
//|          time inverval, and then the final velocity and total time of the drop in real world units (Meters &    |//
//|          Seconds)                                                                                               |//
///-----------------------------------------------------------------------------------------------------------------///
///Progress:
///
/// 01/24/2020-------------------------------------------------------------------------------------------------------->
/// + Wrote program description
/// + Wrote public variables
/// + Completed Begin_Click functionality
/// + Completed myClock_Tick functionality
/// + Completed Restart_Click finctionality
/// 01/25/2020-------------------------------------------------------------------------------------------------------->
/// + Fixed if statement check to calculate proper values

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1___Accel.due_to_gravity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Your Code Here
        double meters, vf, vi, y;           // Real world values
        double a = -9.8;                    // Accel due to gravity

        double pxDrop, pxa, px, py;         // Screen variables
        double timeInterval, timeElapsed;   // Time variables

        private void Begin_Click(object sender, EventArgs e)
        {
            // Your Code here
            // Initializing values
            meters = Convert.ToDouble(txtDistance.Text);

            pxDrop = pnlDrawing.Height;  // How far the ball will drop in pixels
            pxa = 9.8 * (pxDrop / meters);                  // Acceleration in pixel values
            px = pnlSample.Location.X;
            py = 0;
            timeInterval = myClock.Interval / 1000.0;   // Convert interval to MS
            timeElapsed = 0;
            myClock.Enabled = true;
            Begin.Visible = false;
        }

        private void myClock_Tick(object sender, EventArgs e)
        {
            // Your Code here
            double dy;
            dy = 0.5 * pxa * Math.Pow(timeElapsed, 2);
            pnlSample.Location = new Point(Convert.ToInt32(px), Convert.ToInt32(dy));

            if(pxDrop - pnlSample.Height < dy)
            {
                lblResults.Visible = true;
                pnlSample.Location = new Point(Convert.ToInt32(px), Convert.ToInt32(pxDrop - pnlSample.Height));
                lblResults.Text = "Final velocity of the ball: " + Convert.ToString(Math.Round(- 9.8 * timeElapsed, 1)) + "m/s";
                lblResults.Text += "\nTime taken to reach the ground: " + Convert.ToString(Math.Round(timeElapsed,1)) + "s";
                myClock.Enabled = false;
                Restart.Visible = true;
            }
            else
            {
                timeElapsed += timeInterval;
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            // Your Code here
            pnlSample.Location = new Point(Convert.ToInt32(px), 0);
            timeElapsed = 0;
            lblResults.Visible = false;
            Restart.Visible = false;
            Begin.Visible = true;
        }

        public int ReadInputFactor(TextBox a, ref double input)
        {
            try
            {
                input = Convert.ToDouble(a.Text);
            }
            catch
            {
                return 1;
            }
            return 0;
        }
        
    }
}
