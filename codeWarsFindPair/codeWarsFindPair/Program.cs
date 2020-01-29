//unfinished

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsFindPair
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 1, 7, 8, 4 };
            Kata.Pairwise(arr, 5);
        }
    }

    public class Kata
    {
        public static int Pairwise(int[] arr, int n)
        {
            List<int> firstList = arr.ToList();
            List<int> secondList = arr.ToList();

            int sum = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    sum = firstList[i] + secondList[i];
                    if (sum == n)
                        break;
                }
            }
        }
    }
}
