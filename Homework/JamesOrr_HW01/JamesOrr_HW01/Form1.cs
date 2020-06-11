using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesOrr_HW01
{
    public partial class windowForm : Form
    {
        public windowForm()
        {
            InitializeComponent();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            groupBoxName.Text = "Name : " + nameTextBox.Text;    //Applies the entered name to the order details
        }

        private void cashRadio_CheckedChanged(object sender, EventArgs e)
        {
            groupPayLabel.Text = "Payment Method : Cash";     //Applies cash as payment
        }

        private void creditRadio_CheckedChanged(object sender, EventArgs e)
        {
            groupPayLabel.Text = "Payment Method : Credit / Debit";    //Applies credit or debit as payment
        }

        private void paypalRadio_CheckedChanged(object sender, EventArgs e)
        {
            groupPayLabel.Text = "Payment Method : Paypal";    //Applies Paypal as the payment
        }

        private void otherOptionRadio_CheckedChanged(object sender, EventArgs e)
        {
            groupPayLabel.Text = "Payment Method : " + otherOptionTextBox.Text;    //Applies the entered text as the payment
        }

        private void confirmProductButton_Click(object sender, EventArgs e)
        {
            groupProductLabel.Text = "Product : " + productComboBox.Text + " x" + quantitySelect.Value;    //Confirms the order and quantity
        }

        private void selectDate_ValueChanged(object sender, EventArgs e)
        {
            groupBoxDate.Text = "Date of Arrival : " + selectDate.Value;    //Writes down the chosen date
        }

        private void deliveryButton_Click(object sender, EventArgs e)
        {
            deliveryInstructions.Text = instructionTextBox.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)    //Clears all the data entered
        {
            nameTextBox.Text = "";    //Resets the name

            quantitySelect.Value = 1;    //Resets the quatity

            cashRadio.Checked = false;    //Resets each section of the payment group box
            creditRadio.Checked = false;
            paypalRadio.Checked = false;
            otherOptionRadio.Checked = false;
            otherOptionTextBox.Text = "";

            instructionTextBox.Text = "";    //Resets the instruction text box

            groupBoxName.Text = "Name : ";     //Erases all data from the order form group box
            groupPayLabel.Text = "Payment Method : ";
            groupBoxDate.Text = "Date of Arrival : ";
            groupProductLabel.Text = "Product : ";
            deliveryInstructions.Text = "";
        }

        private void confirmOrderButton_Click(object sender, EventArgs e)    //Checks if every field is filled in
        {
            if (groupBoxName.Text == "Name : " &&    //If one of these fields are left empty, this message will appear
                groupPayLabel.Text == "Payment Method : " &&
                groupBoxDate.Text == "Date of Arrival : " &&
                groupProductLabel.Text == "Product : " &&
                deliveryInstructions.Text == "")
            {
                isOrderReadyLabel.Text = "Please fill out all of the fields.";
            }

            else    //If all of the fields are filled in, this message will display
            {
                isOrderReadyLabel.Text = "Thank you for ordering.";
            }
        }

        private void endProgramButton_Click(object sender, EventArgs e)
        {
            Close();    //Immediately closes the program
        }
    }
}
