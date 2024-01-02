using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignments " );
            Swap(10,20);
            Console.WriteLine(GetASCIIValue(' '));
            Console.WriteLine(NetSalCalculator(100));
            Console.WriteLine(isLeapYear(1800));
          //  Console.WriteLine(NetSalAndCom());
            Console.WriteLine(MaxOfThree(10, 20, 30));
            //   DepartmentData();
            // DaysInMonth();
            // AsciiPrint();
            //Console.WriteLine(isPrime());
            // FetchPrimes();
            //getDate();
            //shapeflix();
            //fiboflix();
            combo3();
            Console.ReadKey();
        }

        public static void Swap(int a, int b)
        {       //  Write a program to swap two variables using a third variable by Console Application.
            Console.WriteLine($"Before swapping a is {a} and b is {b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After swapping a is {a} and b is {b}");

        }

        public static int GetASCIIValue(char ch)
        {       // Accept a character from a user and print its ASCII value using Console Application.
            return (int)ch;
        
        }

        public static double NetSalCalculator(double baseSal) 
        {
            /*      Write a program to calculate Net Salary of an employee using Basic Salary based on
      following parameters –
      a.HRA is 20 % of basic salary.
      b.DA is 40 % of basic salary.
      c.PF is 10 % of Gross salary.
      d.Gross Salary is Basic Salary + HRA + DA.
      e.Net salary is Gross Salary – PF.              */
            double HRA_V = 0.20;
            double DA_V = 0.40;
            double PF_V = 0.10;

            double HRA = HRA_V * baseSal; 

            double DA = DA_V * baseSal;


            double GrossSalary = baseSal + HRA + DA;


            double PF = PF_V * GrossSalary;

       

            double NetSalary = GrossSalary - PF; 
           
            return NetSalary;
                
        }

        public static bool isLeapYear(int year) 
        {
            /*                 Write a program to find LEAP year by using –
                 a.If – Else and logical operators.
                 b.Conditional operator.
                 c.Note – A Leap year is divisible by 4 and is not divisible by 100 but it could be divisible
                 by 400.                 */


            if ((year % 4 == 0 || year % 400 == 0) && (year % 100 != 0))
            {
                return true;
            }
            else { return false; }



        }

        public static string NetSalAndCom() 
        {
            /*            Write a program to accept the basic salary and total sales amount from a salesperson and
            calculate commission according to the sales amount.Display the net salary and commission
            earned.
            Sales Amount in Rs.Commission(%) on Sales
            5,000 to 7,500 3
            7,501 to 10,500 8
            10,501 to 15,000 11
            15,000 to above 15          */
            double Commision =0 ;
                            Console.WriteLine("Enter Base salary : ");
                            double baseSal = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Total Sales : ");
                            double Sales = Convert.ToDouble(Console.ReadLine());

            if (Sales >= 5000 && Sales <= 7500)
            {
                Commision = 0.03;
            }
            else if (Sales >= 7501 && Sales <= 10500)
            {
                Commision = 0.08;
            
            }
            else if (Sales >= 10501 && Sales <= 15000)
            {
                Commision = 0.11;

            }
            else if (Sales >= 15000)
            {
                Commision = 0.15;

            }

            double NetCommision = Commision * baseSal;
            double NetSalary = NetCommision + baseSal;
            return ($"The Commision rate is {Commision} and your Net Commision is {NetCommision} and the NetSalary amounts to {NetSalary} ");

        }
            

        public static int MaxOfThree(int a, int b, int c) 
        {
           int max = (a>b)?( (a>c)? (a) :(c) ):((b>c)?(b):(c));

            return max;


        }


        public static void DepartmentData()
        {
                 /*           Write a program to accept an Employee no. And department no.As numeric data and
                designation code as character data.Display the entered data with proper messages as below
                and refer the below table for entered data –  
                 */



            

            int[] empNoArr = new int[5];

            for(int i =0;i<5;i++)
            {
                Console.WriteLine($"Enter Employee number : ");
                int empNo = int.Parse(Console.ReadLine());
                empNoArr[i] = empNo;

            }




            int[] deptNoArr = new int[5];

            for (int i =0; i<5; i++)
            {
                Console.WriteLine($"Enter Department number : ");
                int deptNo = int.Parse(Console.ReadLine());
                deptNoArr[i] = deptNo;

            }


            char[] designationCodeArr = new char[5];
            for (int i=0; i<5;i++) 
            {
                Console.WriteLine("Enter Designation Code : ");
                char designationCode = Convert.ToChar(Console.ReadLine());
                designationCodeArr[i] = designationCode;

            }

            Dictionary<char, string> design = new Dictionary<char, string>();

            design['M'] = "Manager";
            design['S'] = "Supervisor";
            design['A'] = "Analyst";
            design['s'] = "Sales Person";
            design['a'] = "Accountant";

            Dictionary<int, char> design1 = new Dictionary<int, char>();

            design1[0] = 'M';
            design1[1] = 'S';
            design1[2] = 'A';
            design1[3] = 's';
            design1[4] = 'a';


            /*
             switch (designationCode)
             {
                 case 'M':
                     designation = "Manager"; 
                     break;

                 case 'S':
                     designation = "Supervisor";
                     break;
                 case 'A':
                     designation = "Analyst";
                     break;
                 case 's':
                     designation = "Sales Person"; 
                     break;
                 case 'a':
                     designation = "Acciuntant"; 
                     break;
                 default:
                     designation = "Analyst"; 
                     break;      



             }
             */


            for (var i=0; i<5;i++)
            { Console.WriteLine("Department no. \t Departrment Number \t Designation Code \t Designation");

                Console.WriteLine($"{deptNoArr[i]} \t\t {empNoArr[i]} \t\t\t {design1[i]} \t\t\t {design1[i]}");
                

            
            }

        }

        public static void DaysInMonth() 
        {
            
            Console.WriteLine("Enter a date in dd/mm/yy format:");
            string input = Console.ReadLine();

            // Parse the input as a DateTime object
            DateTime date = DateTime.ParseExact(input, "dd/MM/yy", null);

            // Get the year and month from the date
            int year = date.Year;
            int month = date.Month;

            // Get the total number of days in the month using DateTime.DaysInMonth method[^1^][1]
            int days = DateTime.DaysInMonth(year, month);

            // Get the month as a character month using DateTime.ToString method
            string monthName = date.ToString("MMMM");

            // Print the result
            Console.WriteLine("Total number of days in {0} {1} is {2}", monthName, year, days);


        }

        public static void AsciiPrint() {

            // for loop to iterate over the ASCII values 
            for (int i = 0; i <= 255; i++)
                {
                Console.Write((char)i + " ");

                if (i % 10 == 0)
                    {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();  

                    }

                    
                }

        
        }

        public static bool isPrime() 
        {

            Console.WriteLine("Enter a number to check if it's prime or not...");
            int num = int.Parse(Console.ReadLine());

            // check if its prime or not 
            // 1 and itself

            if (num == 0)
                {
                return false;    
                }

            for (int i = 2; i < Math.Sqrt(num); i++)
                {

                if (num % i == 0)
                    {
                    return false;
                    break;
                    }

                }
            return true;
        
        }


        public static bool isPrime2(int a)
        {

           

            // check if its prime or not 
            // 1 and itself

            if (a == 0)
            {
                return false;
            }

            for (int i = 2; i < Math.Sqrt(a); i++)
            {

                if (a % i == 0)
                {
                    return false;
                    break;
                }

            }
            return true;

        }

        public static void FetchPrimes() 
        { int count = 0;
            for (int i = 2; i < 10000 ; i++)
            {
                if (count <= 25)
                {
                    if (isPrime2(i))
                    {
                        count++;
                        Console.Write(i + " ");


                    }
                } else { break; }
                
            }

        
        }

        public static void getDate() 
        {
                /*        Write a function to accept day, month and year from the user in a function called getDate()
            and print that date in main. */
            Console.WriteLine("Enter Date in the format dd/mm/yy : ");
            DateTime dateTime = DateTime.ParseExact( Console.ReadLine(), "dd/mm/yy",null);

            

            int day = dateTime.Day;
            int month = dateTime.Month;
            int year = dateTime.Year;
            string dayName = dateTime.ToString("dddd");

            string monthName = dateTime.ToString("MMMM");
            Console.WriteLine($"The date you have entered falls in {monthName} of {year} on the day {dayName}");
        
        }


       /* public static void shapeflix() 
        {
           

            


            do {

                Console.WriteLine("Enter 1 for Square");
                Console.WriteLine("Enter 2 for Rectangle");
                Console.WriteLine("Enter 3 for Circle");
                Console.WriteLine("Enter 0 to exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice) 
                {

                    case 1:
                        Console.WriteLine("You have choosen a Square");
                        Console.WriteLine("Enter the side of the square : ");
                        double Squareside = double.Parse(Console.ReadLine());
                        int subchoice; 
                        Console.WriteLine("Enter 1 to calculate area  ");
                        Console.WriteLine("Enter 2 to calculate perimeter  ");
                        Console.WriteLine("Enter 3 to calculate area & perimeter both  ");
                        Console.WriteLine("Enter 0 to exit  ");
                        double SquareArea = Squareside * Squareside;
                        double SquarePerimeter = 4 * Squareside;
                        subchoice = int.Parse(Console.ReadLine());

                        do {

                            if (subchoice == 1)
                                {
                                Console.WriteLine($"Area of the Square with side {Squareside} is {SquareArea}");
                                break;
                            }
                            if (subchoice == 2)
                                {
                                Console.WriteLine($"Perimeter of the Square with side {Squareside} is {SquarePerimeter}");
                                break;
                            }
                            if (subchoice == 3)
                                {
                                Console.WriteLine($"Area of the Square with side {Squareside} is {SquareArea}");
                                Console.WriteLine($"Perimeter of the Square with side {Squareside} is {SquarePerimeter}");
                                break;
                            }
                        
                        
                        } while (subchoice != 0);

                        break;


                    case 2:

                        Console.WriteLine("You have choosen a Rectangle");
                        Console.WriteLine("Enter the lenght of the Rectangle : ");
                        double RectangleLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the breadth of the Rectangle : ");
                        double RectangleBreadth = double.Parse(Console.ReadLine());
                        int subchoice2;
                        Console.WriteLine("Enter 1 to calculate area  ");
                        Console.WriteLine("Enter 2 to calculate perimeter  ");
                        Console.WriteLine("Enter 3 to calculate area & perimeter both  ");
                        Console.WriteLine("Enter 0 to exit  ");
                        subchoice2 = int.Parse(Console.ReadLine());
                        double RectangleArea = RectangleLength * RectangleBreadth;
                        double RectanglePerimeter = 2*(RectangleLength + RectangleBreadth);

                        

                        do
                        {

                            if (subchoice2 == 1)
                            {
                                Console.WriteLine($"Area of the Rectangle with lenght {RectangleLength} and breadth {RectangleBreadth} is {RectangleArea}");
                                
                                //break;
                            }
                            if (subchoice2 == 2)
                            {
                                Console.WriteLine($"Perimeter of the Rectanlge with lenght {RectangleLength} and breadth {RectangleBreadth} is {RectanglePerimeter}");
                                
                                // break;
                            }
                            if (subchoice2 == 3)
                            {
                                Console.WriteLine($"Area of the Rectangle with lenght {RectangleLength} and breadth {RectangleBreadth} is {RectangleArea}");
                                Console.WriteLine($"Perimeter of the Rectanlge with lenght {RectangleLength} and breadth {RectangleBreadth} is {RectanglePerimeter}");
                                // The loop is going into an infinite recursion 
                                // break;
                            }
                            break;

                        } while (subchoice2 != 0);


                        break;
                        
                    case 3:


                        Console.WriteLine("You have choosen a Circle");
                        Console.WriteLine("Enter the Radius of the Circle");
                        double Radius = double.Parse(Console.ReadLine());
                        
                        int subchoice3;
                        Console.WriteLine("Enter 1 to calculate area  ");
                        Console.WriteLine("Enter 2 to calculate circumference  ");
                        Console.WriteLine("Enter 3 to calculate area & circumference both  ");
                        Console.WriteLine("Enter 0 to exit  ");
                        double CircleArea = Math.PI*Radius*Radius;
                        
                        double Circumference = 2 *Math.PI*Radius;


                        subchoice3 = int.Parse(Console.ReadLine());

                        do
                        {

                            if (subchoice3 == 1)
                            {
                                Console.WriteLine($"Area of the Circle with radius {Radius} is {CircleArea}");
                                break;
                            }
                            if (subchoice3 == 2)
                            {
                                Console.WriteLine($"Perimeter of the Circle with radius {Radius} is {Circumference}");
                                break;
                            }
                            if (subchoice3 == 3)
                            {
                                Console.WriteLine($"Area of the Circle with radius {Radius} is {CircleArea}");
                                Console.WriteLine($"Perimeter of the Circle with radius {Radius} is {Circumference}");
                                break;
                            }
                           


                        } while (subchoice3 != 0);



                        break;


                
                }

            } while (choice != 0);


        }

        */
        public static void fiboflix() 
        {

            Console.WriteLine("Enter the number of Fibonacci numbers you want ! ");
            int n = int.Parse(Console.ReadLine());

            // initialize the first two terms
            int t1 = 0;
            int t2 = 1;

            Console.WriteLine("Fibonacci Series:");
            Console.Write(t1 + " " + t2 + " ");


            for (int i = 3; i <= n; i++)
                {
                int t3 = t1 + t2;

                Console.Write(t3 + " ");

                t1 = t2;
                t2 = t3;


                }
        
        }


        public static void combo3() 
        {


            int i, j, k;
            // Loop from 1 to 3 for the first element
            for (i = 1; i <= 3; i++)
            {
                // Loop from 1 to 3 for the second element
                for (j = 1; j <= 3; j++)
                {
                    // Loop from 1 to 3 for the third element
                    for (k = 1; k <= 3; k++)
                    {
                        // Print the combination
                        Console.WriteLine("{0}{1}{2}", i, j, k);
                    }
                }
            }
        }
    }
}
