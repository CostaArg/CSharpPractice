using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsIsStringUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class StringExtensions
    {
        public static bool IsUpperCase(this string text)
        {
            List<char> charList = new List<char>();

            charList.AddRange(text);

            foreach (var item in charList)
            {
                if (item.ToString() != item.ToString().ToUpper())
                    return false;
            }

            return true;
        }
    }
}
