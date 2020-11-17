using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("test"));
        }

        public static bool IsPalindrome(string word)
        {
            //Split letters in list
            List<char> charList = new List<char>();
            charList.AddRange(word.ToLower());

            //Check if first letter is the same with the last letter
            for (int i = 0; i < charList.Count - 1 / 2; i++)
            {
                if (charList[i] != charList[charList.Count - i - 1])
                    return false;
            }

            return true;
        }
    }
}
