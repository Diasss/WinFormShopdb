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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source=L206-3;Initial Catalog=ShopDB;" + "User ID = " + textBox1.Text + ";" + "Password = " + textBox2.Text + ";";
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();

            sqlConnectionStringBuilder.DataSource = @"L206-3";
            sqlConnectionStringBuilder.InitialCatalog = "ShopDB";
            sqlConnectionStringBuilder.UserID = textBox1.Text;
            sqlConnectionStringBuilder.Password = textBox2.Text;

            //sqlConnectionStringBuilder["Data Source"] = @"L206-3";
            //sqlConnectionStringBuilder["InitialCatalog"] = "ShopDB";

            using (SqlConnection conn = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection opened to " + conn.Database);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
}
