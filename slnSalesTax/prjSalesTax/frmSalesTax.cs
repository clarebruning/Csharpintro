using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSalesTax
{
    public partial class frmSalesTax : Form
    {
        CTransaction oTransaction;
        

        public frmSalesTax()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double dblPrice;
            double.TryParse(txtPrice.Text, out dblPrice);
            if (dblPrice > 0)
            {

                // Instantiate CTransaction class.
                oTransaction = new CTransaction();

                //Call CalculateSalesTax method to calculate sales tax and store in variable.
                double dblTax;
                dblTax = oTransaction.CalculateSalesTax(dblPrice);

                //Display tax using variable.
                lblTax.Text = dblTax.ToString("C");

                //Calculate and display total.
                lblTotal.Text = (dblPrice + dblTax).ToString("C");

            }
            else
            {
                //Display an error message.
                MessageBox.Show("Error! Please enter a valid price.");
                txtPrice.Focus();
                txtPrice.SelectAll();
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields.
            txtPrice.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;

            //Reset focus to price input.
            txtPrice.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application.
            Application.Exit();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            // Clear outputs.
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
       
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout ofrmAbout = new frmAbout();
            ofrmAbout.ShowDialog();
        }
    }
}
