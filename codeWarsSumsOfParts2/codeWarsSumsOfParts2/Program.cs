using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSumsOfParts2
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
            List<int> lsList = ls.ToList();

            List<int> resultList = new List<int>();

            while (lsList.Count != 0)
            {
                resultList.Add(lsList.Sum());
                lsList.RemoveAt(0);
            }

            resultList.Add(0);

            foreach (var item in resultList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            return resultList.ToArray();
        }
    }
}
