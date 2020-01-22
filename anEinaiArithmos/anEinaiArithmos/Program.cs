using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anEinaiArithmos
{
    class Program
    {
        static void Main(string[] args)
        {

            string arithmos;
            int arithmosAkeraios;

            Console.WriteLine("Enter a number: ");
            arithmos = Console.ReadLine();

            bool ontwsArithmos = int.TryParse(arithmos, out arithmosAkeraios);

            if (ontwsArithmos)
            {
                Console.WriteLine("Einai akeraios trele mou");
            }
            else
            {
                Console.WriteLine("Grafeis ahdies");
            }

        }
    }
}
