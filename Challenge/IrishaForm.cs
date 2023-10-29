using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace Challenge
{
    public partial class IrishaForm : Form
    {
        public IrishaForm()
        {
            InitializeComponent();
        }
        double price;
        double rounded = 0;
        double totalrounded=0;
        double saved;
        public static double savings = 0;

        private void IrishaForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            price = Convert.ToDouble(textBox1.Text);
            rounded = Math.Ceiling(price);
            saved = rounded - price;
            MessageBox.Show($"You have saved £{saved:0.00}.");
            savings = savings + saved;
            totalrounded = rounded + totalrounded;
            Form1.getForm().textBox1.Text = "£"+Convert.ToString(Math.Round(savings,2));
            Form1.getForm().textBox2.Text = "£"+Convert.ToString(Math.Round(totalrounded,2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show($"Your savings account now has £{savings:0.00}.");
        }
        
    }
}

