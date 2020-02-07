using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSumsOfParts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ls = { 0, 1, 3, 6, 10 };
            SumParts.PartsSums(ls);
        }
    }

    class SumParts
    {
        public static int[] PartsSums(int[] ls)
        {
            List<int> resultList = new List<int>();

            int counter = 0;
            int sum = 0;

            do
            {
                for (int i = counter; i < ls.Length; i++)
                {
                    sum = sum + ls[i];
                }

                resultList.Add(sum);
                sum = 0;
                counter++;

            } while (counter <= ls.Length);

            return resultList.ToArray();
        }
    }
}
