using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessMasterTwoDimen
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

            string[,] board = new string[word.Length, word.Length];

            List<char> charList = new List<char>();

            string[] iPosArr = new string[word.Length];

            string[] jPosArr = new string[word.Length];

            Random random = new Random();

            charList.AddRange(word);

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (i == j)
                    {
                        board[i, j] = "| X ";
                    }
                    else
                    {
                        board[i, j] = "|   ";
                    }
                }
            }

            int counter = 0;

            int randomNum;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                randomNum = random.Next(1, word.Length);

                for (int j = 0; j <= word.Length - 1; j++)
                {
                    if (board[i, randomNum] == "|   ")
                    {
                        board[i, randomNum] = "| " + Convert.ToString(charList[counter]) + " ";
                        iPosArr[i] = Convert.ToString(Convert.ToChar(randomNum + 65));
                        jPosArr[i] = Convert.ToString(randomNum + 1);
                        counter++;
                        break;
                    }
                    else
                    {
                        randomNum = random.Next(1, word.Length);
                    }
                }
            }

            int vertical = word.Length;

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("      ---------------------------------------------");

                if (vertical >= 10 || vertical <= -10)
                {
                    Console.Write(vertical-- + "    ");
                }
                else
                {
                    Console.Write(vertical-- + "     ");
                }

                for (int j = 0; j < word.Length; j++)
                {
                    Console.Write(board[i, j]);

                    if (j == word.Length - 1)
                    {
                        Console.Write("|");
                    }
                }

                Console.Write("   " + charList[i] + ": " + "(" + iPosArr[i] + ", " + jPosArr[i] + ")");

                Console.WriteLine();
            }

            Console.WriteLine("      ---------------------------------------------");
            Console.WriteLine("        A   B   C   D   E   F   G   H   I   J   K");

        }
    }
}
