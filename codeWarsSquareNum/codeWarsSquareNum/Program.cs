using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSquareNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 2, 3, 4 };
            Kata.SquareSum(n);
        }
    }

    public static class Kata
    {
        public static int SquareSum(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = Convert.ToInt32(Math.Pow(n[i], 2));
                sum += n[i];
            }
            return sum;
        }
    }
}
