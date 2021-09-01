using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>() { FirstName = "Napoleon", LastName = "Dynamite" };
            employee1.things = new List<string> { "nunchuck skills", "bow hunting skills", "computer hacking skills" };

            Employee<int> employee2 = new Employee<int>() { FirstName = "Number", LastName = "Wizard" };
            employee2.things = new List<int> { 3, 9, 27, 81, 243 };

            int i = 0;
            while (i < 5)
            {
                foreach (string thing in employee1.things)
                {
                    Console.WriteLine(employee1.FirstName + " " + employee1.LastName + " has " + thing);
                }
                foreach (int thing in employee2.things)
                {
                    Console.WriteLine(employee2.FirstName + " " + employee2.LastName + " has " + thing);
                    i++;
                }
            }
            Console.ReadLine();
        }
    }
}
