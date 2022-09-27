using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string msg = " ";
            if(ckBox1.Checked == true)
            {
                msg = "Nhập môn lập trình";
            }
            if (ckBox2.Checked == true)
            {
                msg = msg + "\nLập trình hướng đối tượng";
            }
            if (ckBox3.Checked == true)
            {
                msg = msg + "\nLập trình trực quan";
            }
            if(msg.Length > 0)
            {
                MessageBox.Show(msg + "\nĐã được chọn");
            }
            else
            {
                MessageBox.Show("Không có môn nào được chọn");
            }
            ckBox1.ThreeState = true;
        }
    }
}
