using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Home
{
    class DBConnection
    {
        SqlConnection con;
        public SqlConnection createConnection()
        {
            //con = new SqlConnection(@"Data Source=10.0.0.4;Initial Catalog=80DOTNET52;Persist Security Info=true;User ID=hnd;Password=hnd");

            //con = new SqlConnection(@"Data Source=DESKTOP-1G0QD7K\SQLEXPRESS;Initial Catalog=karishan;Persist Security Info=true;User ID=karishan;Password=jpkk");

            con = new SqlConnection(@"Data Source=DESKTOP-8OS7571\SQLEXPRESS;Initial Catalog=karishan;Persist Security Info=true;User ID=sa;Password=jpkk");
            try
            {
                con.Open();
                return con;
            }
            catch (Exception)
            {
                con = null;
                return con;
            }

        }

        public void addvalues(string Sql)
        {
            con = createConnection();
            SqlCommand cmd = new SqlCommand(Sql, con);
            int i = cmd.ExecuteNonQuery();
        }

        public SqlDataReader getdata(String SQL)
        {
            con = createConnection();
            SqlCommand comm = new SqlCommand();

            comm.CommandText = SQL;
            comm.Connection = con;
            SqlDataReader sqlDReader;
            sqlDReader = comm.ExecuteReader();
            return sqlDReader;
        }

    }
}
