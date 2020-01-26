using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsJosephusPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> items = new List<object> { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            List<object> turns = Josephus.JosephusPermutation(items, k);

            foreach (var item in turns)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Josephus
    {
        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            List<object> turns = new List<object>();
            int point = k - 1;

            while (items.Count != 0)
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

                turns.Add(items[point]);
                items.RemoveAt(point);
                point += k - 1;

            };

            return turns;
        }
    }
}
