using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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
using System.IO;
using System.Text.RegularExpressions;

namespace PatientList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadListOfPatients();

            // improvised "navigation" bar as a combobox
            patientListNav.Items.Add("Sign Up");
        }

        // creation of the Patient collection
        // ObservableCollections use any data types
        //which can be used to add medications dosages (int, double) and expiration dates (Date)
        ObservableCollection<Patient> Patients = new ObservableCollection<Patient>();

        // patientList -> for putting the patient objects into the Data Grid
        ListOfPatients patientList = new ListOfPatients();

        // method that loads data into the application upon initialization
        private void LoadListOfPatients()
        {
            //hard coded objects for demo
            Patients.Add(new Patient {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@hotmail.com",
                Phone = "416-888-8238",
                Address = "50 Center Drive",
                Password = "Secret123$"
            });

            Patients.Add(new Patient
            {
                FirstName = "Jane",
                LastName = "Dot",
                Email = "jane.dot@hotmail.com",
                Phone = "416-801-1235",
                Address = "109 Tender Road",
                Password = "Secret456$"
            });

            Patients.Add(new Patient
            {
                FirstName = "Jack",
                LastName = "Daniels",
                Email = "jack_daniels@hotmail.com",
                Phone = "416-801-1235",
                Address = "109 Tender Road"
            });

            Patients.Add(new Patient
            {
                FirstName = "Peter",
                LastName = "Parker",
                Email = "spider-man@hotmail.com",
                Phone = "416-345-4567",
                Address = "23 Daily Drive",
                Password = "Spider111&"
            });

            // add patient objects to the patient list
            for (int i = 0; i < Patients.Count; i++)
            {
                Patient account = Patients[i];
                patientList.Add(new Patient 
                {
                    FirstName = account.FirstName, 
                    LastName = account.LastName, 
                    Email = "",
                    Address = account.Address, 
                    Phone = account.Phone,
                    Password = ""
                });
            }
            
            //take patient list data and transfers it into the data grid as an ItemsSource
            dg_patients.ItemsSource = patientList;
        }

        // method to allow cell editing on datagrid
        // in other words, allows for information to change
        private void dg_patients_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                // recreate the view
                // System.Windows.Threading.DispatcherPriority.Background -> operations are processed after all other non-idle operations are completed

                dg_patients.Dispatcher.BeginInvoke(new Action(() => dg_patients.Items.Refresh()), System.Windows.Threading.DispatcherPriority.Background);
            }
            catch (Exception)
            {
            }

            // recreate the patient object using updated information
            Patient updatedPatientInformation = (Patient)dg_patients.SelectedItem;
        }


        // when the print button is pressed, a txt file is create that lists all patients saved
        // Note: The file will be located in the PatientList project file
        // PatientList -> bin -> Debug -> txt.file
        private void save_btn_Click(object sender, RoutedEventArgs e)
        {
            //creates a text file called "PatientList.txt"
            StreamWriter File = new StreamWriter("PatientList.txt");

            // textfile header
            File.WriteLine("PATIENT LIST");
            File.WriteLine("------------------");
            File.WriteLine(""); // extra space

            // prints a line for each menu item object in the order list
            for (int i = 0; i < Patients.Count; i++)
            {
                // create patient object for each patient in the textfile
                Patient information = Patients[i];
                File.WriteLine("Name:   " + information.LastName + ", " + information.FirstName);
                File.WriteLine("Addr:   " + information.Address);
                File.WriteLine("No:     " + information.Phone);
                File.WriteLine("Email:  " + information.Email);
                File.WriteLine(""); // extra space
            }

            // close the file -> finish writing the text file
            File.Close();

            // window output
            MessageBox.Show("Patient List saved.");
        }

        // event not used, but it is used when a patient object is selected in the datagrid
        private void dg_patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void addPatient_btn_Click(object sender, RoutedEventArgs e)
        {
            if (fName_txt.Text == "" || lName_txt.Text == "" ||
                address_txt.Text == "" || phone_txt.Text == "")
            {
                //prompts user to enter missing information when left empty
                MessageBox.Show("Please, enter information into the empty field(s).");
            }
            else if (phone_txt.Text != "" && IsValidNumber(phone_txt.Text) == false)
            {
                // prompts user to enter valid phone number if entered incorrectly
                MessageBox.Show("Please, enter valid phone number.");
            }
            else if (fName_txt.Text != "" && lName_txt.Text != "" &&
                    address_txt.Text != "" && phone_txt.Text != "" && IsValidNumber(phone_txt.Text) == true)
            {
                // if all fields are input correctly, add patient information to the patient list

                // add new patient to the patient list
                patientList.Add(new Patient
                {
                    FirstName = fName_txt.Text,
                    LastName = lName_txt.Text,
                    Address = address_txt.Text,
                    Phone = phone_txt.Text
                });

                // add new patient to the patient repository
                // done for the printing of information later
                Patients.Add(new Patient
                {
                    FirstName = fName_txt.Text,
                    LastName = lName_txt.Text,
                    Address = address_txt.Text,
                    Phone = phone_txt.Text

                });

                ClearAll();
            }   
        }

        private void deletePatient_btn_Click(object sender, RoutedEventArgs e)
        {
            // create a patient object that is the selected object
            // you will be able to specify the patient that the user will be deleting 
            Patient itemToRemove = dg_patients.SelectedItem as Patient;

            for (int i = 0; i < patientList.Count; i++)
            {
                // the following if statement checks if the selected patient's properties match
                // this is to prevent patients with the same name, address and phone number to be deleted
                if (patientList[i].FirstName.Equals(itemToRemove.FirstName) && 
                    patientList[i].LastName.Equals(itemToRemove.LastName) &&
                    patientList[i].Address.Equals(itemToRemove.Address) &&
                    patientList[i].Phone.Equals(itemToRemove.Phone))
                {
                    // remove the specific patient in both the list and patient repository
                    Patients.RemoveAt(i);
                    patientList.RemoveAt(i);
                    
                    // the break is meant to stop looping to halt unnecessary actions after finding the specific patient
                    break;
                }
            }
        }

        // method that clears all input fields
        public void ClearAll()
        {
            fName_txt.Clear();
            lName_txt.Clear();
            address_txt.Clear();
            phone_txt.Clear();
        }

        //method for checking if phone number is valid 
        // must have an area code and 7 numbers afterwards (e.g. "1-416-xxx-xxxx", "647-9007000", etc... are acceptable)
        public static bool IsValidNumber(string number)
        {
            //regex expression for "phone numbers"
            return Regex.Match(number, @"((?:\(?[2-9](?(?=1)1[02-9]|(?(?=0)0[1-9]|\d{2}))\)?\D{0,3})(?:\(?[2-9](?(?=1)1[02-9]|\d{2})\)?\D{0,3})\d{4})").Success;
        }

    }
}
