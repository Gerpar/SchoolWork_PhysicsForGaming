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
/// +Wrote project header
/// 02/22/2020-------------------------------------------------------------------------------------------------------->
/// 

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
        double timeInSeconds;
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
                vy = velocity * Math.Sin((angle * 180 / Math.PI));
                a = -9.8;   // Standard Earth gravity
                pxConvert = pnlDraw.Width / x;

                timeInSeconds = clock.Interval / 10000.0f;
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
            timeElapsed += timeInSeconds;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // Your Code Here
        }

    }
}
