using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                string answer = Console.ReadLine();
                int a = 0;
                if (int.TryParse(answer, out a))
                {
                    Console.WriteLine("Please enter a day of the week.");
                }
                else
                {
                    DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), answer);
                    Console.WriteLine("Today is " + today);
                }                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Please enter a day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
            

        }
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
