using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /// clear textbux using delete function
            txtFirstName.Clear();
            txtSecondName.Text = " ";
            lblFullName.Text = " ";
;        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            // Creating Varibale to strore input values
            string fristName, secondName, fullName;


            // intail values
            fristName =txtFirstName.Text  ;
            secondName = txtSecondName.Text;

            ///procesiing concatunation with using +
            
            fullName=fristName + " " + secondName;

            /// Display the output using label
            

            lblFullName.Text= fullName;

            
      





        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
