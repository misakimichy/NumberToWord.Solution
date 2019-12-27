using System;
using System.Collections.Generic;
namespace NumberToWord.Models
{
    public class Translator
    {
        // Dict holds 1 - 9
        public static Dictionary<long, string> Dictionary1 = new Dictionary<long, string>(){
            {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"}, {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}
        };
        // Dict holds 11 - 19
        public static Dictionary<long, string> Dictionary2 = new Dictionary<long, string>(){
            {11, "Eleven"}, {12, "Twelve"}, {13, "Thirteen"}, {14, "Forteen"}, {15, "Fifteen"}, {16, "Sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"}
        };
        // Dict holds 10 - 90
        public static Dictionary<long, string> Dictionary3 = new Dictionary<long, string>(){
            {1, "Ten"}, {2, "Twenty"}, {3, "Thirty"}, {4, "Forty"}, {5, "Fifty"}, {6, "Sixty"}, {7, "Seventy"}, {8, "Eighty"}, {9, "Ninety"}
        };

        public static int Input { get; set; }
        public static string Output { get; set; }

        public Translator (int input)
        {
            Input = input;
            Output = "";
        }

        public static bool CheckZero ()
        {
            bool isZero = Input ? true : false;
            return isZero;
        }

        public static string TranslateInWord(long userInput)
        {
            Stack<long> myStack = new Stack<long>();
            char[] numArray = userInput.ToString().ToCharArray();
            for (int i = numArray.Length - 1; i >= 0; i--)
            {
                myStack.Push(Convert.ToInt64(Char.GetNumericValue(numArray[i])));
            }
            int count = myStack.Count;
            string result = "";
            string word;
            while(count > 0)
            {
                word = "";
                long num = 0;
                switch(count)
                {
                    case 15:
                        num = myStack.Pop();
                        Dictionary1.TryGetValue(num, out word);
                        result += word + " " + "Hundred" + " ";
                        break;
                    case 14:
                        num = myStack.Pop();
                        Dictionary3.TryGetValue(num * 10, out word);
                        result += word + " ";
                        break;
                    case 13:
                        num = myStack.Pop();
                        Dictionary1.TryGetValue(num, out word);
                        result += word + " " + "Trillion" + " ";
                        break;
                    case 12:
                        num = myStack.Pop();
                        Dictionary1.TryGetValue(num, out word);
                        result += word + " " + "Hundred" + " ";
                        break;
                    case 11:
                        num = myStack.Pop();
                        Dictionary3.TryGetValue(num * 10, out word);
                        result += word;
                        break;
                    case 10:
                        num = myStack.Pop();
                        Dictionary1.TryGetValue(num, out word);
                        result += word + " " + "Billion" + " ";
                        break;
                    case 9:
                        num = myStack.Pop();
                        Dictionary1.TryGetValue(num, out word);
                        result += word + " " + "Hundred" + " ";
                        break;
                    case 8:
                        num = myStack.Pop();
                        Dictionary3.TryGetValue(num * 10, out word);
                        result += word;
                        break;
                    case 7:
                        num = myStack.Pop();
                        Dictionary1.TryGetValue(num, out word);
                        result += word + " " + "Million" + " ";
                        break;
                    case 6:
                        num = myStack.Pop();
                        Dictionary1.TryGetValue(num, out word);
                        result += word + " " + "Hundred" + " ";
                        break;
                    case 5:
                        num = myStack.Pop();
                        Dictionary3.TryGetValue(num * 10, out word);
                        result += word;
                        break;
                    case 4:
                        num = myStack.Pop();
                        Dictionary1.TryGetValue(num, out word);
                        result += word + " " + "Thousand" + " ";
                        break;
                    case 3:
                        num = myStack.Pop();
                        Dictionary1.TryGetValue(num, out word);
                        result += word + " " + "Hundred" + " ";
                        break;
                    case 2:
                        num = myStack.Pop();
                        if(num > 1)
                        {
                            Dictionary3.TryGetValue(num * 10, out word);
                            result += word + " ";
                        }
                        else if (num == 0)
                        {}
                        else if (num == 1 && myStack.Peek() == 0)
                        {
                            Dictionary3.TryGetValue(10, out word);
                            result += word;
                        }
                        else
                        {
                            num = myStack.Pop();
                            Dictionary2.TryGetValue(num + 10, out word);
                            result += word;
                        }
                        break;
                    case 1:
                        num = myStack.Pop();
                        Dictionary1.TryGetValue(num, out word);
                        result += word;
                        break;
                }
                count = myStack.Count;
            }
            return result;
        }
    }
}