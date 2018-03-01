using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSalary
{
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Create input variable for number of days worked.

            double dblDays;
            double.TryParse(txtDays.Text, out dblDays);

            // Create accumulator for daily pay and total.

            int intDay = 2;
            double dblTotal = 1;
            double dblPaid = 1;

            // Use loop to calculate and display each day's pay in the listbox.
            lstDailyPay.Items.Add("Day 1 pay:    " + 0.01.ToString("C"));

           if (dblDays > 1)
            {
               
                while(lstDailyPay.Items.Count < dblDays) 
                {
                    
                    {
                        lstDailyPay.Items.Add("Day " + intDay + " pay:    " + ((dblTotal + dblTotal) * 0.01).ToString("C"));
                        intDay++;
                        dblTotal += dblTotal;
                        dblPaid += dblTotal;
                    }
                }
            }
            else
            {
                MessageBox.Show("Input error! Please try again.");
                txtDays.Focus();
                txtDays.SelectAll();
            }

            // Calculate and display total pay.

            lblPaid.Text = (dblPaid*0.01).ToString("C");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {

            // Close the application.

            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input and all outputs.

            lstDailyPay.Items.Clear();
            lblPaid.Text = string.Empty;
            txtDays.Text = string.Empty;

            // Set focus to input.
            txtDays.Focus();

        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            // Clear outputs.

            lstDailyPay.Items.Clear();
            lblPaid.Text = string.Empty;
        }
    }
}
