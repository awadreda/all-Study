using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class frmcalculator : Form
    {
        string Number1 = "";
        string Number2 = "";
        string NumberFromUser = "";
        string answar = "";
        string LineToPushToArray = "";
        string[] arrOfAnswars= new string [100];
        string op = "";

        int i = 0;

        public frmcalculator()
        {
            InitializeComponent();
        }

        string CalcNumbers()
        {
            double num1 = Convert.ToDouble(Number1);
            double num2 = Convert.ToDouble(Number2);

            switch (op)   
            {
                
                case "+":
                    return ((num1 + num2).ToString());
                case "-":
                    return ((num1 - num2).ToString());
                case "*":
                    return ((num1 * num2).ToString());
                case "/":
                    return ((num1 / num2).ToString());               
                case "^":
                    return Math.Pow(num1,num2).ToString();
            }

            return null;
        }

        private void EnableAllButton()
        {
            btnMultiply.Enabled = true;
            btnDivide.Enabled = true;

            btnPlus.Enabled = true;
            btnMinus.Enabled = true;

            btnMultiply.BackColor = Color.Transparent;
            btnDivide.BackColor = Color.Transparent;

            btnPlus.BackColor = Color.Transparent;
            btnMinus.BackColor = Color.Transparent;

            btnPlus.BackColor = Color.Transparent;
            btnMinus.BackColor = Color.Transparent;

            btnPowr.BackColor = Color.Transparent;
            btnHunderdPrecent.BackColor = Color.Transparent;

            btnZero.Enabled = true;
            btnZero.BackColor = Color.Transparent;

            btn1.Enabled = true;
            btn1.BackColor = Color.Transparent;

            btn2.Enabled = true;
            btn2.BackColor = Color.Transparent;

            btn3.Enabled = true;
            btn3.BackColor = Color.Transparent;

            btn4.Enabled = true;
            btn4.BackColor = Color.Transparent;

            btn5.Enabled = true;
            btn5.BackColor = Color.Transparent;

            btn6.Enabled = true;
            btn6.BackColor = Color.Transparent;

            btn7.Enabled = true;
            btn7.BackColor = Color.Transparent;

            btn8.Enabled = true;
            btn8.BackColor = Color.Transparent;

            btn9.Enabled = true;
            btn9.BackColor = Color.Transparent; 

            btnDot.Enabled = true;
            btnDot.BackColor = Color.Transparent;

            btnEqule.Enabled = true;
            btnEqule.BackColor = Color.Transparent;

            btnSqrt.Enabled = true;
            btnSqrt.BackColor = Color.Transparent;

            btnHunderdPrecent.Enabled = true;

            btnPowr.Enabled = true;
            btnPowr.BackColor = Color.Transparent;
        }



        private void DisableAllButton()
        {
            btnMultiply.Enabled = false;
            btnDivide.Enabled = false;

            btnPlus.Enabled = false;
            btnMinus.Enabled = false;

            btnMultiply.BackColor = Color.Gray;
            btnDivide.BackColor = Color.Gray;

            btnPlus.BackColor = Color.Gray;
            btnMinus.BackColor = Color.Gray;

            btnPowr.BackColor = Color.Gray;

           // btnHunderdPrecent.BackColor = Color.Transparent;

            btnZero.Enabled = false;
            btnZero.BackColor = Color.Gray;

            btn1.Enabled = false;
            btn1.BackColor = Color.Gray;

            btn2.Enabled = false;
            btn2.BackColor = Color.Gray;

            btn3.Enabled = false;
            btn3.BackColor = Color.Gray;

            btn4.Enabled = false;
            btn4.BackColor = Color.Gray;

            btn5.Enabled = false;
            btn5.BackColor = Color.Gray;

            btn6.Enabled = false;
            btn6.BackColor = Color.Gray;

            btn7.Enabled = false;
            btn7.BackColor = Color.Gray;

            btn8.Enabled = false;
            btn8.BackColor = Color.Gray;

            btn9.Enabled = false;
            btn9.BackColor = Color.Gray;

            btnDot.Enabled = false;
            btnDot.BackColor = Color.Gray;

            btnEqule.Enabled = false;
            btnEqule.BackColor = Color.Gray;

            btnSqrt.Enabled = false;
            btnSqrt.BackColor = Color.Gray;

            //btnHunderdPrecent.Enabled = false;

            btnPowr.Enabled = false;
            btnPowr.BackColor= Color.Gray;
        }



        private void GetOpFromUser(object sender, EventArgs e)
        {
            if(((Button)sender).Text=="+"|| ((Button)sender).Text=="-")
            {
                btnMultiply.Enabled = false;
                btnDivide.Enabled = false;
                btnPowr.Enabled = false;
                

                btnMultiply.BackColor = Color.Gray;
                btnDivide.BackColor = Color.Gray;

                btnPowr.BackColor = Color.Gray;
               
            }

            if (((Button)sender).Text == "*" || ((Button)sender).Text == "/"|| ((Button)sender).Text == "^")
            {
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;

                btnPlus.BackColor = Color.Gray;
                btnMinus.BackColor = Color.Gray;
            }

            if (Number1!="")
            {
                Number2 = NumberFromUser;

                if (Number2!="")
                {
                    Number1 = CalcNumbers();
                }
            }

            op = ((Button)sender).Text;
            txtShowNumbers.Text += op;

            if(Number1=="")
            {
                Number1 = NumberFromUser;
            }

            NumberFromUser = "";
        }

        private void GetNumberFromUser(object sender, EventArgs e)
        {
            
            NumberFromUser += ((Button)sender).Text;
            txtShowNumbers.Text += ((Button)sender).Text;
        }

        private void btnEqule_Click(object sender, EventArgs e)
        {
            if(op==""||Number1=="")
            {
                return;
            }

            Number2 = NumberFromUser;

            if(Number2=="")
            {
                return;
            }

            DisableAllButton();

             answar = CalcNumbers();

            if(answar== "∞")
            {
                txtShowNumbers.Text = "Math Error";
                return;
            }

            LineToPushToArray = txtShowNumbers.Text + " = " + answar;
            arrOfAnswars[i] = LineToPushToArray;
            i++;
            txtShowNumbers.Text = answar;
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EnableAllButton();
            txtShowNumbers.Text = "";
            Number1 = "";
            Number2 = "";
            NumberFromUser = "";
            answar = "";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try 
            {
                NumberFromUser = Math.Sqrt(Convert.ToDouble(NumberFromUser)).ToString();
            } catch { return; }
            
            if(Number2=="")
            {
                txtShowNumbers.Text = NumberFromUser;
            }
        }

        private void btnHunderdPrecent_Click(object sender, EventArgs e)
        {
            
            if(Number2==""&&Number1=="")
            {
                if(txtShowNumbers.Text=="")
                {
                    return;
                }
                NumberFromUser = (Convert.ToDouble(txtShowNumbers.Text) * 100).ToString();
                txtShowNumbers.Text = NumberFromUser; 
                return;
            }

            if(answar=="")
            {
                return;
            }


            txtShowNumbers.Text = (Convert.ToDouble(answar)*100).ToString();
            LineToPushToArray = answar + " % = " + txtShowNumbers.Text;

            arrOfAnswars[i] = LineToPushToArray;
            i++;

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form frm = new frmHistory(arrOfAnswars);
            frm.ShowDialog();
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            NumberFromUser += ".";
            txtShowNumbers.Text += ".";
        }
    }
}
