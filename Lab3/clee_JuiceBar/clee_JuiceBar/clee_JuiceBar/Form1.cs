/* Caroline Lee
 * 10-18-2017
 * Lab 3
 * PSTCC Juice Bar
 * Ordering system for items at the juice bar 
 * Creates orders, keeps summary of orders (price total, quantity)
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clee_JuiceBar
{
    public partial class Form1 : Form
    {
        //price constants
        const double TWELVE_PRICE = 3.00;
        const double SIXTEEN_PRICE = 3.50;
        const double TWENTY_PRICE = 4.00;
        const double ADDITIVE_PRICE = 2.50;

        //price trackers for daily/individual order items
        double totalTwelvePrice;
        double totalSixteenPrice;
        double totalTwentyPrice;
        double additivePrice;
        double orderPrice;
        double totalPrice;
        double dailyTotalPrice;

        //count trackers for order items
        int numOfAdditives;
        int numOf12;
        int numOf16;
        int numOf20;
        int drinkTotal;
        int orderCount;

        //strings built for output fields
        string twelveOunce;
        string sixteenOunce;
        string twentyOunce;

        //validation for user selections
        Boolean sizeIsSelected;
        Boolean typeIsSelected;

        //font and color changers
        FontDialog fdlg = new FontDialog();
        ColorDialog cdlg = new ColorDialog();


        //MAIN//
        public Form1()
        {
            InitializeComponent();
        }

        //-----------------EVENT METHODS-----------------//

        //operate drink selection -- enables specific (juice/smoothie) comBox 
        private void comboBox_drinkSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_drinkSelection.Text == "")
            {
                disableQuantityBoxes();
                comBox_juiceSelect.Enabled = false;
                comBox_smoothieSelect.Enabled = false;
            }
            if (comboBox_drinkSelection.Text == "Juice")
            {
                comBox_juiceSelect.Enabled = true;
                comBox_smoothieSelect.Enabled = false; 
            }
            if (comboBox_drinkSelection.Text == "Smoothie")
            {
                comBox_smoothieSelect.Enabled = true;
                comBox_juiceSelect.Enabled = false;     
            }    
        }

        //operate juice selection -- enables quantity and additives selections
        private void comBox_juiceSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBox_juiceSelect.Text == "")
            {
                disableQuantityBoxes();
            }
            else
            {
                lBox_additives.Enabled = true;
                enableQuantityBoxes();
                typeIsSelected = true;
            }  
        }

        //operate smoothie selection -- enables quantity and additives selections
        private void comBox_smoothieSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBox_smoothieSelect.Text == "")
            {
                disableQuantityBoxes();
            }
            else
            {
                lBox_additives.Enabled = true;
                enableQuantityBoxes();
                typeIsSelected = true;
            } 
        }

        //operate 12 ounce size selection
        private void comBox_12ou_SelectedIndexChanged(object sender, EventArgs e)
        {
            int multiplier_12 = Int32.Parse(comBox_12ou.Text);
            numOf12 += multiplier_12; 
            totalTwelvePrice = TWELVE_PRICE * multiplier_12;
            if (comBox_20ou.Text != "0")
            {
                sizeIsSelected = true;
            }
            twelveOunce = numOf12.ToString() + " " + label_12ou.Text;     
        }

        //operate 16 ounce size selection
        private void comBox_16ou_SelectedIndexChanged(object sender, EventArgs e)
        {
            int multiplier_16 = Int32.Parse(comBox_16ou.Text);
            numOf16 += multiplier_16;
            totalSixteenPrice = SIXTEEN_PRICE * multiplier_16;
            if (comBox_20ou.Text != "0")
            {
                sizeIsSelected = true;
            }
            sixteenOunce = numOf16.ToString() + " " + label_16ou.Text;  
        }

        //operate 20 ounce size selection
        private void comBox_20ou_SelectedIndexChanged(object sender, EventArgs e)
        {
            int multiplier_20 = Int32.Parse(comBox_20ou.Text);
            numOf20 += multiplier_20;
            totalTwentyPrice = TWENTY_PRICE * multiplier_20;
            if (comBox_20ou.Text != "0")
            {
                sizeIsSelected = true;
            }
            twentyOunce = numOf20.ToString() + " " + label_20ou.Text;     
        }

        //operate additives selection
        private void lBox_additives_SelectedIndexChanged(object sender, EventArgs e)
        {
            numOfAdditives = lBox_additives.SelectedItems.Count;
            additivePrice = numOfAdditives * ADDITIVE_PRICE;
        }

        //add items to order instance
        private void btn_addToOrder_Click(object sender, EventArgs e)
        {
            if (sizeIsSelected && typeIsSelected)
            {
                totalPrice = calculatePrice();
                label_order.Text = twelveOunce + "\n" + sixteenOunce + "\n" + twentyOunce + "\n +"
                    + numOfAdditives + " additives";
                clearAll();
            }
            else
            {
                MessageBox.Show("Please enter a drink type AND size.", "Error");
            } 
        }

        //get summary of total order instance
        private void btn_summary_Click(object sender, EventArgs e)
        {
            orderCount++;
            MessageBox.Show(getSummaryInfo(), "Summary");
        }

        //clear order instance
        private void btn_clearOrder_Click(object sender, EventArgs e)
        {
            label_order.Text = "";
            label_totalPriceContent.Text = "$0.00";
            clearAll();
        }

        //exit application
        private void btn_exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //menu item - show summary of order instance
        private void completeOrderMenuItem_Click(object sender, EventArgs e)
        {
            orderCount++;
            MessageBox.Show(getSummaryInfo(), "Order Summary");
        }

        //menu item - info about application in message box
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This application is designed to make ordering from the juice bar very easy for everyone. \n" +
                " Simply create an order, add as many items as you want, and pay at the end.";
            MessageBox.Show(message, "About This App");
        }

        //menu item - show daily order summary
        private void orderSummaryMenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(getDailySummary());
        }

        //menu item - exit application
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //menu item - changes fonts for every control in form
        private void fontMenuItem_Click(object sender, EventArgs e)
        {
            fdlg.ShowColor = true;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                foreach(Control c in this.Controls)
                {
                    c.Font = fdlg.Font;
                    c.ForeColor = fdlg.Color;
                }
            }
        }

        //menu item - changes back color of form
        private void colorMenuItem_Click(object sender, EventArgs e)
        {

            if (cdlg.ShowDialog() == DialogResult.OK)
            {      
                    this.BackColor = cdlg.Color;  
            }
        }

        //-----------------NON-EVENT METHODS-----------------//

        //make quantity selectors usable
        private void enableQuantityBoxes()
        {
            comBox_12ou.Enabled = true;
            comBox_16ou.Enabled = true;
            comBox_20ou.Enabled = true;
            lBox_additives.Enabled = true;
        }
        
        //make quantity selectors unusable
        private void disableQuantityBoxes()
        {
            comBox_12ou.Enabled = false;
            comBox_16ou.Enabled = false;
            comBox_20ou.Enabled = false;
            lBox_additives.Enabled = false;
        }

        //get total daily summary
        private string getDailySummary()
        {
            string summary;

            dailyTotalPrice += totalPrice;
            drinkTotal = numOf12 + numOf16 + numOf20;
            summary = "Daily Drink Count: \n" + drinkTotal.ToString() + "\n\n" + "Daily Order Count: \n" +
                orderCount.ToString() + "\n\n" + "Daily Total Price: \n" + dailyTotalPrice.ToString();
            return summary;
        }

        //get summary instance info
        private string getSummaryInfo()
        {
            string summary = "Drinks: \n" + label_order.Text + "\n\n" + "Total Order Price: " + 
                label_totalPriceContent.Text;
            return summary;
        }

        //clear order form
        private void clearAll()
        {
            lBox_additives.ClearSelected();
            comboBox_drinkSelection.SelectedIndex = 0;
            comBox_smoothieSelect.SelectedIndex = 0;
            comBox_juiceSelect.SelectedIndex = 0;
            comBox_12ou.SelectedIndex = 0;
            comBox_16ou.SelectedIndex = 0;
            comBox_20ou.SelectedIndex = 0;
            comBox_juiceSelect.Enabled = false;
            comBox_smoothieSelect.Enabled = false;
            disableQuantityBoxes();
        }

        //get price for order instance
        private double calculatePrice()
        {
            orderPrice += totalTwelvePrice + totalSixteenPrice + totalTwentyPrice + additivePrice;
            label_totalPriceContent.Text = string.Format("{0:c}", orderPrice);
            return orderPrice;
        }
    }
}
