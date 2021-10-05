using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            /*----------------------------------LAB SUMMARY--------------------------------------*
            *Prompt: How can if statements be used to cover multiple situations?
            *        Can you show an example.
            *
            *Answer: If statements can be used to help cover multiple situations by addind one or more "else if"
            *        clauses. You would go from the most selective conditions to the least.
            *        For example: If you want to do something based off of if an animal is black and white,
            *        black, or white, you would want to start with the black and white conditiojn first before
            *        doing black by itself or white by itself.
            *        If you were to put the black or white clause first, itr would exit as soon as you hit it and you might not get the
            *        correct answer for an animal that is black and white.
            *        EX:
            *           if( animalColor is black and animal color is white){
            *               say it's a Zebra
            *           } else if ( animal color is black ){
            *               say it's a gorilla
            *           } else if ( animal color is white ){
            *               say the animal is a unicorn
            *           } else {
            *               say that the user needs glasses because onle black and white animals exist.
            *           }
            *   
            *        
           */
            // Initialize variables for the user's integer, user name,
            // and bool variable to hold if the user entered a valid number
            string userName = "";
            double userInteger = 0;
            


            // Ask for the user's name and input it into userName
            Console.Write("Hello, and welcome to the Number Analyer!" +
                "\nPlease enter your name:  ");
            userName = Console.ReadLine();

            // Set up while loop to continue asking for numbers
            bool keepGoing = true;

            while (keepGoing)
            {
                // create a loop to check the validity of the users integer
                bool invalidNumber = true;
                do
                {
                    // Ask for the user's integer
                    Console.Write("Please enter an integer between 1 and 100: ");

                    // Allow the user to input their number and parse it into double.
                    double.TryParse(Console.ReadLine().Trim(), out userInteger);

                    // Create an if statement to check if the number is: > 1
                    // < 100
                    // or a decimal
                    if (userInteger > 100
                        || userInteger < 1
                        || userInteger % 1 != 0)
                    {
                        //Tell the user to try again with a valid number
                        Console.WriteLine();
                        Console.WriteLine($"Hello {userName}, it appears you have entered an invalid number." +
                            $" Please try again.");
                        Console.WriteLine();
                    }
                    else
                    {
                        invalidNumber = false;
                    }
                } while (invalidNumber);

                // create a if/else if/ else tree to see if the user's Integer is Even or Odd

                if (userInteger % 2 == 0) //If integer is even
                {
                    //Set up another if statement to test whether it's whithin certain ranges

                    if ( userInteger < 25) // user integer < 25 print "Even and less than 25
                    {
                        Console.WriteLine($"{userName}'s integer is even and less than 25");
                    }else if ( userInteger <= 60) // user integer <= 60 print "Even"
                    {
                        Console.WriteLine($"{userName}'s integer is even");
                    }
                    else // user integer > 60 print user integer "and Even"
                    {
                        Console.WriteLine($"{userName}'s integer is {userInteger} and even");
                    };
                }
                else //If Integer is odd
                {
                    /*Lab had redundant messages for two different ranges so I put this here to show how to do it if you
                     *actually wanted two separate ranges
                     * 
                    //Set up another if statement to test whether it's whithin certain ranges

                    if ( userInteger < 60)// user integer is < 60 print user integer is Odd
                    {
                        Console.WriteLine($"{userName}'s integer is and odd");
                    }
                    else// user integer is > 60  print users integer and odd
                    {
                        Console.WriteLine($"{userName}'s integer is {userInteger} and odd.");
                    }
                    
                     */

                    Console.WriteLine($"{userName}'s integer is {userInteger} and odd.");

                }

                //Check if the user would like to keep entering numbers.
                // Update boolean varriable depending on answer
                bool invalidAnswer = true;

                do
                {
                    // Ask user if they would like to continue entering numbers
                    Console.WriteLine();
                    Console.Write("Continue? (y/n): ");
                    string userAnswer = Console.ReadLine().Trim();

                    if (userAnswer.ToLower() == "y")
                    {
                        invalidAnswer = false;
                        Console.WriteLine();
                    }
                    else if (userAnswer.ToLower() == "n")
                    {
                        invalidAnswer = false;
                        keepGoing = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either Y or N to continue.");
                    }
                } while (invalidAnswer);


            }

            //Tell the user goodbye
            Console.WriteLine($"Goobye {userName}");
        }
    }
}
