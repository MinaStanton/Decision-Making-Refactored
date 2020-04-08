using System;

namespace Lab3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to Decision Making with integers!\n");
            string userName = GetUserInput("What's your name?");

            bool userContinue = true;
            while (userContinue)
            {
                PrintDecision($"\n{userName}, Enter an integer between 1-100");
                userContinue = GetUserChoice($"\n{userName}, Would you like to go again? y/n", "y", "n");
            }

            Console.WriteLine($"\n{userName}, thanks for playing! Bye!");
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            if(userInput == "")
            {
                return GetUserInput(message);
            }
            else
            {
                return userInput;
            }
        }
        public static bool GetUserChoice(string message, string option1_true, string option2_false)
        {
            string userInput = GetUserInput(message).ToLower();
            if(userInput == option1_true)
            {
                return true;
            }
            else if (userInput == option2_false)
            {
                return false;
            }
            else
            {
                return GetUserChoice(message, option1_true, option2_false);
            }
        }
        public static int GetInteger(string message)
        {
            int userNumber = int.Parse(GetUserInput(message));
            if(userNumber < 1 || userNumber > 100)
            {
                return GetInteger(message);
            }

            return userNumber;
        }
        public static void PrintDecision(string message)
        {
            int userNumber = GetInteger(message);

            if (userNumber % 2 != 0)
            {
                Console.WriteLine($"{userNumber}, is odd!");
            }
            else if(userNumber <= 25)
            {
                Console.WriteLine($"{userNumber}, is even and less than 25");
            }
            else if(userNumber > 25 && userNumber <= 60)
            {
                Console.WriteLine($"{userNumber}, is even and greater than 25 but less than 60!");
            }
            else
            {
                Console.WriteLine($"{userNumber}, even!");
            }
        }
    }
}
