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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = buttonHome.Height;
            homeControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonHome.Height;
            Sidepanel.Top = buttonHome.Top;
            homeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonNewAccount.Height;
            Sidepanel.Top = buttonNewAccount.Top;
            newAccount1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonViewAccount.Height;
            Sidepanel.Top = buttonViewAccount.Top;
            viewAccount1.BringToFront();
        }

        private void newAccount1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonSame_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonSame.Height;
            Sidepanel.Top = buttonSame.Top;
            sameAC1.BringToFront();        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sameAC1_Load(object sender, EventArgs e)
        {

        }
    }
}
