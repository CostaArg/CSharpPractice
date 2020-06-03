using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsFindOccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 10 };
            Kata.FindAll(numbers, 4);
        }
    }

    public class Kata
    {
        public static int[] FindAll(int[] array, int n)
        {
            List<int> integers = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (n == array[i])
                    integers.Add(i);
            }

            int[] pinakas;
            pinakas = integers.ToArray();

            return pinakas;
        }
    }
}
