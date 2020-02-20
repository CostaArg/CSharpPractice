using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversedSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //number n returns the reversed sequence from n to 1
            //example: 5 => [5,4,3,2,1]

            int[] arr = Kata.ReverseSeq(5);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static class Kata
        {
            public static int[] ReverseSeq(int n)
            {
                int minus = n;

                List<int> intList = new List<int>();

                do
                {
                    intList.Add(minus);
                    minus--;
                } while (minus >= 1);

                int[] arr;

                arr = intList.ToArray();

                return arr;
            }
        }
    }
}
