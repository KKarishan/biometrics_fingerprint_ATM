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

namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxLFinger.PasswordChar = '#';
        }

        private void buttonLConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxLFinger.Text == "")
            {
                MessageBox.Show("Please press QuickScan\nAnd Scan your registered finger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                ATM.DBLogin obj = new ATM.DBLogin();
                
                obj.FID1 = textBoxLFinger.Text;
                try
                {
                    SqlDataReader rd = obj.login(obj);

                    if (rd.HasRows)
                    {
                        while (rd.Read())

                            if (textBoxLFinger.Text == rd[5].ToString())
                            {
                                switch (rd[7].ToString().Trim())
                                {
                                    case "Active":
                                        {
                                            this.Hide();
                                            Form1 ad11 = new Form1();
                                            ad11.Show();
                                            break;
                                        }
                                    case "Deactive":
                                        {
                                            MessageBox.Show("Access Denied\nYour Account was Deactivated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            textBoxLFinger.Text = String.Empty;
                                            textBoxLFinger.Focus();
                                            break;
                                        }
                                    
                                }
                                
                            }
                    }
                    else
                    {
                        MessageBox.Show("Please First open an account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxLFinger.Text = String.Empty;
                        textBoxLFinger.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
