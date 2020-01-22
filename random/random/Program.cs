using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string number;

            for (i = 0; i > 10; i++)
            {
                Console.WriteLine("Enter 10 numbers, 1 at a time: ");
                number = Console.ReadLine();
                int tuxaio = Convert.ToInt32(number);
                tuxaio = tuxaio + 1;
            }


        }
    }
}
