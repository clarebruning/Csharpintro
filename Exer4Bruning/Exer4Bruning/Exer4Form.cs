using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer4Bruning
{
    public partial class Exer4Form : Form
    {
        public Exer4Form()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear listbox data.

            lstTuition.Items.Clear();

            // Create input variable.

            double dblCost;
            double.TryParse(txtCost.Text, out dblCost);

            // Create accumulator for number of credits and for total.

            int intCredit = 1;
            double total = 0;

            // Use loop to add the cost per credit to the running total 18 times.

            if (dblCost > 0) 
            {

                while (lstTuition.Items.Count <= 17)
                {
                    lstTuition.Items.Add(intCredit + " credits ~ " + (total += dblCost).ToString("C"));
                    intCredit++;
                }
                
                // Select and set focus at textbox.

                txtCost.Focus();

            }

            else {
                MessageBox.Show("Input error!" + Environment.NewLine + "Please enter a positive, numeric Cost per Credit");
                txtCost.Focus();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input and output.

            txtCost.Text = string.Empty;
            lstTuition.Items.Clear();

            // Select and set focus at textbox.

            txtCost.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit.

            Application.Exit();
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            lstTuition.Items.Clear();
        }
    }
}
