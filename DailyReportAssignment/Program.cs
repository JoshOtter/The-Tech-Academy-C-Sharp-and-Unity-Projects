using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.\nPlease answer the following questions:\nWhat is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int currentPage = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpResponse = Console.ReadLine();
            bool needsHelp = Convert.ToBoolean(helpResponse);
            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there ay other feedback you\'d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursResponse = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hoursResponse);
            Console.WriteLine("Thank you for your answers.\nAn instructor will respond to this shortly.\nHave a great day!");
            Console.ReadLine();
            
            //I used the following code to test the output of the variables in the console.
            //Console.WriteLine("Your name: " + studentName + "\nCurrent course: " + courseName + "\nCurrent page: " + currentPage + "\nDo you need help: " + needsHelp + "\nPositive experiences: " + positiveExperiences + "\nOther feedback: " + otherFeedback + "\nHours studied: " + hoursStudied);
            //Console.ReadLine();
        }
    }
