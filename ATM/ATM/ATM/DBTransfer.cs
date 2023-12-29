using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class DBTransfer
    {
        String FPID;
        String ACNO;
        String Balance;
        String TransferACNO;
        String TransferAmount;
        int balance;
        int tamount;

        public string FPID1
        {
            get
            {
                return FPID;
            }

            set
            {
                FPID = value;
            }
        }

        public string ACNO1
        {
            get
            {
                return ACNO;
            }

            set
            {
                ACNO = value;
            }
        }

        public string Balance1
        {
            get
            {
                return Balance;
            }

            set
            {
                Balance = value;
            }
        }

        public string TransferACNO1
        {
            get
            {
                return TransferACNO;
            }

            set
            {
                TransferACNO = value;
            }
        }

        public string TransferAmount1
        {
            get
            {
                return TransferAmount;
            }

            set
            {
                TransferAmount = value;
            }
        }

        public int Balance2
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public int Tamount
        {
            get
            {
                return tamount;
            }

            set
            {
                tamount = value;
            }
        }

        public SqlDataReader GetAccountNo(DBTransfer obj) //insert comobox
        {
            DBConnection con = new DBConnection();
            return con.getdata("select * from AccountHolders where FingerPrint like'" + obj.FPID1 + "'");
        }

        public SqlDataReader GetAccountBalance(DBTransfer obj) //insert comobox
        {
            DBConnection con = new DBConnection();
            return con.getdata("select * from AccountHolders where AccountNo like'" + obj.ACNO1 + "'");
        }

        public void TransferDetails(DBTransfer obj)//insert details
        {

            String SQL = "insert into TransferDetails values('" + obj.FPID + "','" + obj.ACNO + "','" + obj.TransferACNO1 + "','" + obj.TransferAmount + "')";

            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }

        public SqlDataReader AddAmount(DBTransfer obj) //insert comobox
        {
            DBConnection con = new DBConnection();
            return con.getdata("update AccountHolders set Balance=( Balance+" +(obj.TransferAmount)+")  where AccountNo='"+obj.TransferACNO1+ "'     ");
        }

        public SqlDataReader ReduceAmount(DBTransfer obj) //insert comobox
        {
            DBConnection con = new DBConnection();
            return con.getdata("update AccountHolders set Balance=( Balance-" + (obj.TransferAmount) + ")  where AccountNo='" + obj.ACNO + "'     ");
        }
    }
}
