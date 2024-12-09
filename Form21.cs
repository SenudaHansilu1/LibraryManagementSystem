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

namespace Library_management
{
    public partial class Form21 : Form
    {

        string connectionString = @"Data Source=DESKTOP-4IGJUS8\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;";
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Book_01", sqlcon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM [User]", sqlcon);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView2.DataSource = dt;

            }
        }
    }
}
