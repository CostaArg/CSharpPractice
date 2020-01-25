using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsVowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

public static class Kata
    {
        public static int GetVowelCount(string str)
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
    }

}
