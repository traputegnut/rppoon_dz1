using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int id;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public Person(string firstName,string lastName,int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
    }
}
