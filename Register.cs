
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Register : Form
    {
        Function fn = new Function();
        String query;
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textEmail.Text = "";
            this.textID.Text = "";
            this.textName.Text = "";
            this.textUsename.Text = "";
            this.textpwd.Text = "";
            this.textphone.Text = "";
            cmbDepart.SelectedIndex = -1;
            CmbDesg.SelectedIndex = -1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "insert into Ruser(uid,name,dept,desg,mobile,email,username,password) values('" + textID.Text + "','" + textName.Text + "','" + cmbDepart.SelectedItem + "','" + CmbDesg.SelectedItem + "'," + textphone.Text + ",'" + textEmail.Text + "','" + textUsename.Text + "','" + textpwd.Text + "')";
            fn.setData(query);
            button2_Click(sender, e);
        }
    }
}
