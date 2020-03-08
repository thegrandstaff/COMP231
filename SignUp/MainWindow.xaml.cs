using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SignUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //navigation bar (combobox)
            signupNav.Items.Add("Patients List");
        }

        

        // method checks for valid email - returns boolean
        public static bool IsValidEmail(string email)
        {
            return Regex.Match(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$").Success;
        }

        //method for checking if phone number is valid 
        public static bool IsValidNumber(string number)
        {
            return Regex.Match(number, @"((?:\(?[2-9](?(?=1)1[02-9]|(?(?=0)0[1-9]|\d{2}))\)?\D{0,3})(?:\(?[2-9](?(?=1)1[02-9]|\d{2})\)?\D{0,3})\d{4})").Success;
        }

        private void signup_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (firstName_Txt.Text == "")
            {
                MessageBox.Show("Please, enter your first name.");
            }
            else if (lastName_Txt.Text == "")
            {
                MessageBox.Show("Please, enter your last name.");
            }
            else if (emailAddress_Txt.Text == "")
            {
                MessageBox.Show("Please, enter your email address.");
            }
            else if (IsValidEmail(emailAddress_Txt.Text) == false && emailAddress_Txt.Text != "")
            {
                MessageBox.Show("Please enter a valid email.");
                emailAddress_Txt.Focus();
            }
            else if (phoneNumber_Txt.Text == "")
            {
                MessageBox.Show("Please, enter your phone number.");
            }
            else if (IsValidNumber(phoneNumber_Txt.Text) == false && phoneNumber_Txt.Text != "")
            {
                MessageBox.Show("Please, enter a valid phone number.");
            }
            else if (streetAddress_Txt.Text == "")
            {
                MessageBox.Show("Please, enter your street address.");
            }
            else if (password_box.Password == "")
            {
                MessageBox.Show("Please, enter a password.");
            }
            else if (password_box.Password.Length < 10)
            {
                MessageBox.Show("Please enter a password that is at least 10 characters.");
            }
            else if (confirmPassword_box.Password == "" && password_box.Password != "")
            {
                MessageBox.Show("Please, confirm your password in the 'Confirm Password' box.");
            }
            else
            {
                Patient patient = new Patient();
            }


            

            



            // checks if the password matches the input for "confirm password"
            if (password_box.Password != confirmPassword_box.Password && 
                password_box.Password != "" && 
                confirmPassword_box.Password != "")
            {
                MessageBox.Show("Passwords entered do not match.");
                confirmPassword_box.Password = "";
            }
        }

        private void clear_Btn_Click(object sender, RoutedEventArgs e)
        {
            // clears text input
            firstName_Txt.Clear();
            lastName_Txt.Clear();
            emailAddress_Txt.Clear();
            phoneNumber_Txt.Clear();
            streetAddress_Txt.Clear();
            password_box.Clear();
            confirmPassword_box.Clear();
        }

        private void signupNav_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (signupNav.SelectedIndex == 1)
            {
                MessageBox.Show("You selected Patients List");
            }
        }






        /*

        


        //method for checking if email address is valid
        //needs to follow standard format (e.g. abcdefg@gmail.com). 
        //double dots at the end are not allowed. spaces are not allowed. 
        public static bool IsValidEmail(string email)
        {
            return Regex.Match(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$").Success;
        }


        //method that checks whether or not an email address already exists in the emailSub list
        public bool DoesEmailExist()
        {
            //declare duplicateEmail bool variable
            bool duplicateEmail;

            //checks if there is a duplicate in the emailSub list
            if (duplicateEmail = Program.emailSub.Any(t => t.EmailAddr == emailAddress.Text))
            {
                //email exists
                return true;
            }
            else
            {
                //email does not exist
                return false;
            }
        }

        //method that checks for duplicate phone numbers if they already exist in the phoneSub list
        public bool DoesPhoneExist()
        {
            //declare duplicatePhone boolean
            bool duplicatePhone;

            //checks if there is a duplicate in the emailSub list
            if (duplicatePhone = Program.phoneSub.Any(t => t.CellPhone == phoneNumber.Text))
            {
                //email exists
                return true;
            }
            else
            {
                //email does not exist
                return false;
            }
        }

    */

    }
}
