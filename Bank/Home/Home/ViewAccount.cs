using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace Home
{
    public partial class ViewAccount : UserControl
    {

        public string VFID;
        public ViewAccount()
        {
            InitializeComponent();
           // autosearch();
        }

      /*  void autosearch()
        {
            try
            {
                Home.DBViewAccount obj = new Home.DBViewAccount();
                SqlCommand comm = new SqlCommand();

                SqlDataReader rd = obj.AutoSearch(obj);
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (rd.Read())
                {
                    mycollection.Add(rd.GetString(0));
                }

                textBox1.AutoCompleteCustomSource = mycollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }*/

        private void buttonVSearch_Click(object sender, EventArgs e)
        {
            if (TextboxVAccountNo.Text == "")
            {
                MessageBox.Show("Please Enter the account number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxVAccountNo.Focus();
                //  TextboxVAccountNo.BackColor = Color.Red;

            }
            else
            {
                Home.DBViewAccount obj = new Home.DBViewAccount();

                obj.ACNo1 = TextboxVAccountNo.Text;
                obj.Name1 = TextboxVName.Text;
                obj.PhoneNo1 = TextboxVPhone.Text;
                obj.Address1 = TextboxVAddress.Text;
                obj.NIC1 = TextboxVNIC.Text;
                obj.FID1 = TextboxVFID.Text;
                obj.Fund1 = TextboxVFund.Text;
                // obj.Status1 = TextboxNStatus.Text;

                obj.ViewAccount(obj);


                try
                {
                    SqlDataReader rd = obj.ViewAccount(obj);

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            //TextboxVAccountNo.Text = (rd["Account_No"].ToString());
                            TextboxVName.Text = (rd["Name"].ToString());
                            TextboxVPhone.Text = (rd["Phone_No"].ToString());
                            TextboxVAddress.Text = (rd["Address"].ToString());
                            TextboxVNIC.Text = (rd["NIC"].ToString());
                            TextboxVFID.Text = (rd["FingerPrint"].ToString());
                            TextboxVFund.Text = (rd["InitialFund"].ToString());
                            comboBoxVStatus.Text = (rd["Status"].ToString());

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the correct account number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextboxVAccountNo.Text = String.Empty;
                        TextboxVAccountNo.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }



            }
        }

        private void buttonVUpdate_Click(object sender, EventArgs e)
        {
            if (TextboxVAccountNo.Text == "")
            {
                MessageBox.Show("Please Enter the account number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxVAccountNo.Focus();
            }
            else if (TextboxVName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxVName.Focus();
            }
            else if (!Regex.IsMatch(TextboxVName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid name ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxVName.Focus();
            }
            else if (TextboxVPhone.Text == "")
            {
                MessageBox.Show("Please Enter the phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxVPhone.Focus();
            }
            else if (TextboxVPhone.Text.Length < 10)
            {
                MessageBox.Show("Invalid phone number ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxVPhone.Focus();
            }
            else if (TextboxVAddress.Text == "")
            {
                MessageBox.Show("Please Enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxVAddress.Focus();
            }
            else if (!Regex.IsMatch(TextboxVAddress.Text, @"^[0-9]+\s+([a-zA-Z]+[a-zA-Z]+\s[a-zA-Z]+)$"))
            {
                MessageBox.Show("Invalid address ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxVAddress.Focus();
            }
            else if (TextboxVNIC.Text == "")
            {
                MessageBox.Show("Please Enter NIC number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxVNIC.Focus();
            }
            else if (comboBoxVStatus.Text == "")
            {
                MessageBox.Show("Please choose the status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxVStatus.Focus();
            }
            else
            {
                Home.DBViewAccount obj = new Home.DBViewAccount();

                obj.ACNo1 = TextboxVAccountNo.Text;
                obj.Name1 = TextboxVName.Text;
                obj.PhoneNo1 = TextboxVPhone.Text;
                obj.Address1 = TextboxVAddress.Text;
                obj.NIC1 = TextboxVNIC.Text;
                obj.FID1 = TextboxVFID.Text;
                obj.Fund1 = TextboxVFund.Text;
                obj.Status1 = comboBoxVStatus.Text;

             
                        obj.UpdateAccount(obj);


                        SqlDataReader rd2 = obj.UpdateAccount(obj);
                        SqlCommand comm = new SqlCommand();

                        comm.Parameters.AddWithValue(obj.Name1, TextboxVName.Text);
                        comm.Parameters.AddWithValue(obj.PhoneNo1, TextboxVPhone.Text);
                        comm.Parameters.AddWithValue(obj.Address1, TextboxVAddress.Text);
                        comm.Parameters.AddWithValue(obj.NIC1, TextboxVNIC.Text);
                        comm.Parameters.AddWithValue(obj.FID1, TextboxVFID.Text);
                        comm.Parameters.AddWithValue(obj.Fund1, TextboxVFund.Text);


                        MessageBox.Show("Details will be updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);              
               
            }

        }

        private void ViewAccount_Load(object sender, EventArgs e)
        {
            try
            {
                Home.DBViewAccount obj = new Home.DBViewAccount();
                SqlCommand comm = new SqlCommand();

                SqlDataReader rd = obj.AutoSearch(obj);
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (rd.Read())
                {
                    mycollection.Add(rd.GetString(0));
                }

                TextboxVAccountNo.AutoCompleteCustomSource = mycollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            //serialPortview.Open();
        }

        private void buttonNFinger_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortview.Write("100");
                serialPortview.DataReceived += SerialPortview_DataReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerialPortview_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            VFID = serialPortview.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            TextboxVFID.Text = VFID;
        }

        private void TextboxVPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}