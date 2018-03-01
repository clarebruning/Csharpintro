using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjExer2Bruning
{
    public partial class frmExer1Bruning : Form
    {
        public frmExer1Bruning()
        {
            InitializeComponent();
        }

        private void frmExer1Bruning_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            try
            {
                // Create input variables.

                double dblBooks;
                double dblDays;
                double dblAmount;

                // Convert and store text inputs as numeric values..

                dblBooks = double.Parse(txtBooks.Text);
                dblDays = double.Parse(txtDays.Text);

                // Calculate fine.

                dblAmount = dblBooks * dblDays * 0.05;

                // Display fine.

                lblAmount.Text = dblAmount.ToString("C");

                // Reset focus to first input.

                txtBooks.Focus();
            }

            catch
            {
                // Display error message.

                MessageBox.Show("Error - invalid data type entered");
            }
        }

        private void txtBooks_TextChanged(object sender, EventArgs e)
        {

            // Clear results.
     
            lblAmount.Text = string.Empty;

        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {

            // Clear results.

            lblAmount.Text = string.Empty;
      
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            // Clear inputs and results.

            txtBooks.Text = string.Empty;
            txtDays.Text = string.Empty;
            lblAmount.Text = string.Empty;

            // Reset focus to first input.

            txtBooks.Focus();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            // Close the application.

            Application.Exit();
        }
    }
}
