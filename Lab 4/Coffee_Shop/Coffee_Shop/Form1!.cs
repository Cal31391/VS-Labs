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
        Dictionary<string, string> dictCoffee = new Dictionary<string, string>();

        Dictionary<string, string> dictSyrup = new Dictionary<string, string>();

        const string HIGHPRICE = "$4.50";
        const string MEDIUMPRICE = "$3.00";
        const string LOWPRICE = "$2.50";

        public Form1()
        {
            InitializeComponent();

            dictCoffee.Add("Espresso", HIGHPRICE);
            dictCoffee.Add("Latte", HIGHPRICE);
            dictCoffee.Add("Cappuccino", MEDIUMPRICE);
            dictCoffee.Add("Mocha", LOWPRICE);
            dictCoffee.Add("Americana", LOWPRICE);

            comBox_coffeeFlavors.DataSource = dictCoffee.ToList();
            comBox_coffeeFlavors.DisplayMember = "Key";
            comBox_coffeeFlavors.Text = "Select Coffee Flavor";
        }

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

                comBox_coffeeFlavors.Text = "Select Coffee Flavor";
                textBox_newFlavor.Clear();

               
            }
        }

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
                    comBox_coffeeFlavors.Items.Remove(boxText);
                }
            }
        }

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
                    comBox_coffeeFlavors.Items.Clear();
                    comBox_coffeeFlavors.Text = "(Empty)";
                    MessageBox.Show("Coffee flavor list has been cleared.");
                }
            }


        }

        private void countCoffeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string count = comBox_coffeeFlavors.Items.Count.ToString();
            MessageBox.Show("Number of Coffee Flavors: \n" + count, "Flavor Count");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_itemInfo.Text = "";
            textBox_newFlavor.Text = "";
            listBox_SyrupFlavors.ClearSelected();
            comBox_coffeeFlavors.Text = ""; 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            Form2 form2 = new Form2();

            form2.richTextBox1.Text = "Programmer: Caroline Lee\n\n" + 
                "This application does stuff...\n" +
                "Lots of stuff...";
           
            form2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comBox_coffeeFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = comBox_coffeeFlavors.SelectedItem.ToString();
            Console.Write(selection);
            
                //string price = dictCoffee[selection];
                //label_itemInfo.Text = "Coffee Flavor: \n" + selection + "\n\n" + "Price: \n" + price;
            
        }
    }
}
