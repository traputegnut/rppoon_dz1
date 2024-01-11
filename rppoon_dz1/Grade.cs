using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    class Grade:IStudent
    {
        public string GradeName { get; set; }
        public List<Student> Students { get; set; }
    }

    public Grade(string name)
    {
        GradeName = name;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        Students.Remove(student);
    }
}
