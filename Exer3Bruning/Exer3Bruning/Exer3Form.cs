using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer3Bruning
{
    public partial class Exer3Form : Form
    {
        // Create variables for quantity input and amount due output.

        double dblQuanity;
        double dblTotal;

        public Exer3Form()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {



            try
            {

                // Convert quantity input to numeric value.

                dblQuanity = double.Parse(txtQuantity.Text);

                // Display error if input is negative.

                if (dblQuanity < 0)
                {
                    MessageBox.Show("You can't sell a negative quantity, silly!");
                    txtQuantity.Focus();
                    txtQuantity.SelectAll();
                }

                // Calculate amount due based on numeric value of quanity input.

                else if (dblQuanity < 10)
                {
                    dblTotal = dblQuanity * 99;
                }
                else if (dblQuanity <= 19)
                {
                    dblTotal = (dblQuanity * 99) * 0.95;
                }
                else 
                {
                    dblTotal = (dblQuanity * 99) * 0.9;
                }

                // Display the amount due.

                lblTotal.Text = dblTotal.ToString("C");
            }

            // Display error message if something funky's going on.

            catch
            {
                MessageBox.Show("Please enter a valid input.");
                txtQuantity.Focus();
                txtQuantity.SelectAll();
            }

            // Return focus to the quantity input textbox.

            txtQuantity.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear quantity and amount due.

            txtQuantity.Text = string.Empty;
            lblTotal.Text = string.Empty;

            // Return focus to quantity input.

            txtQuantity.Focus();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            // Clear amount due.

            lblTotal.Text = string.Empty;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application.

            Application.Exit();
        }
    }
}
