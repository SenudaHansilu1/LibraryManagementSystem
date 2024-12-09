using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm08 = new Form5();
            frm08.TopLevel = false;
            panel2.Controls.Add(frm08);
            frm08.BringToFront();
            frm08.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm08 = new Form5();
            frm08.TopLevel = false;
            panel2.Controls.Add(frm08);
            frm08.BringToFront();
            frm08.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form17 frm10 = new Form17();
            frm10.TopLevel = false;
            panel2.Controls.Add(frm10);
            frm10.BringToFront();
            frm10.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form18 frm11 = new Form18();
            frm11.TopLevel = false;
            panel2.Controls.Add(frm11);
            frm11.BringToFront();
            frm11.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form21 frm12 = new Form21();
            frm12.TopLevel = false;
            panel2.Controls.Add(frm12);
            frm12.BringToFront();
            frm12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm13 = new Form1();
            frm13.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
