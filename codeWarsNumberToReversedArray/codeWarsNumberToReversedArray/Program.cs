using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsNumberToReversedArray
{
    class Program
    {
        static void Main(string[] args)
        {
           long[] something = Digitizer.Digitize(35231);

            foreach (var item in something)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Digitizer
    {
        public static long[] Digitize(int n)
        {
            List<char> chars = new List<char>();

            chars.AddRange(n.ToString());
            chars.Reverse();

            List<long> numbers = new List<long>();

            foreach (var item in chars)
            {
                numbers.Add(Convert.ToInt64(item - 48));
            }

            return numbers.ToArray();
        }
    }
}