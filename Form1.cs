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
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            TxBox_Calculator.Text = TxBox_Calculator.Text + "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            TxBox_Calculator.Text = TxBox_Calculator.Text + "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            TxBox_Calculator.Text = TxBox_Calculator.Text + "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            TxBox_Calculator.Text = TxBox_Calculator.Text + "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            TxBox_Calculator.Text = TxBox_Calculator.Text + "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            TxBox_Calculator.Text = TxBox_Calculator.Text + "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            TxBox_Calculator.Text = TxBox_Calculator.Text + "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            TxBox_Calculator.Text = TxBox_Calculator.Text + "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            TxBox_Calculator.Text = TxBox_Calculator.Text + "9";
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            TxBox_Calculator.Text = TxBox_Calculator.Text + "10";
        }
    }
}
