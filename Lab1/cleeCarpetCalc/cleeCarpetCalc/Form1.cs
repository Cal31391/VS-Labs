/* Caroline Lee
 * 9-6-2017
 * Lab 1
 */

using System;
using System.Windows.Forms;

namespace cleeCarpetCalc
{
    public partial class Main_CarpetCalculator : Form
    {
        const int SQ_FT_PER_SQ_YARD = 9;
        const int INCHES_PER_FOOT = 12;
        const string BEST_CARPET = "Berber";
        const string ECONOMY_CARPET = "Pile";

        int roomLengthFeet = 12,
            roomLengthInches = 2,
            roomWidthFeet = 14,
            roomWidthInches = 7;

        double roomLength,
               roomWidth,
               carpetPrice,
               numOfSquareFeet,
               numOfSquareYards,
               totalCost;

        //Main//
        public Main_CarpetCalculator()
        {
            InitializeComponent();
            roomLength = roomLengthFeet + roomLengthInches / INCHES_PER_FOOT;
            roomWidth = roomWidthFeet + roomWidthInches / INCHES_PER_FOOT;
        }

        /// <summary>
        /// Expensive Carpet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnExpensive_CheckedChanged(object sender, EventArgs e)
        {
            carpetPrice = 27.95;
        }

        /// <summary>
        /// Economy Carpet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnEconCarp_CheckedChanged(object sender, EventArgs e)
        {
            carpetPrice = 15.95;
        }

        /// <summary>
        /// Calculates price and displays in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAnswerBox.Text = string.Format("{0:c}", DeterminePrice());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnswerBox.Text = "";
        }

        /// <summary>
        /// Exits program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Determines square feet
        /// </summary>
        /// <returns></returns>
        public double DetermineSquareFeet()
        {
            numOfSquareFeet = roomLength * roomWidth;
            return numOfSquareFeet;
        }

        /// <summary>
        /// Determines square yards
        /// </summary>
        /// <returns></returns>
        public double DetermineSquareYards()
        {
            numOfSquareYards = DetermineSquareFeet() / SQ_FT_PER_SQ_YARD;
            return numOfSquareYards;
        }

        /// <summary>
        /// Determines price
        /// </summary>
        /// <returns></returns>
        public double DeterminePrice()
        {
            totalCost = DetermineSquareYards() * carpetPrice;
            return totalCost;
        }
    }
}
