using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamples
{
    internal class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Class Constructor Executed!");
        }
        public Parent(string name):this()
        {
            Console.WriteLine(name);
        }
    }
}
