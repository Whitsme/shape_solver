// Aaron Whitaker
// Winter 2022
// CIS 207
// GUI Assignment 1: Window for calculating the area of a circle or volume of a sphere based on user input

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Assignment_1
{
    public partial class RadiusSolver : Form
    {

        // This window is initialized via user input mouse click on "Radius Solver" button from shape selection window // it initializes this window for user input and calculation of the radius area or volume and also displays a place holder image // no input data is used // an image of a place holder is expected to be displayed
        public RadiusSolver()
        {
            InitializeComponent();
            pictureBoxRadius.Image = Image.FromFile("Robot.png");
        }

        // User input mouse click on "submit" button triggers this method // the below accepts user input data, verifies the user input is a real, positive number, and displays the calculated area or volume // user data input "radius" is used by this method. user input is also required for combo box choice circle or sphere // the user data input data is output to either the "CircleAreaMath" or "SphereVolumeMath" method and the calculated area(circle) or volume(sphere) of the selected shape is displayed in the window // additional output is "Invalid input:" displayed in "labelRadiusArea" for user feedback if data input is not valid // additional action is generated via user input mouse click "Reset" and doing so will clear any user input or method output currently displayed. The square solver window will then be ready to accept new user data input
        private void buttonSubmitRadius_Click(object sender, EventArgs e)
        {
            // sets pi value for later use in both "CircleAreaMath" and "SphereVolumeMath"
            double pi = 3.14159;

            // validation if else to check that user input data is a real positive number, part 1
            try
            {
                // retrieves the user input data from the text box in TriangleSolver
                double radius = Convert.ToDouble(textBoxRadius.Text);

                // calls the "CircleAreaMath" method and sends user input "radius" and set value "pi" // sets "returnedCircleArea" to the value of the return
                double returnedCircleArea = CircleAreaMath(radius, pi);

                // calls the "SphereVolumeMath" method and sends user input "radius" and set value "pi" // sets "returnedSphereVolume" to the value of the return
                double returnedSphereVolume = SphereVolumeMath(radius, pi);

                // validation if else to check that user input data is a real positive number, part 5
                if (returnedCircleArea != 0 | returnedSphereVolume != 0)
                {
                    // validation if else to check that user input data is a real positive number, part 6
                    if (returnedCircleArea >= 0 | returnedSphereVolume >= 0)
                    {
                        // validation if else to check that user selected Circle
                        if (comboBoxRadius.SelectedIndex == 0)
                        {
                            // displays calculated area of a circle based on user input "radius"
                            labelRadius.Text = ("                                   Enter the radius:");
                            labelRadiusArea.Text = ("Calculated from your radius");
                            textRadiusArea.Text = (returnedCircleArea.ToString("F2"));
                            labelShape.Text = ("is the selected");
                            textBoxShape.Text = ("circle area");
                            pictureBoxRadius.Image = Image.FromFile("CircleRobot.png");
                        }
                        // validation if else to check that user selected Sphere
                        else if (comboBoxRadius.SelectedIndex == 1)
                        {
                            // displays calculated volume of a sphere based on user input "radius"
                            labelRadius.Text = ("                                   Enter the radius:");
                            labelRadiusArea.Text = ("Calculated from your radius");
                            textRadiusArea.Text = (returnedSphereVolume.ToString("F2"));
                            labelShape.Text = ("is the selected");
                            textBoxShape.Text = ("sphere volume");
                            pictureBoxRadius.Image = Image.FromFile("SphereRobot.png");
                        }
                        else
                        {
                            // displays error message due to invalid user input
                            labelRadius.Text = ("Invalid input, click reset or re-enter #:");
                            textBoxRadius.Clear();
                            comboBoxRadius.SelectedIndex = -1;
                            labelRadiusArea.Text = ("");
                            textRadiusArea.Clear();
                            labelShape.Text = ("");
                            textBoxShape.Clear();
                            pictureBoxRadius.Image = Image.FromFile("Robot.png");
                        }
                    }
                    else
                    {
                        // displays error message due to invalid user input
                        labelRadius.Text = ("Invalid input, click reset or re-enter #:");
                        textBoxRadius.Clear();
                        comboBoxRadius.SelectedIndex = -1;
                        labelRadiusArea.Text = ("");
                        textRadiusArea.Clear();
                        labelShape.Text = ("");
                        textBoxShape.Clear();
                        pictureBoxRadius.Image = Image.FromFile("Robot.png");
                    }
                }
                else
                {
                    // displays error message due to invalid user input
                    labelRadius.Text = ("Invalid input, click reset or re-enter #:");
                    textBoxRadius.Clear();
                    comboBoxRadius.SelectedIndex = -1;
                    labelRadiusArea.Text = ("");
                    textRadiusArea.Clear();
                    labelShape.Text = ("");
                    textBoxShape.Clear();
                    pictureBoxRadius.Image = Image.FromFile("Robot.png");
                }
            }
            catch (Exception)
            {
                // displays error message due to invalid user input
                labelRadius.Text = ("Invalid input, click reset or re-enter #:");
                textBoxRadius.Clear();
                comboBoxRadius.SelectedIndex = -1;
                labelRadiusArea.Text = ("");
                textRadiusArea.Clear();
                labelShape.Text = ("");
                textBoxShape.Clear();
                pictureBoxRadius.Image = Image.FromFile("Robot.png");
            }
        }

        // this method is triggered by user input mouse click "Submit" button triggering the "buttonSubmitRadius" method and the "buttonSubmitRadius" method calling this method // this method is called to calculate the area of a circle and validate user input // user input data "radius" is used in this method // the expected output is either the area of the circle based on user input "radius" or an error message due to invalid user input
        static double CircleAreaMath(double radius, double pi)
        {
            // validation if else to check that user input data is a real positive number, (duplicated in "SphereVolumeMath") part 2 
            if (radius != 0)
            {
                // validation if else to check that user input data is a real positive number, (duplicated in "SphereVolumeMath") part 3 
                if (radius > 0)
                {
                    // validation if else to check that user input data is a real positive number, (duplicated in "SphereVolumeMath") part 4 
                    try
                    {
                        // calculation for area of a square // area = side squared // returns calculated area of the circle to "buttonSubmitRadius"
                        return pi * Math.Pow(radius, 2.0);
                    }
                    catch (Exception)
                    {
                        // return triggers error message due to invalid user input
                        return 0;
                    }
                }
                else
                {
                    // return triggers error message due to invalid user input
                    return 0;
                }
            }
            else
            {
                // return triggers error message due to invalid user input
                return 0;
            }
        }

        // this method is triggered by user input mouse click "Submit" button triggering the "buttonSubmitRadius" method and the "buttonSubmitRadius" method calling this method // this method is called to calculate the volume of a sphere and validate user input // user input data "radius" is used in this method // the expected output is either the volume of a sphere based on user input "radius" or an error message due to invalid user input
        static double SphereVolumeMath(double radius, double pi)
        {
            // validation if else to check that user input data is a real positive number, (duplicated in "CircleAreaMath") part 2 
            if (radius != 0)
            {
                // validation if else to check that user input data is a real positive number, (duplicated in "CircleAreaMath") part 3
                if (radius > 0)
                {
                    // validation if else to check that user input data is a real positive number, (duplicated in "CircleAreaMath") part 4
                    try
                    {
                        // calculation for area of a square; // area = side squared
                        return (4.0 / 3.0) * pi * Math.Pow(radius, 3.0);
                    }
                    catch (Exception)
                    {
                        // return triggers error message due to invalid user input
                        return 0;
                    }
                }
                else
                {
                    // return triggers error message due to invalid user input
                    return 0;
                }
            }
            else
            {
                // return triggers error message due to invalid user input
                return 0;
            }
        }

        // User input mouse click on "Reset" button triggers this method // this method resets the RadiusSolver window to accept new user input // user mouse click "Reset" is the only input required // the expected output is the reset of labels and text boxes present in RadiusSolver to return to the same state they were in when the window was first initialized
        private void buttonRadiusReset_Click(object sender, EventArgs e)
        {
            labelRadius.Text = ("                                   Enter the radius:");
            textBoxRadius.Clear();
            comboBoxRadius.SelectedIndex = -1;
            labelRadiusArea.Text = ("");
            textRadiusArea.Clear();
            labelShape.Text = ("");
            textBoxShape.Clear();
            pictureBoxRadius.Image = Image.FromFile("Robot.png");
        }
    }
}
