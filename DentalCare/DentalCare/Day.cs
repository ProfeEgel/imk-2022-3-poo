using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    internal class Day
    {
        public int Id { get; }
        public string Name { get; }

        public Day(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
