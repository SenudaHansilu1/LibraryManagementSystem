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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Register form //
                if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""|| textBox4.Text == ""|| textBox5.Text == "")
                {
                    MessageBox.Show("Please Complete Required Fields");
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IGJUS8\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[User]([Name],[Email],[Telephone No],[Username],[Password])VALUES ('" + textBox1.Text + "' ,'" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' )" , con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your Application has been submitted");
                    this.Hide();
                    Form frm17 = new Form2();
                    frm17.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

          
        }
    }
}
