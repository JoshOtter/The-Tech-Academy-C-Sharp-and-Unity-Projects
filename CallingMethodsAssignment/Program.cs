using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Based on the instructions, I wasn't sure if I was supposed to give three separate results for each method
            //or if I was supposed to have it run through each method with only one result, so I did both.

            MathOperations1 userQuery = new MathOperations1();

            //Here is the first option, where each method gives a different result for the same number.
            Console.WriteLine("Enter an integer.");
            userQuery.argument1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userQuery.argument1 + " plus 9 equals: " + userQuery.Add9());
            Console.WriteLine(userQuery.argument1 + " minus 3 equals: " + userQuery.Subtract3());
            Console.WriteLine(userQuery.argument1 + " times 10 equals: " + userQuery.Multiply10());

            //Here is the second option, where the number entered moves through each method before being given back to the user.
            Console.WriteLine("Enter an integer.");
            int input = Convert.ToInt32(Console.ReadLine());
            userQuery.argument1 = input;

            userQuery.argument1 = userQuery.Add9();
            userQuery.argument1 = userQuery.Subtract3();
            int result = userQuery.Multiply10();

            Console.WriteLine(input + " plus 9, minus 3, multiplied by 10 equals: " + result);
            Console.ReadLine();
        }
    }
}
