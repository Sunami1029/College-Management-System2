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
    public partial class Cinfo : Form
    {
        public Cinfo()
        {
            InitializeComponent();
        }
        public Cinfo(String user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                pictureBox1.Hide();

                pictureBox2.Hide();

            }
            else
            {
                label1.Hide();
                richTextBox1.Hide();
            }
        }
        private void Cinfo_Load(object sender, EventArgs e)
        {

        }



        private void Cinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            SSA_MDI nm = new SSA_MDI();
            this.Hide();
            nm.Show();
        }
    }
}
