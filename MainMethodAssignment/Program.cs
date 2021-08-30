using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here the user enters an int, which is operated on by the Add(int intValue) method.
            Addition add10 = new Addition();
            Console.WriteLine("Enter an integer.");
            int intValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(add10.Add(intValue));

            //Here the user enters an float, which is operated on by the Add(float floatValue) method.
            Console.WriteLine("Enter a decimal number.");
            float floatValue = float.Parse(Console.ReadLine());
            Console.WriteLine(add10.Add(floatValue));

            //Here the user enters a string, which is converted to an int, operated on, and returned as an integer via the Add(stringValue) method.
            Console.WriteLine("Enter a number.");
            string stringValue = Console.ReadLine();
            Console.WriteLine(add10.Add(stringValue));
            Console.ReadLine();
        }
    }
}
