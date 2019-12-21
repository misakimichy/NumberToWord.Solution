using System;

namespace NumberToWord.Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Number to Words!");
            StartGame();
        }

        private static void StartGame()
        {
            Console.WriteLine("Enter a number to translate in words");
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(Translator.TranslateInWord(input));
            RepeatGame();
        }

        private static void RepeatGame()
        {
            Console.WriteLine("Do you want to play again? (Yes / No)");
            int number;
            string input = Console.ReadLine().ToLower();
            bool isValid = Int32.TryParse(input, out number);
            if (!isValid && input == "yes")
            {
                StartGame();
            }
            else if(!isValid && input == "no")
            {
                Console.WriteLine("See you next time!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input!\n");
                Console.ResetColor();
                RepeatGame();
            }
        }
    }
}