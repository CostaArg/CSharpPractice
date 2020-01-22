using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Random tuxaios = new Random();

            int i = 0;

            while (i < 10)
            {
                int hlikia;

                hlikia = tuxaios.Next(1, 101);

                Console.WriteLine("H hlikia sou einai: " + hlikia);

                if (hlikia < 16)
                {
                    Console.WriteLine("Prepei na pareis eishtirio gia paidaki");
                }
                else
                {
                    Console.WriteLine("Prepei na pareis kanoniko eishtirio");
                }
                i++;
            }
        }
    }
}
