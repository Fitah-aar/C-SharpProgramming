namespace WindowsFormsDesigner
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBasic = new System.Windows.Forms.RadioButton();
            this.rdbStandard = new System.Windows.Forms.RadioButton();
            this.rdbPremium = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkLabAccess = new System.Windows.Forms.CheckBox();
            this.chkLibrary = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPremium);
            this.groupBox1.Controls.Add(this.rdbStandard);
            this.groupBox1.Controls.Add(this.rdbBasic);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Plan";
            // 
            // rdbBasic
            // 
            this.rdbBasic.AutoSize = true;
            this.rdbBasic.Location = new System.Drawing.Point(20, 34);
            this.rdbBasic.Name = "rdbBasic";
            this.rdbBasic.Size = new System.Drawing.Size(119, 24);
            this.rdbBasic.TabIndex = 1;
            this.rdbBasic.TabStop = true;
            this.rdbBasic.Text = "Basic -$10";
            this.rdbBasic.UseVisualStyleBackColor = true;
            // 
            // rdbStandard
            // 
            this.rdbStandard.AutoSize = true;
            this.rdbStandard.Location = new System.Drawing.Point(20, 76);
            this.rdbStandard.Name = "rdbStandard";
            this.rdbStandard.Size = new System.Drawing.Size(149, 24);
            this.rdbStandard.TabIndex = 2;
            this.rdbStandard.TabStop = true;
            this.rdbStandard.Text = "Standard -$15";
            this.rdbStandard.UseVisualStyleBackColor = true;
            // 
            // rdbPremium
            // 
            this.rdbPremium.AutoSize = true;
            this.rdbPremium.Location = new System.Drawing.Point(20, 106);
            this.rdbPremium.Name = "rdbPremium";
            this.rdbPremium.Size = new System.Drawing.Size(144, 24);
            this.rdbPremium.TabIndex = 3;
            this.rdbPremium.TabStop = true;
            this.rdbPremium.Text = "Premium -$25";
            this.rdbPremium.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkLibrary);
            this.groupBox2.Controls.Add(this.chkLabAccess);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 151);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services";
            // 
            // chkLabAccess
            // 
            this.chkLabAccess.AutoSize = true;
            this.chkLabAccess.Location = new System.Drawing.Point(20, 56);
            this.chkLabAccess.Name = "chkLabAccess";
            this.chkLabAccess.Size = new System.Drawing.Size(163, 24);
            this.chkLabAccess.TabIndex = 0;
            this.chkLabAccess.Text = "Lab Access +$5";
            this.chkLabAccess.UseVisualStyleBackColor = true;
            // 
            // chkLibrary
            // 
            this.chkLibrary.AutoSize = true;
            this.chkLibrary.Location = new System.Drawing.Point(20, 95);
            this.chkLibrary.Name = "chkLibrary";
            this.chkLibrary.Size = new System.Drawing.Size(124, 24);
            this.chkLibrary.TabIndex = 1;
            this.chkLibrary.Text = "Library +$3";
            this.chkLibrary.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSummary);
            this.groupBox3.Controls.Add(this.btnShow);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(386, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 353);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cart";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(43, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 164);
            this.listBox1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(43, 245);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(106, 36);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.BackColor = System.Drawing.Color.Yellow;
            this.lblSummary.Location = new System.Drawing.Point(43, 307);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(303, 30);
            this.lblSummary.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbStandard;
        private System.Windows.Forms.RadioButton rdbBasic;
        private System.Windows.Forms.RadioButton rdbPremium;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkLibrary;
        private System.Windows.Forms.CheckBox chkLabAccess;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnShow;
    }
}

