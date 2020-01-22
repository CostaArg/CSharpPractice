using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zariTuxaio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random tuxaios = new Random();

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(tuxaios.Next(1, 7));
                i++;
            }
        }
    }
}
