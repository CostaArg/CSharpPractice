using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5dekAsk9
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesOrNo = "N";

            do
            {
                bool prwthBoolean;
                bool deuterhBoolean;
                int prosthesi = 0;

                Console.WriteLine("Please enter the first number: ");
                int prwtos = Convert.ToInt32(Console.ReadLine());

                if (prwtos > 100)
                    prwthBoolean = false;
                else
                    prwthBoolean = true;

                Console.WriteLine("Please enter the second number: ");
                int deuteros = Convert.ToInt32(Console.ReadLine());

                if (deuteros > -40)
                    deuterhBoolean = true;
                else
                    deuterhBoolean = false;

                if (prwthBoolean == false && deuterhBoolean == false)
                {
                    prosthesi = prwtos + deuteros;
                    Console.WriteLine("The sum is: " + prosthesi);
                }

                if (prwthBoolean == true && deuterhBoolean == true)
                {
                    Console.WriteLine("Ena minima ");
                }

                if (prwthBoolean == false || deuterhBoolean == false)
                {
                    int deuterosApoPrwto = deuteros - prwtos;
                    Console.WriteLine("Difference 2nd one minus 1st one: " + deuterosApoPrwto);
                }

                if (prwthBoolean == false && prwtos > 20)
                {
                    int ginomeno = prwtos * deuteros;
                    Console.WriteLine("The multiplication is: " + ginomeno);
                }
                else
                {
                    double diairesi = prwtos / deuteros;
                    Console.WriteLine("The division is: " + diairesi);
                }

                double upolipo = prwtos % deuteros;
                if (deuterhBoolean == true && prosthesi > 44 && upolipo == 0)
                {
                    Console.WriteLine("Do whatever you want");
                }

                do
                {
                    Console.WriteLine("Do you want to continue? Y/N");
                    yesOrNo = Console.ReadLine();
                } while (yesOrNo != "Y" && yesOrNo != "N");

            }
            while (yesOrNo == "Y");

            Console.WriteLine("Closing Program...");

        }
    }
}
