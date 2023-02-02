using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converted
{
    public partial class Form1 : Form
    {
        //constant for convertion rates
        const int FEET_INCHES = 12;
        const int YARDS_INCHES = 36;
        const int YARDS_FEET = 3;


        public Form1()
        {
            InitializeComponent();
        }
       
        private void exitButton_Click(object sender, EventArgs e)
        {
            //close app 
            this.Close();  
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //on click get the entered text and convert
            //if the number enter is a number

            decimal enteredNumber;// = decimal.Parse(distanceTextBox.Text);
            if(decimal.TryParse(distanceTextBox.Text, out enteredNumber))
            {
                //get the list box selections and convert to string to match 
                string fromConversion = fromListBox.SelectedItem.ToString();
                string toConversion = toListBox.SelectedItem.ToString();

                // declare converted total
                decimal convertedTotal;

                //if same conversion is selected display same number
                if(fromConversion==toConversion) {
                    //if the same items on both sides are selected the total would be equal
                    //display the total on the label.
                    convertedTotal = enteredNumber;
                    convertedDistance.Text = convertedTotal.ToString();


                }
                if (fromConversion=="Inches" && toConversion=="Feet") {
                    //convert inches to feet by dividing by 12
                    convertedTotal = enteredNumber / FEET_INCHES;
                    convertedDistance.Text = convertedTotal.ToString();

                }
                if (fromConversion== "Inches" && toConversion == "Yards")
                {
                    //convert inches to yard dividing inches by 36
                    convertedTotal = enteredNumber / YARDS_INCHES;
                    convertedDistance.Text = convertedTotal.ToString();

                }
                if (fromConversion == "Feet"&& toConversion == "Yards")
                {
                    //convert feet to yard by dividing
                    convertedTotal = enteredNumber/ YARDS_FEET;
                    convertedDistance.Text = convertedTotal.ToString();


                }
                if (fromConversion == "Feet" && toConversion == "Inches")
                {
                    //convert feet to inches by multiplying
                    convertedTotal = enteredNumber * FEET_INCHES;
                    convertedDistance.Text = convertedTotal.ToString();

                }
                if (fromConversion=="Yards" && toConversion == "Inches")
                {
                    //convert yards to inches by multiplying
                    convertedTotal = enteredNumber * YARDS_INCHES;
                    convertedDistance.Text = convertedTotal.ToString();

                }
                if (fromConversion == "Yards" && toConversion== "Feet")
                {
                    //convert yards to feet by multiplying
                    convertedTotal = enteredNumber * YARDS_FEET;
                    convertedDistance.Text = convertedTotal.ToString();
                }



            }
            else
            {
                MessageBox.Show("Enter a number to convert!");
            }

        }
    }
}
