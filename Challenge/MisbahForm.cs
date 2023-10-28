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
    public partial class MisbahForm : Form

    {
        private Timer quoteTimer = new Timer();
        private string[] DailyNotifications;
        private int currentNotificationIndex = 0;
        private bool showNotification = false;
        public MisbahForm()
        {
            InitializeComponent();
            button1.Text = "Click here for a notification!";
            label1.Text = "";
            label2.Text = "Daily Notifications!!";

            DailyNotifications = new string[]
            {
            "Start Saving Early! The earlier you start saving, the more your money can grow due to compound interest",
            "Have Savings Goals! Having specific savings goals, like buying a car or going on a vacation, can motivate you to save",
            "Avoid Spending Unnecessarily! Resisting impulse purchases allows you to save more of your income, which you can spend later on more expensive items",
            "Save and Earn: Sometimes, you can earn money by helping with chores or selling items you don't need",
            "Did You Know? Banks keep your money safe when you’re not using it. They also let people borrow (or loan) money. Banks charge customers fees, or interest, for borrowing the money!",
            "Did You Know? Some countries share a currency. For example, countries in Europe all use the Euro. This makes buying and selling between countries less complicated"
            };

            
            quoteTimer.Interval = 5000;
            quoteTimer.Tick += new EventHandler(ChangeQuote);
            quoteTimer.Start();
        }

        private void ChangeQuote(object sender, EventArgs e)
        {
            currentNotificationIndex = (currentNotificationIndex + 1) % DailyNotifications.Length;

            if (showNotification)
            {
                label1.Text = DailyNotifications[currentNotificationIndex];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showNotification = true; 
            label1.Text = DailyNotifications[currentNotificationIndex];
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.AutoSize = true;
        }
        
    }
}
