using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int VowelCount(string str)
        {
            int vowelCount = 0;

            List<char> charList = new List<char>();

            charList.AddRange(str);

            foreach (var item in charList)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                    vowelCount++;
            }

            return vowelCount;
        }

        public static string VowelRemove(string input)
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