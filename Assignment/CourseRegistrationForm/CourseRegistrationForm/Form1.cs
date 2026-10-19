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

namespace CourseRegistrationForm
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
          
        }


       
        private void btnExit_Click(object sender, EventArgs e)
        {
          
        }

        private void chkAccommodation_CheckedChanged(object sender, EventArgs e)
        {

        }

        //  Calculate Button Click Event
        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            // Variables for student information
            string studentName = txtName.Text;
            string studentId = txtId.Text;
            int numCourses = 0;
            int studyLevel = 0;

            // Validate number of courses (Must be between 1 and 8)
            if (!int.TryParse(txtCourses.Text, out numCourses) || numCourses < 1 || numCourses > 8)
            {
                MessageBox.Show("Please enter a valid number of courses between 1 and 8.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate study level (Must be between 1 and 4)
            if (!int.TryParse(txtStudyLevel.Text, out studyLevel) || studyLevel < 1 || studyLevel > 4)
            {
                MessageBox.Show("Please enter a valid study level between 1 and 4.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine fee per course based on study level
            double feePerCourse = 0;
            switch (studyLevel)
            {
                case 1: feePerCourse = 40; break;
                case 2: feePerCourse = 45; break;
                case 3: feePerCourse = 50; break;
                case 4: feePerCourse = 55; break;
            }

            // Calculate basic tuition fee
            double tuitionFee = numCourses * feePerCourse;

            // Optional fees for accommodation and transport
            double accommodationFee = 0;
            double transportFee = 0;

            // Check if accommodation is selected
            if (chkAccommodation.Checked)
            {
                accommodationFee = 120;
            }

            // Check if transport fee is entered or selected
            if (chkTransport.Checked || txtTransportInput.Text == "50" || txtTransportInput.Text.ToLower() == "yes")
            {
                transportFee = 50;
            }

            // Calculate discount percentage
            double discountPercentage = 0;

            // 10% discount for 6 or more courses
            if (numCourses >= 6)
            {
                discountPercentage += 0.10;
            }

            // Extra 5% service discount if both services are selected and courses >= 5
            if ((chkAccommodation.Checked || accommodationFee > 0) &&
                (chkTransport.Checked || transportFee > 0) &&
                numCourses >= 5)
            {
                discountPercentage += 0.05;
            }

            // Calculate final amounts
            double discountAmount = tuitionFee * discountPercentage;
            double finalAmount = tuitionFee + accommodationFee + transportFee - discountAmount;

            // Display results in output labels
            lblOutName.Text = "Name: " + studentName;
            lblOutId.Text = "Id: " + studentId;
            lblOutCourses.Text = "Number Courses: " + numCourses.ToString();
            lblOutStudyYear.Text = "Study year: " + studyLevel.ToString();

            txtTransportInput.Text = "Transport Fee: " + transportFee.ToString();
            lblOutDiscount.Text = "Discount: " + discountAmount.ToString();
            lblOutTuition.Text = "Tuition fee: " + tuitionFee.ToString();
            lblOutFinalAmount.Text = "Final Amount: " + finalAmount.ToString();
        }


       
        private void btnClear_Click(object sender, EventArgs e)
        {
         
        }

        //  Clear Button Click Event
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            // Clear all text inputs and checkboxes
            txtName.Clear();
            txtId.Clear();
            txtCourses.Clear();
            txtStudyLevel.Clear();
            if (txtTransportInput != null) txtTransportInput.Clear();
            chkAccommodation.Checked = false;
            chkTransport.Checked = false;

            // Reset all output labels to default text
            lblOutName.Text = "Name:";
            lblOutId.Text = "Id:";
            lblOutCourses.Text = "Number Courses:";
            lblOutStudyYear.Text = "Study year:";
            txtTransportInput.Text = "Transport Fee:";
            lblOutDiscount.Text = "Discount:";
            lblOutTuition.Text = "Tuition fee:";
            lblOutFinalAmount.Text = "Final Amount:";
        }

        //  Exit Button Click Event
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}











