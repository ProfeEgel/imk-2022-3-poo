using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    internal class Time
    {
        public int Id { get; }
        public string Description { get; }

        public Time(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
