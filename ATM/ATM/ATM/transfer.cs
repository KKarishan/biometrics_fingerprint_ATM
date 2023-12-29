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
    public partial class transfer : Form
    {
        public string TFID;
        public transfer()
        {
            InitializeComponent();
           // Fillcombo();
        }

        void Fillcombo()
        {
            ATM.DBTransfer obj = new ATM.DBTransfer();
            obj.FPID1 = textBoxTID.Text.Trim();
            try
            {
                SqlDataReader rd = obj.GetAccountNo(obj);
                while (rd.Read())
                {
                    comboBoxTACNo.Items.Add(rd[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void buttonTQuickScan_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortTransfer.Write("100");
                serialPortTransfer.DataReceived += SerialPortTransfer_DataReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerialPortTransfer_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            TFID = serialPortTransfer.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            textBoxTID.Text = TFID;
        }

        private void buttonTHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void buttonTAccount_Click(object sender, EventArgs e)
        {
            if (textBoxTID.Text == "")
            {
                MessageBox.Show("Please Press Quick Scan And Scan Your Finger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                Fillcombo();
        }

        private void buttonTConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxTACNo.Text == "")
            {
                MessageBox.Show("Please select the account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                ATM.DBTransfer obj = new ATM.DBTransfer();

                obj.ACNO1 = comboBoxTACNo.Text.Trim();

                try
                {
                    SqlDataReader rd = obj.GetAccountBalance(obj);
                    while (rd.Read())
                    {
                        // comboBoxTACNo.Items.Add(rd[1]);
                        textBoxTBalance.Text = (rd[2].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {

            if (textBoxTID.Text == "")
            {
                MessageBox.Show("Please Press Quick Scan And Scan Your Finger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxTACNo.Text == "")
            {
                MessageBox.Show("Please Choose Accout Number and Press Confirm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxTBalance.Text == "")
            {
                MessageBox.Show("Please Press Confirm Button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxTTransferACNo.Text == "")
            {
                MessageBox.Show("Please Fill Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTTransferACNo.Focus();
            }

            else if (textBoxTTransferAmount.Text == "")
            {
                MessageBox.Show("Please Fill Transfer Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTTransferAmount.Focus();
            }
            // obj.ACNO1 = comboBoxTACNo.Text.Trim();
            //  int balance;
            // int tamount;
            //  balance = Int32.Parse(textBoxTBalance.Text.Trim());
            //  tamount = Int32.Parse(textBoxTTransferAmount.Text.Trim());

           else if (textBoxTBalance.Text.Trim() == textBoxTTransferAmount.Text.Trim())
            {
                MessageBox.Show("You Should maintain Rs.1000 as minimum Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(textBoxTBalance.Text.Trim()) < Convert.ToInt32(textBoxTTransferAmount.Text.Trim()))
            {
                MessageBox.Show("Your balance is low\n Please try another amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(textBoxTBalance.Text.Trim()) == 1000)
            {

                MessageBox.Show("You can't make withdrawal\n your balance amount is low", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ATM.DBTransfer obj = new ATM.DBTransfer();

                obj.FPID1 = textBoxTID.Text.Trim();
                obj.ACNO1 = comboBoxTACNo.Text.Trim();
                obj.TransferACNO1 = textBoxTTransferACNo.Text.Trim();
                obj.TransferAmount1 = textBoxTTransferAmount.Text.Trim();
                obj.Tamount = Convert.ToInt32(textBoxTTransferAmount.Text.Trim());
                obj.Balance2 = Convert.ToInt32(textBoxTBalance.Text.Trim());

                obj.TransferDetails(obj);
                obj.AddAmount(obj);
                obj.ReduceAmount(obj);

                MessageBox.Show("Amount is transfer successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void transfer_Load(object sender, EventArgs e)
        {
            //serialPortTransfer.Open();
        }

        private void textBoxTTransferAmount_KeyPress(object sender, KeyPressEventArgs e)
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
