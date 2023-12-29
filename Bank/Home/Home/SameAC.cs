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
using System.Text.RegularExpressions;

namespace Home
{
    public partial class SameAC : UserControl
    {
        public SameAC()
        {
            InitializeComponent();
        }

        private void SameAC_Load(object sender, EventArgs e)
        {
            try
            {
                Home.DBSameAC obj = new Home.DBSameAC();
                SqlCommand comm = new SqlCommand();

                SqlDataReader rd = obj.AutoSearch(obj);
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (rd.Read())
                {
                    mycollection.Add(rd.GetString(0));
                }

                TextboxSAccount.AutoCompleteCustomSource = mycollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void buttonSSearch_Click(object sender, EventArgs e)
        {
            if (TextboxSAccount.Text == "")
            {
                MessageBox.Show("Please Enter the account number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSAccount.Focus();
                //  TextboxVAccountNo.BackColor = Color.Red;

            }
            else
            {
                Home.DBSameAC obj = new Home.DBSameAC();

                obj.ACNo1 = TextboxSAccount.Text;
                obj.Name1 = TextboxSName.Text;
                obj.PhoneNo1 = TextboxSPhone.Text;
                obj.Address1 = TextboxSAddress.Text;
                obj.NIC1 = TextboxSNIC.Text;
                obj.FID1 = TextboxSFID.Text;
                obj.Fund1 = TextboxSFund.Text;
                obj.Status1 = "Active";

                obj.ViewAccount(obj);


                try
                {
                    SqlDataReader rd = obj.ViewAccount(obj);

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            //TextboxSAccount.Text = (rd["Account_No"].ToString());
                            TextboxSName.Text = (rd["Name"].ToString());
                            TextboxSPhone.Text = (rd["Phone_No"].ToString());
                            TextboxSAddress.Text = (rd["Address"].ToString());
                            TextboxSNIC.Text = (rd["NIC"].ToString());
                            TextboxSFID.Text = (rd["FingerPrint"].ToString());
                            TextboxSFund.Text = (rd["InitialFund"].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the correct account number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextboxSAccount.Text = String.Empty;
                        TextboxSAccount.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void buttonSSave_Click(object sender, EventArgs e)
        {
            if (TextboxSAccount.Text == "")
            {
                MessageBox.Show("Please Enter the account number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSAccount.Focus();
            }
            else if (TextboxSName.Text == "")
            {
                MessageBox.Show("Please press the search button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSName.Focus();
            }
            else if (TextboxSPhone.Text == "")
            {
                MessageBox.Show("Please Enter the phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSPhone.Focus();
            }

            else if (TextboxSAddress.Text == "")
            {
                MessageBox.Show("Please Enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSAddress.Focus();
            }
            else if (TextboxSNIC.Text == "")
            {
                MessageBox.Show("Please Enter NIC number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSNIC.Focus();
            }
            else if (TextboxSFID.Text == "")
            {
                MessageBox.Show("Please Scan the finger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSFID.Focus();
            }
            else if (TextboxSFund.Text == "")
            {
                MessageBox.Show("Please enter the initial fund", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSFund.Focus();
            }
            else if (!Regex.IsMatch(TextboxSName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid name ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSName.Focus();
            }
            else if (!Regex.IsMatch(TextboxSAddress.Text, @"^[0-9]+\s+([a-zA-Z]+[a-zA-Z]+\s[a-zA-Z]+)$"))
            {
                MessageBox.Show("Invalid address ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSAddress.Focus();
            }
            else if (TextboxSPhone.Text.Length < 10)
            {
                MessageBox.Show("Invalid phone number ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSPhone.Focus();
            }
            else
            {
                Home.DBSameAC obj = new Home.DBSameAC();

                obj.ACNo1 = TextboxSAccount.Text.Trim();
                obj.Name1 = TextboxSName.Text.Trim();
                obj.PhoneNo1 = TextboxSPhone.Text.Trim();
                obj.Address1 = TextboxSAddress.Text.Trim();
                obj.NIC1 = TextboxSNIC.Text.Trim();
                obj.FID1 = TextboxSFID.Text.Trim();
                obj.Fund1 = TextboxSFund.Text.Trim();
                obj.Status1 = "Active";

                try
                {
                    SqlDataReader rd = obj.CheckACNO(obj);

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            MessageBox.Show("Duplicate Account number \n Please enter another account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TextboxSAccount.Focus();
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

        private void TextboxSPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextboxSFund_KeyPress(object sender, KeyPressEventArgs e)
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
