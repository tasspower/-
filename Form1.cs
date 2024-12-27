﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get prices and quantities
                int iCoffeePrice = chbCoffee.Checked ? GetIntFromTextBox(tbCoffeePrice) : 0;
                int iCoffeeQuantity = chbCoffee.Checked ? GetIntFromTextBox(tbCoffeeQuantity) : 0;

                int iGreenTeaPrice = chbGreenTea.Checked ? GetIntFromTextBox(tbGreenTeaPrice) : 0;
                int iGreenTeaQuantity = chbGreenTea.Checked ? GetIntFromTextBox(tbGreenTeaQuantity) : 0;

                // Calculate total
                int iTotal = (iCoffeePrice * iCoffeeQuantity) + (iGreenTeaPrice * iGreenTeaQuantity);
                tbTotal.Text = iTotal.ToString();

                // Get cash input
                int iCash = GetIntFromTextBox(tbCash);

                // Check if cash is sufficient
                if (iCash < iTotal)
                {
                    MessageBox.Show("Insufficient cash!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate change
                int iChange = iCash - iTotal;
                tbChange.Text = iChange.ToString();

                // Calculate denominations
                CalculateDenominations(iChange);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetIntFromTextBox(TextBox textBox)
        {
            int value = 0;
            if (!int.TryParse(textBox.Text, out value))
            {
                MessageBox.Show($"Invalid input in {textBox.Name}. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return value;
        }

        private void CalculateDenominations(int change)
        {
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            TextBox[] textBoxes = { tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb1 };

            for (int i = 0; i < denominations.Length; i++)
            {
                int count = change / denominations[i];
                change %= denominations[i];
                textBoxes[i].Text = count.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
    }
}