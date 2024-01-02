using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Please enter your name!");
                string myName = Console.ReadLine();
                Console.WriteLine("Please enter your age!");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Welcome To Infoway! C-DAC!");
                Console.WriteLine("Welcome To DotNet Framework Training!");
                Console.WriteLine($"My name is {myName} and My age is {age}");
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
    }
}
