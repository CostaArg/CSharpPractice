using System;
using System.Collections.Generic;
using System.Linq;

namespace snippingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //flips words with 5 or more letters
            string word = SpinWords("Hey howdy how is it going");
            Console.WriteLine(word);
        }

        public static string SpinWords(string sentence)
        {
            List<string> words = sentence.Split(' ').ToList();
            List<char> reversing = new List<char>();

            string reversedWord = null;
            string word = null;

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length >= 5)
                {
                    reversing.AddRange(words[i]);
                    reversing.Reverse();

                    foreach (var item in reversing)
                    {
                        reversedWord = reversedWord + item;
                    }

                    words[i] = reversedWord;
                    reversedWord = null;
                    reversing.Clear();
                }

            }

            foreach (var item in words)
            {
                word = word + item + " ";
            }

            word = word.Remove(word.Length - 1);

            return word;
        }
    }
}