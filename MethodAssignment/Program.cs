using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionalParameter times3 = new OptionalParameter();

            Console.WriteLine("Enter either one or two numbers.\nIf you chose to enter one simply hit enter again after you enter your first number.");
            int requiredNumber = Convert.ToInt32(Console.ReadLine());
            string secondInput = Console.ReadLine();
            //This if statment checks to see if the there anything was entered for the second input.
            if (secondInput != "")
            {
                int optionalNumber = Convert.ToInt32(secondInput);
                Console.WriteLine("The result is: " + times3.MultiplyBy3(requiredNumber, optionalNumber));
            }
            else
            {
                Console.WriteLine("The result is: " + times3.MultiplyBy3(requiredNumber));
            }
            Console.ReadLine();
        }
    }
}
