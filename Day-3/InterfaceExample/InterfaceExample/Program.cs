using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IPhysics physics=new Science();
            physics.PhysicsCalci();
            IChemistry chemistry = new Science();
            chemistry.ChemistryCalci();
            IBiology biology = new Science();
            biology.BiologyCalci();
            Console.WriteLine("--------------------");
            IScience science=new Science(); 
            
        }
    }
}
