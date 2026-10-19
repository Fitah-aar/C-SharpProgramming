namespace Vehicle_Rental_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYearsOfDrvingExperience = new System.Windows.Forms.TextBox();
            this.txtNumberOfRentalDays = new System.Windows.Forms.TextBox();
            this.txtCustomerAge = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblYearsOfDrvingExperience = new System.Windows.Forms.Label();
            this.lblNumberOfRentalDays = new System.Windows.Forms.Label();
            this.lblCustomerAge = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoLuxury = new System.Windows.Forms.RadioButton();
            this.rdoSuv = new System.Windows.Forms.RadioButton();
            this.rdoEconomy = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBoxresult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.ForeColor = System.Drawing.Color.White;
            this.lblNameCustomer.Location = new System.Drawing.Point(-4, -2);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(871, 52);
            this.lblNameCustomer.TabIndex = 0;
            this.lblNameCustomer.Text = "🚔Vehicle Rental Management System";
            this.lblNameCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYearsOfDrvingExperience);
            this.groupBox1.Controls.Add(this.txtNumberOfRentalDays);
            this.groupBox1.Controls.Add(this.txtCustomerAge);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.lblYearsOfDrvingExperience);
            this.groupBox1.Controls.Add(this.lblNumberOfRentalDays);
            this.groupBox1.Controls.Add(this.lblCustomerAge);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // txtYearsOfDrvingExperience
            // 
            this.txtYearsOfDrvingExperience.Location = new System.Drawing.Point(280, 137);
            this.txtYearsOfDrvingExperience.Name = "txtYearsOfDrvingExperience";
            this.txtYearsOfDrvingExperience.Size = new System.Drawing.Size(242, 32);
            this.txtYearsOfDrvingExperience.TabIndex = 6;
            // 
            // txtNumberOfRentalDays
            // 
            this.txtNumberOfRentalDays.Location = new System.Drawing.Point(280, 104);
            this.txtNumberOfRentalDays.Name = "txtNumberOfRentalDays";
            this.txtNumberOfRentalDays.Size = new System.Drawing.Size(242, 32);
            this.txtNumberOfRentalDays.TabIndex = 5;
            // 
            // txtCustomerAge
            // 
            this.txtCustomerAge.Location = new System.Drawing.Point(280, 68);
            this.txtCustomerAge.Name = "txtCustomerAge";
            this.txtCustomerAge.Size = new System.Drawing.Size(242, 32);
            this.txtCustomerAge.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(280, 30);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(242, 32);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblYearsOfDrvingExperience
            // 
            this.lblYearsOfDrvingExperience.AutoSize = true;
            this.lblYearsOfDrvingExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearsOfDrvingExperience.Location = new System.Drawing.Point(15, 137);
            this.lblYearsOfDrvingExperience.Name = "lblYearsOfDrvingExperience";
            this.lblYearsOfDrvingExperience.Size = new System.Drawing.Size(259, 22);
            this.lblYearsOfDrvingExperience.TabIndex = 3;
            this.lblYearsOfDrvingExperience.Text = "Years Of Drving Experience";
            // 
            // lblNumberOfRentalDays
            // 
            this.lblNumberOfRentalDays.AutoSize = true;
            this.lblNumberOfRentalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRentalDays.Location = new System.Drawing.Point(37, 104);
            this.lblNumberOfRentalDays.Name = "lblNumberOfRentalDays";
            this.lblNumberOfRentalDays.Size = new System.Drawing.Size(221, 22);
            this.lblNumberOfRentalDays.TabIndex = 2;
            this.lblNumberOfRentalDays.Text = "Number Of Rental Days";
            // 
            // lblCustomerAge
            // 
            this.lblCustomerAge.AutoSize = true;
            this.lblCustomerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAge.Location = new System.Drawing.Point(122, 68);
            this.lblCustomerAge.Name = "lblCustomerAge";
            this.lblCustomerAge.Size = new System.Drawing.Size(136, 22);
            this.lblCustomerAge.TabIndex = 1;
            this.lblCustomerAge.Text = "Customer Age";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(122, 30);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(152, 22);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.Click += new System.EventHandler(this.lblCustomerName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoLuxury);
            this.groupBox2.Controls.Add(this.rdoSuv);
            this.groupBox2.Controls.Add(this.rdoEconomy);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Type";
            // 
            // rdoLuxury
            // 
            this.rdoLuxury.AutoSize = true;
            this.rdoLuxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLuxury.Location = new System.Drawing.Point(339, 43);
            this.rdoLuxury.Name = "rdoLuxury";
            this.rdoLuxury.Size = new System.Drawing.Size(86, 24);
            this.rdoLuxury.TabIndex = 2;
            this.rdoLuxury.TabStop = true;
            this.rdoLuxury.Text = "Luxury";
            this.rdoLuxury.UseVisualStyleBackColor = true;
            // 
            // rdoSuv
            // 
            this.rdoSuv.AutoSize = true;
            this.rdoSuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSuv.Location = new System.Drawing.Point(199, 43);
            this.rdoSuv.Name = "rdoSuv";
            this.rdoSuv.Size = new System.Drawing.Size(64, 24);
            this.rdoSuv.TabIndex = 1;
            this.rdoSuv.TabStop = true;
            this.rdoSuv.Text = "Suv";
            this.rdoSuv.UseVisualStyleBackColor = true;
            // 
            // rdoEconomy
            // 
            this.rdoEconomy.AutoSize = true;
            this.rdoEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEconomy.Location = new System.Drawing.Point(41, 43);
            this.rdoEconomy.Name = "rdoEconomy";
            this.rdoEconomy.Size = new System.Drawing.Size(107, 24);
            this.rdoEconomy.TabIndex = 0;
            this.rdoEconomy.TabStop = true;
            this.rdoEconomy.Text = "Economy";
            this.rdoEconomy.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkInsurance);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 89);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insurance Option";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInsurance.Location = new System.Drawing.Point(29, 42);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(268, 24);
            this.chkInsurance.TabIndex = 0;
            this.chkInsurance.Text = "Add Insurance (15$ per day )";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(31, 482);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 42);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(223, 482);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(400, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBoxresult
            // 
            this.listBoxresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxresult.FormattingEnabled = true;
            this.listBoxresult.ItemHeight = 20;
            this.listBoxresult.Items.AddRange(new object[] {
            "Renatl Inforamtion And Result"});
            this.listBoxresult.Location = new System.Drawing.Point(576, 77);
            this.listBoxresult.Name = "listBoxresult";
            this.listBoxresult.Size = new System.Drawing.Size(291, 404);
            this.listBoxresult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(866, 526);
            this.Controls.Add(this.listBoxresult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNameCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblNumberOfRentalDays;
        private System.Windows.Forms.Label lblCustomerAge;
        private System.Windows.Forms.TextBox txtYearsOfDrvingExperience;
        private System.Windows.Forms.TextBox txtNumberOfRentalDays;
        private System.Windows.Forms.TextBox txtCustomerAge;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblYearsOfDrvingExperience;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoLuxury;
        private System.Windows.Forms.RadioButton rdoSuv;
        private System.Windows.Forms.RadioButton rdoEconomy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxresult;
    }
}

