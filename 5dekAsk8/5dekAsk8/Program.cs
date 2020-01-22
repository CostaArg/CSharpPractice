using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5dekAsk8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tragoudistes = new string[4];
            int[] totalScores = new int[4];
            int[] mesosOros = new int[4];

            int max = -1;
            string maxName = "kanenas";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Give your name: ");
                tragoudistes[i] = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Give your score: ");
                    int score = Convert.ToInt32(Console.ReadLine());
                    totalScores[i] = totalScores[i] + score;
                }

            }

            for (int i = 0; i < 4; i++)
            {
                mesosOros[i] = totalScores[i] / 3;
            }

            for (int i = 0; i < 4; i++)
            { 
                if (mesosOros[i] > max)
                {
                    max = mesosOros[i];
                    maxName = tragoudistes[i];
                }
            }

                for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("For the singer: " + tragoudistes[i] + " your total score is: " + totalScores[i] + " and your average: " + mesosOros[i]);
            }

            Console.WriteLine("Winner is: " + maxName + " and his average was: " + max);
        }
    }
}
