using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {



            // Create a boolean flag for booking approval
            bool bookingApproved = true;

            // Get passenger name
            string passengerName = txtPaasengerName.Text.Trim();

            // Validate passenger name
            if (string.IsNullOrWhiteSpace(passengerName))
            {
                MessageBox.Show("Passenger name cannot be empty.");
                txtPaasengerName.Focus();
                bookingApproved = false;
                return;
            }

            // Declare variables for passenger information
            int passengerAge;
            int numberOfTickets;
            double baggageWeight;

            // Validate passenger age using TryParse
            if (!int.TryParse(txtPaasengerAge.Text.Trim(), out passengerAge))
            {
                MessageBox.Show("Passenger age must be a valid number.");
                txtPaasengerAge.Focus();
                bookingApproved = false;
                return;
            }

            // Validate number of tickets using TryParse
            if (!int.TryParse(txtNumberOfTickets.Text.Trim(), out numberOfTickets))
            {
                MessageBox.Show("Number of tickets must be a valid number.");
                txtNumberOfTickets.Focus();
                bookingApproved = false;
                return;
            }

            // Validate baggage weight using TryParse
            if (!double.TryParse(txtBaggageWeight.Text.Trim(), out baggageWeight))
            {
                MessageBox.Show("Baggage weight must be a valid number.");
                txtBaggageWeight.Focus();
                bookingApproved = false;
                return;
            }

            // Validate passenger age range
            if (passengerAge < 1 || passengerAge > 100)
            {
                MessageBox.Show("Passenger age must be between 1 and 100.");
                txtPaasengerAge.Focus();
                bookingApproved = false;
                return;
            }

            // Validate number of tickets
            if (numberOfTickets < 1 || numberOfTickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5.");
                txtNumberOfTickets.Focus();
                bookingApproved = false;
                return;
            }

            // Validate baggage weight per passenger
            // The assignment allows a maximum of 50 kg per passenger
            if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Baggage weight must be between 0 and 50 kg per passenger.");
                txtBaggageWeight.Focus();
                bookingApproved = false;
                return;
            }

            // Validate travel class selection
            if (!radioButtonNormalClass.Checked &&
                !radioButtonBussinesClass.Checked &&
                !radioButtonFirstClass.Checked)
            {
                MessageBox.Show("Please select a travel class.");
                bookingApproved = false;
                return;
            }

            // Reject First Class for passengers below 12 years
            if (passengerAge < 12 && radioButtonFirstClass.Checked)
            {
                MessageBox.Show("Passengers below 12 cannot book First Class.");
                bookingApproved = false;
                return;
            }

            // Determine travel class and ticket price
            string travelClass = "";
            double ticketPrice = 0;

            if (radioButtonNormalClass.Checked)
            {
                travelClass = "Normal Class";
                ticketPrice = 100; // Example price
            }
            else if (radioButtonBussinesClass.Checked)
            {
                travelClass = "Business Class";
                ticketPrice = 200; // Example price
            }
            else if (radioButtonFirstClass.Checked)
            {
                travelClass = "First Class";
                ticketPrice = 300; // Example price
            }

            // Calculate basic ticket cost
            double basicTicketCost = ticketPrice * numberOfTickets;

            // Calculate discount based on ticket quantity
            double quantityDiscountPercent = 0;

            if (numberOfTickets >= 3 && numberOfTickets <= 4)
            {
                quantityDiscountPercent = 0.05;
            }
            else if (numberOfTickets == 5)
            {
                quantityDiscountPercent = 0.10;
            }

            double quantityDiscountAmount =
                basicTicketCost * quantityDiscountPercent;

            // Calculate cost after quantity discount
            double costAfterQuantityDiscount =
                basicTicketCost - quantityDiscountAmount;

            // Calculate child or senior discount
            double ageDiscountPercent = 0;

            if (passengerAge < 12)
            {
                ageDiscountPercent = 0.20;
            }
            else if (passengerAge >= 60)
            {
                ageDiscountPercent = 0.10;
            }

            double ageDiscountAmount =
                costAfterQuantityDiscount * ageDiscountPercent;

            // Calculate travel insurance cost
            double insuranceCost = 0;

            if (checkBoxAddTravelInsurance.Checked)
            {
                insuranceCost = 25 * numberOfTickets;
            }

            // Calculate final booking cost
            double totalCost =
                costAfterQuantityDiscount
                - ageDiscountAmount
                + insuranceCost;

            // Calculate total baggage allowance
            double totalFreeBaggage = 20 * numberOfTickets;

            // Calculate maximum permitted baggage
            double maximumBaggage = 50 * numberOfTickets;

            // Display booking details
            listBoxResult.Items.Clear();

            listBoxResult.Items.Add("====== AIRLINE BOOKING DETAILS ======");
            listBoxResult.Items.Add("Passenger Name: " + passengerName);
            listBoxResult.Items.Add("Passenger Age: " + passengerAge);
            listBoxResult.Items.Add("Travel Class: " + travelClass);
            listBoxResult.Items.Add("Ticket Price: $" + ticketPrice.ToString("F2"));
            listBoxResult.Items.Add("Number of Tickets: " + numberOfTickets);
            listBoxResult.Items.Add("Baggage Weight per Passenger: " +
                                    baggageWeight.ToString("F2") + " kg");

            listBoxResult.Items.Add("--------------------------------------");
            listBoxResult.Items.Add("Basic Ticket Cost: $" +
                                    basicTicketCost.ToString("F2"));

            listBoxResult.Items.Add("Quantity Discount: -$" +
                                    quantityDiscountAmount.ToString("F2"));

            listBoxResult.Items.Add("Age Discount: -$" +
                                    ageDiscountAmount.ToString("F2"));

            listBoxResult.Items.Add("Travel Insurance: +$" +
                                    insuranceCost.ToString("F2"));

            listBoxResult.Items.Add("Free Baggage Allowance: " +
                                    totalFreeBaggage.ToString("F2") + " kg");

            listBoxResult.Items.Add("Maximum Baggage Limit: " +
                                    maximumBaggage.ToString("F2") + " kg");

            listBoxResult.Items.Add("--------------------------------------");
            listBoxResult.Items.Add("TOTAL COST: $" + totalCost.ToString("F2"));
            listBoxResult.Items.Add("Status: Booking Approved");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            // Clear all input fields
            txtPaasengerName.Clear();
            txtPaasengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();

            // Clear travel class selection
            radioButtonNormalClass.Checked = false;
            radioButtonBussinesClass.Checked = false;
            radioButtonFirstClass.Checked = false;

            // Reset travel insurance
            checkBoxAddTravelInsurance.Checked = false;

            // Clear previous results
            listBoxResult.Items.Clear();

            // Return focus to passenger name
            txtPaasengerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}











