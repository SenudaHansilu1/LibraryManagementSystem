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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 frm15 = new Form11();
            frm15.TopLevel = false;
            panel2.Controls.Add(frm15);
            frm15.BringToFront();
            frm15.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 frm16 = new Form14();
            frm16.TopLevel = false;
            panel2.Controls.Add(frm16);
            frm16.BringToFront();
            frm16.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 frm17 = new Form12();
            frm17.TopLevel = false;
            panel2.Controls.Add(frm17);
            frm17.BringToFront();
            frm17.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 frm17 = new Form13();
            frm17.TopLevel = false;
            panel2.Controls.Add(frm17);
            frm17.BringToFront();
            frm17.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm18 = new Form1();
            frm18.Show();
        }
    }
}
