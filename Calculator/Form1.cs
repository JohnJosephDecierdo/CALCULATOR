using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool afterEquals = false;
        bool newInput = true;

        public Form1()
        {
            InitializeComponent();

            textBox1_Result.Text = "0";
            label1.Text = "";

            textBox1_Result.ReadOnly = true;
            textBox1_Result.TabStop = false;
            textBox1_Result.HideSelection = true;

            this.ActiveControl = null;
        }

        private string ForceDouble(string expr)
        {
            // Add .0 to whole numbers → forces double math
            return System.Text.RegularExpressions.Regex.Replace(
                expr,
                @"(?<![\d.])(\d+)(?![\d.])",
                "$1.0"
            );
        }


        private string FormatResult(double value)
        {

            if (value % 1 == 0)
                return value.ToString("0");


            return value.ToString("0.##########");
        }

        // NUMBER & DOT

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            if (textBox1_Result.Text == "(-0)")
            {
                if (button.Text == ".")
                    textBox1_Result.Text = "(-0.)";
                else
                    textBox1_Result.Text = "(-" + button.Text + ")";

                newInput = false;
                return;
            }

            if (newInput)
            {
                if (afterEquals)
                    label1.Text = "";

                textBox1_Result.Text = "0";
                afterEquals = false;
                newInput = false;
            }


            if (textBox1_Result.Text == "0" && button.Text != ".")
                textBox1_Result.Text = "";


            if (textBox1_Result.Text.Length > 0 &&
                textBox1_Result.Text.All(c => c == '0') &&
                button.Text != ".")
                textBox1_Result.Text = "";

            if (button.Text == ".")
            {
                if (textBox1_Result.Text.Contains("."))
                    return;

                if (textBox1_Result.Text == "")
                    textBox1_Result.Text = "0";
            }

            if (textBox1_Result.Text.StartsWith("(-") && textBox1_Result.Text.EndsWith(")"))
            {

                string inner = textBox1_Result.Text.Substring(2, textBox1_Result.Text.Length - 3);

                if (button.Text == ".")
                {
                    if (inner.Contains("."))
                        return;
                    if (inner == "")
                        inner = "0";
                }

                textBox1_Result.Text = "(-" + inner + button.Text + ")";
            }
            else
            {
                textBox1_Result.Text += button.Text;
            }
        }

        // OPERATORS

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string op = button.Text;

            if (op == "x" || op == "×")
                op = "*";


            if (newInput)
                return;

            if (afterEquals)
            {
                label1.Text = textBox1_Result.Text + " " + op + " ";
                afterEquals = false;

                textBox1_Result.Text = "0";
                newInput = true;
                return;
            }


            string currentValue = textBox1_Result.Text;
            if (currentValue.EndsWith("."))
                currentValue = currentValue.TrimEnd('.');


            if (currentValue.StartsWith("(-") && currentValue.EndsWith(")"))
            {

                string inner = currentValue.Substring(2, currentValue.Length - 3);
                currentValue = "-" + inner;
            }

            // Normal case
            label1.Text += currentValue + " " + op + " ";

            textBox1_Result.Text = "0";
            newInput = true;
        }






        // EQUALS

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (afterEquals && newInput)
                    return;


                if (label1.Text == "" && textBox1_Result.Text != "0")
                {
                    label1.Text = textBox1_Result.Text;
                    afterEquals = true;
                    newInput = true;
                    return;
                }

                if (label1.Text == "" && textBox1_Result.Text == "0")
                    return;


                if (label1.Text.Trim().EndsWith("+") ||
                    label1.Text.Trim().EndsWith("-") ||
                    label1.Text.Trim().EndsWith("*") ||
                    label1.Text.Trim().EndsWith("x") ||
                    label1.Text.Trim().EndsWith("×") ||
                    label1.Text.Trim().EndsWith("/"))
                {

                    if (textBox1_Result.Text == "0" && newInput)
                    {
                        MessageBox.Show("Invalid Expression");
                        ClearAll();
                        return;
                    }
                }

                string expression;

                if (label1.Text.EndsWith(" "))
                {
                    string currentValue = textBox1_Result.Text;


                    if (currentValue.EndsWith("."))
                        currentValue = currentValue.TrimEnd('.');


                    if (currentValue.StartsWith("(-") && currentValue.EndsWith(")"))
                    {
                        string inner = currentValue.Substring(2, currentValue.Length - 3);
                        currentValue = "-" + inner;
                    }

                    expression = label1.Text + currentValue;
                }
                else
                    expression = label1.Text;


                expression = expression.Replace("x", "*").Replace("×", "*");


                expression = ForceDouble(expression);

                expression = expression.Trim();


                label1.Text = expression.Replace("*", "x");

                object result = new DataTable().Compute(expression, null);

                double value = Convert.ToDouble(result);

                textBox1_Result.Text = FormatResult(value);

                afterEquals = true;
                newInput = true;
            }
            catch
            {
                MessageBox.Show("Invalid Expression");
                ClearAll();
            }
        }


        // NEGATE (±)

        private void buttonNegate_Click(object sender, EventArgs e)
        {
            string val = textBox1_Result.Text.Trim();

            if (val == "")
                return;


            if (val == ".")
            {
                textBox1_Result.Text = "0";
                return;
            }

            if (val.EndsWith("."))
            {
                string numPart = val.TrimEnd('.');
                if (numPart.StartsWith("(-") && numPart.EndsWith(")"))
                {
                    string inner = numPart.Substring(2, numPart.Length - 3);
                    textBox1_Result.Text = inner + ".";
                }
                else if (numPart.StartsWith("-"))
                {
                    textBox1_Result.Text = numPart.Substring(1) + ".";
                }
                else
                {
                    textBox1_Result.Text = "(-" + numPart + ".)";
                }
                return;
            }

            if (val.StartsWith("(-") && val.EndsWith(")"))
            {
                textBox1_Result.Text = val.Substring(2, val.Length - 3);
            }
            else if (val.StartsWith("-"))
            {
                textBox1_Result.Text = val.Substring(1);
            }
            else
            {
                textBox1_Result.Text = "(-" + val + ")";
            }


        }

        // BACKSPACE

        private void button18_Click(object sender, EventArgs e)
        {
            string current = textBox1_Result.Text;


            if (current.StartsWith("(-") && current.EndsWith(")"))
            {
                string inner = current.Substring(2, current.Length - 3);

                // Handle empty inner or single character properly
                if (inner.Length == 0)
                {
                    // (-) becomes 0
                    textBox1_Result.Text = "0";
                }
                else if (inner.Length == 1)
                {
                    // (-5) becomes 5, (-.) becomes 0
                    if (inner == ".")
                        textBox1_Result.Text = "0";
                    else
                        textBox1_Result.Text = inner;
                }
                else
                {
                    // Remove last character from inside
                    string newInner = inner.Substring(0, inner.Length - 1);

                    // Special cases after backspace
                    if (newInner == "0" || newInner == "0.")
                        textBox1_Result.Text = "0";  // (-0) or (-0.) becomes just 0
                    else
                        textBox1_Result.Text = "(-" + newInner + ")";
                }
            }
            else if (current.Length > 1)
            {
                textBox1_Result.Text = current.Substring(0, current.Length - 1);
            }
            else
            {
                textBox1_Result.Text = "0";
            }
        }

        // CLEAR

        private void button16_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            textBox1_Result.Text = "0";
            label1.Text = "";
            afterEquals = false;
            newInput = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}