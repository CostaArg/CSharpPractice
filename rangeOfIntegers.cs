using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rangeOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GenerateRange(1, 10, 4);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] GenerateRange(int min, int max, int step)
        {
            List<int> intList = new List<int>();

            int counter = min;

            intList.Add(min);

            while (counter < max)
            {
                counter = counter + step;
                if (counter <= max)
                    intList.Add(counter);
            }

            int[] arr;

            arr = intList.ToArray();

            return arr;
        }
    }

}
