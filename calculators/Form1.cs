using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculators
{
    public partial class Form1 : Form
    {
        private Single sngNum1, sngNum2, sngAnswer;
        private String strCalc;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMuliply_Click(object sender, EventArgs e)
        {

            String strCalc;
            { 
                //copy the number to the num1 variable
                sngNum1 = Convert.ToSingle(txtNum1.Text);
                //set the calc variable with multiply
                strCalc = "multiply";
                //clear the txtnum1.text box and remove the numbers ready for the new numbers
                txtNum1.Text = string.Empty;
                //Puts the cursor back in the textbox
                txtNum1.Focus();
            }


            //holding variable
                Single sngNumber1, sngNumber2;

            //if the number is a real number then convert it to a single and pass it out with 'Number'


            if (Single.TryParse(txtNum1.Text, out sngNumber1) &&
                Single.TryParse(txtNum2.Text, out sngNumber2))
            {
                sngNum1 = sngNumber1;
                sngNum2 = sngNumber2;
                // sngNum2 = Convert.ToSingle(txtNum2.Text);
                //run the calculation
                sngAnswer = sngNum1 * sngNum2;
                //Pass the answer to the label and the listbox
                lblAnswer.Text = Convert.ToString(sngAnswer);
                lbxAnswer.Items.Add(sngNum1 + " X " + sngNum2 + " = " + sngAnswer);
            }

            else //otherwise don't do anything
            {
                sngNum1 = 0;
                txtNum1.Text = ""; //empty the text box
                sngNum2 = 0;
                txtNum2.Text = ""; //empty the text box
                //Show a message
                MessageBox.Show("Please enter a number in Text Box");
            }


           /* //pass the number from the text box to the variables
            sngNum1 = Convert.ToSingle(txtNum1.Text);
            sngNum2 = Convert.ToSingle(txtNum2.Text);
            //run the calculation
            sngAnswer = sngNum1 * sngNum2;
            //Pass the answer to the label and the listbox
            lblAnswer.Text = Convert.ToString(sngAnswer);
            lbxAnswer.Items.Add(sngNum1 + " X " + sngNum2 + " = " + sngAnswer);*/
        }



        private void btnDivide_Click(object sender, EventArgs e)
        {
            //pass the number from the text box to the variables
            sngNum1 = Convert.ToSingle(txtNum1.Text);
            sngNum2 = Convert.ToSingle(txtNum2.Text);
            //run the calculation
            sngAnswer = sngNum1 / sngNum2;
            //Pass the answer to the label and the listbox
            lblAnswer.Text = Convert.ToString(sngAnswer);
            lbxAnswer.Items.Add(sngNum1 + " / " + sngNum2 + " = " + sngAnswer);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //pass the number from the text box to the variables
            sngNum1 = Convert.ToSingle(txtNum1.Text);
            sngNum2 = Convert.ToSingle(txtNum2.Text);
            //run the calculation
            sngAnswer = sngNum1 - sngNum2;
            //Pass the answer to the label and the listbox
            lblAnswer.Text = Convert.ToString(sngAnswer);
            lbxAnswer.Items.Add(sngNum1 + " - " + sngNum2 + " = " + sngAnswer);
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbxAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
             // copy the number on the text of the button to the textbox
               txtNum1.Text += btn1.Text;
        
         }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            { 
                sngNum2 = Convert.ToSingle(txtNum1.Text);
                txtNum1.Text = string.Empty;
                //if the calc holds the text of multiply (note the == for absolute)
                if (strCalc == "multiply")
                {
                    //run the calculation
                    sngAnswer = sngNum1 * sngNum2;
                    //Pass the answer to the label and the listbox
                    lblAnswer.Text = Convert.ToString(sngAnswer);
                    lbxAnswer.Items.Add(sngNum1 + " X " + sngNum2 + " = " + sngAnswer);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
         



    }

    private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            //pass the number from the text box to the variables
            sngNum1 = Convert.ToSingle(txtNum1.Text);
            sngNum2 = Convert.ToSingle(txtNum2.Text);
            //run the calculation
            sngAnswer = sngNum1 + sngNum2;
            //Pass the answer to the label and the listbox
            lblAnswer.Text = Convert.ToString(sngAnswer);
            lbxAnswer.Items.Add(sngNum1 + " + " + sngNum2 + " = " + sngAnswer);
        }
    
}
}
