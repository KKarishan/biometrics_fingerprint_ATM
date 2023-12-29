using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class DBSameAC
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

        public SqlDataReader AutoSearch(DBSameAC obj) //Auto Searching Details
        {
            DBConnection con = new DBConnection();
            return con.getdata("select* from CustomerDetails ");

        }
        public SqlDataReader ViewAccount(DBSameAC obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata("select * from CustomerDetails where Account_No like'" + obj.ACNo1 + "'");

        }
        public SqlDataReader CheckACNO(DBSameAC obj)
        {
            DBConnection con = new DBConnection();
            return con.getdata(" select*from CustomerDetails where Account_No='" + obj.ACNo + "' ");
        }
        public void AddAccount(DBSameAC obj)//insert details
        {

            String SQL = "insert into CustomerDetails values('" + obj.ACNo1 + "','" + obj.Name + "','" + obj.PhoneNo + "','" + obj.Address + "','" + obj.NIC + "','" + obj.FID + "','" + obj.Fund1 + "','" + obj.Status + "')";

            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }
        public void AddAccount2(DBSameAC obj)//insert details
        {

            String SQL = "insert into AccountHolders values('" + obj.FID + "','" + obj.ACNo + "','" + obj.Fund + "')";

            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }
    }
}
