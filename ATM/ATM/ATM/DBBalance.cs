using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class DBBalance
    {
        String FingerID;
        String ACBalance;
        String ACNumber;

        public string FingerID1
        {
            get
            {
                return FingerID;
            }

            set
            {
                FingerID = value;
            }
        }

        public string ACBalance1
        {
            get
            {
                return ACBalance;
            }

            set
            {
                ACBalance = value;
            }
        }

        public string ACNumber1
        {
            get
            {
                return ACNumber;
            }

            set
            {
                ACNumber = value;
            }
        }

        public SqlDataReader GetAccountNo(DBBalance obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata("select * from AccountHolders where FingerPrint like'" + obj.FingerID1 + "'");
        }

        public SqlDataReader GetAccountBalance(DBBalance obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata("select * from AccountHolders where AccountNo like'" + obj.ACBalance + "'");
        }
    }
}
