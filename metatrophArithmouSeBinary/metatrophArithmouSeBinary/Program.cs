using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metatrophArithmouSeBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int arithmos;
            int counter = 0;
            int i = 0;
            int binaryArithmos = 0;
            int misos = 0;

            List<int> arithmoiList = new List<int>();

                Console.WriteLine("Dwse ton arithmo sou: ");
                arithmos = Int32.Parse(Console.ReadLine());

            misos = arithmos / 2;

                while (misos > 2)
                {
                
                 arithmoiList.Add(arithmos % 2);

                 if (counter != 0)
                 {
                    misos = misos / 2;
                 }
                arithmos = misos;

                counter++;
                }          

            Console.WriteLine("Your list that big: " + counter);

            Console.WriteLine("O arithmos sou einai: ");

            while (i < counter)
            {
                Console.WriteLine(arithmoiList[i]);
                i++;
            }

        }
    }
}
