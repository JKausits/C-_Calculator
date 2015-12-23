using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorProgram : Form
    {
        public string operation = "";
        public double savedNumber;
        public string resultString = "";

        public CalculatorProgram()
        {
            InitializeComponent();
        }

        //methods to backspace the resultString
        private void backSpace() {
            if (resultLabel.Text != "")
            {
                resultLabel.Text = resultLabel.Text.Substring(0, resultLabel.Text.Length - 1);
            }
        }

        //method to add numbers to the resultString
        public void numberButtons(string num)
        {
            resultString += num;
            resultLabel.Text = resultString;

        }

        //returns the result number based on the operation put in
        private void equalButton() {
            try
            {
                switch (operation)
                {
                    case "+":
                        savedNumber += double.Parse(resultLabel.Text);
                        displayLabel.Text = this.savedNumber.ToString();
                        resultString = "";
                        resultLabel.Text = resultString;
                        break;
                    case "-":
                        savedNumber = savedNumber - double.Parse(resultLabel.Text);
                        displayLabel.Text = this.savedNumber.ToString();
                        resultString = "";
                        resultLabel.Text = resultString; resultString = "";
                        break;
                    case "x":
                        savedNumber *= double.Parse(resultLabel.Text);
                        displayLabel.Text = this.savedNumber.ToString();
                        resultString = "";
                        resultLabel.Text = resultString;
                        break;
                    case "/":
                        savedNumber /= double.Parse(resultLabel.Text);
                        displayLabel.Text = this.savedNumber.ToString();
                        resultString = "";
                        resultLabel.Text = resultString;
                        break;
                }
            }
            catch (FormatException) { }
        }

        //makes the equal button work
        private void equalsButton_Click(object sender, EventArgs e)
        {
            equalButton(); 
        }

        //makes the number buttons work
        public void zeroButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text != "")
            {
                numberButtons("0");
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            numberButtons("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            numberButtons("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            numberButtons("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            numberButtons("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            numberButtons("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            numberButtons("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            numberButtons("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            numberButtons("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            numberButtons("9");
        }

        //adds the decimal into the value
        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!resultLabel.Text.Contains("."))
            {
                numberButtons(".");
            }
        }

        //clears all the values
        private void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            displayLabel.Text = "";
            savedNumber = 0;
            operation = "";
            resultString = "";
        }

        //turns the calculator off
        private void OffButton_Click(object sender, EventArgs e)
        {
            this.savedNumber = 0;
            displayLabel.Text = "";
            this.resultString = "";
            resultLabel.Text = "";
            onButton.Show();
            OffButton.Hide();
            oneButton.Enabled = false;
            twoButton.Enabled = false;
            threeButton.Enabled = false;
            fourButton.Enabled = false;
            fiveButton.Enabled = false;
            sixButton.Enabled = false;
            sevenButton.Enabled = false;
            eightButton.Enabled = false;
            nineButton.Enabled = false;
            zeroButton.Enabled = false;
            OffButton.Enabled = false;
            backSpaceButton.Enabled = false;
            addButton.Enabled = false;
            subtractButton.Enabled = false;
            multiplyButton.Enabled = false;
            divideButton.Enabled = false;
            resultLabel.Text = "";
            resultLabel.Enabled = false;
            clearButton.Enabled = false;
            dotButton.Enabled = false;
            equalsButton.Enabled = false;
        }

        //turns the calculator on
        private void OnButton_Click(object sender, EventArgs e)
        {
            OffButton.Show();
            onButton.Hide();
            oneButton.Enabled = true;
            twoButton.Enabled = true;
            threeButton.Enabled = true;
            fourButton.Enabled = true;
            fiveButton.Enabled = true;
            sixButton.Enabled = true;
            sevenButton.Enabled = true;
            eightButton.Enabled = true;
            nineButton.Enabled = true;
            zeroButton.Enabled = true;
            OffButton.Enabled = true;
            backSpaceButton.Enabled = true;
            addButton.Enabled = true;
            subtractButton.Enabled = true;
            multiplyButton.Enabled = true;
            divideButton.Enabled = true;
            resultLabel.Enabled = true;
            clearButton.Enabled = true;
            dotButton.Enabled = true;
            equalsButton.Enabled = true;
        }

        //backspace button
        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            backSpace();
        }
        
        //method that sets the operation you want to do
        private void setOperation(string operation)
        {
            if (resultString != "")
            {
                this.savedNumber = double.Parse(resultString);
                this.operation = operation;
                resultString = "";
                displayLabel.Text = this.savedNumber.ToString() + " " + this.operation;
                resultLabel.Text = resultString;
            }
            else if (savedNumber != 0)
            {
                this.operation = operation;
                displayLabel.Text = this.savedNumber.ToString() + " " + this.operation;
            }
        }

        //sets the operation based on the button you click
        private void addButton_Click(object sender, EventArgs e)
        {
            setOperation("+");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            setOperation("-");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            setOperation("x");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            setOperation("/");
        }

        //Adds keyboard commands to the controller
        private void keyboardInput(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                if (resultLabel.Text != "")
                {
                    numberButtons("0");
                }
            }
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                numberButtons("1");
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                numberButtons("2");
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                numberButtons("3");
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                numberButtons("4");
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                numberButtons("5");
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                numberButtons("6");
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                numberButtons("7");
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                numberButtons("8");
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                numberButtons("9");
            }
            if (e.KeyCode == Keys.Decimal) {
                if (!resultLabel.Text.Contains("."))
                {
                    numberButtons(".");
                }
            }
            if (e.KeyCode == Keys.Add)
            {
                setOperation("+");
            }
            if (e.KeyCode == Keys.Subtract)
            {
                setOperation("-");
            }
            if (e.KeyCode == Keys.Multiply)
            {
                setOperation("x");
            }
            if (e.KeyCode == Keys.Divide)
            {
                setOperation("/");
            }
            if (e.KeyCode == Keys.Enter) {
                equalButton();
            }
            if (e.KeyCode == Keys.Back) {
                backSpace();
            }

        }
    }
}
