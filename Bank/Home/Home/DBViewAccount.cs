using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class DBViewAccount
    {
        String ACNo;
        String Name;
        String PhoneNo;
        String Address;
        String NIC;
        String FID;
        String Fund;
        String Status;

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

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string PhoneNo1
        {
            get
            {
                return PhoneNo;
            }

            set
            {
                PhoneNo = value;
            }
        }

        public string Address1
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }

        public string NIC1
        {
            get
            {
                return NIC;
            }

            set
            {
                NIC = value;
            }
        }

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

        public string Fund1
        {
            get
            {
                return Fund;
            }

            set
            {
                Fund = value;
            }
        }

        public string Status1
        {
            get
            {
                return Status;
            }

            set
            {
                Status = value;
            }
        }

       
        public SqlDataReader ViewAccount(DBViewAccount obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata("select * from CustomerDetails where Account_No like'" + obj.ACNo1 + "'");

        }
        public SqlDataReader UpdateAccount(DBViewAccount obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata("update CustomerDetails set Name='" + obj.Name + "',Phone_No='" + obj.PhoneNo + "',Address='" + obj.Address + "',NIC='" + obj.NIC + "',FingerPrint='" + obj.FID + "',InitialFund='" + obj.Fund1 + "',Status='" + obj.Status1 + "' where Account_No='" + obj.ACNo1 + "'");

        }

        public SqlDataReader AutoSearch(DBViewAccount obj) //Auto Searching Details
        {
            DBConnection con = new DBConnection();
            return con.getdata("select* from CustomerDetails ");

        }

        public SqlDataReader CheckAC(DBViewAccount obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata(" select*from CustomerDetails where Account_No='" + obj.ACNo1 + "' ");
        }

        public SqlDataReader CheckNIC(DBViewAccount obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata(" select*from CustomerDetails where NIC='" + obj.NIC + "' ");
        }

    }
}
