using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamples
{
    internal class Child : Parent
    {
        public Child():base("Pravinkumar R. D.")
        {
            Console.WriteLine("Child Class Constructor Executed!");
        }
    }
}
