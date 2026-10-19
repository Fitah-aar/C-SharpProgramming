using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Vehicle_Rental_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {



            //  INPUT VALIDATION USING TRYPARSE

            // Check if Customer Name is empty
            string customerName = txtCustomerName.Text.Trim();
            if (customerName=="")
            {
                MessageBox.Show("Please enter the customer name.");
                return;
            }

            // Validate Customer Age
            if (!int.TryParse(txtCustomerAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid integer for age.");
                return;
            }

            // Validate Number of Rental Days
            if (!int.TryParse(txtNumberOfRentalDays.Text, out int rentalDays))
            {
                MessageBox.Show("Please enter a valid integer for rental days.");
                return;
            }

            // Validate Driving Experience
            if (!int.TryParse(txtYearsOfDrvingExperience.Text, out int experience))
            {
                MessageBox.Show("Please enter a valid integer for driving experience.");
                return;
            }

            // --- BUSINESS LOGIC RULES VERIFICATION ---

            // Customer age must be between 18 and 80 years
            if (age < 18 || age > 80)
            {
                MessageBox.Show("Customer age must be between 18 and 80 years.");
                return;
            }

            // Customers below 21 years are not eligible
            if (age < 21)
            {
                MessageBox.Show("Customers below 21 years are not eligible.");
                return;
            }

            // Rental days must be between 1 and 30 days
            if (rentalDays < 1 || rentalDays > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30 days.");
                return;
            }

            // Driving experience cannot be negative
            if (experience < 0)
            {
                MessageBox.Show("Driving experience cannot be negative.");
                return;
            }

            // Customers must have at least 1 year of driving experience
            if (experience < 1)
            {
                MessageBox.Show("Customers must have at least 1 year of driving experience.");
                return;
            }

            // Determine Daily Rate based on Vehicle Type
            double dailyRate = 0;
            string vehicleType = "";

            if (rdoEconomy.Checked)
            {
                dailyRate = 35;
                vehicleType = "Economy";
            }
            else if (rdoSuv.Checked)
            {
                dailyRate = 60;
                vehicleType = "SUV";
            }
            else if (rdoLuxury.Checked)
            {
                dailyRate = 100;
                vehicleType = "Luxury";

                // Luxury vehicles require at least 25 years of age and 3 years of driving experience
                if (age < 25 || experience < 3)
                {
                    MessageBox.Show("Luxury vehicles require at least 25 years of age and 3 years of driving experience.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a Vehicle Type.");
                return;
            }

            //  COST CALCULATIONS

            // Calculate Basic Rental Cost
            double basicRentalCost = dailyRate * rentalDays;

            // Apply Rental Duration Discounts
            double discountPercentage = 0;
            if (rentalDays >= 7 && rentalDays <= 13)
            {
                discountPercentage = 0.05; // 5% discount
            }
            else if (rentalDays >= 14)
            {
                discountPercentage = 0.10; // 10% discount
            }
            double discount = basicRentalCost * discountPercentage;

            // Calculate Optional Insurance Cost ($15 per day)
            double insuranceCost = chkInsurance.Checked ? (15 * rentalDays) : 0;

            // Apply Young-Driver Surcharge (Age 21-24: Add 10% young-driver surcharge)
            double youngDriverSurcharge = 0;
            if (age >= 21 && age <= 24)
            {
                youngDriverSurcharge = basicRentalCost * 0.10;
            }

            // Calculate Final Total Rental Cost
            double finalRentalCost = basicRentalCost - discount + insuranceCost + youngDriverSurcharge;

            //  DISPLAY RESULTS
      

            listBoxresult.Items.Add("Customer Name :" + customerName);
            listBoxresult.Items.Add("Vehicle Type :" + vehicleType);
            listBoxresult.Items.Add("Basic Rental Cosrt : $" + basicRentalCost);
            listBoxresult.Items.Add("`Discount : -$" + discount);
            listBoxresult.Items.Add("Insurance Cost : $" + insuranceCost);
            listBoxresult.Items.Add("Young Driver Surcharge : $" + youngDriverSurcharge);
            listBoxresult.Items.Add("Final Rental cost : $" + finalRentalCost);
            listBoxresult.Items.Add("Rental Status : Approved ");






        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            // Clear all text entry boxes
            txtCustomerName.Clear();
            txtCustomerAge.Clear();
            txtNumberOfRentalDays.Clear();
            txtYearsOfDrvingExperience.Clear();
           listBoxresult.Items.Clear();

            // Uncheck selection options
            rdoEconomy.Checked = false;
            rdoSuv.Checked = false;
            rdoLuxury.Checked = false;
            chkInsurance.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}









