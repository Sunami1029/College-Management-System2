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
    public partial class StudentR : Form
    {
        Function fn = new Function();
        String query;
        public StudentR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textAddress1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnclera_Click(object sender, EventArgs e)
        {

            textAddress1.Text = "";
            textName1.Text = "";
            textphone1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }
        protected int n, total = 0;
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            query = "insert into student(sname,address,phone,sem,branch)values('" + textName1.Text + "','" + textAddress1.Text + "'," + textphone1.Text + ",'" + comboBox2.SelectedItem + "','" + comboBox1.SelectedItem + "')";
            fn.setData(query);

            MessageBox.Show("Student Registred Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void StudentR_Load(object sender, EventArgs e)
        {

        }

        private void buttoUP_Click(object sender, EventArgs e)
        {
            Studentdata sn = new Studentdata("1238");
            this.Hide();
            sn.Show();
        }

        private void butRMvee_Click(object sender, EventArgs e)
        {
            Studentdata sn = new Studentdata("1239");
            this.Hide();
            sn.Show();
        }
    }
}
