using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "John", LastName = "Connor", Id = 00001 };
            Employee employee2 = new Employee() { FirstName = "Sarah", LastName = "Connor", Id = 00000 };

            Console.WriteLine(employee1.Id == employee2.Id);
            Console.ReadLine();
        }
    }
}
