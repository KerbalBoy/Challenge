using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


        private void projectName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void QuizPage_Click_1(object sender, EventArgs e)
        {
            Quiz form = new Quiz();
            form.Show();

        }
    }
}