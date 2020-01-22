using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eksafanishAn8rwpoi
{
    class Program
    {
        static void Main(string[] args)
        {
            double humans = 7000000000;
            double extinct = 6000;
            int time = 0;

            while (humans > extinct)
            {
                humans = humans - (2 * humans / 100);
                time = time + 1;
            }

            Console.WriteLine("Humans will extinct in: " + time + " years");

        }
    }
}
