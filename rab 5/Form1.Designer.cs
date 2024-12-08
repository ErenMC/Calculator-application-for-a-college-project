namespace CalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClearHistory, buttonClear, buttonBackspace, buttonChangeSign, buttonDot, buttonEquals;
        private System.Windows.Forms.Button button0, button1, button2, button3, button4, button5, button6, button7, button8, button9;
        private System.Windows.Forms.Button buttonPlus, buttonMinus, buttonMultiply, buttonDivide;
        private System.Windows.Forms.Button buttonOpenAdditionalForm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonChangeSign = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonOpenAdditionalForm = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(12, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 29);
            this.textBox1.TabIndex = 0;

            this.historyListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.historyListBox.ItemHeight = 16;
            this.historyListBox.Location = new System.Drawing.Point(326, 18);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(260, 228);
            this.historyListBox.TabIndex = 2;

            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 1;

            this.buttonClearHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonClearHistory.Location = new System.Drawing.Point(558, 252);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(28, 34);
            this.buttonClearHistory.TabIndex = 3;
            this.buttonClearHistory.Text = "🗑️";
            this.buttonClearHistory.Click += new System.EventHandler(this.ButtonClearHistory_Click);

            this.buttonClear.Location = new System.Drawing.Point(12, 79);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 38);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "C";
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);

            this.buttonBackspace.Location = new System.Drawing.Point(93, 79);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(146, 38);
            this.buttonBackspace.TabIndex = 5;
            this.buttonBackspace.Text = "⬅️";
            this.buttonBackspace.Click += new System.EventHandler(this.ButtonBackspace_Click);

            this.buttonChangeSign.Location = new System.Drawing.Point(12, 248);
            this.buttonChangeSign.Name = "buttonChangeSign";
            this.buttonChangeSign.Size = new System.Drawing.Size(75, 38);
            this.buttonChangeSign.TabIndex = 6;
            this.buttonChangeSign.Text = "+/-";
            this.buttonChangeSign.Click += new System.EventHandler(this.ButtonChangeSign_Click);

            this.buttonDot.Location = new System.Drawing.Point(164, 248);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(75, 38);
            this.buttonDot.TabIndex = 7;
            this.buttonDot.Text = ".";
            this.buttonDot.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.buttonEquals.Location = new System.Drawing.Point(245, 248);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(75, 38);
            this.buttonEquals.TabIndex = 8;
            this.buttonEquals.Text = "=";
            this.buttonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);

            this.button0.Location = new System.Drawing.Point(88, 248);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 38);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.button1.Location = new System.Drawing.Point(12, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.button2.Location = new System.Drawing.Point(88, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.button3.Location = new System.Drawing.Point(164, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.button4.Location = new System.Drawing.Point(12, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.button5.Location = new System.Drawing.Point(88, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 38);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.button6.Location = new System.Drawing.Point(164, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 38);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.button7.Location = new System.Drawing.Point(12, 123);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 38);
            this.button7.TabIndex = 16;
            this.button7.Text = "7";
            this.button7.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.button8.Location = new System.Drawing.Point(88, 123);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 38);
            this.button8.TabIndex = 17;
            this.button8.Text = "8";
            this.button8.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.button9.Location = new System.Drawing.Point(164, 123);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 38);
            this.button9.TabIndex = 18;
            this.button9.Text = "9";
            this.button9.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.buttonPlus.Location = new System.Drawing.Point(245, 207);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 38);
            this.buttonPlus.TabIndex = 19;
            this.buttonPlus.Text = "+";
            this.buttonPlus.Click += new System.EventHandler(this.ButtonOperation_Click);

            this.buttonMinus.Location = new System.Drawing.Point(245, 167);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 38);
            this.buttonMinus.TabIndex = 20;
            this.buttonMinus.Text = "-";
            this.buttonMinus.Click += new System.EventHandler(this.ButtonOperation_Click);

            this.buttonMultiply.Location = new System.Drawing.Point(245, 123);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(75, 38);
            this.buttonMultiply.TabIndex = 21;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.Click += new System.EventHandler(this.ButtonOperation_Click);

            this.buttonDivide.Location = new System.Drawing.Point(245, 79);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(75, 38);
            this.buttonDivide.TabIndex = 22;
            this.buttonDivide.Text = "/";
            this.buttonDivide.Click += new System.EventHandler(this.ButtonOperation_Click);


            this.buttonOpenAdditionalForm.Location = new System.Drawing.Point(326, 252);
            this.buttonOpenAdditionalForm.Name = "buttonOpenAdditionalForm";
            this.buttonOpenAdditionalForm.Size = new System.Drawing.Size(226, 30);
            this.buttonOpenAdditionalForm.TabIndex = 23;
            this.buttonOpenAdditionalForm.Text = "Расширенные функции";
            this.buttonOpenAdditionalForm.Click += new System.EventHandler(this.ButtonOpenAdditionalForm_Click);


            this.BackgroundImage = global::CalculatorApp.Properties.Resources._1595531145_4765efc2cd1a25db8dd6ce29ccfa6716;
            this.ClientSize = new System.Drawing.Size(600, 302);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonChangeSign);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonOpenAdditionalForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
