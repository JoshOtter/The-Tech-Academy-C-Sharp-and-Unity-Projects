using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uses a void method that prints the output to the console from the method itself.
            DivideByTwo Divide = new DivideByTwo();
            Console.WriteLine("Enter a number to divide it by two.");
            Divide.divide(Convert.ToInt32(Console.ReadLine()));

            //Uses an output parameter to also provide the remainder of the division operation
            Console.WriteLine("Enter a number to divide it by three.");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            int remainder1 = 0;
            Console.WriteLine(operand1 + " divided by three is " + Divide.divideBy3(operand1, out remainder1) + "\nAnd the remainder is " + remainder1);

            //Uses an overload method to divide by three but using float data types
            Console.WriteLine("Enter float number to divide it by three.");
            float operand2 = float.Parse(Console.ReadLine());
            Console.WriteLine(operand2 + " divided by three is " + Divide.divideBy3(operand2));

            //Uses a static class that does not need to be instantiated
            Console.WriteLine("Enter the name of your favorite animal. Mine is the \"Norwegian Forest Cat\"");
            string animal = Console.ReadLine();
            Console.WriteLine(StaticClass.favoriteAnimal(animal));
            Console.ReadLine();
        }
    }
}
