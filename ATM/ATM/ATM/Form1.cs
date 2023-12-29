using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonFProfile_Click(object sender, EventArgs e)
        {

        }

        private void buttonFWithdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            withdraw with = new withdraw();
            with.Show();
        }

        private void buttonFBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            balance bal = new balance();
            bal.Show();
        }

        private void buttonFTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            transfer tra = new transfer();
            tra.Show();
        }
    }
}
