using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SignUpForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void signUpbotton_Click(object sender, EventArgs e)
        {
            bool isValidData = default;

            string firstName = default;
            if (SignUpWork.CheckString(nameof(firstName), nameTextBox.Text))
            {
                isValidData = true;
                firstName = SignUpWork.CleanDataFromTextBox(nameTextBox.Text);
            }else
                isValidData = false; 
            //--
            string lastName = default;
            if (SignUpWork.CheckString(nameof(lastName), lastNameTextBox.Text))
            {
                isValidData = true && isValidData;
                lastName = SignUpWork.CleanDataFromTextBox(lastNameTextBox.Text);
            }else
                isValidData = false;
            //--
            string phoneNumber = default;
            if (SignUpWork.CheckPhone(phoneNumberTextBox.Text))
            {
                phoneNumber = SignUpWork.CleanPhone(SignUpWork.CleanDataFromTextBox(phoneNumberTextBox.Text));
                isValidData = (true && isValidData);
            }
            else
                isValidData = (false && isValidData);
            //--
            int age = default;
            if (SignUpWork.IsValidAgeWithMessage(ageTextBox.Text))
                age = SignUpWork.GetAge(ageTextBox.Text);
            else
                isValidData = false;
            //--

        }
    }
}
