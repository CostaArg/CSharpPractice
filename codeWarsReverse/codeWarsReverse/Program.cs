using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsReverse
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

public static class Kata
    {
        public static string Solution(string str)
        {
            if (str == string.Empty)
                return str;

            List<char> charList = new List<char>();
            charList.AddRange(str);
            charList.Reverse();

            string word = null;

            foreach (var item in charList)
            {
                word += item;
            }

            return word;
        }
    }
}
