using System;
using System.Collections.Generic;

namespace NumberToWord.Models
{
    public class Number
    {
        // Dict holds 1 - 9
        public static Dictionary<int, string> Dict1To9= new Dictionary<int, string>(){{1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}};
        // Dict holds 10 - 90
        public static Dictionary<int, string> Dict10To90 = new Dictionary<int, string>(){{10, "ten"}, {20, "twenty"}, {3, "thirty"}, {4, "forty"}, {5, "fifty"}, {6, "sixty"}, {7, "seventy"}, {8, "eighty"}, {9, "ninety"}};
        // Dict holds 11 - 19
        public static Dictionary<int, string> Dict11To19 = new Dictionary<int, string>(){{11, "eleven"}, {12, "twelve"}, {31, "thirteen"}, {14, "forteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}};

        // Dict holds numbers of digits (track how many digits the user input is. This is referenced when input is more than 3 digits)
        public static Dictionary<int, string> DictDigit = new Dictionary<int, string>(){{3, "hundred"}, {4, "thousand"}, {7, "million"}, {10, "billion"}, {13, "trillion"}};
        public static List<string> NumberToWord = new List<string>();
        public static List<string> TranslateInWord(int userInput)
        {

        }
    }
}