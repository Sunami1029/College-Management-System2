using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace College_Management_System
{
    public partial class TeachingStaff : Form
    {
        public TeachingStaff()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Could'nt Update anything", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel) ;
            {

            }

        }

        private void TeachingStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            SSA_MDI nh = new SSA_MDI();
            this.Hide();
            nh.Show();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void TeachingStaff_Load(object sender, EventArgs e)
        {
            WebBrowser wb = new WebBrowser();
            wb.Navigate("https://gfgc.kar.nic.in/ssa-bellary/About-Us-2");
        }
    }
}
