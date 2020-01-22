using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eksafanish
{
    class Program
    {
        static void Main(string[] args)
        {

            double liontaria = 23000;
            double upoeksafanish = 6000;
            double an8rwpoi = 7000000000;

            int xronosLiontaria = 0;
            int xronosAn8rwpoi = 0;

            while (liontaria > upoeksafanish)
            {
                liontaria = liontaria - (2 * liontaria / 100);
                xronosLiontaria = xronosLiontaria + 1;

                liontaria = Math.Truncate(liontaria);
            }

            while (an8rwpoi > upoeksafanish)
            {
                an8rwpoi = an8rwpoi - (2 * an8rwpoi / 100);
                xronosAn8rwpoi = xronosAn8rwpoi + 1;

                an8rwpoi = Math.Truncate(an8rwpoi);
            }

            Console.WriteLine("Lions are going extinct after: " + xronosLiontaria + " years");
            Console.WriteLine("Amount of lions that exist: " + liontaria);

            Console.WriteLine("Humans are going extinct after: " + xronosAn8rwpoi + " years");
            Console.WriteLine("Amount of humans that exist: " + an8rwpoi);
        }
    }
}
