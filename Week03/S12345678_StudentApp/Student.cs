using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_StudentApp
{
    class Student
    {
        //Question 1
        //Complete the missing attributes & Properties and the incomplete student class constructor
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // attributes and properties
        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        // constructor
        public Student(int i, string n, string t, DateTime dob)
        {
            Id = i;
            Name = n;
            Tel = t;
            DateOfBirth = dob;
        }

    }
}
