/* Caroline Lee
 * 10/30/17
 * Coffee Shop App
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Form1 : Form
    {
        //dictionaries to hold coffee and syrup flavors(keys) and their prices(values)
        Dictionary<string, string> dictCoffee = new Dictionary<string, string>();
        Dictionary<string, string> dictSyrup = new Dictionary<string, string>();

        //price constants
        const string HIGHPRICE = "$4.50";
        const string MEDIUMPRICE = "$3.00";
        const string LOWPRICE = "$2.50";
        const string SYRUPPRICE = "$2.50";

        //variable to hold cute little coffee cup logo from external file
        string logo = "";


        public Form1()
        {
            InitializeComponent();

            //fill coffee dictionary with key/value pairs
            dictCoffee.Add("Espresso", HIGHPRICE);
            dictCoffee.Add("Latte", HIGHPRICE);
            dictCoffee.Add("Cappuccino", MEDIUMPRICE);
            dictCoffee.Add("Mocha", LOWPRICE);
            dictCoffee.Add("Americana", LOWPRICE);
            //bind combobox to coffee dictionary so it will be populated with values
            comBox_coffeeFlavors.DataSource = dictCoffee.ToList();
            comBox_coffeeFlavors.DisplayMember = "Key";//display the key only

            //fill syrup dictionary with key/value pairs
            dictSyrup.Add("Almond", SYRUPPRICE);
            dictSyrup.Add("Amaretto", SYRUPPRICE);
            dictSyrup.Add("Caramel", SYRUPPRICE);
            dictSyrup.Add("Chocolate Milano", SYRUPPRICE);
            dictSyrup.Add("Cinnamon", SYRUPPRICE);
            //bind listbox to syrup dictionary so it will be populated with values
            listBox_SyrupFlavors.DataSource = dictSyrup.ToList();
            listBox_SyrupFlavors.DisplayMember = "Key";//display the key only
            readFile(logo);//read the logo.txt file, catch exception if file is not found
        }

        /// <summary>
        /// Reads external file and puts content into string variable
        /// </summary>
        private void readFile(string l)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader("logo.txt", Encoding.UTF8))
                {
                    l = streamReader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File does not exist.", ex.Message);
            }
        }

        /// <summary>
        /// Adds new coffee flavor to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCoffeeFlavorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox_newFlavor.Text))
            {
                MessageBox.Show("Please enter a coffee flavor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comBox_coffeeFlavors.Items.Contains(textBox_newFlavor.Text))
            {
                MessageBox.Show("Flavor already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dictCoffee.Add(textBox_newFlavor.Text, LOWPRICE);

                comBox_coffeeFlavors.DataSource = dictCoffee.ToList();
               
                textBox_newFlavor.Clear();   
            }
        }

        /// <summary>
        /// Removes selected coffee flavor from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeCoffeeFlavorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string boxText = comBox_coffeeFlavors.SelectedText;
            if (string.IsNullOrEmpty(boxText))
            {
                MessageBox.Show("Please select a coffee flavor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string MessageBoxContent = "Are you sure you want to delete this flavor?";
                DialogResult dialogResult = MessageBox.Show(MessageBoxContent, "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dictCoffee.Remove(boxText);
                    comBox_coffeeFlavors.DataSource = dictCoffee.ToList();  
                }
            }
        }

        /// <summary>
        /// Clears the coffee list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearCoffeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MessageBoxContent = "Are you sure you want to delete this coffee flavor list?";
            if (string.IsNullOrEmpty(comBox_coffeeFlavors.Text))
            {
                MessageBox.Show("Coffee flavors list is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(MessageBoxContent, "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dictCoffee.Clear();
                    
                    comBox_coffeeFlavors.Text = "(Empty)";
                    comBox_coffeeFlavors.DataSource = dictCoffee.ToList();
                    MessageBox.Show("Coffee flavor list has been cleared.");
                }
            }
        }

        /// <summary>
        /// Counts number of coffee flavors in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countCoffeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string count = comBox_coffeeFlavors.Items.Count.ToString();
            MessageBox.Show("Number of Coffee Flavors: \n" + count, "Flavor Count");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_itemInfo.Text = "";
            label_syrupInfo.Text = "";
            textBox_newFlavor.Text = "";
            listBox_SyrupFlavors.ClearSelected();
            comBox_coffeeFlavors.Text = "Select Coffee Flavor"; 
        }

        /// <summary>
        /// Launches the "About" menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.richTextBox1.Text = "Programmer: Caroline Lee\n\n" + logo + "\n\n" +
                "This application allows the user to select various coffee and/or syrup flavors.\n\n" +
                "Users can add or remove a coffee flavor, as well as view pricing information for each item.";
           
            form2.Show();
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Toggles display of coffee flavor info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comBox_coffeeFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comBox_coffeeFlavors.Text))
            {
                string select = comBox_coffeeFlavors.SelectedItem.ToString();
                label_itemInfo.Text = "Coffee Flavor: \n" + select;
            }
        }

        /// <summary>
        /// Toggles display of syrup flavor info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_SyrupFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(listBox_SyrupFlavors.Text))
            {
                string selection = listBox_SyrupFlavors.SelectedItem.ToString();
                label_syrupInfo.Text = "Syrup Flavor: \n" + selection;
            }  
        }
    }
}
