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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
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

                TextboxAccountNo.AutoCompleteCustomSource = mycollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
