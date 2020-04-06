using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        class Employee
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
        
        public double CountSalary(Employee Person, string[] Postlist, int[]Salarylst)
        {
            double summ = 0;
            int i, n = Postlist.Length;
            for(i = 0; i < n; i++)
            {
                if (Person.EmplPost == Postlist[i])
                {
                    summ += Salarylst[i] + (Person.EmplExperience / 10)*1000 + 500;
                    break;
                }
            }
            if (summ == 0)
            {
                Console.WriteLine("There is no such post in PostList");
            }            
            return summ;
        }
        public double CountTax(double summ)
        {
            double tax = summ * 0.14;
            return tax;
        }
        }
    }
}
