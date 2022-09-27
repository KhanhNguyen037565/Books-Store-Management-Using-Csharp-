using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(cbSelect.SelectedIndex == 0)
            {
                MessageBox.Show("Sunday");
                return;
            }
            if (cbSelect.SelectedIndex == 1)
            {
                MessageBox.Show("Monday");
                return;
            }
            if (cbSelect.SelectedIndex == 2)
            {
                MessageBox.Show("Tuesday");
                return;
            }
            if (cbSelect.SelectedIndex == 3)
            {
                MessageBox.Show("Wednesday");
                return;
            }
            if (cbSelect.SelectedIndex == 4)
            {
                MessageBox.Show("Thursday");
                return;
            }
            if (cbSelect.SelectedIndex == 5)
            {
                MessageBox.Show("Friday");
                return;
            }
            if (cbSelect.SelectedIndex == 6)
            {
                MessageBox.Show("Saturday");
                return;
            }
            else
            {
                cbSelect.Text = "Sunday \nMonday \nTuesday \nWednesday \nThursday \nFriday \nSaturday";
                MessageBox.Show(cbSelect.Text);
            }
        }
    }
}
