using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    internal class Schedule
    {
        public int DayId { get; }
        public int TimeId { get; }

        public Schedule(int dayId, int timeId)
        {
            DayId = dayId;
            TimeId = timeId;
        }
    }
}
