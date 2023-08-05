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
    public partial class Syllabus : Form
    {
        public Syllabus()
        {
            InitializeComponent();
        }
        public Syllabus(String user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                pictureBox1.Hide();
                pictureBox2.Hide();
            }
            else if(user=="Admin")
            {
                pictureBox3.Hide();
                pictureBox4.Hide();
            }
        }
        private void Syllabus_FormClosed(object sender, FormClosedEventArgs e)
        {
            SSA_MDI nm = new SSA_MDI();
            this.Hide();
            nm.Show();
        }
    }
}
