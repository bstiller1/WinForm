﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Why would you click here?\n Are you daft?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text + ", " + textBox1.Text;
            MessageBox.Show(textBox1.Text + " " + textBox2.Text);
        }
    }
}