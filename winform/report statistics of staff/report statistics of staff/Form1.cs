using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace report_statistics_of_staff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void CustomizeDesing()
        {
            btnReportStatistics.Visible = false;
        }
        private void hideSubMenu()
        {
            if(btnReportStatistics.Visible = true)
            {
                btnReportStatistics.Visible = false;
            }
        }
        private void showSubMenu(Panel btnReportStatistics)
        {
            if (btnReportStatistics.Visible == false)
            {
                hideSubMenu();
                btnReportStatistics.Visible = true;
            }
            else
            {
                btnReportStatistics.Visible = false;
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            showSubMenu(btnReportStatistics);
        }

        private void btnStatisticsStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //....
            hideSubMenu();
        }

        private void btnStatisticsManager_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //....
            hideSubMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //....
            hideSubMenu();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            //....
            hideSubMenu();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            //....
            hideSubMenu();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //....
            hideSubMenu();
        }

        private void btnStocker_Click(object sender, EventArgs e)
        {
            //....
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        
    }
}
