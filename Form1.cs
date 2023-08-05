using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace College_Management_System
{


    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=siddu143;Initial Catalog=\"SSA College\";Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxun.Text == "")
            {
                MessageBox.Show("Please enter your User Name...");
            }
            if (this.textBoxpas.Text.Length == 0)
            {
                MessageBox.Show("Please enter your Password...");
            }
            if (this.textBoxpas.Text.Length == 0 || this.textBoxun.Text.Length == 0)
            {
                MessageBox.Show("All Fields are Mandatory...");
            }


            con.Open();
            String qry = "select *from Ruser where username='" + textBoxun.Text + "' and password='" + textBoxpas.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Valid User");
                SSA_MDI md = new SSA_MDI();
                this.Hide();
                md.Show();
            }
            else
            {
                MessageBox.Show("Ivalid User");
            }

            con.Close();
            button2_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBoxpas.Text = "";
            this.textBoxun.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}