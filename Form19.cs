﻿using System;
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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.libraryDataSet1.User);
            // TODO: This line of code loads data into the 'libraryDataSet.Book_01' table. You can move, or remove it, as needed.
            this.book_01TableAdapter.Fill(this.libraryDataSet.Book_01);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
