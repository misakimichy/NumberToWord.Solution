using System;
using System.Collections.Generic;
namespace NumberToWord.Models
{
    public class Translator
    {
        // Dict holds 1 - 9
        public static Dictionary<long, string> Dictionary1 = new Dictionary<long, string>(){
            {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}
        };
        // Dict holds 11 - 19
        public static Dictionary<long, string> Dictionary2 = new Dictionary<long, string>(){
            {11, "eleven"}, {12, "twelve"}, {31, "thirteen"}, {14, "forteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}
        };
        // Dict holds 10 - 90
        public static Dictionary<long, string> Dictionary3 = new Dictionary<long, string>(){
            {10, "ten"}, {20, "twenty"}, {3, "thirty"}, {4, "forty"}, {5, "fifty"}, {6, "sixty"}, {7, "seventy"}, {8, "eighty"}, {9, "ninety"}
        };

        // Dict holds numbers of digits (track how many digits the user input is. This is referenced when input is more than 3 digits)
        public static Dictionary<long, string> Dictionary4 = new Dictionary<long, string>(){
            {100, "hundred"}, {1000, "thousand"}, {1000000, "million"}, {1000000000, "billion"}, {1000000000000, "trillion"}
        };
        public static List<string> NumberToWord = new List<string>();
        public static string TranslateInWord(int userInput)
        {
            // List<string> numberInWord = new List<string>();
            // char[] numArray = userInput.ToString().ToCharArray();



            return "";
        }
    }
}