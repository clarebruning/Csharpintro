using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer1Bruning
{
    public partial class Exer1Form : Form
    {
        public Exer1Form()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Change "Fox Valley Technical College" text to name

            lblName.Text = "Clare Bruning";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Change name text back to "Fox Valley Technical College

            lblName.Text = "Fox Valley Technical College";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application

            Application.Exit();
        }
    }
}
