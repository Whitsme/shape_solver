// Aaron Whitaker
// Winter 2022
// CIS 207
// GUI Assignment 1: Window for calculating the area of a triangle based on user input

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
    public partial class TriangleSolver : Form
    {

        // This window is initialized via user input mouse click on "triangle solver" button from shape selection window // it initializes this window for user input and calculation of the triangle's area and also displays a triangle image // no input data is used // an image of a triangle is expected to be displayed
        public TriangleSolver()
        {
            InitializeComponent();
            pictureBoxTriangleArea.Image = Image.FromFile("TriRobot.png");
        }

        // User input mouse click on "submit" button triggers this method // the below accepts user input data, verifies the user input is a real, positive number, and displays the calculated area // user data inputs "triangleBase" and "triangleHeight" are used by this method // the user data input data is output to "textTriangleArea" method and the calculated area of the triangle is displayed in the window // additional output is an error message displayed in "labelTriangleBase" and "labelTriangleHeight" for user feedback if data input is not valid // additional action is generated via user input mouse click "Reset" and doing so will clear any user input or method output currently displayed. The TriangleSolver window will then be ready to accept new user data input
        private void buttonSubmitTriangle_Click(object sender, EventArgs e)
        {
            // validation if else to check that user input data is a real positive number, part 1
            try
            {
                // retrieves the user input data from "textBoxTriBase"
                double triangleBase = Convert.ToDouble(textBoxTriBase.Text);

                // retrieves the user input data from "textBoxTriHeight"
                double triangleHeight = Convert.ToDouble(textBoxTriHeight.Text);

                // calls the "TriangleMath" method and sends user inputs "textBoxTriBase" and "textBoxTriHeight" // sets "returnedTriangleArea" to the value of the return
                double returnedTriangleArea = TriangleMath(triangleHeight, triangleBase);

                // validation if else to check that user input data is a real positive number, part 3
                if (returnedTriangleArea != 0)
                {
                    // validation if else to check that user input data is a real positive number, part 4
                    if (returnedTriangleArea >= 0)
                    {
                        // displays area of a circle based on user inputs "textBoxTriHeight" and "textBoxTriBase"
                        labelTriangleBase.Text = ("Enter the length of the triangle's base:");
                        labelTriangleHeight.Text = ("                   Enter the triangle's height:");
                        labelTriangleArea.Text = ("The area of the triangle is: ");
                        textTriangleArea.Text = (returnedTriangleArea.ToString("F2"));
                    }
                    else
                    {
                        // displays error message due to invalid user input 
                        labelTriangleBase.Text = (" Invalid input, click reset or re-enter #:");
                        labelTriangleHeight.Text = ("Invalid input, click reset or re-enter #:");
                        textBoxTriBase.Clear();
                        textBoxTriHeight.Clear();
                        labelTriangleArea.Text = ("");
                        textTriangleArea.Clear();
                    }
                }
                else
                {
                    // displays error message due to invalid user input
                    labelTriangleBase.Text = (" Invalid input, click reset or re-enter #:");
                    labelTriangleHeight.Text = ("Invalid input, click reset or re-enter #:");
                    textBoxTriBase.Clear();
                    textBoxTriHeight.Clear();
                    labelTriangleArea.Text = ("");
                    textTriangleArea.Clear();
                }
            }
            catch (Exception)
            {
                // displays error message due to invalid user input
                labelTriangleBase.Text = (" Invalid input, click reset or re-enter #:");
                labelTriangleHeight.Text = ("Invalid input, click reset or re-enter #:");
                textBoxTriBase.Clear();
                textBoxTriHeight.Clear();
                labelTriangleArea.Text = ("");
                textTriangleArea.Clear();
            }
        }

        // this method is triggered by user input mouse click "Submit" button triggering the "buttonSubmitTriangle" method and the "buttonSubmitTriangle" method calling this method // this method is called to calculate the area of a triangle and validate user input // user input data "triangleBase" and "triangleHeight" are used in this method // the expected output is either the area of the triangle based on user inputs "triangleBase" and "triangleHeight" or an error message due to invalid user input
        static double TriangleMath(double triangleHeight, double triangleBase)
        {
            // validation if else to check that user input data is a real positive number, part 2
            try
            {
                // calculation for area of a triangle // 1/2 * "triangleBase" * "triangleHeight"
                return 1.0 /2.0 * triangleBase * triangleHeight; // INSTRUCTOR COMMENTS: I think you meant 1.0 / 2.0?
            }
            catch (Exception)
            {
                // return triggers error message due to invalid user input
                return 0;
            }

        }

        // User input mouse click on "Reset" button triggers this method // this method resets the TriangleSolver window to accept new user input // user mouse click "Reset" is the only input required // the expected output is the reset of labels and text boxes present in TriangleSolver to return to the same state they were in when the window was first initialized
        private void buttonTriangleReset_Click(object sender, EventArgs e)
        {
            labelTriangleBase.Text = ("Enter the length of the triangle's base:");
            labelTriangleHeight.Text = ("                   Enter the triangle's height:");
            textBoxTriBase.Clear();
            textBoxTriHeight.Clear();
            labelTriangleArea.Text = ("");
            textTriangleArea.Clear();
        }
    }
}
