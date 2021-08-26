using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        string[] stringArray = { "Fish", "Bird", "Reptile", "Mammal", "Insect" };
        int[] intArray = { 3, 9, 27, 81, 243 };

        Console.WriteLine("Please select an index from 0 to 4 from the animal array.");
        int stringIndex = Convert.ToInt32(Console.ReadLine());
        int i = 0;

        while (i != 1)
        {
            if (stringIndex < 5 && stringIndex > -1)
            {
                Console.WriteLine("You have selected " + stringArray[stringIndex]);
                i++;
            }
            else
            {
                Console.WriteLine("You have selected an index that does not exist. Please enter an index from 0 to 4");
                stringIndex = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nPlease select an index from 0 to 4 from the number array.");
        int intIndex = Convert.ToInt32(Console.ReadLine());
        int n = 0;

        while(n != 1)
        {
            if (intIndex < 5 && intIndex > -1)
            {
                Console.WriteLine("You have selected " + intArray[intIndex]);
                n++;
            }
            else
            {
                Console.WriteLine("You have selected an index that does not exist. Please enter an index from 0 to 4");
                intIndex = Convert.ToInt32(Console.ReadLine());
            }
        }

        List<string> autoList = new List<string> { "Ford", "Toyota", "Mazda", "Dodge", "Audi" };
        Console.WriteLine("\nPlease select an index of 0 to 4 in the auto list.");
        int autoIndex = Convert.ToInt32(Console.ReadLine());
        n = 0;

        while (n != 1)
        {
            if (autoIndex < 5 && autoIndex > -1)
            {
                Console.WriteLine("You have selected " + autoList[autoIndex]);
                n++;
            }
            else
            {
                Console.WriteLine("You have selected an index that does not exist. Please enter an index from 0 to 4");
                autoIndex = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.ReadLine();

    }
}

