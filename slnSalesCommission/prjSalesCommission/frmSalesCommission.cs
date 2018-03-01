using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSalesCommission
{
    public partial class frmSalesCommission : Form
    {

        public frmSalesCommission()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                // Create variables for sales input and commission output.

                double dblSales;
                double dblCommission;

                // Convert sales input into numeric value.

                dblSales = double.Parse(txtSales.Text);

                // Make sure numeric input is a positive number. If not, send 'em back to sales input!

                if (dblSales < 0)
                {
                    MessageBox.Show("Invalid input type. Try again.");
                    txtSales.Focus();
                    txtSales.SelectAll();
                }
               
                    // Display text in commission label.

                    lblLabel.Visible = true;

                    lblNameDisplay.Text = "for" + ' ' + txtFirstName.Text + ' ' + txtLastName.Text + ':';

                    // Calculate and display commission.

                    dblCommission = dblSales * 0.1;

                    lblDisplayCommission.Text = dblCommission.ToString("C");
                }

                catch
            {
                // Display error message.

                MessageBox.Show("Invalid input type. Try again.");

                // Reroute the user to re-entering data.

                txtSales.Focus();
                txtSales.SelectAll();
            }
        
     
        }

        private void lblLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            // Clear input and output fields as well as generated label.

            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtSales.Text = string.Empty;
            lblLabel.Visible = false;
            lblNameDisplay.Text = string.Empty;
            lblDisplayCommission.Text = string.Empty;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            // Close the application.

            Application.Exit();

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblDisplayCommission.Text = string.Empty;
            lblNameDisplay.Text = string.Empty;
            lblLabel.Visible = false;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lblDisplayCommission.Text = string.Empty;
            lblNameDisplay.Text = string.Empty;
            lblLabel.Visible = false;
        }

        private void txtSales_TextChanged(object sender, EventArgs e)
        {
            lblDisplayCommission.Text = string.Empty;
            lblNameDisplay.Text = string.Empty;
            lblLabel.Visible = false;
        }
    }
}
