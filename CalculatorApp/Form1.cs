using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        float a, b; 
        int count; 
        bool znak = true; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void ButtonOperation_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "+":
                    count = 1;
                    break;
                case "-":
                    count = 2;
                    break;
                case "*":
                    count = 3;
                    break;
                case "/":
                    count = 4;
                    break;
            }

            label1.Text = textBox1.Text + " " + button.Text;
            textBox1.Clear();
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = "";
        }

        private void Calculate()
        {
            b = float.Parse(textBox1.Text);
            float result = 0;

            switch (count)
            {
                case 1:
                    result = a + b;
                    break;
                case 2:
                    result = a - b;
                    break;
                case 3:
                    result = a * b;
                    break;
                case 4:
                    if (b != 0)
                        result = a / b;
                    else
                    {
                        MessageBox.Show("Деление на ноль невозможно");
                        return;
                    }
                    break;
            }

            textBox1.Text = result.ToString();

            // Добавление операции в историю
            string operation = $"{a} {GetOperationSymbol(count)} {b} = {result}";
            historyListBox.Items.Add(operation);


            a = result;
        }

        private string GetOperationSymbol(int operation)
        {
            switch (operation)
            {
                case 1: return "+";
                case 2: return "-";
                case 3: return "*";
                case 4: return "/";
                default: return "";
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void ButtonChangeSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (znak)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    znak = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                    znak = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void historyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClearHistory_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();
        }
    }
}
