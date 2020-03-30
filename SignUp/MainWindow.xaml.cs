using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

        // creation of the Account collection
        // ObservableCollections use any data types
        // which can be used to add medications dosages (int, double) and expiration dates (Date)
        ObservableCollection<Account> Accounts = new ObservableCollection<Account>();

        // method checks for valid email
        // must follow the standard "example@email.com" domain 
        public static bool IsValidEmail(string email)
        {
            //regex expression for "email addresses"
            return Regex.Match(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$").Success;
        }

        // method for checking if phone number is valid 
        // must have an area code and 7 numbers afterwards (e.g. "1-416-xxx-xxxx", "647-9007000", etc... are acceptable)
        public static bool IsValidNumber(string number)
        {
            //regex expression for "phone numbers"
            return Regex.Match(number, @"((?:\(?[2-9](?(?=1)1[02-9]|(?(?=0)0[1-9]|\d{2}))\)?\D{0,3})(?:\(?[2-9](?(?=1)1[02-9]|\d{2})\)?\D{0,3})\d{4})").Success;
        }

        private void signup_Btn_Click(object sender, RoutedEventArgs e)
        {
            //set of prompts for input - incorrect or missing information
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
            // checks if the password matches the input for "confirm password"
            else if (password_box.Password != confirmPassword_box.Password &&
                password_box.Password != "" &&
                confirmPassword_box.Password != "")
            {
                MessageBox.Show("Passwords entered do not match.");
                confirmPassword_box.Password = "";
            }
            else
            {
                //if all information is filled properly, an account object will be created

                //create new account object with user input
                Accounts.Add(new Account
                {   
                    FirstName = firstName_Txt.ToString(), 
                    LastName = lastName_Txt.ToString(), 
                    Email = emailAddress_Txt.ToString(), 
                    Phone = phoneNumber_Txt.ToString(), 
                    Address = streetAddress_Txt.ToString(), 
                    Password = password_box.Password 
                });
                
                //create "account name" which is the first letter (lowercase) for the first name and the last name
                string firstName = firstName_Txt.Text.ToLower();
                string lastName = lastName_Txt.Text;

                //creating the substring for the first name
                string firstNameSubString = firstName.Substring(0,1);

                //creating the actual account name
                string accountName = firstNameSubString + lastName;

                //creates a text file called "accountInfo.txt"
                StreamWriter File = new StreamWriter("accountInfo.txt");

                //prints account information into the text file
                File.WriteLine("Account:    " + accountName);
                File.WriteLine("First Name: " + firstName_Txt.Text);
                File.WriteLine("Last Name:  " + lastName_Txt.Text);
                File.WriteLine("Address:    " + streetAddress_Txt.Text);
                File.WriteLine("Phone No.:  " + phoneNumber_Txt.Text);
                File.WriteLine("Email:      " + emailAddress_Txt.Text);
                File.WriteLine("Password:   " + password_box.Password);

                // this line is needed to close the file -> finish writing
                // information is now in a text file located in the project files
                // SignUp folder -> bin -> Debug -> txt.file
                File.Close();

                // output message - shows new account name
                MessageBox.Show("Account " + accountName + " created.");

                // window output - tells user that information is saved
                MessageBox.Show("Account information saved.");

                //clears all
                firstName_Txt.Clear();
                lastName_Txt.Clear();
                emailAddress_Txt.Clear();
                phoneNumber_Txt.Clear();
                streetAddress_Txt.Clear();
                password_box.Clear();
                confirmPassword_box.Clear();
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

        // automatically generated method
        private void signupNav_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {            
        }
    }
}
