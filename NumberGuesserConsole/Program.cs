using System;

// Namespace
namespace NumberGuesserConsole
{
    //Main Class
    public class Program
    {
        // Entry Point Method 
        static void Main(string[] args)
        {
            GetAppinfo(); // Run GetAppInfo function to get info
            GreetUser(); // Ask for User Name and Greet

            while (true)
            {
                // Set correct number 
                // int correctnumber = 7;

                // Create a Random object
                Random random = new Random();

                //Init correct Number 
                int correctnumber = random.Next(1, 10);

                // Initial guess variable 
                int guess = 0;

                // Ask user for number 
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct 
                while (guess != correctnumber)
                {
                    //Get users input 
                    string numberInput = Console.ReadLine();

                    // Make sure the iput is a number 
                    if (!int.TryParse(numberInput, out guess))
                    {
                       // Print error message
                       PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess variable 
                    guess = Convert.ToInt32(numberInput);

                    //Match guess to correct number 
                    if (guess != correctnumber)
                    {
                        // Print error message when the wrong number has been input
                        PrintColorMessage(ConsoleColor.Red, "Wrong number please guess again");

                    }
                }

                // Output Success message 
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                // Ask the user if they would like to play again?
                Console.WriteLine("Play again? [Y or N}");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        static void GetAppinfo()
        {
            //Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string name = " Hemory";

            // Change Text Color 
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, name);

            // Reset Text Color 
            Console.ResetColor();
        }

        // Users name and greet
        static void GreetUser()
        {
            // Ask user for name 
            Console.WriteLine(" What is your name?");
            string nameInput = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", nameInput);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change Text Color 
            Console.ForegroundColor = color;

            // Tell user it is not a number 
            Console.WriteLine(message);

            // Reset Text Color 
            Console.ResetColor();
        }

        
    }
}
