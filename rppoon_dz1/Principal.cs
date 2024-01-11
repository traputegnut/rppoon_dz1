using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    class Principal:Person,IStudent,ITeacher
    {
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public Principal(string firstname,string lastname,int id):base(firstname,lastname,id)
        {
            FirstName = firstname;
            LastName = lastname;
            Id = id;
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            Teachers.Remove(teacher);
        }
        public void ShowGrades()
        {
            foreach(var student in Students)
            {
                Console.WriteLine(Grade);
            }
        }
    }
}
