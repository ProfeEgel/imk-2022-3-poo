using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCareForms
{
    internal class AppointmentByPatient
    {
        public string PatientFullName { get; }
        public string DayName { get; }
        public string TimeDescription { get; }

        public AppointmentByPatient(string patientFullName, string dayName, string timeDescription)
        {
            PatientFullName = patientFullName;
            DayName = dayName;
            TimeDescription = timeDescription;
        }
    }
}
