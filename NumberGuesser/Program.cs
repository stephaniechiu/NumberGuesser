using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class MainClass
    {
        //Entry Point Method
        public static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();


            while (true)
            {


                //Init correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for a guess
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //Get user's input
                    string input = Console.ReadLine();

                    //Check if input is a number using try parse
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Type a number");

                        continue;
                    }

                    //Cast to int and put into guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Guess again");
                    }
                }

                //Sucess message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!");

                //Ask to play again
                Console.WriteLine("Play again? [Y/N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private static void PrintColorMessage()
        {
            throw new NotImplementedException();
        }

        //Get and display app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Stephanie Chiu";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            //Write out app info
            Console.WriteLine("{0}:  Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask user's name
            Console.WriteLine("What's your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello, {0}, let's play a game...", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
