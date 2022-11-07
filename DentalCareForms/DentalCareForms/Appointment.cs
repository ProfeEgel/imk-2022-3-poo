using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCareForms
{
    internal class Appointment
    {
        public int PatientId { get; }
        public int DayId { get; }
        public int TimeId { get; }

        public Appointment(int patientId, int dayId, int timeId)
        {
            PatientId = patientId;
            DayId = dayId;
            TimeId = timeId;
        }
    }
}
