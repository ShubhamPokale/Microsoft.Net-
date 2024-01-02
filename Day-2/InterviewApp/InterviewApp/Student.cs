using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp
{
    public delegate void InfowayDelegate();
    internal class Student
    {
        private int m_StudentId;
        public event InfowayDelegate Selected;
        public event InfowayDelegate Rejected;
        public int StudentId
        {
            get
            {
                return m_StudentId;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id Can not be zero or negative value!");
                }
                else
                {
                    m_StudentId = value;
                }
            }
        }
        public string StudentName { get; set; }
        public string City { get; set; }
        public int TotalMarks { get; set; }

        //public string CalculateResult(int marks,out bool confirmation)
        public string CalculateResult(int marks, ref bool confirmation)
        {
            if (marks > 80)
            {
                if (Selected != null)
                {
                    Selected();
                }
                confirmation = true;
                return $"{StudentName} has been passed the interview!";
            }
            else
            {
                if (Rejected != null)
                {
                    Rejected();
                }
                //confirmation = false;
                return $"{StudentName} is failed in the interview!";
            }
        }
        public void InterviewRounds(params string[] rounds)
        {
            for (int i = 0; i < rounds.Length; i++)
            {
                Console.WriteLine(rounds[i]);
            }
        }
    }
}
