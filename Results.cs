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
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_FormClosed(object sender, FormClosedEventArgs e)
        {
            SSA_MDI tr = new SSA_MDI();
            this.Hide();
            tr.Show();

        }
    }
}
