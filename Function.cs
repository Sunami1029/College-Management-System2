using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Management_System
{
    internal class Function
    {
      protected SqlConnection GetConnection()
        {
            SqlConnection  con = new SqlConnection();
            con.ConnectionString = "Data Source=siddu143;Initial Catalog=\"SSA College\";Integrated Security=True";
            return con;
            
        }
        public DataSet getData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter  da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public void setData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Your Record Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
