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
            Addition add10 = new Addition();
            Console.WriteLine("Enter an integer.");
            int intValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(add10.Add(intValue));

            Console.WriteLine("Enter a decimal number.");
            float floatValue = float.Parse(Console.ReadLine());
            Console.WriteLine(add10.Add(floatValue));

            Console.WriteLine("Enter a number.");
            string stringValue = Console.ReadLine();
            Console.WriteLine(add10.Add(stringValue));
            Console.ReadLine();
        }
    }
}
