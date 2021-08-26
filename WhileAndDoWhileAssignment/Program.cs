using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who is the strongest original Avenger?\nChose between Iron Man, Captain America, Thor, The Hulk, Black Widow, and Hawkeye.");
            string answer = Console.ReadLine();
            bool guess = answer == "The Hulk";

            do
            {
                switch (answer)
                {
                    case "Iron Man":
                        Console.WriteLine("Tony Stark agrees with you, but that's incorrect. Try again.\nGuess an Avenger.");
                        answer = Console.ReadLine();
                        break;
                    case "Captain America":
                        Console.WriteLine("Steve Rogers is flattered, but he he humbly disagrees. Try again.\nGuess an Avenger.");
                        answer = Console.ReadLine();
                        break;
                    case "Thor":
                        Console.WriteLine("Thor is just as surprised as you are to find out this guess is wrong. Try again.\nGuess an Avenger.");
                        answer = Console.ReadLine();
                        break;
                    case "The Hulk":
                        Console.WriteLine("Isn't it obvious? You got it right! Congratulations");
                        guess = true;
                        break;
                    case "Black Widow":
                        Console.WriteLine("Nope, but she really likes the strongest Avenger. Try again.\nGuess an Avenger.");
                        answer = Console.ReadLine();
                        break;
                    case "Hawkeye":
                        Console.WriteLine("Are you even serious with this guess? Try again.\nGuess an Avenger.");
                        answer = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please only enter one of these Avengers:\nIron Man, Captain America, Thor, The Hulk, Black Widow, or Hawkeye\nGuess an Avenger.");
                        answer = Console.ReadLine();
                        break;
                }
            }
            while (!guess);

            Console.WriteLine("\nTime for a bonus Game!\nWhat number am I thinking of between 1 and 10?\nGuess in three tries to win.");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int numGuess = 0;

            while (i < 2)
            {
                switch (num)
                {
                    case 3:
                        Console.WriteLine("That\'s correct! Are you a mind reader?");
                        i = 3;
                        break;
                    default:
                        Console.WriteLine("That\'s incorrect. Guess again.");
                        i++;
                        numGuess++;
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            if (num == 3)
            {
                Console.WriteLine("Congratulations! You guessed the number in three guesses or less!");
            }
            else
            {
                Console.WriteLine("Too bad. You ran out of guesses.");
            }

            Console.ReadLine();
        }
    }
}
