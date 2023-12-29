using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;

namespace ATM
{
    public partial class withdraw : Form
    {
        public string FFID;
        public withdraw()
        {
            InitializeComponent();
        }

        void Fillcombo()
        {
            
             ATM.ClassWithdraw obj = new ATM.ClassWithdraw();
              obj.ID1 = TextboxWID.Text.Trim();
           // obj.ID1 = FFID;
            try
             {
                 SqlDataReader rd = obj.GetAccountNo(obj);
                 while (rd.Read())
                 {
                     DropdownWACNo.Items.Add(rd[1]);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("" + ex);
             }
        }
        private void buttonWHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
              if (TextboxWID.Text == "")
            {
                MessageBox.Show("Please Press Quick Scan And Scan Your Finger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DropdownWACNo.Text == "")
            {
                MessageBox.Show("Please Choose Accout Number and Press Confirm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextboxWBalance.Text == "")
            {
                MessageBox.Show("Please Press Confirm Button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (TextboxWAmount.Text == "")
            {
                MessageBox.Show("Please Fill Withdrawal Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //int balance = Convert.ToInt32(TextboxWBalance.Text.Trim());
            //int wamopunt = Convert.ToInt32(TextboxWAmount.Text.Trim());

           else if (TextboxWBalance.Text.Trim() == TextboxWAmount.Text.Trim())
            {
                MessageBox.Show("You Should maintain Rs.1000 as minimum Amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (Convert.ToInt32(TextboxWBalance.Text.Trim()) < Convert.ToInt32(TextboxWAmount.Text.Trim()))
               {
                   
                   MessageBox.Show("Your balance is low\n Please try another amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            else if (Convert.ToInt32(TextboxWBalance.Text.Trim()) == 1000)
            {

                MessageBox.Show("You can't make withdrawal\n your balance amount is low", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
              
                ATM.ClassWithdraw obj = new ATM.ClassWithdraw();

                obj.ACNo1 = DropdownWACNo.Text.Trim();
                obj.ID1 = TextboxWID.Text.Trim();
                obj.Amount1 = TextboxWAmount.Text.Trim();
                obj.Wamount = Convert.ToInt32(TextboxWAmount.Text.Trim());
                obj.Balance2 = Convert.ToInt32(TextboxWBalance.Text.Trim());
                
                
                obj.WithdrawDetails(obj);
                obj.ReduceAmount(obj);
                MessageBox.Show("Please Take Your Cash", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                this.Hide();
                withdraw pd = new withdraw();
                pd.Show();

           
              
                    
                  

            }
        }

        private void buttonWAccount_Click(object sender, EventArgs e)
        {
            if (TextboxWID.Text == "")
            {
                MessageBox.Show("Please Press Quick Scan And Scan Your Finger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            Fillcombo();
        }

        private void buttonWConfirm_Click(object sender, EventArgs e)
        {
            if (DropdownWACNo.Text == "")
            {
                MessageBox.Show("Please select the account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                ATM.ClassWithdraw obj = new ATM.ClassWithdraw();

                obj.ACNo1 = DropdownWACNo.Text.Trim();

                try
                {
                    SqlDataReader rd = obj.GetAccountBalance(obj);
                    while (rd.Read())
                    {
                        // comboBoxTACNo.Items.Add(rd[1]);
                        TextboxWBalance.Text = (rd[2].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void button1000_Click(object sender, EventArgs e)
        {
            TextboxWAmount.Text = "1000";
        }

        private void button5000_Click(object sender, EventArgs e)
        {
            TextboxWAmount.Text = "5000";
        }

        private void button7500_Click(object sender, EventArgs e)
        {
            TextboxWAmount.Text = "7500";
        }

        private void button10000_Click(object sender, EventArgs e)
        {
            TextboxWAmount.Text = "10000";
        }

        private void buttonWQuickScan_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortWithdraw.Write("100");
                serialPortWithdraw.DataReceived += SerialPortWithdraw_DataReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerialPortWithdraw_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            FFID = serialPortWithdraw.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            TextboxWID.Text = FFID;
        }

        private void withdraw_Load(object sender, EventArgs e)
        {
            //serialPortWithdraw.Open();
        }
    }
}
