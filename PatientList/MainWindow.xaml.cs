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
                    Address = account.Address, 
                    Phone = account.Phone
                });
            }
            
            //take patient list data and transfers it into the data grid as an ItemsSource
            dg_patients.ItemsSource = patientList;
            
        }

        // when the print button is pressed, a txt file is create that lists all patients saved
        // Note: The file will be located in the PatientList project file
        // PatientList -> bin -> Debug -> txt.file
        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            //creates a text file called "PatientList.txt"
            StreamWriter File = new StreamWriter("PatientList.txt");

            File.WriteLine("PATIENT LIST");
            File.WriteLine("------------------");
            File.WriteLine(""); // extra space

            //prints a line for each menu item object in the order list
            for (int i = 0; i < Patients.Count; i++)
            {
                //
                Patient information = Patients[i];
                File.WriteLine("Name:   " + information.LastName + ", " + information.FirstName);
                File.WriteLine("Addr:   " + information.Address);
                File.WriteLine("No:     " + information.Phone);
                File.WriteLine("Email:  " + information.Email);
                File.WriteLine(""); // extra space
            }

            // this line is needed to close the file -> finish writing
            File.Close();

            // window output
            MessageBox.Show("Patient List saved.");
        }

        // event not used, but it is used when a patient object is selected in the datagrid
        private void dg_patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }



    }
}
