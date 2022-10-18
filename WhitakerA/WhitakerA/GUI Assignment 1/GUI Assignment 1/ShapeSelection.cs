// Aaron Whitaker
// Winter 2022
// CIS 207
// GUI Assignment 1: Window with buttons to select a shape

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
    public partial class SelectShape : Form
    {
        public SelectShape()
        {
            InitializeComponent();
        }

        // triggered by user input via mouse click on the button "square solver"// opens a the square solver window // no data input is used other than the trigger from user mouse click // the expected action is for the square solver window to open
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            SquareSolver openSquareSolver = new SquareSolver();
            openSquareSolver.Show();
        }

        // triggered by user input via mouse click on the button "triangle solver"// opens a the triangle solver window / no data input is used other than the trigger from user mouse click // the expected action is for the triangle solver window to open
        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            TriangleSolver openTriangleSolver = new TriangleSolver();
            openTriangleSolver.Show();
        }

        // triggered by user input via mouse click on the button "radius solver"// opens a the radius solver window // no data input is used other than the trigger from user mouse click // the expected action is for the radius solver window to open
        private void buttonCircleOrSphere_Click(object sender, EventArgs e)
        {
            RadiusSolver openCircleSolver = new RadiusSolver();
            openCircleSolver.Show();
        }
    }
}
