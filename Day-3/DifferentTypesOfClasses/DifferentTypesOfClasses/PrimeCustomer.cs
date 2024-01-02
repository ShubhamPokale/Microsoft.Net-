using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypesOfClasses
{
    //PrimeCustomer IS-A Customer
    sealed class PrimeCustomer:Customer
    {
        public int PrimeId { get; set; }
        public double PrimeFees { get; set; }
    }
}
