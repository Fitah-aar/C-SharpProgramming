using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsDesigner
{
    public partial class Form1 : Form
    {
        // Variabiliyada lagu kaydinayo qiimaha iyo magaca qorshaha la doorto
        private int planPrice = 0;
        private string selectedPlanName = "";

        public Form1()
        {
            InitializeComponent();

            // Ku xidhitaanka dhacdooyinka (Events) haddii aadan ka dhex samayn design-ka
            rdbBasic.CheckedChanged += RadioButtons_CheckedChanged;
            rdbStandard.CheckedChanged += RadioButtons_CheckedChanged;
            rdbPremium.CheckedChanged += RadioButtons_CheckedChanged;
            chkLabAccess.CheckedChanged += Services_CheckedChanged;
            chkLibrary.CheckedChanged += Services_CheckedChanged;
        }

        // 1. SHAQADA RADIO BUTTONS-KA (COURSE PLAN)
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            // Markasta oo qorshe cusub la doorto, nadiifi ListBox-ka si aanay u qasmin
            listBox1.Items.Clear();

            if (rdbBasic.Checked)
            {
                selectedPlanName = "Basic";
                planPrice = 10;
                listBox1.Items.Add("Basic -$10");
            }
            else if (rdbStandard.Checked)
            {
                selectedPlanName = "Standard";
                planPrice = 15;
                listBox1.Items.Add("Standard -$15");
            }
            else if (rdbPremium.Checked)
            {
                selectedPlanName = "Premium";
                planPrice = 25;
                listBox1.Items.Add("Premium -$25");
            }

            // Ku dar adeegyada (Services) haddii ay sii saxnaayeen
            UpdateCartServices();
        }

        // 2. SHAQADA CHECKBOX-YADA (SERVICES)
        private void Services_CheckedChanged(object sender, EventArgs e)
        {
            // Hubi in marka hore qorshe (Plan) la doortay ka hor intaan adeeg la dooran
            if (string.IsNullOrEmpty(selectedPlanName))
            {
                MessageBox.Show("Fadlan marka hore dooro Course Plan!", "Digniin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Dib u nidaami checkboxes-ka si aanay u saxmin
                chkLabAccess.Checked = false;
                chkLibrary.Checked = false;
                return;
            }

            UpdateCartServices();
        }

        // Habka dib loogu cusboonaysiinayo adeegyada gudaha ListBox
        private void UpdateCartServices()
        {
            // Ka saar adeegyadii hore ee ListBox-ka si aanay u labalaabmin
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                string itemText = listBox1.Items[i].ToString();
                if (itemText.Contains("Lab Access") || itemText.Contains("library"))
                {
                    listBox1.Items.RemoveAt(i);
                }
            }

            // Ku dar kuwa hadda la saxay
            if (chkLabAccess.Checked)
            {
                listBox1.Items.Add("Lab Access + $5");
            }

            if (chkLibrary.Checked)
            {
                listBox1.Items.Add("library + $3");
            }
        }

        // 3. SHAQADA BADHANKA "SHOW"
        private void btnShow_Click(object sender, EventArgs e)
        {
            // Hubi in wax la doortay
            if (string.IsNullOrEmpty(selectedPlanName))
            {
                lblSummary.Text = "Cart-ku waa madhan yahay! Fadlan wax dooro.";
                return;
            }

            // Xisaabi qiimaha guud
            int totalCost = planPrice;

            if (chkLabAccess.Checked)
            {
                totalCost += 5;
            }

            if (chkLibrary.Checked)
            {
                totalCost += 3;
            }

            // Soo bandhig qiimaha guud gudaha Label-ka Huruudda ah
            lblSummary.Text = $"Total Price: ${totalCost}";
        }
    }
}

