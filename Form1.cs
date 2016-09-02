using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public string allitems { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(returnMe());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label3.Text = textBox2.Text + ", " + textBox1.Text;
            MessageBox.Show(textBox1.Text + " " + textBox2.Text);
        }
        public string returnMe()
        {
            return "Why would you click here?\n Are you daft?";
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = " ";
            foreach (string activity in listBox1.SelectedItems)
            {
                result += activity + ", ";
            }
            label4.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tip Calculator\n ver 1.0 beta");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://blakestiller.com/contact.html");
            Process.Start(sInfo);
        }
    }
}
