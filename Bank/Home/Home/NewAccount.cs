using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Home
{
    public partial class NewAccount : UserControl
    {
        public string FID1;

        public NewAccount()
        {
            InitializeComponent();
            AutoID();
        }

        void AutoID()
        {
            Home.DBNewAccount obj = new Home.DBNewAccount();
            try
            {
                SqlDataReader rd = obj.Autofill(obj);
                string mid=null;
                while (rd.Read())
                {
                    mid = rd["Account_No"].ToString();              
                }

                mid = mid.Trim();
                string a = mid.Substring(1);
                int id = Convert.ToInt32(a);
                string ids = null;

                if (id > 0 && id < 9)
                {
                    id = id + 1;
                    ids = "A00" + id;
                }
                else if (id >= 0 && id < 99)
                {
                    id = id + 1;
                    ids = "A0" + id;
                }
                else if (id >= 99)
                {
                    id = id + 1;
                    ids = "A" + id;
                }
                this.TextboxNAccount.AppendText(ids); //"AppendText" is add for give details for while loop other wise it not working

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (TextboxNAccount.Text == "")
            {
                MessageBox.Show("Please Enter the account number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNAccount.Focus();
            }
            else if (TextboxNName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNName.Focus();
            }
            else if (TextboxNPhone.Text == "")
            {
                MessageBox.Show("Please Enter the phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNPhone.Focus();
            }

            else if (TextboxNAddress.Text == "")
            {
                MessageBox.Show("Please Enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNAddress.Focus();
            }
            else if (TextboxNNIC.Text == "")
            {
                MessageBox.Show("Please Enter NIC number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNAccount.Focus();
            }
            else if (TextboxNFID.Text == "")
            {
                MessageBox.Show("Please Scan the finger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNFID.Focus();
            }
            else if (TextboxNFund.Text == "")
            {
                MessageBox.Show("Please enter the initial fund", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNFund.Focus();
            }
            else if (!Regex.IsMatch(TextboxNName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid name ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNName.Focus();
            }
            else if (!Regex.IsMatch(TextboxNAddress.Text, @"^[0-9]+\s+([a-zA-Z]+[a-zA-Z]+\s[a-zA-Z]+)$"))
            {
                MessageBox.Show("Invalid address ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNAddress.Focus();
            }
            else if (TextboxNPhone.Text.Length<10)
            {
                MessageBox.Show("Invalid phone number ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxNPhone.Focus();
            }
            else
            {            
                Home.DBNewAccount obj = new Home.DBNewAccount();
                
                obj.ACNo1 = TextboxNAccount.Text.Trim();
                obj.Name1 = TextboxNName.Text.Trim();
                obj.PhoneNo1 = TextboxNPhone.Text.Trim();
                obj.Address1 = TextboxNAddress.Text.Trim();
                obj.NIC1 = TextboxNNIC.Text.Trim();
                obj.FID1 = TextboxNFID.Text.Trim();
                obj.Fund1 = TextboxNFund.Text.Trim();
                obj.Status1 = "Active";

                try
                {
                    SqlDataReader rd = obj.CheckNIC(obj);

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            MessageBox.Show("Duplicate NIC number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                           
                            TextboxNNIC.Focus();
                        }

                            
                    }
                    else
                    {
                        obj.AddAccount(obj);
                        obj.AddAccount2(obj);

                        MessageBox.Show("Details will be saves successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        Form1 with = new Form1();
                        with.Show();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

              
              


            }
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            //serialPort1newAC.Open();
        }

        private void TextboxNAddress_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonNFinger_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1newAC.Write("100");
                serialPort1newAC.DataReceived += SerialPort1newAC_DataReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerialPort1newAC_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            FID1 = serialPort1newAC.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            TextboxNFID.Text = FID1;
        }

        private void TextboxNFund_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextboxNPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNClear_Click(object sender, EventArgs e)
        {


             TextboxNName.Text = String.Empty;
             TextboxNPhone.Text = String.Empty;
             TextboxNAddress.Text = String.Empty;
             TextboxNNIC.Text = String.Empty;
             TextboxNFID.Text = String.Empty;
             TextboxNFund.Text = String.Empty;

           


        }
    }
}
