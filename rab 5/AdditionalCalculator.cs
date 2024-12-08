using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class AdditionalCalculator : Form
    {
        public Form1 MainCalculator { get; set; }

        public AdditionalCalculator()
        {
            InitializeComponent();
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputTextBox.Text, out double number))
            {
                resultLabel.Text = "log(" + number + ") = " + Math.Log(number).ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputTextBox.Text, out double baseNumber) && double.TryParse(powerTextBox.Text, out double exponent))
            {
                resultLabel.Text = $"{baseNumber} ^ {exponent} = " + Math.Pow(baseNumber, exponent).ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные числа.");
            }
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputTextBox.Text, out double number))
            {
                resultLabel.Text = "√" + number + " = " + Math.Sqrt(number).ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            powerTextBox.Clear();
            resultLabel.Text = "";
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainCalculator.Show();
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
