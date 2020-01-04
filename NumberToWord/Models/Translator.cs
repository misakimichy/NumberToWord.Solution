using System;
using System.Collections.Generic;
namespace NumberToWord.Models
{
    public class Translator
    {
        // Dict holds 1 - 9
        public static Dictionary<long, string> SingleDigits = new Dictionary<long, string>(){
            {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"}, {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}
        };
        // Dict holds 11 - 19
        public static Dictionary<long, string> Teens = new Dictionary<long, string>(){
            {11, "Eleven"}, {12, "Twelve"}, {13, "Thirteen"}, {14, "Forteen"}, {15, "Fifteen"}, {16, "Sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"}
        };
        // Dict holds 10 - 90
        public static Dictionary<long, string> Tens = new Dictionary<long, string>(){
            {1, "Ten"}, {2, "Twenty"}, {3, "Thirty"}, {4, "Forty"}, {5, "Fifty"}, {6, "Sixty"}, {7, "Seventy"}, {8, "Eighty"}, {9, "Ninety"}
        };
        public static int Input;
        public static string Output = "";

        public static bool CheckZero(int number)
        {
            bool isZero = number == 0 ? true : false;
            return isZero;
        }

        public static string ConvertMoreThan100(int inputNumber, int num, string numWord)
        {
            int divided = inputNumber / num;
            int remainder = inputNumber % num;
            if(divided > 9)
            {
                return Convert(divided);
            }
            else
            {
                if(remainder == 0)
                {
                    return Output += SingleDigits[divided] + " " + numWord;
                }
                else
                {
                    Output += SingleDigits[divided] + " " + numWord + " ";
                    return Convert(remainder); 
                }
            }
        }

        public static string Convert(int number)
        {
            if (number < 10)
            {
                Output += SingleDigits[number];
            }
            else if (number < 20 && number != 10)
            {
                Output += Teens[number];
            }
            else if (number < 99)
            {
                int divided = number / 10;
                int remainder = number % 10;
                if(remainder == 0)
                {
                    Output += Tens[divided];
                }
                else
                {
                    Output += Tens[divided] + " " + SingleDigits[remainder];
                }
            }
            else if (number > 99 && number < 1000)
            {
                ConvertMoreThan100(number, 100, "Hundred");
            }
            else if (number > 999 && number < 100000)
            {
                ConvertMoreThan100(number, 1000, "Thousand");
            }
            return Output;
        }
    }
}