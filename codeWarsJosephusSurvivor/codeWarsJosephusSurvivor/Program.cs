using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsJosephusSurvivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int k = 3;

            int survivor = JosephusSurvivor.JosSurvivor(n, k);

            Console.WriteLine("Survivor is: " + survivor);

        }
    }

    public class JosephusSurvivor
    {
        public static int JosSurvivor(int n, int k)
        {
            List<int> items = new List<int>();

            for (int i = 1; i < n + 1; i++)
            {
                items.Add(i);
            }

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            int point = k - 1;

            while (items.Count != 1)
            {
                while (point >= items.Count)
                {
                    point -= items.Count;
                }

                Console.WriteLine("Pointer position: " + point + " looking at: " + items[point]);

                foreach (var item in items)
                {
                    Console.Write(item);
                }

                Console.WriteLine();

                items.RemoveAt(point);
                point += k - 1;

            };

            return items[0];
        }
    }
}
