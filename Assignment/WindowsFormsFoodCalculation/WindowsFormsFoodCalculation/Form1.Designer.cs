namespace WindowsFormsFoodCalculation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tnCalculate_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textNameFood1 = new System.Windows.Forms.TextBox();
            this.textAmountTipes = new System.Windows.Forms.TextBox();
            this.textPriceFood2 = new System.Windows.Forms.TextBox();
            this.textNameFood2 = new System.Windows.Forms.TextBox();
            this.textPriceFood1 = new System.Windows.Forms.TextBox();
            this.labelSalesTexst = new System.Windows.Forms.Label();
            this.labelTipesAmount = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelNetAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Name Of Food1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter The Name Of Food2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter The Price Of Food1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter The Price Of Food2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter The Amount Of Tipes";
            // 
            // tnCalculate_Click
            // 
            this.tnCalculate_Click.Location = new System.Drawing.Point(55, 211);
            this.tnCalculate_Click.Name = "tnCalculate_Click";
            this.tnCalculate_Click.Size = new System.Drawing.Size(155, 71);
            this.tnCalculate_Click.TabIndex = 5;
            this.tnCalculate_Click.Text = "Calcculate The amount";
            this.tnCalculate_Click.UseVisualStyleBackColor = true;
            this.tnCalculate_Click.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 71);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 79);
            this.button3.TabIndex = 7;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sales_Taxest";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipes Amount";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Net Amount";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textNameFood1
            // 
            this.textNameFood1.Location = new System.Drawing.Point(249, 31);
            this.textNameFood1.Name = "textNameFood1";
            this.textNameFood1.Size = new System.Drawing.Size(240, 26);
            this.textNameFood1.TabIndex = 12;
            // 
            // textAmountTipes
            // 
            this.textAmountTipes.Location = new System.Drawing.Point(249, 170);
            this.textAmountTipes.Name = "textAmountTipes";
            this.textAmountTipes.Size = new System.Drawing.Size(240, 26);
            this.textAmountTipes.TabIndex = 13;
            this.textAmountTipes.TextChanged += new System.EventHandler(this.textAmountTipes_TextChanged);
            // 
            // textPriceFood2
            // 
            this.textPriceFood2.Location = new System.Drawing.Point(249, 134);
            this.textPriceFood2.Name = "textPriceFood2";
            this.textPriceFood2.Size = new System.Drawing.Size(240, 26);
            this.textPriceFood2.TabIndex = 14;
            // 
            // textNameFood2
            // 
            this.textNameFood2.Location = new System.Drawing.Point(249, 99);
            this.textNameFood2.Name = "textNameFood2";
            this.textNameFood2.Size = new System.Drawing.Size(240, 26);
            this.textNameFood2.TabIndex = 15;
            // 
            // textPriceFood1
            // 
            this.textPriceFood1.Location = new System.Drawing.Point(249, 63);
            this.textPriceFood1.Name = "textPriceFood1";
            this.textPriceFood1.Size = new System.Drawing.Size(240, 26);
            this.textPriceFood1.TabIndex = 16;
            // 
            // labelSalesTexst
            // 
            this.labelSalesTexst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalesTexst.Location = new System.Drawing.Point(207, 302);
            this.labelSalesTexst.Name = "labelSalesTexst";
            this.labelSalesTexst.Size = new System.Drawing.Size(244, 25);
            this.labelSalesTexst.TabIndex = 17;
            // 
            // labelTipesAmount
            // 
            this.labelTipesAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTipesAmount.Location = new System.Drawing.Point(207, 335);
            this.labelTipesAmount.Name = "labelTipesAmount";
            this.labelTipesAmount.Size = new System.Drawing.Size(244, 25);
            this.labelTipesAmount.TabIndex = 18;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalAmount.Location = new System.Drawing.Point(207, 373);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(244, 25);
            this.labelTotalAmount.TabIndex = 19;
            // 
            // labelNetAmount
            // 
            this.labelNetAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNetAmount.Location = new System.Drawing.Point(207, 406);
            this.labelNetAmount.Name = "labelNetAmount";
            this.labelNetAmount.Size = new System.Drawing.Size(244, 25);
            this.labelNetAmount.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNetAmount);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.labelTipesAmount);
            this.Controls.Add(this.labelSalesTexst);
            this.Controls.Add(this.textPriceFood1);
            this.Controls.Add(this.textNameFood2);
            this.Controls.Add(this.textPriceFood2);
            this.Controls.Add(this.textAmountTipes);
            this.Controls.Add(this.textNameFood1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tnCalculate_Click);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tnCalculate_Click;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNameFood1;
        private System.Windows.Forms.TextBox textAmountTipes;
        private System.Windows.Forms.TextBox textPriceFood2;
        private System.Windows.Forms.TextBox textNameFood2;
        private System.Windows.Forms.TextBox textPriceFood1;
        private System.Windows.Forms.Label labelSalesTexst;
        private System.Windows.Forms.Label labelTipesAmount;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelNetAmount;
    }
}

