using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmaXromata
{
    class Program
    {
        enum xromata { mpez, fouksia, galazio, tirkouaz, ladi, keramidi };
        static void Main(string[] args)
        {
            Console.WriteLine("Xrhsth dwse ena noumero metaksi tou 1-6:");
            int noumero = Int32.Parse(Console.ReadLine());
            noumero = noumero - 1;

            switch (noumero)
            {
                case 0:
                    Console.WriteLine("To xrwma sou einai: " + xromata.mpez);
                    break;
                case 1:
                    Console.WriteLine("To xrwma sou einai: " + xromata.fouksia);
                    break;
                case 2:
                    Console.WriteLine("To xrwma sou einai: " + xromata.galazio);
                    break;
                case 3:
                    Console.WriteLine("To xrwma sou einai: " + xromata.tirkouaz);
                    break;
                case 4:
                    Console.WriteLine("To xrwma sou einai: " + xromata.ladi);
                    break;
                case 5:
                    Console.WriteLine("To xrwma sou einai: " + xromata.keramidi);
                    break;
                default:
                    Console.WriteLine("Les blakies");
                    break;
            }

        }
    }
}
