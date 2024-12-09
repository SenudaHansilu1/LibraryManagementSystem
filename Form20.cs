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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_management
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.libraryDataSet1.User);
            // TODO: This line of code loads data into the 'libraryDataSet.Book_01' table. You can move, or remove it, as needed.
            this.book_01TableAdapter.Fill(this.libraryDataSet.Book_01);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IGJUS8\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=TrueData Source=DESKTOP-8NI0MP4;Initial Catalog=Library;Integrated Security=True");
           // con.Open();
           // SqlCommand cmd = new SqlCommand("Select * from  Book_01 where", con);
           // cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
           // SqlDataAdapter da = new SqlDataAdapter(cmd);
           // DataTable dt = new DataTable();
           // da.Fill(dt);
           // dataGridView1.DataSource = dt;//


        }
    }
}
