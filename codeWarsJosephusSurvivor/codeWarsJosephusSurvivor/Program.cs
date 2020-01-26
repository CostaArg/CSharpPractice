using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsJosephusSurvivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int k = 3;

            int survivor = Josephus.Survivor(n, k);

            Console.WriteLine("Survivor is: " + survivor);
        }
    }

    public class Josephus
    {
        public static int Survivor(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                return (Survivor(n - 1, k) + k - 1) % n + 1;
        }
    }
}
