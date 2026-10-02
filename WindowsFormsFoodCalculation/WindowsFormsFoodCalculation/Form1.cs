using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFoodCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
        
            // Creating Variables

            // Food names
            string Food1, Food2;

            // Food prices and calculation variables
            double priceFood1, priceFood2;
            double SalesText, Tips, TotalAmount, NetAmount;

            // Fixed percentages
            const double SalesVat = 5;
            const double TipVat = 15;
            // Ka qaad magaca Food 1 TextBox-ka
            Food1 = textNameFood1.Text;

            // Ka qaad qiimaha Food 1 TextBox-ka
            priceFood1 = double.Parse(textPriceFood1.Text);

            // Ka qaad magaca Food 2 TextBox-ka
            Food2 = textNameFood2.Text;

            // Ka qaad qiimaha Food 2 TextBox-ka
            priceFood2 = double.Parse(textPriceFood2.Text);

            // Isku dar qiimaha labada cunto
            TotalAmount = priceFood1 + priceFood2;

            // Xisaabi Sales Tax-ka oo ah 5%
            SalesText = TotalAmount * (SalesVat / 100);

            // Xisaabi Tips-ka oo ah 15%
            Tips = TotalAmount * (TipVat / 100);

            // Xisaabi lacagta guud ee la bixinayo
            NetAmount = TotalAmount -SalesText - Tips;

            // Ku soo bandhig Sales Tax-ka Label-ka
            labelSalesTexst.Text = SalesText.ToString();

            // Ku soo bandhig Tips Amount-ka Label-ka
            labelTipesAmount.Text = Tips.ToString();

            // Ku soo bandhig Total Amount-ka Label-ka
            labelTotalAmount.Text = TotalAmount.ToString();

            // Ku soo bandhig Net Amount-ka Label-ka
            labelNetAmount.Text = NetAmount.ToString();
        }
    }
    }


