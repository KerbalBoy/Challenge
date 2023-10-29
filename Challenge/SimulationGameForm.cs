using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge
{
    public partial class SimulationGameForm : Form
    {
        public SimulationGameForm()
        {
            InitializeComponent();
            updateScreen();
            InitTimer();
        }

        double currentAmount = 500;
        double apr = 0;

        double nextBankCost = 100;

        int tickCount = 0;

        bool hasBoughtHouse = false;
        double amountPaidToHouse = 0;

        bool hasBoughtCar = false;
        double amountPaidToCar = 0;

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(tick);
            timer1.Interval = 500; // in miliseconds
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentAmount >= nextBankCost)
            {
                apr += 2;

                if (nextBankCost == 100)
                {
                    nextBankCost = 750;
                } else
                {
                    nextBankCost *= 2;
                }

                updateScreen();
            }
        }

        private void tick(Object sender, EventArgs e)
        {
            if (tickCount >= 40 * 6 || currentAmount < -10000)
            {
                return;
            }


            tickCount += 1;
            currentAmount *= 1 + (apr / 100);
            updateScreen();
        }

        private void updateScreen()
        {
            label1.Text = $"£{Convert.ToString(Math.Round(currentAmount, 2))}";
            aprLabel.Text = $"{apr}% APR";

            if (currentAmount < nextBankCost)
            {
                // make first button grey
                button1.BackColor = Color.Gray;
            }
            else
            {
                button1.BackColor = Color.Green;
            }

            button1.Text = $"Switch bank!\n{apr + 2}% for £{nextBankCost}";

            label2.Text = $"Year {tickCount / 6}";

            if (currentAmount < 50000 || hasBoughtHouse)
            {
                // make first button grey
                houseButton.BackColor = Color.Gray;
            }
            else
            {
                houseButton.BackColor = Color.Green;
            }



            if (currentAmount < 1000 || hasBoughtCar)
            {
                // make first button grey
                carButton.BackColor = Color.Gray;
            }
            else
            {
                carButton.BackColor = Color.Green;
            }

            if (hasBoughtHouse && amountPaidToHouse < 450000)
            {
                currentAmount -= (450000 / 30) / 6;
                amountPaidToHouse += (450000 / 30) / 6;
            }


            if (hasBoughtCar && amountPaidToCar < 10000)
            {
                currentAmount -= (9000 / 5) / 6;
                amountPaidToCar += (9000 / 5) / 6;
            }
        }

        private void SimulationGameForm_Load(object sender, EventArgs e)
        {
            
        }

        private void houseButton_Click(object sender, EventArgs e)
        {
            if (currentAmount > 50000 && !hasBoughtHouse)
            {
                currentAmount -= 50000;
                hasBoughtHouse = true;

                updateScreen();
            }
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            if (currentAmount > 1000 && !hasBoughtCar)
            {
                currentAmount -= 1000;
                hasBoughtCar = true;

                updateScreen();
            }
        }

        private void aprLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
