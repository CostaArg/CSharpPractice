using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thetikoiLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbersList = new List<int>() { 10, 9, 8, 7, 6, 5, 1, 2, 3, 4 };
            List<int> numbersList = new List<int>();

            int i = 0;
            int max = -1;
            string tosesString;
            int toses;

            Console.WriteLine("Enter how many values you want to enter: ");
            tosesString = Console.ReadLine();
            toses = Convert.ToInt32(tosesString);

            for (int j = 0; j < toses; j++)
            {
                Console.WriteLine("Give me the {0} value: ", j + 1);
                numbersList.Add(Convert.ToInt32(Console.ReadLine()));
            }


            while (i < numbersList.Count)
            {
                if (numbersList[i] > max)
                {
                    max = numbersList[i];
                }
                i++;
            }

            Console.WriteLine("O max einai: " + max);

            foreach (int patata in numbersList)
            {
                if (patata % 2 == 0)
                {
                    Console.WriteLine("Autos o arithmos einai zugos: " + patata);
                }
            }
        }
    }
}
