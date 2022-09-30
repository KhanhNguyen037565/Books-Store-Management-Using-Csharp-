using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1;
            tb1 = textBox1.Text;
            string tb2;
            tb2 = textBox2.Text;
            string gtinh= " ";
            if(radioButton1.Checked == true)
            {
                gtinh = radioButton1.Text;
                
            }
            if (radioButton2.Checked == true)
            {
                gtinh = radioButton2.Text;
                
            }
            if (radioButton3.Checked == true)
            {
                gtinh = radioButton3.Text;
                
            }
            string subject = " ";
            if (checkBox1.Checked == true)
            {
                subject = checkBox1.Text;

            }
            if (checkBox2.Checked == true)
            {
                subject = checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                subject = checkBox3.Text;

            }
            MessageBox.Show(
                "Name: " + tb1
                + "\nAddress: " + tb2
                + "\nGender: " + gtinh
                + "\nCourse: " + subject
                ); 
            

        }
    }
}
