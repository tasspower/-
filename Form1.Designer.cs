namespace WindowsFormsApp3
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
            this.chbCoffee = new System.Windows.Forms.CheckBox();
            this.tbCoffeePrice = new System.Windows.Forms.TextBox();
            this.chbGreenTea = new System.Windows.Forms.CheckBox();
            this.tbGreenTeaPrice = new System.Windows.Forms.TextBox();
            this.tbCoffeeQuantity = new System.Windows.Forms.TextBox();
            this.tbGreenTeaQuantity = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.tb1000 = new System.Windows.Forms.TextBox();
            this.tb500 = new System.Windows.Forms.TextBox();
            this.tb100 = new System.Windows.Forms.TextBox();
            this.tb50 = new System.Windows.Forms.TextBox();
            this.tb20 = new System.Windows.Forms.TextBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.Cash = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Checkout = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbCoffee
            // 
            this.chbCoffee.AutoSize = true;
            this.chbCoffee.Location = new System.Drawing.Point(22, 39);
            this.chbCoffee.Name = "chbCoffee";
            this.chbCoffee.Size = new System.Drawing.Size(57, 17);
            this.chbCoffee.TabIndex = 0;
            this.chbCoffee.Text = "Coffee";
            this.chbCoffee.UseVisualStyleBackColor = true;
            this.chbCoffee.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbCoffeePrice
            // 
            this.tbCoffeePrice.Location = new System.Drawing.Point(121, 36);
            this.tbCoffeePrice.Name = "tbCoffeePrice";
            this.tbCoffeePrice.Size = new System.Drawing.Size(98, 20);
            this.tbCoffeePrice.TabIndex = 2;

            // 
            // chbGreenTea
            // 
            this.chbGreenTea.AutoSize = true;
            this.chbGreenTea.Location = new System.Drawing.Point(22, 72);
            this.chbGreenTea.Name = "chbGreenTea";
            this.chbGreenTea.Size = new System.Drawing.Size(77, 17);
            this.chbGreenTea.TabIndex = 3;
            this.chbGreenTea.Text = "Green Tea";
            this.chbGreenTea.UseVisualStyleBackColor = true;
            this.chbGreenTea.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tbGreenTeaPrice
            // 
            this.tbGreenTeaPrice.Location = new System.Drawing.Point(121, 70);
            this.tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            this.tbGreenTeaPrice.Size = new System.Drawing.Size(98, 20);
            this.tbGreenTeaPrice.TabIndex = 4;
            // 
            // tbCoffeeQuantity
            // 
            this.tbCoffeeQuantity.Location = new System.Drawing.Point(244, 36);
            this.tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            this.tbCoffeeQuantity.Size = new System.Drawing.Size(98, 20);
            this.tbCoffeeQuantity.TabIndex = 5;

            // 
            // tbGreenTeaQuantity
            // 
            this.tbGreenTeaQuantity.Location = new System.Drawing.Point(244, 70);
            this.tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            this.tbGreenTeaQuantity.Size = new System.Drawing.Size(98, 20);
            this.tbGreenTeaQuantity.TabIndex = 6;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(633, 40);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(98, 20);
            this.tbTotal.TabIndex = 7;
            // 
            // tbCash
            // 
            this.tbCash.Location = new System.Drawing.Point(633, 72);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(98, 20);
            this.tbCash.TabIndex = 8;
            // 
            // tbChange
            // 
            this.tbChange.Location = new System.Drawing.Point(633, 107);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(98, 20);
            this.tbChange.TabIndex = 9;
            // 
            // tb1000
            // 
            this.tb1000.Location = new System.Drawing.Point(633, 142);
            this.tb1000.Name = "tb1000";
            this.tb1000.Size = new System.Drawing.Size(98, 20);
            this.tb1000.TabIndex = 10;
            // 
            // tb500
            // 
            this.tb500.Location = new System.Drawing.Point(633, 181);
            this.tb500.Name = "tb500";
            this.tb500.Size = new System.Drawing.Size(98, 20);
            this.tb500.TabIndex = 11;
            // 
            // tb100
            // 
            this.tb100.Location = new System.Drawing.Point(633, 218);
            this.tb100.Name = "tb100";
            this.tb100.Size = new System.Drawing.Size(98, 20);
            this.tb100.TabIndex = 12;
            // 
            // tb50
            // 
            this.tb50.Location = new System.Drawing.Point(633, 256);
            this.tb50.Name = "tb50";
            this.tb50.Size = new System.Drawing.Size(98, 20);
            this.tb50.TabIndex = 13;
            // 
            // tb20
            // 
            this.tb20.Location = new System.Drawing.Point(633, 294);
            this.tb20.Name = "tb20";
            this.tb20.Size = new System.Drawing.Size(98, 20);
            this.tb20.TabIndex = 14;
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(633, 330);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(98, 20);
            this.tb10.TabIndex = 15;
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(633, 367);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(98, 20);
            this.tb5.TabIndex = 16;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(633, 404);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(98, 20);
            this.tb1.TabIndex = 17;
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Location = new System.Drawing.Point(559, 76);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(31, 13);
            this.Cash.TabIndex = 18;
            this.Cash.Text = "Cash";
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(559, 115);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(44, 13);
            this.Change.TabIndex = 19;
            this.Change.Text = "Change";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(559, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "1";
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(365, 32);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(174, 390);
            this.Checkout.TabIndex = 28;
            this.Checkout.Text = "Check out";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.button1_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(559, 43);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 29;
            this.Total.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb10);
            this.Controls.Add(this.tb20);
            this.Controls.Add(this.tb50);
            this.Controls.Add(this.tb100);
            this.Controls.Add(this.tb500);
            this.Controls.Add(this.tb1000);
            this.Controls.Add(this.tbChange);
            this.Controls.Add(this.tbCash);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbGreenTeaQuantity);
            this.Controls.Add(this.tbCoffeeQuantity);
            this.Controls.Add(this.tbGreenTeaPrice);
            this.Controls.Add(this.chbGreenTea);
            this.Controls.Add(this.tbCoffeePrice);
            this.Controls.Add(this.chbCoffee);
            this.Name = "Form1";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbCoffee;
        private System.Windows.Forms.TextBox tbCoffeePrice;
        private System.Windows.Forms.CheckBox chbGreenTea;
        private System.Windows.Forms.TextBox tbGreenTeaPrice;
        private System.Windows.Forms.TextBox tbCoffeeQuantity;
        private System.Windows.Forms.TextBox tbGreenTeaQuantity;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbCash;
        private System.Windows.Forms.TextBox tbChange;
        private System.Windows.Forms.TextBox tb1000;
        private System.Windows.Forms.TextBox tb500;
        private System.Windows.Forms.TextBox tb100;
        private System.Windows.Forms.TextBox tb50;
        private System.Windows.Forms.TextBox tb20;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label Cash;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.Label Total;
    }
}

