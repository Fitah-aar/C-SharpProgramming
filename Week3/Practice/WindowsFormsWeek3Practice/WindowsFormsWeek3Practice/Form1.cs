using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWeek3Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                // creating variables

                int score = int.Parse(txtScore.Text);
                string grade = "";

                //  Isticmaalka if-else-if Decision Structure
                if (score >= 90)
                {
                    grade = "A - Excellent!";
                }
                else if (score >= 80)
                {
                    grade = "B - Very Good!";
                }
                else if (score >= 70)
                {
                    grade = "C - Good!";
                }
                else if (score >= 60)
                {
                    grade = "D - Pass!";
                }
                else
                {
                    grade = "F - Fail!";
                }

                //  Ku soo bandhigida natiijada Labelka
                lblResult.Text = "Grade: " + grade;
            }
            catch (Exception ex)
            {
                // gali number sax ah
                MessageBox.Show("Fadlan geli nambar sax ah. Khalad: " );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear 
            txtScore.Clear();
            lblResult.Text = "Grade Result";
            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the application
            this.Close();
        }
    }
}
