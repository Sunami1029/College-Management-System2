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
    public partial class Histoclg : Form
    {
        public Histoclg()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString(textBox1.Text, new Font("Times New Roman", 12,
                FontStyle.Regular), Brushes.Black, new PointF(130, 130));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void Histoclg_FormClosed(object sender, FormClosedEventArgs e)
        {
            SSA_MDI ss = new SSA_MDI();
            this.Hide();
            ss.Show();
        }
    }
}
