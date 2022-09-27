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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lbSelect.SelectedIndex == 0)
            {
                MessageBox.Show("Sunday");
                return;
            }
            if (lbSelect.SelectedIndex == 1)
            {
                MessageBox.Show("Monday");
                return;
            }
            if (lbSelect.SelectedIndex == 2)
            {
                MessageBox.Show("Tuesday");
                return;
            }
            if (lbSelect.SelectedIndex == 3)
            {
                MessageBox.Show("Wednesday");
                return;
            }
            if (lbSelect.SelectedIndex == 4)
            {
                MessageBox.Show("Thursday");
                return;
            }
            if (lbSelect.SelectedIndex == 5)
            {
                MessageBox.Show("Friday");
                return;
            }
            if (lbSelect.SelectedIndex == 6)
            {
                MessageBox.Show("Saturday");
                return;
            }
            else
            {
                lbSelect.Text = "Sunday \nMonday \nTuesday \nWednesday \nThursday \nFriday \nSaturday";
                MessageBox.Show(lbSelect.Text);
            }
        }
    }
}
