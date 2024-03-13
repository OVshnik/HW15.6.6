using System;
using System.Collections.Generic;
using System.Linq;
using HW15_6_6;

namespace HW15_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }
        static string[] GetAllStudents(Classroom[] classes)
        {
            var allStudents = from c in classes
                              from students in c.Students
                              select students;
            return allStudents.ToArray();
        }
    }
}