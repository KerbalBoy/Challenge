﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Challenge
{
    public partial class Form1 : Form
    {
        static Form1 this_form;
        public Form1()
        {
            InitializeComponent();
            this_form = this;
        }

        private void nourhanPage_Click(object sender, EventArgs e)
        {
            NourhanForm form = new NourhanForm();
            form.Show();
        }

        private void irishaPage_Click(object sender, EventArgs e)
        {
            IrishaForm form = new IrishaForm();
            form.Show();
        }

        private void misbahPage_Click(object sender, EventArgs e)
        {
            MisbahForm form = new MisbahForm();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = IrishaForm.savings.ToString();
        }

        public static Form1 getForm()
        {
            return this_form;
        }

    }
}
