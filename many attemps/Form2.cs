﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace many_attemps
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            regFormuc1.Show();
            regFormuc1.BringToFront();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            Form2 f2 = new Form2();
            f2.Close();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BuyDash_v1 buy1 = new BuyDash_v1();
            buy1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            regFormuc1.Hide();
        }

        private void regFormuc1_Load(object sender, EventArgs e)
        {

        }
    }
}
