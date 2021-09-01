using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool result = employee1.Id == employee2.Id;
            return result;
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool result = employee1.Id != employee2.Id;
            return result;
        }
    }
}
