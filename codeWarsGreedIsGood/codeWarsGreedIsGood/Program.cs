using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsGreedIsGood
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static int Score(int[] dice)
        {
            int ones = 0;
            int twos = 0;
            int threes = 0;
            int fours = 0;
            int fives = 0;
            int sixs = 0;
            int points = 0;

            foreach (var item in dice)
            {
                if (item == 1)
                {
                    ones++;
                }
                else if (item == 2)
                {
                    twos++;
                }
                else if (item == 3)
                {
                    threes++;
                }
                else if (item == 4)
                {
                    fours++;
                }
                else if (item == 5)
                {
                    fives++;
                }
                else if (item == 6)
                {
                    sixs++;
                }
            }

            if (ones >= 3)
            {
                points += 1000;
            }
            else if (sixs >= 3)
            {
                points += 600;
            }
            else if (fives >= 3)
            {
                points += 500;
            }
            else if (fours >= 3)
            {
                points += 400;
            }
            else if (threes >= 3)
            {
                points += 300;
            }
            else if (twos >= 3)
            {
                points += 200;
            }

            if (ones > 3)
            {
                ones -= 3;
                points += ones * 100;
            }
            else if (ones == 1 || ones == 2)
            {
                points += ones * 100;
            }

            if (fives > 3)
            {
                fives -= 3;
                points += fives * 50;
            }
            else if (fives == 1 || fives == 2)
            {
                points += fives * 50;
            }

            return points;

        }
    }
}
