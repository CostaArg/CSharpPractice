using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessMasterMeMonosdiastato
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "CHESSMASTER";

            string[] pinakas = new string[121];

            List<char> xaraktiresList = new List<char>();

            string[] theseisTouIArray = new string[11];

            string[] theseisTouJArray = new string[11];

            Random tuxaio = new Random();

            xaraktiresList.AddRange(word);

            for (int i = 0; i < 121; i++)
            {

                if (i % 12 == 0)
                {
                    pinakas[i] = "| X ";
                }
                else
                {
                    pinakas[i] = "|   ";
                }
            }

            int counter = 0;

            int tuxaios;

            int thesi = 0;

            do
            {

                tuxaios = tuxaio.Next(1, word.Length);

                //if (pinakas[i, tuxaios] == "|   ")

                if (pinakas[thesi + tuxaios] == "|   ")
                {
                    pinakas[thesi + tuxaios] = "| " + Convert.ToString(xaraktiresList[counter]) + " ";
                    theseisTouIArray[counter] = Convert.ToString(Convert.ToChar(tuxaios + 65));
                    theseisTouJArray[counter] = Convert.ToString(tuxaios + 1);
                    counter++;
                    thesi = word.Length * counter;
                }
                else
                {
                    tuxaios = tuxaio.Next(1, word.Length);
                    thesi++;
                }


            } while (thesi < 121 && counter <= 11);

            int katheta = 121;
            int metritis = 0;

            for (int i = 0; i < 121; i++)
            {
                if (i % 11 == 0 && i != 0)
                {
                    Console.Write("|");
                    Console.Write("   " + xaraktiresList[metritis] + ": " + "(" + theseisTouIArray[metritis] + ", " + theseisTouJArray[metritis] + ")");
                    Console.WriteLine();
                    metritis++;
                }

                Console.Write(pinakas[i]);

                
/*                if (katheta >= 10 || katheta <= -10)
                {
                    Console.Write(katheta-- + "    ");
                }
                else
                {
                    Console.Write(katheta-- + "     ");
                }*/
            }

            Console.Write("|");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("  A   B   C   D   E   F   G   H   I   J   K");

        }
    }
}
