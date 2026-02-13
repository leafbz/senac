using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        private void cmdAny_Click(object sender, EventArgs e)
        {
            input += (sender as Button).Text;
            lblDisplay.Text = input;
    }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void cmdSubtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void cmdMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void cmdDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void cmdEqual_Click(object sender, EventArgs e)
        {
            string runningTotal = result.ToString();

            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                lblDisplay.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                lblDisplay.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                lblDisplay.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    lblDisplay.Text = result.ToString();
                }
                else
                {
                    lblDisplay.Text = "Cant /Zero";
                }

            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
    }
}
