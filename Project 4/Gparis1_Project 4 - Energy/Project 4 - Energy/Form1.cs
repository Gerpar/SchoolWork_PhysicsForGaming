///-----------------------------------------------------------------------------------------------------------------///
//|	Name: Gerad Paris											                                                    |//
//|	Due Date: 04/01/2020										                                                    |//
//|	Instructor: Steven MacNaughton  							                                                    |//
//| Purpose: 
///-----------------------------------------------------------------------------------------------------------------///
///Progress:
///
/// 03/31/2020
///+ Created final Velocity function
///+ Created Weight to mass function
///+ Created kinetic energy function
///+ Finished implementing btnNudge_Click

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4___Energy
{
    public partial class Form1 : Form
    {
        const double ERROR_NUM = -999;

        public Form1()
        {
            InitializeComponent();
        }

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
                return ERROR_NUM;
            }
        }

        private void btnNudge_Click(object sender, EventArgs e)
        {
            double ballAWeight, ballBWeight, ballHeight;
            // If all entries are valid
            if ((ballAWeight = ConvertToDouble(txtBallWtA.Text, "Ball A.")) != ERROR_NUM && (ballBWeight = ConvertToDouble(txtBallWtB.Text, "Ball B.")) != ERROR_NUM && (ballHeight = ConvertToDouble(txtBallHt.Text, "Ball height.")) != ERROR_NUM)
            {
                double finalVel = -CalculateFinalVelocity(0, -9.8, -ballHeight); // Calculate final velocity
                double ballAKE = CalculateKineticEnergy(WeightToMass(ballAWeight), finalVel);   // Calculate ball A Kinetic Energy before hitting ground
                double ballBKE = CalculateKineticEnergy(WeightToMass(ballBWeight), finalVel);   // Calculate ball B Kinetic Energy before hitting ground

                // Output text
                lblBallV.Text = "Ball A Kinetic energy when hitting the ground: " + Convert.ToString(Math.Round(ballAKE,2)) + "J\n";
                lblBallV.Text += "Final velocity of ball A: " + Convert.ToString(Math.Round(finalVel, 2)) + "m/s\n\n";

                lblBallV.Text += "Ball B Kinetic energy when hitting the ground: " + Convert.ToString(Math.Round(ballBKE, 2)) + "J\n";
                lblBallV.Text += "Final Velocity of ball B: " + Convert.ToString(Math.Round(finalVel, 2)) + "m/s\n\n"; 
                lblBallV.Visible = true;    // Show output text
                btnNudge.Visible = false;   // Hide nudge button
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            // Your Code Here
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Your Code Here
        }

        // CALCULATION FUNCTIONS
        //--------------------

        // Calculates final velocity based on passed parameters
        private double CalculateFinalVelocity(double initialVelocity, double acceleration, double distanceDelta)
        {
            double result = Math.Sqrt(Math.Pow(initialVelocity, 2) + (2 * acceleration * distanceDelta));
            return result;
        }

        // Converts lbs into mass in KG
        private double WeightToMass(double weight)
        {
            double result = weight / 0.2248;    // Convert lbs to N
            result = result / 9.8;              // Convert N to KG
            return result;
        }

        // Calculates the Kinetic energy of the object using it's mass and velocity
        private double CalculateKineticEnergy(double mass, double velocity)
        {
            double result =  0.5 * (mass * Math.Pow(velocity, 2));  // Calculate KEf
            return result;
        }
    }
}
