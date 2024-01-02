using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypesOfClasses
{
    //Customer IS-A Person
    internal class Customer : Person
    {
        public int CustomerId { get; set; }
        public override bool ChangeAddress(string oldAddress, string newAddress)
        {
            Console.WriteLine($"Customer {ContactName} has changed his/her address from {oldAddress} to {newAddress}!");
            return true;
        }
    }
}
