using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 6;

            int temp = 8989;

            int athrisma = Method(a, b, out temp);

                Console.WriteLine(athrisma);
                Console.WriteLine(temp);

            if(Int32.TryParse("35", out temp))
            {
                Console.WriteLine("GG");
            }
            else
            {
                Console.WriteLine("Paketo");
            }
        }

        public static int Method(int c, int d, out int mult)
        {
            int sum = c + d;
            mult = c * d;
            return sum;
        }
    }
}
