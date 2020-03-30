﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientList
{
    public class Patient : INotifyPropertyChanged
    {
        //declare variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        //patient constructor
        public Patient(string fName, string lName, string email, string phone, string address, string password)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.Password = password;
        }
        
        //patient constructor - only 4 properties 
        public Patient(string fName, string lName, string phone, string address)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Phone = phone;
            this.Address = address;
        }

        //patient constructor - no properties (needed for datagrid)
        public Patient()
        { 
        }

        //event handler - only necessary / used when a property in the datagrid changes
        public event PropertyChangedEventHandler PropertyChanged;

        // Create OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}