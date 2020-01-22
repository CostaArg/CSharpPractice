using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Method(3, 4, 6, 4, 3, 5, 7, 1, 2);
        }

        public static void Method(params int[] p) //params mpenoun panta teleutaia giati den kserei pote teleiwneis na grafeis
        {
            foreach (var item in p)
            {
                Console.WriteLine(item);
            }
        }
    }
}
