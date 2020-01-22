using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectParagontikh
{
    class Program
    {
        static double fac(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * fac(x - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(fac(5));
        }
    }
}
