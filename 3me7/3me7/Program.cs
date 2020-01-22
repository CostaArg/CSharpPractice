using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3me7
{
    class Program
    {
        static void Main(string[] args)
        {
            string prinx;
            int x;

            Console.WriteLine("Enter x: ");
            prinx = Console.ReadLine();

            x = int.Parse(prinx);

            if ( (x > 3) && (x <= 7) )
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
