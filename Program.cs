using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Стаж работы n лет добавляет к зарплате ((n/10)*1000+500)сом */
            string[] Postlist  = {"Директор", 
                                  "Бухгалтер", 
                                  "Аналитик", 
                                  "Программист", 
                                  "HR менеджер"};
            double[] Salarylist = {70000,
                                   40000,
                                   45000,
                                   60000,
                                   35000} ;
            double summ1, summ2, summ3;
            double tax1,  tax2,  tax3;

            Employee emp1 = new Employee("Косимова","Нодира");
            Employee emp2 = new Employee("Саидов","Азим");
            Employee emp3 = new Employee("Алиев","Сухроб");
            
            emp1.EmplPost = "Аналитик";
            emp1.EmplExperience = 5;
            summ1 = emp1.CountSalary(Postlist,Salarylist);
            tax1 = Employee.CountTax(summ1);

            emp2.EmplPost = "Программист";
            emp2.EmplExperience = 10;
            summ2 = emp2.CountSalary(Postlist,Salarylist);
            tax2 = Employee.CountTax(summ2);

            emp3.EmplPost = "Директор";
            emp3.EmplExperience = 4;
            summ3 = emp3.CountSalary(Postlist,Salarylist);
            tax3 = Employee.CountTax(summ3);

            Console.Write("|ФИО                |Должность     |Оклад    |Налог     \n");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{emp1.EmplSurname,-9} {emp1.EmplName,-11}{emp1.EmplPost,-15}{summ1, -10}{tax1, -4}");
            Console.WriteLine($"{emp2.EmplSurname,-9} {emp2.EmplName,-11}{emp2.EmplPost,-15}{summ2, -10}{tax2, -4}");
            Console.WriteLine($"{emp3.EmplSurname,-9} {emp3.EmplName,-11}{emp3.EmplPost,-15}{summ3, -10}{tax3, -4}");

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
        
        public double CountSalary(string[] Postlist, double[]Salarylist)
        {
            double summ = 0;
            int i, n = Postlist.Length;
            for(i = 0; i < n; i++)
            {
                if (this.EmplPost == Postlist[i])
                {
                    summ += Salarylist[i] + (this.EmplExperience / 10)*1000 + 500;
                    break;
                }
            }
            if (summ == 0)
            {
                Console.WriteLine("There is no such post in PostList");
            }            
            return Math.Round(summ,4);
        }
        public static double CountTax(double summ)
        {
            double tax = summ * 0.14;
            return Math.Round(tax,4);
        }
        }
    }

    /*При написании данной программы я столнкулась с проблемой вывода текста с выравниванием,
    так как хотелось сделать вывод более аккуратным. Данная проблема была решена методом "гуглить" */
}
