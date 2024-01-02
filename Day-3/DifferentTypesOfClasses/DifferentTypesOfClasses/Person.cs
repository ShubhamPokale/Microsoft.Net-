using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypesOfClasses
{
    abstract class Person
    {
        public int SocialNumber { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }

        public abstract bool ChangeAddress(string oldAddress, string newAddress);
    }
}
