using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class DBLogin
    {
        String FID;

        public string FID1
        {
            get
            {
                return FID;
            }

            set
            {
                FID = value;
            }
        }
        public SqlDataReader login(DBLogin obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata("SELECT * FROM CustomerDetails WHERE FingerPrint='" + obj.FID1 + "'");
        }
    }
}
