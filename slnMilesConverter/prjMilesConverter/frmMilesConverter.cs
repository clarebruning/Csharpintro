using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMilesConverter
{
    public partial class frmMilesConverter : Form
    {
        public frmMilesConverter()
        {
            InitializeComponent();
            txtMiles.Focus();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Create variable for miles input.

            double dblMiles;

            // Create variable for kilometers output.

            double dblKilometers;

            // Get input from display.

            dblMiles = double.Parse(txtMiles.Text);

            // Calculate converson.

            dblKilometers = dblMiles * 1.61;

            // Display output.

            lblDisplayKm.Text = dblKilometers.ToString("N2");

            // Set focus to textbox.

            txtMiles.Focus();
            txtMiles.SelectAll();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            // Clear the display.

            txtMiles.Clear();

            lblDisplayKm.Text = string.Empty;

            // Set focus to textbox.

            txtMiles.Focus();
            txtMiles.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            // Exit the application.

            Application.Exit();
        }

        private void txtMiles_TextChanged(object sender, EventArgs e)
        {

            // Clear output when input changed. 

            lblDisplayKm.Text = string.Empty;
        }
    }
}
