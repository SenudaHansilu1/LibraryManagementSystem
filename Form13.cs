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

namespace Library_management
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Required Fields");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IGJUS8\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from  Book_01 where [Write name]=@Wname", con);
                cmd.Parameters.AddWithValue("@Wname", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
