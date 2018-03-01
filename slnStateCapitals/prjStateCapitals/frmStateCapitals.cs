using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjStateCapitals
{
    public partial class frmStateCapitals : Form
    {
        public frmStateCapitals()
        {
            InitializeComponent();
        }

        private void btnWisconsin_Click(object sender, EventArgs e)
        {
            // Display the capital of Wisconsin.

            lblState.Text = "Wisconsin";
            lblCapital.Text = "Madison";
        }

        private void btnGeorgia_Click(object sender, EventArgs e)
        {

            // Display the capital of Georgia.

            lblState.Text = "Georgia";
            lblCapital.Text = "Atlanta";
        }

        private void btnColorado_Click(object sender, EventArgs e)
        {

            // Display the capital of Colorado.

            lblState.Text = "Colorado";
            lblCapital.Text = "Denver";
        }

        private void btnCalifornia_Click(object sender, EventArgs e)
        {

            // Display the capital of California.

            lblState.Text = "California";
            lblCapital.Text = "Sacramento";
        }

        private void btnNewYork_Click(object sender, EventArgs e)
        {

            // Display the capital of New York.

            lblState.Text = "New York";
            lblCapital.Text = "Albany";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            // Exit the application.

            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            // Clear the text boxes.

            lblState.Text = string.Empty;
            lblCapital.Text = string.Empty;
        }
    }
}
