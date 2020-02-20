using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            //remove duplicates from 2 arrays
            int[] a = {1, 2, 1, 4, 7 };
            int[] b = {8, 2, 1, 4, 7 };
            int[] after = Kata.ArrayDiff(a, b);

            Console.WriteLine(after);
        }

        public class Kata
        {
            public static int[] ArrayDiff(int[] a, int[] b)
            {

                List<int> intListA = a.ToList();
                List<int> intListB = b.ToList();

                foreach (var item in intListA)
                {
                    foreach (var item2 in intListB)
                    {
                        if (item == item2)
                            intListA.Remove(item);
                    }
                }

                a = intListA.ToArray();
                b = intListB.ToArray();

                return a;
            }
        }
    }
}
