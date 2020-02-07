using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsAreTheyTheSame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = { 132, 14641, 20736, 361, 25921, 361, 20736, 361 };
            Console.WriteLine(AreTheySame.comp(a, b));
        }
    }

    class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
                return true;

            List<double> firstList = (from item in a select Convert.ToDouble(item)).ToList();
            List<double> secondList = (from item in b select Convert.ToDouble(item)).ToList();

            firstList.OrderBy(x => x);
            secondList.OrderBy(x => x);

            for (int i = 0; i < secondList.Count; i++)
            {
                secondList[i] = Math.Sqrt(secondList[i]);
            }

            int count = 0;

            foreach (var second in secondList)
            {
                foreach (var first in firstList)
                {
                    if (second != first)
                    {
                        count++;
                    }
                    if (count == firstList.Count)
                    {
                        return false;
                    }
                }
                count = 0;
            }

            return true;
        }
    }
}
