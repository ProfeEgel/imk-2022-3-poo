using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCareForms
{
    internal class AppointmentByTime
    {
        public string TimeDescription { get; }
        public string PatientFullName { get; }

        public AppointmentByTime(string timeDescription, string patientFullName)
        {
            TimeDescription = timeDescription;
            PatientFullName = patientFullName;
        }
    }
}
