using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblText_Click(object sender, EventArgs e)
        {
            lblText.AutoSize = true;
            lblText.Text = "Do you want to submit this project?";
            lblText.Font = new Font("French Scrip MT", 18);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Text = "Submit";
            btnSubmit.AutoSize = true;
            btnSubmit.BackColor = Color.LightBlue;
            btnSubmit.Padding = new Padding(6);
            btnSubmit.Font = new Font("French Scrip MT", 18);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Text = "Cancel";
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.LightPink;
            btnCancel.Padding = new Padding(6);
            btnCancel.Font = new Font("French Scrip MT", 18);
        }
    }
}
