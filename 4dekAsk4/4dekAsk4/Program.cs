using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4dekAsk4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> digitsList = new List<char>();

            Console.WriteLine("Whatever 4 digits: ");
            string tetrapsifios = Console.ReadLine();

            digitsList.AddRange(tetrapsifios);

            int apotelesma = 0, arithmos, i = 0, j = 3;

            while (i < 4)
            {
                arithmos = Convert.ToInt32(digitsList[i]);
                arithmos = arithmos - 48;
                apotelesma = apotelesma + arithmos;
                i++;
            }

            Console.WriteLine("The sum is: " + apotelesma);

            while (j > -1)
            {
                arithmos = Convert.ToInt32(digitsList[j]);
                arithmos = arithmos - 48;
                Console.Write(arithmos);
                j--;
            }
            Console.Write("\n");


        }
    }
}
