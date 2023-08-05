using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace College_Management_System
{
    public partial class NOn_Teaching : Form
    {
        public NOn_Teaching()
        {
            InitializeComponent();
        }
        public NOn_Teaching(String User)
        {
            InitializeComponent();
            if (User == "123")
            {
                textBox1.Hide();
                guna2HtmlLabel1.Hide();
            }
            else
            {
                richTextBox1.Hide();
                ititi.Hide();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SSA_MDI mdi = new SSA_MDI();
            this.Hide();
            mdi.Show();
        }

        private void NOn_Teaching_FormClosed(object sender, FormClosedEventArgs e)
        {
            SSA_MDI mdi = new SSA_MDI();
            this.Hide();
            mdi.Show();
        }
    }
}
