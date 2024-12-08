namespace CalculatorApp
{
    partial class AdditionalCalculator
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReturn;

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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.inputTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(200, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
 
            this.powerTextBox.Location = new System.Drawing.Point(220, 12);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(100, 20);
            this.powerTextBox.TabIndex = 1;

            this.resultLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resultLabel.Location = new System.Drawing.Point(12, 35);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(308, 30);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);

            this.buttonLog.Location = new System.Drawing.Point(12, 81);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 49);
            this.buttonLog.TabIndex = 3;
            this.buttonLog.Text = "Логарифм";
            this.buttonLog.Click += new System.EventHandler(this.ButtonLog_Click);

            this.buttonPower.Location = new System.Drawing.Point(93, 81);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(75, 49);
            this.buttonPower.TabIndex = 4;
            this.buttonPower.Text = "Степень";
            this.buttonPower.Click += new System.EventHandler(this.ButtonPower_Click);

            this.buttonSqrt.Location = new System.Drawing.Point(174, 81);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(99, 49);
            this.buttonSqrt.TabIndex = 5;
            this.buttonSqrt.Text = "Квадратный корень";
            this.buttonSqrt.Click += new System.EventHandler(this.ButtonSqrt_Click);

            this.buttonClear.Location = new System.Drawing.Point(279, 81);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(51, 49);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "🗑️";
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);


            this.buttonReturn.Location = new System.Drawing.Point(255, 154);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 34);
            this.buttonReturn.TabIndex = 7;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);



            this.BackgroundImage = global::CalculatorApp.Properties.Resources._1595531145_4765efc2cd1a25db8dd6ce29ccfa6716;
            this.ClientSize = new System.Drawing.Size(341, 200);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonReturn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdditionalCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
