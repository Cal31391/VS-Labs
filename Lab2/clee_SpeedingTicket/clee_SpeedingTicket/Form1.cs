using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace clee_SpeedingTicket
{
    public partial class Main_TicketCalculator : Form
    {
        const int MPH_LIMIT = 35;

        int mph, ticketCount;
        double fineAmount, seniorFine, totalPrice, totalDailyPrice;
        double eveningPrice = 0;


        //Main
        public Main_TicketCalculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calculates total ticket price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, System.EventArgs e)
        {
            double price = calculateTotalPrice();
            txtbxPrice.Text = string.Format("{0:c}", price);

            if (cboxAppeal.Checked)
            { txtbxAppeal.Text = "Appeal"; }
            else
            { txtbxAppeal.Text = "No Appeal"; }

            updateTicketCountAndPrice(price);
        }
        /// <summary>
        /// Clears screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, System.EventArgs e)
        {
            txtbxPrice.Text = "";
            txtbxSpeed.Text = "";
            txtbxAppeal.Text = "";
            comboxViolators.Text = "";
            cboxEvening.Checked = false;
            cboxAppeal.Checked = false;
        }
        /// <summary>
        /// Exits program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Calculates fine based on violator category
        /// </summary>
        /// <returns></returns>
        public double calculateFine()
        {
            mph = Int32.Parse(txtbxSpeed.Text);
            if (isSpeeding())
            {
                if (mph <= 55)
                { seniorFine = 50.00; }
                else
                { seniorFine = 120.00; }

                switch (comboxViolators.Text)
                {
                    case "Visitors":
                        fineAmount = 35.00;
                        break;
                    case "Faculty/Staff":
                        fineAmount = 75.00 + (calcMileAddition(mph) * 30.00);
                        break;
                    case "Students":
                        fineAmount = 75.00 + (calcMileAddition(mph) * 37.50);
                        break;
                    case "Seniors":
                        fineAmount = 75.00 + seniorFine;
                        break;
                }
            }
            else { fineAmount = 0; }
            return fineAmount;
        }
        /// <summary>
        /// Calculates ticket price with or without evening price added
        /// </summary>
        /// <returns></returns>
        public double calculateTotalPrice()
        {
            if (cboxEvening.Checked && isSpeeding())
            { eveningPrice = 40.00; }
            else
            { eveningPrice = 0.00; }

            totalPrice = calculateFine() + eveningPrice;
            return totalPrice;
        }
        /// <summary>
        /// Checks to see if clocked speed is over the limit
        /// </summary>
        /// <returns></returns>
        public Boolean isSpeeding()
        {
            return mph > MPH_LIMIT;
        }
        /// <summary>
        /// Calculates mile addition 
        /// </summary>
        /// <param name="mph"></param>
        /// <returns></returns>
        public int calcMileAddition(int mph)
        {
            int mileAddition = 0;
            int mphDifference = mph - MPH_LIMIT;
            mileAddition = Convert.ToInt32(mphDifference / 5);


            //Debug.WriteLine($"{mileAddition}");
            return mileAddition;
        }
        /// <summary>
        /// Updates ticket count, price, and date
        /// </summary>
        /// <param name="tdp"></param>
        public void updateTicketCountAndPrice(double tdp)
        {
            ticketCount++;
            totalDailyPrice += tdp;
            txtbxDailyTotals.Text = string.Format("Ticket Count: {0}{2}Total Price: {1:c}", ticketCount, totalDailyPrice, Environment.NewLine);
            string date = DateTime.Now.ToString("M/d/yyyy");
            txtbxDate.Text = string.Format("Ticket issue date: {0}", date);
        }
    }
}
