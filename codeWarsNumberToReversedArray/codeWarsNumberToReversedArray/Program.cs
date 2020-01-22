using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsNumberToReversedArray
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] something = Digitizer.Digitize(35231);

            foreach (var item in something)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Digitizer
    {
        public static int[] Digitize(int n)
        {
            // Code goes here
            List<char> xaraktires = new List<char>();

            string kati = Convert.ToString(n);

            xaraktires.AddRange(kati);
            xaraktires.Reverse();

            int[] pinakas;

            pinakas = makria.ToArray();

            return pinakas;
        }
    }
}