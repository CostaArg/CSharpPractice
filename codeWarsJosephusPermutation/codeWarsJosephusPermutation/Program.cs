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

            do
            {
                if (point >= items.Count)
                    point -= items.Count;

                turns.Add(items[point]);
                items.Remove(items[point]);

                if (items.Count == 2)
                    break;

                point += k - 1;

            } while (items.Count != 2);

            point -= items.Count;
            turns.Add(items[point]);
            items.Remove(items[point]);
            turns.Add(items[0]);

            return turns;
        }
    }
}
