using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter the package weight:");
        int packageWeight = Convert.ToInt32(Console.ReadLine());
        
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                int quote = ((packageHeight * packageWidth * packageLength) * packageWeight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00\nThank you!");
            }
        }
        Console.ReadLine();
    }
}

