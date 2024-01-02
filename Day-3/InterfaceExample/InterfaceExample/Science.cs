using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Science : IScience
    {
        void IBiology.BiologyCalci()
        {
            Console.WriteLine("This is a Biology Department Calci!");
        }
        void IChemistry.ChemistryCalci()
        {
            Console.WriteLine("This is a Chemistry Department Calci!");
        }
        void IPhysics.PhysicsCalci()
        {
            Console.WriteLine("This is a Physics Department Calci!");
        }
    }
}
