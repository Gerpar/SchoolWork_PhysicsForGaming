///-----------------------------------------------------------------------------------------------------------------///
//|	Name: Gerad Paris											                                                    |//
//|	Due Date: 04/01/2020										                                                    |//
//|	Instructor: Steven MacNaughton  							                                                    |//
//| Purpose: Create a program that is able to find the kinetic energy and final velocity of a ball using the weight |//
//|          and height of the ball. The program will also be able to calculate the Potential energy of a bullet    |//
//|          using it's weight and initial velocity, the program will also find the max height of the bullet after  |//
//|          being shot straight up in the air.                                                                     |//
///-----------------------------------------------------------------------------------------------------------------///
///Progress:
///
/// 03/31/2020
/// + Created final Velocity function
/// + Created Weight to mass function
/// + Created kinetic energy function
/// + Finished implementing btnNudge_Click
/// + Wrote program purpose
/// 
/// 04/01/2020
/// + Created GPE function
/// + Created max height function
/// + Added OZ conversion from weight to mass
/// + Finished implementing btnFire_Click
/// + Finished btnClear_Click

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
        enum WeightUnit { LB, OZ};

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
            if ((ballAWeight = ConvertToDouble(txtBallWtA.Text, "Ball A Weight.")) != ERROR_NUM && (ballBWeight = ConvertToDouble(txtBallWtB.Text, "Ball B Weight.")) != ERROR_NUM && (ballHeight = ConvertToDouble(txtBallHt.Text, "Ball height.")) != ERROR_NUM)
            {
                double finalVel = -CalculateFinalVelocity(0, -9.8, -ballHeight); // Calculate final velocity
                double ballAKE = CalculateKineticEnergy(WeightToMass(ballAWeight, WeightUnit.LB), finalVel);   // Calculate ball A Kinetic Energy before hitting ground
                double ballBKE = CalculateKineticEnergy(WeightToMass(ballBWeight, WeightUnit.LB), finalVel);   // Calculate ball B Kinetic Energy before hitting ground

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
            double bullAWeight, bullBWeight, bullInitialVelocity;
            // If all entries are valid
            if((bullAWeight = ConvertToDouble(txtBulletWtA.Text, "Bullet A Weight.")) != ERROR_NUM && (bullBWeight = ConvertToDouble(txtBulletWtB.Text, "Bullet B Weight.")) != ERROR_NUM && (bullInitialVelocity = ConvertToDouble(txtBulletV.Text, "Bullet Velocity.")) != ERROR_NUM)
            {
                double bullHt = CalculateMaxHeight(bullInitialVelocity);    // Calculate max height of bullets
                double bullAGPE = CalculateGPE(WeightToMass(bullAWeight, WeightUnit.OZ), bullHt);   // Calculate bullet A GPE
                double bullBGPE = CalculateGPE(WeightToMass(bullBWeight, WeightUnit.OZ), bullHt);   // Calculate bullet B GPE

                // Output text
                lblBulletHt.Text = "Bullet A GPE at max height: " + Convert.ToString(Math.Round(bullAGPE, 2)) + "J\n";
                lblBulletHt.Text += "Max Height: " + Convert.ToString(Math.Round(bullHt, 2)) + "m\n\n";

                lblBulletHt.Text += "Bullet B GPE at max height: " + Convert.ToString(Math.Round(bullBGPE, 2)) + "J\n";
                lblBulletHt.Text += "Max Height: " + Convert.ToString(Math.Round(bullHt, 2)) + "m\n\n";
                lblBulletHt.Visible = true; // Show output text
                btnFire.Visible = false;    // Hide fire button
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clearing fields
            txtBallWtA.Text = "";
            txtBallWtB.Text = "";
            txtBallHt.Text = "";
            txtBulletWtA.Text = "";
            txtBulletWtB.Text = "";
            txtBulletV.Text = "";
            lblBallV.Text = "";
            lblBulletHt.Text = "";

            // showing / hiding
            lblBallV.Visible = false;
            lblBulletHt.Visible = false;
            btnNudge.Visible = true;
            btnFire.Visible = true;

            // rest tab focus
            txtBallWtA.Focus();
        }

        // CALCULATION FUNCTIONS
        //--------------------

        // Calculates final velocity based on passed parameters
        private double CalculateFinalVelocity(double initialVelocity, double acceleration, double distanceDelta)
        {
            // Vf = sqrt(vi^2+2a*Dr)
            double result = Math.Sqrt(Math.Pow(initialVelocity, 2) + (2 * acceleration * distanceDelta));
            return result;
        }

        // Converts lbs into mass in KG
        private double WeightToMass(double weight, WeightUnit unit)
        {
            double result = 0;
            switch (unit)
            {
                case WeightUnit.LB:
                    result = weight / 0.2248;   // Convert lbs to N
                    break;
                case WeightUnit.OZ:
                    result = weight / 16;       // convert oz to lbs
                    result /= 0.2248;           // convert lbs to N
                    break;
            }
            result /= 9.8;                      // Convert N to KG

            return result;
        }

        // Calculates the Kinetic energy of the object using it's mass and velocity
        private double CalculateKineticEnergy(double mass, double velocity)
        {
            double result =  0.5 * (mass * Math.Pow(velocity, 2));  // Calculate KEf
            return result;
        }

        // Calculates GPE based on earth's gravity
        private double CalculateGPE(double mass, double height)
        {
            double result = mass * 9.8 * height;
            return result;
        }

        // Calculates the maximum height of the bullet
        private double CalculateMaxHeight(double initialVelocity)
        {
            // Dr = Vf^2(0) + Vi^2 / 2A
            double result = Math.Pow(initialVelocity,2) / (2 * 9.8);
            return result;
        }
    }
}
