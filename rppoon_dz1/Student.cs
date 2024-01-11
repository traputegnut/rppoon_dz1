using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    class Student:Person,IGradeable
    {
        public List<int> Grades { get; set; };
        public string Grade { get; set; };

        public Student(string firstName,string lastName,int id,string grade):base(firstName,lastName,id)
        {
            Grades = new List<int>();
            Grade = grade;
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }

        public void ShowGrades()
        {
            foreach(var grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }

    }
}
