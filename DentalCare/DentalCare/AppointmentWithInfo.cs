using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    internal class AppointmentWithInfo
    {
        public Patient Patient { get; }
        public Day Day { get; }
        public Time Time { get; }

        public AppointmentWithInfo(Patient patient, Day day, Time time)
        {
            Patient = patient;
            Day = day;
            Time = time;
        }
    }
}
