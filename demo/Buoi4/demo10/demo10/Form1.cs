﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbNumberic_Click(object sender, EventArgs e)
        {

            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 5;
            textBox1.Text = numericUpDown1.Value.ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                 
        }
    }
}
