using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Employee
        {
        public string EmplName{get; set;}
        public string EmplSurname{get; set;}
        public string EmplPost{get; set;}
        public int EmplExperience{get; set;}

        public Employee(string surname, string name)
        {
            EmplSurname = surname;
            EmplName = name;
        }

        }
    }
}
