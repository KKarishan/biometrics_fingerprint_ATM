using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace ATM
{
    public partial class balance : Form
    {
        public string BFID;
        public balance()
        {
            InitializeComponent();
        }

        void Fillcombo()
        {
            ATM.DBBalance obj = new ATM.DBBalance();
            obj.FingerID1 = TextboxIFingerID.Text.Trim();
            try
            {
                SqlDataReader rd = obj.GetAccountNo(obj);
                while (rd.Read())
                {
                    DropdownACNumber.Items.Add(rd[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void buttonIHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void buttonIAccount_Click(object sender, EventArgs e)
        {
            if (TextboxIFingerID.Text == "")
            {
                MessageBox.Show("Please Press Quick Scan And Scan Your Finger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                Fillcombo();
        }

        private void buttonIConfirm_Click(object sender, EventArgs e)
        {
            if (DropdownACNumber.Text == "")
            {
                MessageBox.Show("Please select the account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                ATM.DBBalance obj = new ATM.DBBalance();

                obj.ACBalance1 = DropdownACNumber.Text.Trim();
                //DropdownACNumber.SelectedItem = 1;

                try
                {
                    SqlDataReader rd = obj.GetAccountBalance(obj);
                    while (rd.Read())
                    {
                        // comboBoxTACNo.Items.Add(rd[1]);
                        TextboxACBalance.Text = (rd[2].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void buttonIQuickScan_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortBalance.Write("100");
                serialPortBalance.DataReceived += SerialPortBalance_DataReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void SerialPortBalance_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            BFID = serialPortBalance.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            TextboxIFingerID.Text = BFID;
        }

        private void balance_Load(object sender, EventArgs e)
        {
            //serialPortBalance.Open();
        }
    }
}
