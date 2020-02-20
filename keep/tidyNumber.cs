using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsTidyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           bool result = Kata.TidyNumber(123);
            Console.WriteLine("Is the number tidy?");
            Console.WriteLine(result);
        }
    }

    class Kata
    {
        public static bool TidyNumber(int n)
        {
            List<char> charList = new List<char>();

            charList.AddRange(n.ToString());

            List<int> intList = new List<int>();

            foreach (var item in charList)
            {
                intList.Add(Convert.ToInt32(item.ToString()));
            }

            for (int i = 0; i < intList.Count - 1; i++)
            {
                if (intList[i] > intList[i + 1])
                    return false;
            }

            return true;
        }
    }
}
