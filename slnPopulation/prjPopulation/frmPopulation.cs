using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPopulation
{
    public partial class frmPopulation : Form
    {

        public frmPopulation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Create input variables for starting and ending populations.

            double dblStartingPop;
            double dblEndingPop;

            // Get inputs and store them in our variables.

            double.TryParse(txtStartPop.Text, out dblStartingPop);
            double.TryParse(txtEndPop.Text, out dblEndingPop);

            if ((dblStartingPop > 0) && (dblEndingPop > 0) && (txtCity.Text != string.Empty) && (txtState.Text != string.Empty))
            {

                // Create output variables for percent increase and decrease displays.

                double dblIncrease;
                double dblDecrease;

                // Calculate difference between populations and store in new variable.

                double dblChange = dblEndingPop - dblStartingPop;

                //then calculate and display percent change.

                if (dblChange < 0)
                {
                    dblDecrease = Math.Abs(dblChange) / dblStartingPop;
                    lblDecreaseDisplay.Text = dblDecrease.ToString("P");
                    // lblIncreaseDisplay.Text = "none";
                    MessageBox.Show("Decrease in population for " + txtCity.Text + ", " + txtState.Text.ToUpper(), "Population Decrease");
                    txtStartPop.Focus();
                }
                else if (dblChange > 0)
                {
                    dblIncrease = dblChange / dblStartingPop;
                    lblIncreaseDisplay.Text = dblIncrease.ToString("P");
                    // lblDecreaseDisplay.Text = "none";
                    MessageBox.Show("Increase in population for " + txtCity.Text + ", " + txtState.Text.ToUpper(), "Population Increase");
                    txtStartPop.Focus();
                }
                else if (dblChange == 0)
                {
                    MessageBox.Show("No change in population for " + txtCity.Text + ", " + txtState.Text.ToUpper(), "No Population Change");
                    txtStartPop.Focus();
                }

                else
                {
                    MessageBox.Show("Error! Please try again.");

                    // Clear all fields.

                    txtCity.Text = string.Empty;
                    txtState.Text = string.Empty;
                    txtStartPop.Text = string.Empty;
                    txtEndPop.Text = string.Empty;
                    lblDecreaseDisplay.Text = string.Empty;
                    lblIncreaseDisplay.Text = string.Empty;

                    // Return focus to starting population input area.

                    txtStartPop.Focus();
                }
            }

          else
            {
                MessageBox.Show("Error! Please try again.");

                // Clear all fields.

                txtCity.Text = string.Empty;
                txtState.Text = string.Empty;
                txtStartPop.Text = string.Empty;
                txtEndPop.Text = string.Empty;
                lblDecreaseDisplay.Text = string.Empty;
                lblIncreaseDisplay.Text = string.Empty;

                // Return focus to first input area.

                txtCity.Focus();
            }
   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields.

            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtStartPop.Text = string.Empty;
            txtEndPop.Text = string.Empty;
            lblDecreaseDisplay.Text = string.Empty;
            lblIncreaseDisplay.Text = string.Empty;

            // Return focus to first input area.

            txtCity.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application.

            Application.Exit();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            // Clear calculated values.

            lblDecreaseDisplay.Text = string.Empty;
            lblIncreaseDisplay.Text = string.Empty;
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            // Clear calculated values.

            lblDecreaseDisplay.Text = string.Empty;
            lblIncreaseDisplay.Text = string.Empty;
        }

        private void txtStartPop_TextChanged(object sender, EventArgs e)
        {
            // Clear calculated values.

            lblDecreaseDisplay.Text = string.Empty;
            lblIncreaseDisplay.Text = string.Empty;
        }

        private void txtEndPop_TextChanged(object sender, EventArgs e)
        {
            // Clear calculated values.

            lblDecreaseDisplay.Text = string.Empty;
            lblIncreaseDisplay.Text = string.Empty;
        }
    }
}
