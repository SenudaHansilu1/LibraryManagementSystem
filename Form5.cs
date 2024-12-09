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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_management
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm14 = new Form4();
            frm14.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //New Book Add//
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
                {
                    MessageBox.Show("Please Complete Required Fields");
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IGJUS8\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Book_01]([Id],[Book Name],[Type],[Price],[Write name])VALUES ('" + textBox1.Text + "' ,'" + textBox2.Text + "' ,'" + comboBox1.Text + "' , '" + textBox3.Text + "' ,  '" + textBox4.Text + "'  )", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Book Added.");

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IGJUS8\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Book_01  SET [Book Name]=@book , Type=@type , Price=@price , [Write name]=@Wname WHERE Id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@book", textBox2.Text);
            cmd.Parameters.AddWithValue("@type", comboBox1.Text);
            cmd.Parameters.AddWithValue("@price", textBox3.Text);
            cmd.Parameters.AddWithValue("@Wname", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Updated");
            
        }
    }
}
