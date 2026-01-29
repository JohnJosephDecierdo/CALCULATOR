using System;
using System.Data;
using System.Windows.Forms;

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

            if (button.Text == ".")
            {
                if (textBox1_Result.Text.Contains("."))
                    return;

                if (textBox1_Result.Text == "")
                    textBox1_Result.Text = "0";
            }

            textBox1_Result.Text += button.Text;
        }





        // OPERATORS

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string op = button.Text;

            if (op == "x" || op == "×")
                op = "*";

        
            if (afterEquals)
            {
                label1.Text = textBox1_Result.Text + " " + op + " ";
                afterEquals = false;

                textBox1_Result.Text = "0";
                newInput = true;
                return;
            }

            if (newInput && label1.Text.EndsWith(" "))
            {
                label1.Text =
                    label1.Text.Substring(0, label1.Text.Length - 3)
                    + " " + op + " ";
                return;
            }

           
            if (newInput && textBox1_Result.Text == "0")
                return;

            label1.Text += textBox1_Result.Text + " " + op + " ";

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

                string expression;

                if (label1.Text.EndsWith(" "))
                    expression = label1.Text + textBox1_Result.Text;
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

            if (val == "0" || val == "")
                return;


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

           
            newInput = true;
        }



        // BACKSPACE

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1_Result.Text.Length > 1)
            {
                textBox1_Result.Text =
                    textBox1_Result.Text.Substring(
                        0, textBox1_Result.Text.Length - 1);
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
