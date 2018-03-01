using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLooping
{
    public partial class frmLooping : Form
    {
        public frmLooping()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Clear any listbox data.

            lstOutput.Items.Clear();

            // Make input variables for phrase and number of repetitions.

            var varPhrase = txtPhrase.Text;
            double dblNumber;
            double.TryParse(txtNumber.Text, out dblNumber);

            // Take the number of repetitions entered by the user and add the phrase they entered to the listbox that many times.

            if ((dblNumber > 0) && (txtPhrase.Text != string.Empty))
            {

                for (int intCounter = 1; intCounter <= dblNumber; intCounter++)
                {
                    lstOutput.Items.Add(intCounter + ". " + varPhrase);
                }
            }
            else
            {
                MessageBox.Show("Error");
                txtPhrase.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all entered data as well as listbox.

            txtNumber.Text = string.Empty;
            txtPhrase.Text = string.Empty;
            lstOutput.Items.Clear();
            txtPhrase.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application.

            Application.Exit();
        }
    }
}
