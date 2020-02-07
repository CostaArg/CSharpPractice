//unfinished - got bugs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSumOfDigitsRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 456;
            int number = Number.DigitalRoot(n);
            Console.WriteLine(number);
        }
    }
    public class Number
    {

        public static int DigitalRoot(long n)
        {
            List<char> charList = new List<char>();

            charList.AddRange(n.ToString());

            List<long> longList = new List<long>();

            foreach (var item in charList)
            {
                longList.Add(Convert.ToInt64(item.ToString()));
            }

            n = 0;

            foreach (var item in longList)
            {
                n += item;
            }

            if (n.ToString().Length > 1)
                return DigitalRoot(n);

            return Convert.ToInt32(n);
        }
    }
}
