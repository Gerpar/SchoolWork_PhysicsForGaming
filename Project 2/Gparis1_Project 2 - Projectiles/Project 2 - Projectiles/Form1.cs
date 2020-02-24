///-----------------------------------------------------------------------------------------------------------------///
//|	Name: Gerad Paris											                                                    |//
//|	Due Date: 02/23/2020										                                                    |//
//|	Instructor: Steven MacNaughton  							                                                    |//
//| Purpose: Program a simulation of a paintball shooting towards a wall, when the paintball hits the wall or the   |//
//|          floor, the paintabll should turn into a flattened splat agains the surface that it impacted. The       |//
//|          program will take in an initial velocity for the ball, the angle the ball will be fired at, and how far|//
//|          the wall is away from the firing point. All of the units will use a scale of meters / seconds. The     |//
//|          program will keep track of how many seconds have passed, and how far up the wall the ball hits if it   |//
//|          does land on the wall. If it doesn't, it will calculate how far the ball traveled instead.             |//
///-----------------------------------------------------------------------------------------------------------------///
///Progress:
///
/// 02/20/2020-------------------------------------------------------------------------------------------------------->
/// + Wrote project header
/// 02/22/2020-------------------------------------------------------------------------------------------------------->
/// + Created base functionality for button click (Launching ball)
/// ! Ball travels too slowly, will find fix later
/// 02/23/2020-------------------------------------------------------------------------------------------------------->
/// + Fixed bug with ball traveling too slowly (interval was using 10000 instead of 1000)
/// + Wrote "collision" checks with the wall and ground
/// + Made splats allign correctly with their new centre
/// + 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2___Projectiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Your Code Here
        double pxConvert;   // Equation for converting real world values to px values
        double vx, vy;  // Initial velocity
        double a;       // Acceleration
        double x, y;    // Distance traveled
        int px, py;  // Distance traveled (pixels)
        double timeInSeconds;   // Value for seconds per clock tick
        double timeElapsed; // Total time passed
        int initialHeight;  // Height the ball starts at

        private int ReadInput(TextBox a, ref double input)
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

        private void Fire_Click(object sender, EventArgs e)
        {
            double velocity = 0;
            double angle = 0;
            initialHeight = pnlDraw.Height - pnlSample.Height;

            if(ReadInput(txtSpeed, ref velocity) == 0 && ReadInput(txtAngle, ref angle) == 0 && ReadInput(txtDtoWall, ref x) == 0)   // Numbers were read successfuly
            {
                vx = velocity * Math.Cos((angle * (Math.PI / 180)));
                vy = velocity * Math.Sin((angle * (Math.PI / 180)));
                a = -9.8;   // Standard Earth gravity
                pxConvert = pnlDraw.Width / x;  // Value that converts real world to pixel values

                timeInSeconds = clock.Interval / 1000.0f;
                timeElapsed = 0;
                clock.Enabled = true;
            }

        }

        private void clock_Tick(object sender, EventArgs e)
        {
            x = vx * timeElapsed;
            y = vy * timeElapsed + (0.5 * a * Math.Pow(timeElapsed, 2));
            px = Convert.ToInt32(x * pxConvert);
            py = Convert.ToInt32(initialHeight - (y * pxConvert));

            pnlSample.Location = new Point(px, py);

            if(px > pnlDraw.Width - pnlSample.Width)    // Ball hit the wall
            {
                pnlSample.Visible = false;
                pnlSplat.Location = new Point(pnlDraw.Width - pnlSample.Width + (pnlSplat.Width / 2), py + (pnlSample.Height - pnlSplat.Height));
                pnlSplat.Visible = true;

                lblResults.Text = "The ball hit the wall " + Convert.ToString(Math.Round(y, 2)) + " Meters up the wall.";

                clock.Enabled = false;
                Clear.Enabled = true;
            }
            else if(y <= 0 && timeElapsed > 0)  // Ball hit the ground (After leaving)
            {
                pnlSample.Visible = false;
                pnlGround.Location = new Point(px + (pnlSample.Width - pnlGround.Width), pnlDraw.Height - pnlGround.Height);
                pnlGround.Visible = true;

                lblResults.Text = "The ball traveled " + Convert.ToString(Math.Round(x,2)) + " meters before hitting the ground.";

                clock.Enabled = false;
                Clear.Enabled = true;
            }
            else    // Ball is still in the air
            {
                timeElapsed += timeInSeconds;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            lblResults.Text = "";
            txtAngle.Clear();
            txtDtoWall.Clear();
            txtSpeed.Clear();

            pnlSample.Location = new Point(0, initialHeight);

            pnlSample.Visible = true;
            pnlSplat.Visible = false;
            pnlGround.Visible = false;

            Fire.Enabled = true;
            Clear.Enabled = false;
        }

    }
}
