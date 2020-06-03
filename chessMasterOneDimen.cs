using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessMasterOneDimen
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "CHESSMASTER";

            string[] board = new string[121];

            List<char> charList = new List<char>();

            string[] iPosArr = new string[11];

            string[] jPosArr = new string[11];

            Random random = new Random();

            charList.AddRange(word);

            for (int i = 0; i < 121; i++)
            {

                if (i % 12 == 0)
                {
                    board[i] = "| X ";
                }
                else
                {
                    board[i] = "|   ";
                }
            }

            int counter = 0;

            int randomNum;

            int pos = 0;

            do
            {

                randomNum = random.Next(1, word.Length);

                if (board[pos + randomNum] == "|   ")
                {
                    board[pos + randomNum] = "| " + Convert.ToString(charList[counter]) + " ";
                    iPosArr[counter] = Convert.ToString(Convert.ToChar(randomNum + 65));
                    jPosArr[counter] = Convert.ToString(randomNum + 1);
                    counter++;
                    pos = word.Length * counter;
                }
                else
                {
                    randomNum = random.Next(1, word.Length);
                    pos++;
                }


            } while (pos < 121 && counter <= 11);

            int vertical = 121;
            int counter2 = 0;

            for (int i = 0; i < 121; i++)
            {
                if (i % 11 == 0 && i != 0)
                {
                    Console.Write("|");
                    Console.Write("   " + charList[counter2] + ": " + "(" + iPosArr[counter2] + ", " + jPosArr[counter2] + ")");
                    Console.WriteLine();
                    counter2++;
                }

                Console.Write(board[i]);

            }

            Console.Write("|");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("  A   B   C   D   E   F   G   H   I   J   K");

        }
    }
}
