using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //ITERATION ASSIGNMENT PART 1
        //Created an array of present tense verbs and an array with equal number of blank elements for past tense verbs.
        string[] presentTense = { "walk", "look", "work", "rest", "play" };
        string[] pastTense = new string[5];

        //Retrieves the common past tense ending from the user
        Console.WriteLine("What is the ending for most past tense verbs?");
        string pastEnding = Console.ReadLine();

        //Loop corrects the user if they enter anything other than "ed" and gives them another chance to enter the correct ending.
        bool ending = false;
        while (ending != true)
        {
            if (pastEnding != "ed")
            {
                Console.WriteLine("That is incorrect. Look up the common past tense ending for English verbs and try again.");
                pastEnding = Console.ReadLine();
            }
            else
            {
                Console.WriteLine(pastEnding + " is correct!");
                ending = true;
            }
        }

        //This loop adds past tense endings to each element in the presentTense and passes those values to the pastTense array.
        for (int i = 0; i < presentTense.Length; i++)
        {
            pastTense[i] = presentTense[i] + pastEnding;
        }

        //This loop prints to the console all the elements of the presentTense array after being modified with past tense endings.
        Console.WriteLine("\nHere's a few examples of verbs ending in " + pastEnding);
        for (int j = 0; j < pastTense.Length; j++)
        {
            Console.WriteLine(pastTense[j]);
        }
        Console.ReadLine();
        
        //ITERATION ASSIGNMENT PART 2
        //The infinite loop that I fixed by including "k++;". It stops printing out verbs once it comes to the word "rested."
        int k = 0;
        int l = pastTense.Length;
        Console.WriteLine("Here's the first three verbs in the list again.");
        while (l != k)
        {
            if (pastTense[k] != "rested")
            {
                Console.WriteLine(pastTense[k]);
                k++; //Without line, the loop would run infinitely.
            }
            else
            {
                k = pastTense.Length;
            }
        }
        Console.ReadLine();

        //ITERATION ASSIGNMENT PART 3
        //This for loop used the < operator to determine when to stop the loop.
        Console.WriteLine("Here's the entire list again.");
        for (int m = 0; m < 5; m++)
        {
            Console.WriteLine(pastTense[m]);
        }
        Console.ReadLine();

        //This for loop used the <= operator to determine when to stop the loop.
        Console.WriteLine("Here's the entire list again for good measure.");
        for (int n = 0; n <= 4; n++)
        {
            Console.WriteLine(pastTense[n]);
        }
        Console.ReadLine();

        //ITERATION ASSIGNMENT PART 4
        //This list has five entries for the future tense versions of the previous words.
        List<string> futureTense = new List<string>() { "will walk", "will look", "will work", "will rest", "will play" };
        Console.WriteLine("To make a verb future tense, add \"will\" before it.\nEnter the future tense version of one of the previous words");
        string futureVerb = Console.ReadLine();

        //This for loop iterates through each index in the List plus one additional iteration that goes beyond the index range
        //(this is because I needed a way to check through all iterations for an incorrect value without ending the loop.
        for (int o = 0;o < (futureTense.Count + 1); o++)
        {
            //This if statement starts by checking if the value of o (the iteration amount) is still less than the count of the futureTense List,
            //because it needs to switch to the else statement before it tries access an index in the list that doesn't exist, creating an error.
            //This also ends the loop if a match is found by setting the value of o to 1 + the count of the list.
            if (o < futureTense.Count && futureTense[o] == futureVerb)
            {
                Console.WriteLine("The future tense verb you entered is at index " + o);
                o = (futureTense.Count + 1);
            }
            //I included an empty else if statement, because I needed a location for the loop to do nothing but iterate if the input didn't match
            //the current index value in that iteration. Without this else if statement, anything but "will walk" sends the program straight to the else statement.
            else if (o < futureTense.Count && futureTense[o] != futureVerb)
            {

            }
            //This statement only activates if the user input doesn't match any element in the list AND the iteration value for o has gone beyond the
            //.Count for the futureTense list.
            else
            {
                Console.WriteLine("Your entry does not match the future tense of any of the previous verbs. Please try again.");
                futureVerb = Console.ReadLine();
                o = -1;
            }
        }
        Console.ReadLine();

        //ITERATION ASSIGNMENT PART FIVE
        //This list includes several sets of the same words, and asks the user to pick one of the sets to see where their index is in the list.
        List<string> homographs = new List<string>() { "does", "does", "second", "second", "minute", "minute", "refuse", "refuse" };
        Console.WriteLine("Did you know that two words can be spelled exactly the same but have different meanings and pronunciations?" +
            "\nEnter the word \"does\", \"second\", \"minute\", or \"refuse\" to see how many times they appear in our homograph array.");
        string homographInput = Console.ReadLine();
        //This string is blank and will eventually hold the values of the indices for the word pairs.
        string index1 = "";
        //This int will control when the while loop ends.
        int q = 0;
        //This int will iterate through the list.
        int r = 0;
        //I used a while loop because I thought it might be easier to control a search for two identical items in an array
        //and because I wanted to see if I could do it with a while loop instead of another for loop.
        while (q != 2)
        {
            //Checks first to see if the counter has gone beyond the range of the list, and then iterates the loop if the input does not match that element.
            if (r < homographs.Count && homographInput != homographs[r])
            {
                r++;
            }
            //Checks first to see if the counter has gone past the range of the list, and then if the input matches the element in this iteration, the value
            //of the index is converted to a string and added to index1 (a second value is added if one already has been added). Each time it matches, the value
            //of q increases by 1 to exit the loop after two matches have been found.
            else if (r < homographs.Count && homographInput == homographs[r])
            {
                index1 = index1 + " " + Convert.ToString(r);
                r++;
                q++;
            }
            //If the loop iterates through the entire list without finding two matches, it tells the user the word they entered was not on the list and
            //prompts them to try again, setting the iterations back to 0 and asking for new input.
            else
            {
                Console.WriteLine("The word you entered was not on the list. Please enter \"does\", \"second\", \"minute\", or \"refuse\".");
                homographInput = Console.ReadLine();
                r = 0;
            }
        }
        Console.WriteLine("The word \"" + homographInput + "\" appears in the indices" + index1 + ".");
        Console.ReadLine();


        //ITERATION ASSIGNMENT PART SIX
        List<string> moreHomographs = new List<string>() { "tear", "wind", "wound", "wind", "wound", "tear", };
        //This array is given half the elements of the list above it, since each word in the list is repeated twice
        //(It could be equal to it if it wasn't guarenteed that each word would have a pair).
        //The elements from the list will be placed in the array when they do not match any element in the array.
        string[] firstGuesses = new string[moreHomographs.Count / 2];
        //this int variable will allow the loop to place each new string into the next available array element.
        int t = 0;

        foreach (string homograph in moreHomographs)
        {
            //It starts out knowing the first element in the array is null and places the first word at that index
            if (firstGuesses[0] == null)
            {
                firstGuesses[0] = homograph;
                Console.WriteLine("The word \"" + homograph + "\" has only appeared once so far on this list.");
                t++;
            }
            //After the initial if statement, the following elements from the list are compared to the elements in the array.
            //If they match with any of the elements, it prints that they this is the second time they appeared in the list.
            else if (firstGuesses[0] == homograph)
            {
                Console.WriteLine("This is the second time \"" + homograph + "\" has appeared on this list.");
            }
            else if (firstGuesses[1] == homograph)
            {
                Console.WriteLine("This is the second time \"" + homograph + "\" has appeared on this list.");
            }
            else if (firstGuesses[2] == homograph)
            {
                Console.WriteLine("This is the second time \"" + homograph + "\" has appeared on this list.");
            }
            //If an element from the list has no matches in the array, it places the new word in the next array index and 
            //increases the value of t by 1, so that it's ready to place any other new strings in the next array index
            //until it finished going through each list element.
            else
            {
                firstGuesses[t] = homograph;
                Console.WriteLine("The word \"" + homograph + "\" has only appeared once so far on this list.");
                t++;
            }
        }
        Console.ReadLine();
    }
}

