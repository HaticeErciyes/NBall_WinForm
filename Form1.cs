using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace NBall
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi = Convert.ToInt32(textBox1.Text);
                label1.Text = Math.Ceiling(Convert.ToDouble(Math.Log10(sayi) / Math.Log10(3))).ToString();
            
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş.");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.khanacademy.org/math/math-for-fun-and-glory/puzzles/brain-teasers/v/finding-heavier-ball?platform=hootsuite&modal=1");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
