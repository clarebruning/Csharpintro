using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBookSales
{
    public partial class frmBookSales : Form
    {
        public frmBookSales()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Make input variables.

                double dblTotal;
                double dblSavings;
                double dblDiscountTotal;

                // Convert and store text input as numeric value.

                dblTotal = double.Parse(txtTotal.Text);

                // Calculate the savings and the discounted total.

                dblSavings = dblTotal * 0.25;
                dblDiscountTotal = dblTotal - dblSavings;

                // Display the calculated savings and discounted total.

                lblSavingsDisplay.Text = dblSavings.ToString("N2");
                lblDiscountDisplay.Text = dblDiscountTotal.ToString("N2");


                // Reset focus to text input.

                txtTotal.Focus();

            }

            catch
            {
                // Display error message.

                MessageBox.Show("Error - invalid data entered");

            }

           }

        private void lblClear_Click(object sender, EventArgs e)
        {

            // Clear the text input and the displayed results.

            txtTotal.Text = string.Empty;
            lblSavingsDisplay.Text = string.Empty;
            lblDiscountDisplay.Text = string.Empty;

            // Reset focus to text input.

            txtTotal.Focus();

        }

        private void lblExit_Click(object sender, EventArgs e)
        {

            // Close the application.

            Application.Exit();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

            // Clear savings and discounted total displays when text input is changed.

            lblSavingsDisplay.Text = string.Empty;
            lblDiscountDisplay.Text = string.Empty;

        }
    }
}
