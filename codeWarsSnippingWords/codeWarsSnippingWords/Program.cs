using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSnippingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Kata.SpinWords("Hey howdy how is it going");
            Console.WriteLine(word);
        }
    }

    public class Kata
    {
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
