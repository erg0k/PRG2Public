using S12345678_StudentApp;
using System;
using System.Collections.Generic;

namespace Week03
{
    class Practical
    {
        static void DisplayOutput(List<Student> sList)
        {
            Console.WriteLine($"\n{"ID",-5} {"Name",-15} {"Tel",-10} {"Date of Birth",-13}");
            foreach (Student student in sList)
            {
                Console.WriteLine($"{student.Id, -5} {student.Name, -15} {student.Tel, -10} {student.DateOfBirth.ToString("dd/MM/yyyy"), -13}");
            }
        }

        static Student GetStudent()
        {
            Console.Write("Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student name: ");
            string name = Console.ReadLine();

            Console.Write("Student telephone number: ");
            string tel = Console.ReadLine();

            Console.Write("Student DOB (yyyy/MM/dd): ");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Student newStudent = new Student(id, name, tel, dateOfBirth);
            return newStudent;
        }

        static void Main()
        {
            DateTime dob1 = new DateTime(2000, 10, 13);
            Student s1 = new Student(1, "John Tan", "88552211", dob1);

            DateTime dob2 = new DateTime(2001, 11, 1);
            Student s2 = new Student(2, "Peter Lim", "85678141", dob2);

            DateTime dob3 = new DateTime(2000, 1, 3);
            Student s3 = new Student(3, "David Chan", "88555461", dob3);

            DateTime dob4 = new DateTime(2000, 5, 7);
            Student s4 = new Student(4, "Muhammed Faizal", "98762211", dob4);

            DateTime dob5 = new DateTime(2000, 8, 9);
            Student s5 = new Student(5, "Esther Eng", "83352245", dob5);

            Console.WriteLine($"{"ID", -5} {"Name", -15} {"Tel", -10} {"Date of Birth", -13}");
            Console.WriteLine($"{s1.Id, -5} {s1.Name, -15} {s1.Tel, -10} {s1.DateOfBirth.ToString("dd/MM/yyyy"), -13}");
            Console.WriteLine($"{s2.Id, -5} {s2.Name, -15} {s2.Tel, -10} {s2.DateOfBirth.ToString("dd/MM/yyyy"), -13}");
            Console.WriteLine($"{s3.Id, -5} {s3.Name, -15} {s3.Tel, -10} {s3.DateOfBirth.ToString("dd/MM/yyyy"), -13}");
            Console.WriteLine($"{s4.Id, -5} {s4.Name, -15} {s4.Tel, -10} {s4.DateOfBirth.ToString("dd/MM/yyyy"), -13}");
            Console.WriteLine($"{s5.Id, -5} {s5.Name, -15} {s5.Tel, -10} {s5.DateOfBirth.ToString("dd/MM/yyyy"), -13}");



            List<Student> studentList = new List<Student> {s1, s2, s3, s4, s5};
          

            DisplayOutput(studentList);

            Student newStudent = GetStudent();
            studentList.Add(newStudent);

            DisplayOutput(studentList);

            List<Student> studentList2 = new List<Student>(2);
            using (StreamReader sr = new StreamReader("Students.csv"))
            {
                string? s = sr.ReadLine(); //removes header
                while ((s = sr.ReadLine()) != null)
                {
                    string[] studentInfo = s.Split(',');
                    Student newnewStudent = new Student(Convert.ToInt32(studentInfo[0]), studentInfo[1], studentInfo[2], Convert.ToDateTime(studentInfo[3]));
                    studentList2.Add(newnewStudent);
                }
            }

            DisplayOutput(studentList2);
        }
    }
}