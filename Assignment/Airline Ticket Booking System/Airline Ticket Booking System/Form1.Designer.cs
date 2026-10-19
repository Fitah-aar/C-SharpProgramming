namespace Airline_Ticket_Booking_System
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
            this.Title = new System.Windows.Forms.Label();
            this.groupBoxPersonalInformation = new System.Windows.Forms.GroupBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.txtPaasengerAge = new System.Windows.Forms.TextBox();
            this.txtPaasengerName = new System.Windows.Forms.TextBox();
            this.lblBaggageWeight = new System.Windows.Forms.Label();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.lblPassengerAge = new System.Windows.Forms.Label();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.groupBoxTravelClass = new System.Windows.Forms.GroupBox();
            this.radioButtonBussinesClass = new System.Windows.Forms.RadioButton();
            this.radioButtonNormalClass = new System.Windows.Forms.RadioButton();
            this.radioButtonFirstClass = new System.Windows.Forms.RadioButton();
            this.groupBoxAdditionalOptiton = new System.Windows.Forms.GroupBox();
            this.checkBoxAddTravelInsurance = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.groupBoxPersonalInformation.SuspendLayout();
            this.groupBoxTravelClass.SuspendLayout();
            this.groupBoxAdditionalOptiton.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(0, -3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(920, 62);
            this.Title.TabIndex = 0;
            this.Title.Text = "Airline Ticket Booking System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxPersonalInformation
            // 
            this.groupBoxPersonalInformation.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBoxPersonalInformation.Controls.Add(this.txtBaggageWeight);
            this.groupBoxPersonalInformation.Controls.Add(this.txtNumberOfTickets);
            this.groupBoxPersonalInformation.Controls.Add(this.txtPaasengerAge);
            this.groupBoxPersonalInformation.Controls.Add(this.txtPaasengerName);
            this.groupBoxPersonalInformation.Controls.Add(this.lblBaggageWeight);
            this.groupBoxPersonalInformation.Controls.Add(this.lblNumberOfTickets);
            this.groupBoxPersonalInformation.Controls.Add(this.lblPassengerAge);
            this.groupBoxPersonalInformation.Controls.Add(this.lblPassengerName);
            this.groupBoxPersonalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPersonalInformation.Location = new System.Drawing.Point(12, 62);
            this.groupBoxPersonalInformation.Name = "groupBoxPersonalInformation";
            this.groupBoxPersonalInformation.Size = new System.Drawing.Size(502, 206);
            this.groupBoxPersonalInformation.TabIndex = 1;
            this.groupBoxPersonalInformation.TabStop = false;
            this.groupBoxPersonalInformation.Text = "Personal Information";
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(231, 155);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(265, 35);
            this.txtBaggageWeight.TabIndex = 8;
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Location = new System.Drawing.Point(231, 114);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(265, 35);
            this.txtNumberOfTickets.TabIndex = 7;
            // 
            // txtPaasengerAge
            // 
            this.txtPaasengerAge.Location = new System.Drawing.Point(231, 70);
            this.txtPaasengerAge.Name = "txtPaasengerAge";
            this.txtPaasengerAge.Size = new System.Drawing.Size(265, 35);
            this.txtPaasengerAge.TabIndex = 6;
            // 
            // txtPaasengerName
            // 
            this.txtPaasengerName.Location = new System.Drawing.Point(231, 27);
            this.txtPaasengerName.Name = "txtPaasengerName";
            this.txtPaasengerName.Size = new System.Drawing.Size(265, 35);
            this.txtPaasengerName.TabIndex = 2;
            this.txtPaasengerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBaggageWeight
            // 
            this.lblBaggageWeight.AutoSize = true;
            this.lblBaggageWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaggageWeight.Location = new System.Drawing.Point(12, 155);
            this.lblBaggageWeight.Name = "lblBaggageWeight";
            this.lblBaggageWeight.Size = new System.Drawing.Size(213, 22);
            this.lblBaggageWeight.TabIndex = 5;
            this.lblBaggageWeight.Text = "Baggage weight (KG) :";
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTickets.Location = new System.Drawing.Point(36, 114);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(189, 22);
            this.lblNumberOfTickets.TabIndex = 4;
            this.lblNumberOfTickets.Text = "Number Of Tickets :";
            // 
            // lblPassengerAge
            // 
            this.lblPassengerAge.AutoSize = true;
            this.lblPassengerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerAge.Location = new System.Drawing.Point(67, 70);
            this.lblPassengerAge.Name = "lblPassengerAge";
            this.lblPassengerAge.Size = new System.Drawing.Size(158, 22);
            this.lblPassengerAge.TabIndex = 3;
            this.lblPassengerAge.Text = "Passenger Age :";
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerName.Location = new System.Drawing.Point(51, 31);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(174, 22);
            this.lblPassengerName.TabIndex = 2;
            this.lblPassengerName.Text = "Passenger Name :";
            // 
            // groupBoxTravelClass
            // 
            this.groupBoxTravelClass.Controls.Add(this.radioButtonBussinesClass);
            this.groupBoxTravelClass.Controls.Add(this.radioButtonNormalClass);
            this.groupBoxTravelClass.Controls.Add(this.radioButtonFirstClass);
            this.groupBoxTravelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTravelClass.Location = new System.Drawing.Point(12, 290);
            this.groupBoxTravelClass.Name = "groupBoxTravelClass";
            this.groupBoxTravelClass.Size = new System.Drawing.Size(510, 67);
            this.groupBoxTravelClass.TabIndex = 2;
            this.groupBoxTravelClass.TabStop = false;
            this.groupBoxTravelClass.Text = "Travel Class";
            // 
            // radioButtonBussinesClass
            // 
            this.radioButtonBussinesClass.AutoSize = true;
            this.radioButtonBussinesClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBussinesClass.Location = new System.Drawing.Point(343, 31);
            this.radioButtonBussinesClass.Name = "radioButtonBussinesClass";
            this.radioButtonBussinesClass.Size = new System.Drawing.Size(156, 24);
            this.radioButtonBussinesClass.TabIndex = 2;
            this.radioButtonBussinesClass.TabStop = true;
            this.radioButtonBussinesClass.Text = "Bussines Class";
            this.radioButtonBussinesClass.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormalClass
            // 
            this.radioButtonNormalClass.AutoSize = true;
            this.radioButtonNormalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNormalClass.Location = new System.Drawing.Point(179, 31);
            this.radioButtonNormalClass.Name = "radioButtonNormalClass";
            this.radioButtonNormalClass.Size = new System.Drawing.Size(139, 24);
            this.radioButtonNormalClass.TabIndex = 1;
            this.radioButtonNormalClass.TabStop = true;
            this.radioButtonNormalClass.Text = "Normal Class";
            this.radioButtonNormalClass.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirstClass
            // 
            this.radioButtonFirstClass.AutoSize = true;
            this.radioButtonFirstClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFirstClass.Location = new System.Drawing.Point(27, 32);
            this.radioButtonFirstClass.Name = "radioButtonFirstClass";
            this.radioButtonFirstClass.Size = new System.Drawing.Size(119, 24);
            this.radioButtonFirstClass.TabIndex = 0;
            this.radioButtonFirstClass.TabStop = true;
            this.radioButtonFirstClass.Text = "First Class";
            this.radioButtonFirstClass.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdditionalOptiton
            // 
            this.groupBoxAdditionalOptiton.Controls.Add(this.checkBoxAddTravelInsurance);
            this.groupBoxAdditionalOptiton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdditionalOptiton.Location = new System.Drawing.Point(12, 381);
            this.groupBoxAdditionalOptiton.Name = "groupBoxAdditionalOptiton";
            this.groupBoxAdditionalOptiton.Size = new System.Drawing.Size(510, 74);
            this.groupBoxAdditionalOptiton.TabIndex = 3;
            this.groupBoxAdditionalOptiton.TabStop = false;
            this.groupBoxAdditionalOptiton.Text = "Additional Options";
            // 
            // checkBoxAddTravelInsurance
            // 
            this.checkBoxAddTravelInsurance.AutoSize = true;
            this.checkBoxAddTravelInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAddTravelInsurance.Location = new System.Drawing.Point(16, 29);
            this.checkBoxAddTravelInsurance.Name = "checkBoxAddTravelInsurance";
            this.checkBoxAddTravelInsurance.Size = new System.Drawing.Size(336, 24);
            this.checkBoxAddTravelInsurance.TabIndex = 0;
            this.checkBoxAddTravelInsurance.Text = "Add Trvael Insurance (25$ per Ticket)";
            this.checkBoxAddTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(28, 461);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(153, 63);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(200, 461);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 63);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(369, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 63);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Items.AddRange(new object[] {
            "AirLine Booking Detailes"});
            this.listBoxResult.Location = new System.Drawing.Point(535, 70);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(365, 464);
            this.listBoxResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 543);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBoxAdditionalOptiton);
            this.Controls.Add(this.groupBoxTravelClass);
            this.Controls.Add(this.groupBoxPersonalInformation);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxPersonalInformation.ResumeLayout(false);
            this.groupBoxPersonalInformation.PerformLayout();
            this.groupBoxTravelClass.ResumeLayout(false);
            this.groupBoxTravelClass.PerformLayout();
            this.groupBoxAdditionalOptiton.ResumeLayout(false);
            this.groupBoxAdditionalOptiton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox groupBoxPersonalInformation;
        private System.Windows.Forms.Label lblBaggageWeight;
        private System.Windows.Forms.Label lblNumberOfTickets;
        private System.Windows.Forms.Label lblPassengerAge;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.TextBox txtPaasengerName;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.TextBox txtPaasengerAge;
        private System.Windows.Forms.GroupBox groupBoxTravelClass;
        private System.Windows.Forms.RadioButton radioButtonBussinesClass;
        private System.Windows.Forms.RadioButton radioButtonNormalClass;
        private System.Windows.Forms.RadioButton radioButtonFirstClass;
        private System.Windows.Forms.GroupBox groupBoxAdditionalOptiton;
        private System.Windows.Forms.CheckBox checkBoxAddTravelInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}

