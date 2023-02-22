using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {

        int opOne = 0;
        int opTwo = 0;
        bool opPressed = false;
        
        string filePath = "C:\\demo";
        
        string fileName = "demoo.txt";
        FileManager fm = null;

        public Form1()
        {
            InitializeComponent();

            fm = new FileManager(filePath, fileName);

            try
            {
                fm.CreateFile();
                txtHistory.Text = fm.Read();
            }
            catch
            {
                MessageBox.Show("There is an error in creating file.");
            }
        }

        //private void btnDisplay_Click(object sender, EventArgs e)
        //{

        //}

        private void btn1_Click(object sender, EventArgs e)
        {
            if (opPressed == true)
            {
                txtDisplay.Text = String.Empty;
                opPressed = false;
            }
            txtDisplay.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (opPressed == true)
            {
                txtDisplay.Text = String.Empty;
                opPressed = false;
            }
            txtDisplay.Text += "2";
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            if (opPressed == true)
            {
                txtDisplay.Text = String.Empty;
                opPressed = false;
            }
            txtDisplay.Text += "3";
        }
        private void btn4_Click_1(object sender, EventArgs e)
        {
            if (opPressed == true)
            {
                txtDisplay.Text = String.Empty;
                opPressed = false;
            }
            txtDisplay.Text += "4";
        }
        private void btn5_Click_1(object sender, EventArgs e)
        {
            if (opPressed == true)
            {
                txtDisplay.Text = String.Empty;
                opPressed = false;
            }
            txtDisplay.Text += "5";
        }
        private void btn6_Click_1(object sender, EventArgs e)
        {
            if (opPressed == true)
            {
                txtDisplay.Text = String.Empty;
                opPressed = false;
            }
            txtDisplay.Text += "6";
        }
private void btn7_Click_1(object sender, EventArgs e)
        {
            if (opPressed == true)
            {
                txtDisplay.Text = String.Empty;
                opPressed = false;
            }
            txtDisplay.Text += "7";
        }
private void btn8_Click_1(object sender, EventArgs e)
        {
            if (opPressed == true)
            {
                txtDisplay.Text = String.Empty;
                opPressed = false;
            }
            txtDisplay.Text += "8";
        }
private void btn9_Click_1(object sender, EventArgs e)
        {
            if (opPressed == true)
            {
                txtDisplay.Text = String.Empty;
                opPressed = false;
            }
            txtDisplay.Text += "9";
        }
        private void btn0_Click_1(object sender, EventArgs e)
        {
            if (opPressed == true)
            {
                txtDisplay.Text = String.Empty;
                opPressed = false;
            }
            txtDisplay.Text += "0";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            opOne = Convert.ToInt32(txtDisplay.Text);
            opPressed = true;
            lblOperator.Text = "+";
        }

        private void btnsub_Click_1(object sender, EventArgs e)
        {
            opOne = Convert.ToInt16(txtDisplay.Text);
            opPressed = true;
            lblOperator.Text = "-";
        }

        private void btnmul_Click_1(object sender, EventArgs e)
        {
            opOne = Convert.ToInt32(txtDisplay.Text);
            opPressed = true;
            lblOperator.Text = "*";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string result;
            switch (lblOperator.Text)
            {
                case "+" :
                   result = (opOne + Convert.ToInt32(txtDisplay.Text)).ToString();
                    break;
                    case "-" :
                     result = (opOne - Convert.ToInt32(txtDisplay.Text)).ToString();
                    break ;
                case "*":
                     result = (opOne * Convert.ToInt32(txtDisplay.Text)).ToString();
                    break;

                default:
                     result = txtDisplay.Text;
                    break;
            }
           
            string s = opOne.ToString() + lblOperator.Text + txtDisplay.Text + "=" + result.ToString();
            fm.Write(s);

            txtDisplay.Text = result.ToString();

            txtHistory.Text = fm.Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //here type the value that would get display after pressing cls
            txtDisplay.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }
    }
}
