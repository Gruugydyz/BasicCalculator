using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;




namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        float Num1,Num2;

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {

            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            Num1 = float.Parse(txtbox1.Text);
            Num2 = float.Parse(txtbox2.Text);


            if(cbOperator.Text == "+")
            {
                txtbox3.Text = BasicComputation.Addition(Num1,Num2).ToString();

            }
            else if(cbOperator.Text == "-")
            {
                txtbox3.Text = BasicComputation.Subtraction(Num1, Num2).ToString();
            }
            else if(cbOperator.Text == "*")
            {
                txtbox3.Text = BasicComputation.Multiplication(Num1, Num2).ToString();
            }
            else if( cbOperator.Text == "/")
            {
                txtbox3.Text = BasicComputation.Division(Num1, Num2).ToString();
            }

        }


    }
}
