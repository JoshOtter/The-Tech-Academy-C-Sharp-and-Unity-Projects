using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("It is currently: " + date + "\nEnter a number.");
            int hour = Convert.ToInt32(Console.ReadLine());
            TimeSpan duration = new TimeSpan(hour, 0, 0);
            Console.WriteLine("In " + hour + " hours, it will be " + (date + duration));
            Console.ReadLine();
        }
    }
}
