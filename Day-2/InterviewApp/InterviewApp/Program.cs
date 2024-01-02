using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Infoway Interview Application!");
            try
            {
                Student student = new Student();
                student.Selected += PassedStudents;
                student.Selected += ExcellentStudents;
                student.Rejected += FailedStudents;
                student.StudentId = 34892;
                student.StudentName = "Test";
                student.City = "Test";
                student.TotalMarks = 57;
                if (student.TotalMarks<95)
                {
                    student.Selected -= ExcellentStudents;
                }
                bool confirm=false;
                string result = student.CalculateResult(student.TotalMarks,ref confirm);
                Console.WriteLine(result);
                Console.WriteLine(confirm);
                student.InterviewRounds("Round-1");
                student.InterviewRounds("Round-1","Round-2");
                student.InterviewRounds("Round-1", "Round-2", "Round-3","Round-4");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        private static void PassedStudents()
        {
            Console.WriteLine("Record stored in Oracle Database!");
        }
        private static void ExcellentStudents()
        {
            Console.WriteLine("Record stored in DB2 Database!");
        }
        private static void FailedStudents()
        {
            Console.WriteLine("Record stored in MySQL Server Database!");
        }
    }
    
}
