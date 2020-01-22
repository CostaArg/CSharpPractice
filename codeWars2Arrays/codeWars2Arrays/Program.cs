using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWars2Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            int sum = 0;

            foreach (var item in arr1)
            {
                sum = sum + item;
            }

            foreach (var item in arr2)
            {
                sum = sum + item;
            }

            return sum;
        }
    }
}
