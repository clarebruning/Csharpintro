using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer5Bruning
{
    public partial class Exer5Form : Form
    {
        CMilesPerGallon oMilesPerGallon;

        public Exer5Form()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Create and parse input variables.

            double.TryParse(txtMiles.Text, out double dblMiles);
            double.TryParse(txtGallons.Text, out double dblGallons);

            if ((dblMiles > 0) && (dblGallons > 0))
            {
                // Instantiate CMilesPerGallon class.
                oMilesPerGallon = new CMilesPerGallon();

                // Calculate and display miles per gallon.
                double dblMPG = oMilesPerGallon.CalculateMilesPerGallon(dblMiles, dblGallons);
                lblMPG.Text = dblMPG.ToString("N1");
            }

            else
            {
                // Display error message.
                MessageBox.Show("Input error! Please try again.");

                // Set focus and select first input area.
                txtMiles.Focus();
                txtMiles.SelectAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input and output areas.

            txtMiles.Text = string.Empty;
            txtGallons.Text = string.Empty;
            lblMPG.Text = string.Empty;

            // Set focus to first input area.

            txtMiles.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the applicatoin.

            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout ofrmAbout = new frmAbout();
            ofrmAbout.ShowDialog();
        }
    }
}
