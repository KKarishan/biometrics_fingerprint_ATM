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

namespace Home
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
            textBoxLPassword.PasswordChar = '*';
        }

        private void buttonLExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (textBoxLUserName.Text == "" || textBoxLPassword.Text == "")
            {
                MessageBox.Show("Please insert username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Home.DBLogin obj = new Home.DBLogin();
                obj.Username = textBoxLUserName.Text;
                obj.Password = textBoxLPassword.Text;
                try
                {
                    SqlDataReader rd = obj.login(obj);

                    if (rd.HasRows)
                    {
                        while (rd.Read())

                            if (textBoxLUserName.Text == rd[0].ToString() && textBoxLPassword.Text == rd[1].ToString())
                            {
                                this.Hide();
                                Form1 ad = new Form1();
                                ad.Show();
                            }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxLPassword.Text = String.Empty;
                        textBoxLPassword.Focus();
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
