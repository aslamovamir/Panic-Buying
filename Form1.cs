using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            double item_price = 0;
            int num_items = 0;
            double money = 0;

            bool error = false;

            try
            {
                //get the item price from the respective texbox
                item_price = double.Parse(Item_Price.Text);
                //validate the item price
                if (item_price <= 0)
                {
                    //show a message box
                    MessageBox.Show("Invalid input for the item price! Put a value greater than 0!");
                    //reset the text value of the item price textbox
                    Item_Price.Text = "";
                    error = true;
                }
            } catch {
                MessageBox.Show("Invalid input! Enter a number!");
                Item_Price.Text = "";
                error = true;
            }
            
            try
            {
                //get the number of units
                num_items = int.Parse(Number_Units.Text);
                //validate the number of items
                if (num_items <= 0)
                {
                    //show a message box
                    MessageBox.Show("Invalid input for the number of units! Put a value greater than 0!");
                    //reset the text value of the textbox
                    Number_Units.Text = "";
                    error = true;
                }
            } catch
            {
                MessageBox.Show("Invalid input! Enter a number!");
                Number_Units.Text = "";
                error = true;
            }

            try {
                //get the amount of money the user has
                money = double.Parse(Money_Amount.Text);
                //validate the money amount
                if (money < 0)
                {
                    //show a message box
                    MessageBox.Show("Invalid input for the amount of money! Put a value greater than or eqaul to 0!");
                    //reset the text value of the textbox
                    Money_Amount.Text = "";
                    error = true;
                }
            } catch
            {
                MessageBox.Show("Invalid input! Enter a number!");
                Money_Amount.Text = "";
                error = true;
            }

            if (error)
            {
                Results.Text = "Error! Check your inputs!";
            }
            else
            {
                Results.Text = "";

                //now let's calculate the total amount of money required
                double total = 0;

                for (int i = 1; i <= num_items; i++)
                {
                    total += item_price * i;
                }

                //now check if the amount of the user money is less than the total required
                //if so, tell how much more is required
                if (total > money)
                {
                    //respectively change the text value of the results textbox
                    Results.Text = "Error! " + (total - money).ToString() + " dollar(s) are requred to complete the purchase!";
                }
                //if the user money amount is greater than or equal to the total required, indicate purchase can be successfully completed
                else
                {
                    //respectively change the text value of the results textbox
                    Results.Text = "Success! Sufficient amount of money to successfully complete the purchase!";
                }
            }
        }
    }
}
