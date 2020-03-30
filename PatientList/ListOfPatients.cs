using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientList
{
    // class used to create the list of patients (observablecollections)
    class ListOfPatients : ObservableCollection<Patient>
    {
        public ListOfPatients() : base()
        {
        }
    }
}
