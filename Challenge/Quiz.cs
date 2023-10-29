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
    public partial class Quiz : Form


    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Quiz()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    
                    "Quiz Ended!!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly!" + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again!"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }



            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum) 
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.image1;

                    label1.Text = "What is the term for money that you set aside for future needs or goals?";

                    button1.Text = "Money";
                    button2.Text = "Savings";
                    button3.Text = "Equity";
                    button4.Text = "Happiness";

                    correctAnswer = 2;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.pic2;

                    label1.Text = "When you put you money back into the bank, what does the bank do with it?";

                    button1.Text = "Pays Interest";
                    button2.Text = "Keeps it safe";
                    button3.Text = "Steals it";
                    button4.Text = "Pays interest and keeps it safe";

                    correctAnswer = 4;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.pic3;

                    label1.Text = "What should you do if you want to buy a new toy but dont have enough money currently?";

                    button1.Text = "Save up";
                    button2.Text = "Annoy your parents";
                    button3.Text = "Buy something else";
                    button4.Text = "Just cry";

                    correctAnswer = 1;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.pic4;

                    label1.Text = "What is the name of the magical power that makes your money grow?";

                    button1.Text = "Just pure magic";
                    button2.Text = "Aliens";
                    button3.Text = "Parents putting money there";
                    button4.Text = "Compound interest";

                    correctAnswer = 4;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.pic5;

                    label1.Text = "What is a good way to save money from you allowance or gifts?";

                    button1.Text = "Have a savings goal";
                    button2.Text = "Give it to your parents";
                    button3.Text = "Hide it";
                    button4.Text = "Spend it";

                    correctAnswer = 1;

                    break;




            }




        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }
    }

}
