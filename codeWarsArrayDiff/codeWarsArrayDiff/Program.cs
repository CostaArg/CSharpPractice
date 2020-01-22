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
            int[] a = {1, 2, 1, 4, 7 };
            int[] b = {8, 2, 1, 4, 7 };
            int[] after = Kata.ArrayDiff(a, b);

            Console.WriteLine(after);
        }

        public class Kata
        {
            public static int[] ArrayDiff(int[] a, int[] b)
            {
                // Your brilliant solution goes here
                // It's possible to pass random tests in about a second ;)

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
