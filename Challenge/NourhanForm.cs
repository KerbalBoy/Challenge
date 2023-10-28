using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            

            label1.Text = @"Purpose: 
Helping young people save towards wanted things.";

            label2.Text = @"Please enter in the amount of money that went IN and OUT of your account in the past 3 months:
            the data will appear in the form:
month 1, in:
month 1: out
month 2: in
etc...
the app will then work out how much you can afford to contribute to your chosen object :";

            starting_value = svalue;


            double svalue = 0d; // value in bank at start of each month
            double evalue = 0d; //value in bank at ennd of each month
            for (int i = 1; i < 4; i++)
            {
                label3.Text = $"Month {i}, in : ";
                svalue += Convert.ToDouble(Console.ReadLine());
                label4.Text = ($"Month {i}, out : ");
                evalue += Convert.ToDouble(Console.ReadLine());
            }

            double saving = (svalue - evalue) / 3; /*average (of 3 month), calculates how much money 
                                                    the person will be able to contribute each month */

            label5.Text = ("Would your parents like to make a contribution? enter 'yes' or 'no'.");
            string permission = Console.ReadLine();
            if (permission == "yes")
            {

                label6.Text = "How much would you like to contribute?";
                double contribution = Convert.ToDouble(Console.ReadLine());
            }

            label7.Text = ("How much does the object that you would like to purchase cost?");

            double cost = Convert.ToDouble(Console.ReadLine());

            long weeks = Convert.ToInt64((Math.Round(cost / saving)));

            label8.Text = ($@" Since your desired object costs £{cost}, and you will to contibute £{saving} each month towards it
, it would take {weeks} weeks for you to afford it.");

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
    }
}
