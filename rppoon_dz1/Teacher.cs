using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    class Teacher:Person,IGradeable
    {
        public List<string> Courses { get; set; }

        public Teacher(string firstname,string lastname,int id,List<string> courses):base(firstname,lastname,id)
        {
            Courses = courses;
            FirstName = firstname;
            LastName = lastname;
            Id = id;
        }


        void AddGrade(int grade)
        {
            Grades.Add(grade);
        }

        void ShowGrades()
        {
            foreach(var grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
