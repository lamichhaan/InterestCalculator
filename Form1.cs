using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal principle = decimal.Parse(principleTextBox.Text);
            double rate = double.Parse(interestTextBox.Text);
            int year = (int)yearUpDown.Value;

            // set output header
            string output = "Year\tTotal Amount\r\n";

            // calculating amount after each year and appending ti the output
            for (int yearCounter = 1; yearCounter <= year; ++yearCounter)
            {
                decimal amount = principle * ((decimal)Math.Pow((1 + rate / 100), yearCounter));
                output += $"{yearCounter}\t{amount:C}\r\n";

            }
            displayTextBox.Text = output; // display result
        }
    }
}
