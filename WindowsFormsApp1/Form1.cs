using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Samlever_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int txt1 = Convert.ToInt32(textBox1.Text);
            int txt2 = Convert.ToInt32(textBox2.Text);
            int txt3 = Convert.ToInt32(textBox3.Text);
            int txt4 = Convert.ToInt32(textBox4.Text);

           

            var collect =  txt1 + txt2 + txt3 - txt4;
            String txt = "Du har følgende i din pensionsoversigt:";
            Console.WriteLine(txt + " " + collect);
            MessageBox.Show("Se din pensionsoversigt i loggen");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
