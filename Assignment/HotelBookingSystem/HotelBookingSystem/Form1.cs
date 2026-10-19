using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // creating variables
            string guestName = txtGuestName.Text;
            int guestAge, numberOfNights, numberOfGuest = 0;

            // chekced if the booking is approved
            bool isApproved = true;

            // check is name is empty

            if (guestName=="")
            {
                MessageBox.Show("Guest name cannot be empty");
                isApproved = false;
                return;
            }
           

           // checkign text number is using tryparse

            if(!int.TryParse(txtGuestAge.Text, out guestAge))
            {
                MessageBox.Show("Invalid only need number");
                isApproved = false;
                return;
            }


            if (!int.TryParse(txtNumberOfNights.Text, out numberOfNights))
            {
                MessageBox.Show("Invalid only need number");
                isApproved = false;
                return;
            }

            if (!int.TryParse(txtNumberOfGuest.Text, out numberOfGuest))
            {
                MessageBox.Show("Invalid only need number");
                isApproved = false;
                return;
            }

            // checking limits

            if(guestAge<18 || guestAge > 90)
            {
                MessageBox.Show("Age must be between 18 and 90");
                isApproved = false;
                return;
            }

            if(numberOfNights<1 || numberOfNights > 30)
            {
                MessageBox.Show("number of nigtes must be between 1 and 30");
                isApproved = false;
                return;
            }

            if(numberOfGuest<1 || numberOfGuest > 6)
            {
                MessageBox.Show("number of guest must be between 1 and 6");
                isApproved = false;
                return;
            }

            // Check whether a room type has been selected
            if (!radioStandard.Checked &&
                !radioNormal.Checked &&
                !radioHight.Checked)
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            // checked room caapasity

            if (radioStandard.Checked && numberOfGuest > 2)
            {
                MessageBox.Show("Standerd room max is 2 Guests. Rejected");
                isApproved = false;

                return;

            }else if(radioNormal.Checked && numberOfGuest > 4)
            {
                MessageBox.Show("Normal room max is 4 Guests. Rejected");
                isApproved = false;
                return;

            }
            else if(radioHight.Checked && numberOfGuest > 6)
            {
                MessageBox.Show("hight room max is 6 Guests. Rejected");
                isApproved = false;
                return;
            }


            // calculate costs

            string roomType = "";
            double ratePerNights, beseRoomCost, totalCost = 0.0;

            if (isApproved)
            {
                if (radioStandard.Checked) roomType = "Standard";
                else if (radioNormal.Checked) roomType = "Normal";
                else if (radioHight.Checked) roomType = "Hight";

                switch (roomType)
                {
                    case "Standard":
                        ratePerNights = 50;
                        break;

                    case "Normal":
                        ratePerNights = 80;
                        break;


                    case "Hight":
                        ratePerNights = 130;
                        break;

                    default :
                        return;

                }
                beseRoomCost = ratePerNights * numberOfNights;

                // calculate nights discount

                double nightDiscountPercent = 0;
                if(numberOfNights>=5 && numberOfNights <= 9)
                {
                    nightDiscountPercent = 0.05;

                }else if(numberOfNights>=10)
                {
                    nightDiscountPercent = 0.12;
                }

                double nightsDiscountAmount = beseRoomCost * nightDiscountPercent;

                // calculate breKFast cost

                double breakFastCost = 0;
                if (checkBreakFast.Checked)
                {
                    breakFastCost = 10 * numberOfGuest * numberOfNights;
                }

                // add 5% surcharge if guests >4

                double surchargeAmount = 0;

                if (numberOfGuest > 4)
                {
                    surchargeAmount = beseRoomCost * 0.05;

                }

                // give 5% discount if age >=60
                double seniorDicountAmount = 0;


                if (guestAge >= 60)
                {
                    seniorDicountAmount = beseRoomCost * 0.05;
                }

                //total cost

                totalCost = beseRoomCost - nightsDiscountAmount + breakFastCost + surchargeAmount - seniorDicountAmount;


                // show result in listBox

                listBoxResult.Items.Clear();
                listBoxResult.Items.Add("=== ======== Hotel Room Booking Details ============");
                listBoxResult.Items.Add("Gust Name: " + guestName);
                listBoxResult.Items.Add("Gust Age: " + guestAge);
                listBoxResult.Items.Add("Room Type: " + roomType);
                listBoxResult.Items.Add("Number Of Nights: " + numberOfNights);
                listBoxResult.Items.Add(" Number of Guests: " + numberOfGuest);
                listBoxResult.Items.Add("Gust Name: " + guestName);
                listBoxResult.Items.Add("----------------------------------------------------");
                listBoxResult.Items.Add("Base Room cost: " + beseRoomCost);
                listBoxResult.Items.Add("nigh discount : - " + nightsDiscountAmount);
                listBoxResult.Items.Add("breakFast Charge: " + breakFastCost);
                listBoxResult.Items.Add("Sevices surchages: " + surchargeAmount);
                listBoxResult.Items.Add("Senior discount: - " + seniorDicountAmount);
                listBoxResult.Items.Add("-------------------------------------------------------");
                listBoxResult.Items.Add("Total Cost: " + totalCost);
                listBoxResult.Items.Add("Status : Booking Approved");
















            }









        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNumberOfNights.Clear();  
            txtNumberOfGuest.Clear();
            radioStandard.Checked = true;
            checkBreakFast.Checked = false;
            listBoxResult.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
