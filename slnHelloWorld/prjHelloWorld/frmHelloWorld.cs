using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHelloWorld
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Change the blank label to the welcome message.

            lblWelcome.Text = "Welcome to Visual Studio ~C#!";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Return the welcome message to the blank label.

            lblWelcome.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application.

            Application.Exit();
        }
    }
}
