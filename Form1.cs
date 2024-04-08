using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string strInput;
        double douOutput;
        double FirstNumber;
        double SecondNumber;
        int operators;
        public Form1()
        {
            InitializeComponent();
            NumberText.Text = "";
        }
        private void Add_Number(string Use_number)
        {
            if (TxBox_Calculator.Text == "0")
                TxBox_Calculator.Text = "";
            TxBox_Calculator.Text = TxBox_Calculator.Text + Use_number;
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Add_Number("1");
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Add_Number("2");
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Add_Number("3");
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Add_Number("4");
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Add_Number("5");
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Add_Number("6");
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Add_Number("7");
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Add_Number("8");
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Add_Number("9");
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Add_Number("0");
        }

        private void Divide_button_MouseClick(object sender, MouseEventArgs e)
        {
            FirstNumber = Convert.ToSingle(TxBox_Calculator.Text);
            NumberText.Text = TxBox_Calculator.Text + "/";
            TxBox_Calculator.Text = "";
            operators = 4;
        }

        private void Multiply_button_MouseClick(object sender, MouseEventArgs e)
        {
            FirstNumber = Convert.ToSingle(TxBox_Calculator.Text);
            NumberText.Text = TxBox_Calculator.Text + "*";
            TxBox_Calculator.Text = "";
            operators = 3;
        }

        private void Reduce_button_MouseClick(object sender, MouseEventArgs e)
        {
            FirstNumber = Convert.ToSingle(TxBox_Calculator.Text);
            NumberText.Text = TxBox_Calculator.Text + "-";
            TxBox_Calculator.Text = "";
            operators = 2;
        }

        private void Add_button_MouseClick(object sender, MouseEventArgs e)
        {
            FirstNumber = Convert.ToSingle(TxBox_Calculator.Text);
            NumberText.Text = TxBox_Calculator.Text + "+";
            TxBox_Calculator.Text = "";
            operators = 1;


        }

        private void Equal_Button_MouseClick(object sender, MouseEventArgs e)
        {
            double finalResults = 0f;
            SecondNumber = Convert.ToSingle(TxBox_Calculator.Text);
            switch (operators)
            {
                case 1:
                    finalResults = FirstNumber + SecondNumber;
                    break;
                case 2:
                    finalResults = FirstNumber - SecondNumber;
                    break;
                case 3:
                    finalResults = FirstNumber * SecondNumber;
                    break;
                case 4:
                    finalResults = FirstNumber / SecondNumber;
                    break;
            }
            TxBox_Calculator.Text = string.Format("{0:0.##########}", finalResults);
            NumberText.Text = "";
            FirstNumber = 0f;
            SecondNumber = 0f;
            operators = -1;

        }

        private void Dot_button_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxBox_Calculator.Text.IndexOf(".") == -1)
            {
                TxBox_Calculator.Text = TxBox_Calculator.Text + ".";
            }
                
        }

        private void AC_Btn_MouseClick(object sender, MouseEventArgs e)
        {
            TxBox_Calculator.Text = "0";
            NumberText.Text = "";
            FirstNumber = 0f;
            SecondNumber = 0f;
            operators = -1;
        }

        private void Percentage_Button_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void BackSpace_Btn_MouseClick(object sender, MouseEventArgs e)
        {
            
            string number = TxBox_Calculator.Text;
            int numberLen = number.Length-1;
            number.Substring(0, numberLen);
            TxBox_Calculator.Text = number;
        }
    }
}
