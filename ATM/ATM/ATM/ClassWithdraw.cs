using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ClassWithdraw
    {
        String ACNo;
        String ID;
        String Amount;
        String Balance;
        int balance;
        int wamount;

        public string ACNo1
        {
            get
            {
                return ACNo;
            }

            set
            {
                ACNo = value;
            }
        }

        public string ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string Amount1
        {
            get
            {
                return Amount;
            }

            set
            {
                Amount = value;
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

        public int Wamount
        {
            get
            {
                return wamount;
            }

            set
            {
                wamount = value;
            }
        }

        public void WithdrawDetails(ClassWithdraw obj)//insert details
        {
            String SQL = "insert into WithdrawalDetails values('" + obj.ID + "','" + obj.ACNo1 + "','" + obj.Amount + "')";
            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }

        public SqlDataReader GetAccountNo(ClassWithdraw obj) 
        {
            DBConnection con = new DBConnection();
            return con.getdata("select * from AccountHolders where FingerPrint like'" + obj.ID1 + "'");
        }

        public SqlDataReader GetAccountBalance(ClassWithdraw obj) 
        {
            DBConnection con = new DBConnection();
            return con.getdata("select * from AccountHolders where AccountNo like'" + obj.ACNo1 + "'");
        }

        public SqlDataReader ReduceAmount(ClassWithdraw obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata("update AccountHolders set Balance=( Balance-" + (obj.Amount1) + ")  where AccountNo='" + obj.ACNo + "'     ");
        }
    }
}
