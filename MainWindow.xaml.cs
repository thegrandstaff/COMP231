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

            //navigation bar (combobox)
            patientListNav.Items.Add("Sign Up");
        }

        ObservableCollection<Patient> Patients = new ObservableCollection<Patient>();

        // patientList -> for putting the patient objects into the Data Grid
        ListOfPatients patientList = new ListOfPatients();

        private void LoadListOfPatients()
        {
            //patient list datagrid
            /*
            patientList.Add(new Patient { FirstName = "John", LastName = "Doe", Email = "john.doe@hotmail.com", Phone = "416-888-8238", Address = "50 Center Drive", Password = "Secret123$" });
            patientList.Add(new Patient { FirstName = "Jane", LastName = "Dot", Email = "jane.dot@hotmail.com", Phone = "416-801-1235", Address = "109 Tender Road", Password = "Secret456$" });
            patientList.Add(new Patient { FirstName = "Jack", LastName = "Daniels", Email = "jack_daniels@hotmail.com", Phone = "416-801-1235", Address = "109 Tender Road"});
            patientList.Add(new Patient { FirstName = "Peter", LastName = "Parker", Email = "spider-man@hotmail.com", Phone = "416-345-4567", Address = "23 Daily Drive", Password = "Spider111&" });
            */

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

            //add patient objects to the patient list
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
            
            //take patient list into the data grid
            dg_patients.ItemsSource = patientList;
            
        }

        private void dg_patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void patientListNav_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (patientListNav.SelectedIndex == 0) //sign up
            {

            }

        }

    }
}
