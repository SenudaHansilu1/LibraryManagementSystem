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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IGJUS8\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Book_01 where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Deleted.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }
    }
}
