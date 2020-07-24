using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectPalindrome
{
    class Program
    {
        private static String input;
        private static LinkedList<Char> palindromeList = new LinkedList<char>();
        private static String[] splitInput;
        private static int palindromeLength;
        static void Main(string[] args)

        {
            obtainingPalindrome();

            if (palindromeList.Count() <= 1)
            {
                Console.WriteLine("Not enough letters to make a decision");
            }
            else
            {
                while (palindromeList.Count() >= 0)
                {
                    if (palindromeList.Count() > 1)
                    {
                        Console.WriteLine(palindromeList.First.Value);
                        Console.WriteLine(palindromeList.Last.Value);
                        if (palindromeList.First.Value == palindromeList.Last.Value)
                        {
                            palindromeList.RemoveFirst();
                            palindromeList.RemoveLast();
                        }
                        else
                        {
                            Console.WriteLine("The provided word is not a palindrome");
                            Console.Read();

                        }
                    }
                    else
                    {
                        Console.WriteLine("The provided word is a palindrome");
                        Console.Read();
                    }
                }
            }
            Console.Read();            
        }
        //obtains user input of potential palindrome
        public static void obtainingPalindrome()
        {
            Console.WriteLine("Type in the potential palindrome\n");
            input = Console.ReadLine();
            input = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
            palindromeLength = input.Length;
            splitInput = new String[palindromeLength];

            foreach (char s in input)
            {
                palindromeList.AddFirst(s);
            }
        }
    }
}
