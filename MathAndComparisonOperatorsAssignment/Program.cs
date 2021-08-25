using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //Person 1 Information Collection
        Console.WriteLine("Anonymous Income Comparison Program\nPerson1\nHourly Rate?");
        string rate1 = Console.ReadLine();
        Console.WriteLine("Hours worked per week?");
        string hours1 = Console.ReadLine();

        //Person 2 Information Collection
        Console.WriteLine("Person2\nHourly Rate?");
        string rate2 = Console.ReadLine();
        Console.WriteLine("Hours worked per week?");
        string hours2 = Console.ReadLine();

        //Person 1 Annual Salary Calculation
        int pay1 = Convert.ToInt32(rate1);
        int time1 = Convert.ToInt32(hours1);
        int annualSalary1 = pay1 * time1 * 52;
        Console.WriteLine("Annual salary of Person 1:\n$" + annualSalary1);

        //Person 2 Annual Salary Calculation
        int pay2 = Convert.ToInt32(rate2);
        int time2 = Convert.ToInt32(hours2);
        int annualSalary2 = pay2 * time2 * 52;
        Console.WriteLine("Annual salary of Person 2:\n$" + annualSalary2);

        //Annual Salary Comparison
        bool salaryComparison = annualSalary1 > annualSalary2;
        Console.WriteLine("Does Person 1 make more money than Person 2?\n" + salaryComparison);
        Console.ReadLine();
    }
}

