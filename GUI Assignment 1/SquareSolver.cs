// Aaron Whitaker
// Winter 2022
// CIS 207
// GUI Assignment 1: Window for calculating the area of a square based on user input

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
    public partial class SquareSolver : Form
    {

        // This window is initialized via user input mouse click on "square solver" button from shape selection window / it initializes this window for user input and calculation of the square's area and also displays a square image / no input data is used / an image of a square is expected to be displayed
        public SquareSolver()
        {
            InitializeComponent();
            pictureBoxSquareArea.Image = Image.FromFile("BoxRobot.png");
        }

        // User input mouse click on "submit" button triggers this method / the below accepts user input data, verifies the user input is a real, positive number, and displays the calculated area / user data input "squareSide" is used by this method / the user data input data is output to the "SquareMath" method and the calculated area of the square is displayed in the window / additional output is "Invalid input:" displayed in "labelSquareSide" for user feedback if data input is not valid / additional action is generated via user input mouse click "Reset" and doing so will clear any user input or method output currently displayed. The square solver window will then be ready to accept new user data input
        private void buttonSubmitSquare_Click(object sender, EventArgs e)
        {
            // validation if else to check that user input data is a real positive number, part 1
            try
            {
                // retrieves the user input data from the text box in SquareSolver
                double squareSide = Convert.ToDouble(textBoxSquareSide.Text);

                // sends user input "squareSide" to "SquareMath" for area calculation and initial validation of user input / area is returned from "SquareMath"
                double returnedSquareArea = SquareMath(squareSide);

                // validation if else to check that user input data is a real positive number, part 5
                if (returnedSquareArea != 0)
                {
                    // validation if else to check that user input data is a real positive number, part 6
                    if (returnedSquareArea >= 0)
                    {
                        // displays the "labelArea" text and the calculated area of the square to "textBoxArea", based on user input
                        labelSquareSide.Text = ("Enter the length of the square's side:");
                        labelArea.Text = ("The area of the square is:");
                        textBoxArea.Text = (returnedSquareArea.ToString("F2"));
                    }
                    else
                    {
                        // displays error message due to invalid user input
                        labelSquareSide.Text = ("Invalid input, click reset or re-enter #:");
                        textBoxSquareSide.Clear();
                        labelArea.Text = ("");
                        textBoxArea.Clear();
                    }
                }
                else
                {
                    // displays error message due to invalid user input
                    labelSquareSide.Text = ("Invalid input, click reset or re-enter #:");
                    textBoxSquareSide.Clear();
                    labelArea.Text = ("");
                    textBoxArea.Clear();
                }
            }
            catch (Exception)
            {
                // displays error message due to invalid user input
                labelSquareSide.Text = ("Invalid input, click reset or re-enter #:");
                textBoxSquareSide.Clear();
                labelArea.Text = ("");
                textBoxArea.Clear();
            }
        }

        // this method is triggered by user input mouse click "Submit" button triggering the "buttonSubmitSquare" method and the "buttonSubmitSquare" method calling this method / this method is called to calculate the area of a square and validate user input / user input data "squareSide" is used in this method / the expected output is either the area of the square based on user input "squareSide" or an error message due to invalid user input
        static double SquareMath(double squareSide)
        {
            // validation if else to check that user input data is a real positive number, part 2
            if (squareSide != 0)
            {
                // validation if else to check that user input data is a real positive number, part 3
                if (squareSide > 0)
                {
                    // validation if else to check that user input data is a real positive number, part 4
                    try
                    {
                        // calculation for area of a square; // area = side squared
                        return Math.Pow(squareSide, 2.0);
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

        // User input mouse click on "Reset" button triggers this method / this method resets the SquareSolver window to accept new user input / user mouse click "Reset" is the only input required / the expected output is the reset of labels and text boxes present in SquareSolver to return to the same state they were in when the window was first initialized
        private void buttonSquareReset_Click(object sender, EventArgs e)
        {
            labelSquareSide.Text = ("Enter the length of the square's side:");
            textBoxSquareSide.Clear();
            labelArea.Text = ("");
            textBoxArea.Clear();
        }
    }
}
