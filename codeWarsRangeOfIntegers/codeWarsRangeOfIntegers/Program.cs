using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsRangeOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pinakas = Kata.GenerateRange(1, 10, 4);

            foreach (var item in pinakas)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Kata
    {
        public static int[] GenerateRange(int min, int max, int step)
        {
            // your code goes here

            List<int> kati = new List<int>();

            int counter = min;

            kati.Add(min);

            while (counter < max)
            {
                counter = counter + step;
                if (counter <= max)
                    kati.Add(counter);
            }

            int[] pinakas;

            pinakas = kati.ToArray();

            return pinakas;
        }
    }
}
