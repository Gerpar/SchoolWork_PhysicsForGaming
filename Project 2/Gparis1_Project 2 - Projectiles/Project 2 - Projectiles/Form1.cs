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
            // Your Code Here

        }

        private void clock_Tick(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // Your Code Here
        }

    }
}
