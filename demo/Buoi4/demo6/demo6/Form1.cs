using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo6
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbRed.Checked == true)
            {
                MessageBox.Show("You are selected Red !!");
                return;
            }
            if (rbBlue.Checked == true)
            {
                MessageBox.Show("You are selected Blue !!");
                return;
            }
            else
            {
                MessageBox.Show("You are selected Green !!");
                return;
            }
        }
    }
}
