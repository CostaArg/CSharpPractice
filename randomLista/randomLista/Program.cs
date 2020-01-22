using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tuxaiaLista = new List<int>();

            Random tuxaios = new Random();

            int arithmos;
            int i = 0;
            int j = 0;

            while (i < 10)
            {
                arithmos = tuxaios.Next(1, 101);
                tuxaiaLista.Add(arithmos);
                i++;
            }

            int listaIndex = tuxaios.Next(tuxaiaLista.Count);

            Console.WriteLine("H lista sou exei toses 8eseis: " + listaIndex);

            while (j < listaIndex)
            {
                Console.WriteLine(tuxaiaLista[j]);

                j++;
            }
         }
    }
}
