using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuxaioPragma
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int tuxaio = rnd.Next(10);

            Console.WriteLine("Tuxaios apo 0 ews 9: " + tuxaio);
        }
    }
}
