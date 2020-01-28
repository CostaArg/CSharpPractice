using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsMenFromBoys
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 82, 91, 72, 76, 76, 100, 85 };
            Kata.MenFromBoys(numbers);
        }
    }

    public class Kata
    {
        public static int[] MenFromBoys(int[] a)
        {
            List<int> men = new List<int>();

            foreach (var item in a)
            {
                if (item % 2 == 0)
                    men.Add(item);
            }

            List<int> boys = new List<int>();

            foreach (var item in a)
            {
                if (item % 2 != 0)
                    boys.Add(item);
            }

            var ascendingOrder = men.OrderBy(i => i);
            var descendingOrder = boys.OrderByDescending(i => i);

            List<int> everyoneList = new List<int>();

            foreach (var item in ascendingOrder)
            {
                everyoneList.Add(item);
            }

            foreach (var item in descendingOrder)
            {
                everyoneList.Add(item);
            }

            foreach (var item in everyoneList)
            {
                Console.Write(item + ", ");
            }

            return everyoneList.ToArray();
        }
    }
}
