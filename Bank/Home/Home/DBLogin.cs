using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class DBLogin
    {
        String username;
        String password;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public SqlDataReader login(DBLogin obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata("SELECT * FROM Login WHERE UserName='" + obj.username + "' and Password='" + obj.password + "' ");
        }
    }
}
