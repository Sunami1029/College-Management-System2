using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class e_learn : Form
    {
        public e_learn()
        {
            InitializeComponent();
        }

        private void e_learn_FormClosed(object sender, FormClosedEventArgs e)
        {
            SSA_MDI tr = new SSA_MDI();
            this.Hide();
            tr.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
