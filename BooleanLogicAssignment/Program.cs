using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        //collects information from the user and turns it into the appropriate data type for each question.
        Console.WriteLine("Please answer these questions to see if you qualify for auto insurance:\n\nWhat is your age?");
        string ageString = Console.ReadLine();
        int ageInt = Convert.ToInt32(ageString);
        Console.WriteLine("Have you ever had a DUI? Answer \"true\" or \"false\".");
        string duiString = Console.ReadLine();
        bool duiBool = Convert.ToBoolean(duiString);
        Console.WriteLine("How many speeding tickets do you have?");
        string ticketsString = Console.ReadLine();
        int ticketsInt = Convert.ToInt32(ticketsString);

        //makes an assessment as to whether or not the user qualifies for car insuranced based on their previous input.
        Console.WriteLine("Qualified?");
        bool qualified = (ageInt > 15 && duiBool == false && ticketsInt <= 3);
        Console.WriteLine(qualified);
        Console.ReadLine();
    }
}

