using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsShortestWord
{
    public class Kata
    {

        public static void Main()
        {
            Console.WriteLine("Enter sentence: ");
            string sentence = Console.ReadLine();
            FindShort(sentence);
        }

        public static void FindShort(string s)
        {
            List<char> charList = new List<char>();
            List<string> wordList = new List<string>();
            charList.AddRange(s);

            int max = 0;
            string maxWord = null;
            string newWord = null;
            bool repeat = true;

            foreach (char item in charList)
            {
                string strchar = Convert.ToString(item);
                
                if (strchar != " ")
                {
                    repeat = false;
                    newWord = newWord + strchar;
                }
                else if (strchar == " " && repeat == false)
                {
                    repeat = true;
                    wordList.Add(newWord);
                    newWord = null;
                }
                else
                {
                    repeat = true;
                }
            }

            if (newWord != null)
            {
                wordList.Add(newWord);
            }

            foreach (string word in wordList)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }

            }

            foreach (var item in wordList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Max word is: " + maxWord + " with that many letters: " + max);

        }
    }
}
