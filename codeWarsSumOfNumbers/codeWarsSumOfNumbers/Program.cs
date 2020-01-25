using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum s1 = new Sum();
            int something = s1.GetSum(0, 4);
            Console.WriteLine(something);
        }
    }
    public class Sum
    {
        public int GetSum(int a, int b)
        {
            List<int> numbers = new List<int>();

            int numSum = 0;

            if (a == b)
                return a;

            if (a < b)
            {
                do
                {
                    numbers.Add(a);
                    a++;

                } while (a <= b);
            }
            else if (a > b)
            {
                do
                {
                    numbers.Add(a);
                    a--;

                } while (a >= b);
            }

            foreach (var item in numbers)
            {
                numSum += item;
            }

            return numSum;
        }
    }
}
