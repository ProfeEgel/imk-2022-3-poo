using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataControls
{
    internal class Patient
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName => $"{LastName}, {FirstName}";
        
        public Patient(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
