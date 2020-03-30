using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp
{
    public class Account : INotifyPropertyChanged
    {
        //declare variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        //account constructors

        public Account(string fName, string lName, string email, string phone, string address, string password)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.Password = password;
        }


        public Account(string fName, string lName, string phone, string address)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Phone = phone;
            this.Address = address;
        }

        public Account()
        { }

        // method is only necessary when a new function is used where account properties need to change
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
