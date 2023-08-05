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
    public partial class Vision : Form
    {
        public Vision()
        {
            InitializeComponent();
        }
        public Vision(String user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                richTextBox2.Hide();
                label2.Hide();
                label1.Hide();
                richTextBox1.Hide();
                label3.Hide();
                richTextBox3.Hide();
            }
            else if (user == "Admin")
            {
                pictureBox1.Hide();
                richTextBox2.Hide();
                label2.Hide();
                label3.Hide();
                richTextBox3.Hide();
            }
            else if (user == "1234")
            {
                label1.Hide();
                richTextBox1.Hide();
                pictureBox1.Hide();
                label3.Hide();
                richTextBox3.Hide();
            }
            else if (user == "1433")
            {
                label1.Hide();
                richTextBox1.Hide();
                pictureBox1.Hide();
                richTextBox2.Hide();
                label2.Hide();
            }

        }

        private void Vision_FormClosed(object sender, FormClosedEventArgs e)
        {
            SSA_MDI nm = new SSA_MDI();
            this.Hide();
            nm.Show();
        }

        private void Vision_Load(object sender, EventArgs e)
        {



        }


    }
}
