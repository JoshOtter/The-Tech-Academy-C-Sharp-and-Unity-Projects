using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I instantiate a new list of employees.
            List<Employee> employees = new List<Employee>();

            //Here I instantiate employee objects with their properties and add them to the list
            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Fisher", Id = 0 };
            employees.Add(employee1);
            Employee employee2 = new Employee() { FirstName = "Josh", LastName = "Otterman", Id = 1 };
            employees.Add(employee2);
            Employee employee3 = new Employee() { FirstName = "Anna", LastName = "Otterman", Id = 2 };
            employees.Add(employee3);
            Employee employee4 = new Employee() { FirstName = "Bill", LastName = "Nye", Id = 3 };
            employees.Add(employee4);
            Employee employee5 = new Employee() { FirstName = "Joe", LastName = "Swimmer", Id = 4 };
            employees.Add(employee5);
            Employee employee6 = new Employee() { FirstName = "Lisa", LastName = "Swimmer", Id = 5 };
            employees.Add(employee6);
            Employee employee7 = new Employee() { FirstName = "Aaron", LastName = "Toe", Id = 6 };
            employees.Add(employee7);
            Employee employee8 = new Employee() { FirstName = "Angie", LastName = "Hoffer", Id = 7 };
            employees.Add(employee8);
            Employee employee9 = new Employee() { FirstName = "David", LastName = "Scan", Id = 8 };
            employees.Add(employee9);
            Employee employee10 = new Employee() { FirstName = "Jason", LastName = "Randy", Id = 9 };
            employees.Add(employee10);

            //Here I create a new list for employees named Joe and use a foreach loop to find and add them to the list
            List<Employee> employeesNamedJoe1 = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employeesNamedJoe1.Add(employee);
                }
            }
            Console.WriteLine("Employees named Joe include:");
            for (int i = 0; i < employeesNamedJoe1.Count; i++)
            {
                Console.WriteLine(employeesNamedJoe1[i].FirstName + " " + employeesNamedJoe1[i].LastName + "\n");
            }

            //Here I create another new list for employees named Joe and use a lambda expression to find and add them to the list
            List<Employee> employeesNamedJoe2 = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("Employees named Joe include:");
            for (int j = 0; j < employeesNamedJoe2.Count; j++)
            {
                Console.WriteLine(employeesNamedJoe2[j].FirstName + " " + employeesNamedJoe2[j].LastName + "\n");
            }

            //Here I create a list for newer employees with Ids higher than five and use a lambda epxression to find and add them to the list
            List<Employee> newEmployees = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("New employees include: ");
            for (int k = 0; k < newEmployees.Count; k++)
            {
                Console.WriteLine(newEmployees[k].FirstName + " " + newEmployees[k].LastName + "\n");
            }
            Console.ReadLine();
        }
    }
}
