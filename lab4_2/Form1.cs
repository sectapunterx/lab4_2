using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MyCalcBase calc;

            if (rbCalc1.Checked)
            {
                calc = new MyCalc1();
                ((MyCalc1)calc).A = int.Parse(txtA.Text);
                if(((MyCalc1)calc).A == 2)
                {
                    MessageBox.Show("A cannot be 2.");
                    return;
                }
                ((MyCalc1)calc).B = double.Parse(txtB.Text);
                ((MyCalc1)calc).B = double.Parse(txtB.Text);
                lblExpression.Text = "Expression: (A - B) / (A - 2)";
            }
            else if (rbCalc2.Checked)
            {
                calc = new MyCalc2();
                ((MyCalc2)calc).A = int.Parse(txtA.Text);
                ((MyCalc2)calc).B = double.Parse(txtB.Text);
                ((MyCalc2)calc).D = double.Parse(txtD.Text);
                lblExpression.Text = "Expression: (A - D) / (A + D)";
            }
            else
            {
                MessageBox.Show("Please select a calculation type.");
                return;
            }

            try
            {
                double result = calc.Calculate();
                txtResult.Text = result.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private const string DefaultTextA = "A";
        private const string DefaultTextB = "B";
        private const string DefaultTextD = "D";

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == DefaultTextA || txt.Text == DefaultTextB || txt.Text == DefaultTextD)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == "")
            {
                if (txt.Name == "txtA")
                {
                    txt.Text = DefaultTextA;
                }
                else if (txt.Name == "txtB")
                {
                    txt.Text = DefaultTextB;
                }
                else if (txt.Name == "txtD")
                {
                    txt.Text = DefaultTextD;
                }
                txt.ForeColor = Color.Gray;
            }
        }



    }
}