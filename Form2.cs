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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm02 = new Form1();
            frm02.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm18 = new Form16();
            frm18.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm5 = new Form3();
            frm5.Show();
            this.Hide();
            Form frm5 = new Form3();
            frm5.Show();
        }
                this.Hide();
                Form frm2 = new Form10();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username & Password...");
            }

        }
    }
}
