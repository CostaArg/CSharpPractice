using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessMasterMeDisdiastato
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;

            do
            {
                Console.WriteLine("Give me the word \"CHESSMASTER\": ");
                word = Console.ReadLine();
            } while (word != "CHESSMASTER");

            string[,] pinakas = new string[word.Length, word.Length];

            List<char> xaraktiresList = new List<char>();

            string[] theseisTouIArray = new string[word.Length];

            string[] theseisTouJArray = new string[word.Length];

            Random tuxaio = new Random();


            xaraktiresList.AddRange(word);

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (i == j)
                    {
                        pinakas[i, j] = "| X ";
                    }
                    else
                    {
                        pinakas[i, j] = "|   ";
                    }
                }
            }

            int counter = 0;

            int tuxaios;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                tuxaios = tuxaio.Next(1, word.Length);

                for (int j = 0; j <= word.Length - 1; j++)
                {
                    if (pinakas[i, tuxaios] == "|   ")
                    {
                        pinakas[i, tuxaios] = "| " + Convert.ToString(xaraktiresList[counter]) + " ";
                        theseisTouIArray[i] = Convert.ToString(Convert.ToChar(tuxaios + 65));
                        theseisTouJArray[i] = Convert.ToString(tuxaios + 1);
                        counter++;
                        break;
                    }
                    else
                    {
                        tuxaios = tuxaio.Next(1, word.Length);
                    }
                }
            }

            int katheta = word.Length;

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("      ---------------------------------------------");

                if (katheta >= 10 || katheta <= -10)
                {
                    Console.Write(katheta-- + "    ");
                }
                else
                {
                    Console.Write(katheta-- + "     ");
                }

                for (int j = 0; j < word.Length; j++)
                {
                    Console.Write(pinakas[i, j]);

                    if (j == word.Length - 1)
                    {
                        Console.Write("|");
                    }
                }

                Console.Write("   " + xaraktiresList[i] + ": " + "(" + theseisTouIArray[i] + ", " + theseisTouJArray[i] + ")");

                Console.WriteLine();
            }

            Console.WriteLine("      ---------------------------------------------");
            Console.WriteLine("        A   B   C   D   E   F   G   H   I   J   K");

        }
    }
}
