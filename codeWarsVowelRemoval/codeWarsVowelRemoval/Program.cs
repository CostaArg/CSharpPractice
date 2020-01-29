using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsVowelRemoval
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Kata
    {
        public static string Shortcut(string input)
        {
            List<char> charList = new List<char>();

            charList.AddRange(input);

            List<char> charList2 = new List<char>();

            for (int i = 0; i < charList.Count; i++)
            {
                if (charList[i] != 'a' && charList[i] != 'e' && charList[i] != 'i' && charList[i] != 'o' && charList[i] != 'u')
                    charList2.Add(charList[i]);
            }

            input = null;

            foreach (var item in charList2)
            {
                input += item;
            }

            return input;
        }
    }
}