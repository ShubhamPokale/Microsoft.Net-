using System;
using KA=India.Karnataka;
using MH = India.Maharashtra;
namespace DifferentTypesOfClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KA.Customer kc1=new KA.Customer();
            MH.Customer mhc1=new MH.Customer();
           
            Math math=new Math();
            
            
            try
            {
                PrimeCustomer customer = new PrimeCustomer();
                customer.PrimeFees= 999;
                customer.ContactName = "Manish Kaushik";
                customer.Address = "Suncity";
                customer.City = "Raipur";
                Console.WriteLine($"{customer.ChangeAddress(customer.Address, "MoonCity")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
