using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Challenge
{
    public partial class NourhanForm : Form
    {
        public NourhanForm()
        {
            InitializeComponent();

           

        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void header_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Our purpose is to help young people save towards smaller aspects of their " +
                "lives such as a new phone, game or something fun by introducting them to the concept of saving" +
                " what they can afford to monthly in order to purchase it, and how many weeks that process will" +
                " take");
        }

        private void NourhanForm_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double svalue = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox5.Text);
            double evalue = Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox6.Text);
            double savings = (svalue - evalue) / 3 + Convert.ToDouble(textBox7.Text);

            label10.Text = Convert.ToString(Math.Round(savings));
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double svalue = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox5.Text);
            double evalue = Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox6.Text);
            double savings = (svalue - evalue) / 3 + Convert.ToDouble(textBox7.Text);

            int weeks = Convert.ToInt16(Math.Round(Convert.ToDouble(textBox8.Text)/savings));  
            label18.Text = $"{ Convert.ToString(weeks)} weeks";



            


        }
    }
}
