using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        List<int> dividends = new List<int>() { 2, 4, 12, 15, 27, 36, 54 };
        
        try
        {
            Console.WriteLine("Pick a number to divide each number in the dividends list.");
            int divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHere are the results:");
            foreach (int dividend in dividends)
            {
                Console.WriteLine(dividend / divisor);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        finally
        {
            Console.ReadLine();
        }
        
    }
}

