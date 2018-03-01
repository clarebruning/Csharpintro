using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPetClinic
{
    public partial class frmPetClinic : Form
    {
        double dblSubtotal;
        const double SERVICE1_COST = 10;
        const double SERVICE2_COST = 15;
        const double SERVICE3_COST = 25;
        const double SERVICE4_COST = 50;
        const double SERVICE5_COST = 45;
        const double SERVICE6_COST = 100;
        const double SERVICE7_COST = 40;
        const double SERVICE8_COST = 200;

        public frmPetClinic()
        {
            InitializeComponent();

        }


        private void chkService1_CheckedChanged(object sender, EventArgs e)
        {
            

            // When checkbox is checked, display the cost and add it to the running total.

            if (chkService1.Checked)
            {
             
                lblCost1.Visible = true;
                dblSubtotal = dblSubtotal + SERVICE1_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }

            // When checkbox unchecked, remove the displayed cost and subtract it from the running total.

            else
            {

                lblCost1.Visible = false;
                dblSubtotal = dblSubtotal - SERVICE1_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }
        }

        private void chkService2_CheckedChanged(object sender, EventArgs e)
        {
            // When checkbox is checked, display the cost and add it to the running total.

            if (chkService2.Checked)
            {

                lblCost2.Visible = true;
                dblSubtotal = dblSubtotal + SERVICE2_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }

            // When checkbox unchecked, remove the displayed cost and subtract it from the running total.

            else
            {

                lblCost2.Visible = false;
                dblSubtotal = dblSubtotal - SERVICE2_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }
        }

        private void chkService3_CheckedChanged(object sender, EventArgs e)
        {
            // When checkbox is checked, display the cost and add it to the running total.

            if (chkService3.Checked)
            {

                lblCost3.Visible = true;
                dblSubtotal = dblSubtotal + SERVICE3_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }

            // When checkbox unchecked, remove the displayed cost and subtract it from the running total.

            else
            {

                lblCost3.Visible = false;
                dblSubtotal = dblSubtotal - SERVICE3_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }
        }

        private void chkService4_CheckedChanged(object sender, EventArgs e)
        {
            // When checkbox is checked, display the cost and add it to the running total.

            if (chkService4.Checked)
            {

                lblCost4.Visible = true;
                dblSubtotal = dblSubtotal + SERVICE4_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }

            // When checkbox unchecked, remove the displayed cost and subtract it from the running total.

            else
            {

                lblCost4.Visible = false;
                dblSubtotal = dblSubtotal - SERVICE4_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }
        }

        private void chkService5_CheckedChanged(object sender, EventArgs e)
        {
            // When checkbox is checked, display the cost and add it to the running total.

            if (chkService5.Checked)
            {

                lblCost5.Visible = true;
                dblSubtotal = dblSubtotal + SERVICE5_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }

            // When checkbox unchecked, remove the displayed cost and subtract it from the running total.

            else
            {

                lblCost5.Visible = false;
                dblSubtotal = dblSubtotal - SERVICE5_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }
        }

        private void chkService6_CheckedChanged(object sender, EventArgs e)
        {
            // When checkbox is checked, display the cost and add it to the running total.

            if (chkService6.Checked)
            {

                lblCost6.Visible = true;
                dblSubtotal = dblSubtotal + SERVICE6_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }

            // When checkbox unchecked, remove the displayed cost and subtract it from the running total.

            else
            {

                lblCost6.Visible = false;
                dblSubtotal = dblSubtotal - SERVICE6_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }
        }

        private void chkService7_CheckedChanged(object sender, EventArgs e)
        {
            // When checkbox is checked, display the cost and add it to the running total.

            if (chkService7.Checked)
            {

                lblCost7.Visible = true;
                dblSubtotal = dblSubtotal + SERVICE7_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }

            // When checkbox unchecked, remove the displayed cost and subtract it from the running total.

            else
            {

                lblCost7.Visible = false;
                dblSubtotal = dblSubtotal - SERVICE7_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }
        }

        private void chkService8_CheckedChanged(object sender, EventArgs e)
        {
            // When checkbox is checked, display the cost and add it to the running total.

            if (chkService8.Checked)
            {

                lblCost8.Visible = true;
                dblSubtotal = dblSubtotal + SERVICE8_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }

            // When checkbox unchecked, remove the displayed cost and subtract it from the running total.

            else
            {

                lblCost8.Visible = false;
                dblSubtotal = dblSubtotal - SERVICE8_COST;
                lblSubtotalDisplay.Text = dblSubtotal.ToString("C");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields.

            lblCost1.Visible = false;
            lblCost2.Visible = false;
            lblCost3.Visible = false;
            lblCost4.Visible = false;
            lblCost5.Visible = false;
            lblCost6.Visible = false;
            lblCost7.Visible = false;
            lblCost8.Visible = false;
            lblSubtotal.Text = string.Empty;
            chkService1.Checked = false;
            chkService2.Checked = false;
            chkService3.Checked = false;
            chkService4.Checked = false;
            chkService5.Checked = false;
            chkService6.Checked = false;
            chkService7.Checked = false;
            chkService8.Checked = false;

            // Reset focus.

            chkService1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit application.

            Application.Exit();
        }
    }
}
