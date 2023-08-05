using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Studentdata : Form
    {
        SqlConnection con = new SqlConnection("Data Source=siddu143;Initial Catalog=\"SSA College\";Integrated Security=True");
        String query;

        public Studentdata()
        {
            InitializeComponent();
        }
        public Studentdata(String user)
        {
            InitializeComponent();
            if (user == "1238")
            {

            }
            if (user == "1239")
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttpp_Click(object sender, EventArgs e)
        {

        }

        private void Studentdata_FormClosed(object sender, FormClosedEventArgs e)
        {
            SSA_MDI fi = new SSA_MDI();
            this.Hide();
            fi.Show();

        }

        private void Studentdata_Load(object sender, EventArgs e)
        {
            ShowStudent();
        }
        private void ShowStudent()
        {
            con.Open();
            String qry = "select *from student";

            SqlDataAdapter sdt = new SqlDataAdapter(qry, con);
            DataTable ct = new DataTable();
            sdt.Fill(ct);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in ct.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();


            }
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "SSA*GFGC*BELLARY";
            printer.SubTitle = "ALL STUDENTS REPORT";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "FoxLearn";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            String qry = "select *from student where sname like '" + textBox1.Text + "%'";
            SqlDataAdapter sdt = new SqlDataAdapter(qry, con);
            DataTable ct = new DataTable();
            sdt.Fill(ct);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in ct.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String Sem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            String Branch = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


        }
    }
}
