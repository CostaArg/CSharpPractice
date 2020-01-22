using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsReversedSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pinakas = Kata.ReverseSeq(5);

            foreach (var item in pinakas)
            {
                Console.WriteLine(item);
            }
        }

        public static class Kata
        {
            public static int[] ReverseSeq(int n)
            {
                int minus = n;

                List<int> lista = new List<int>();

                do
                {
                    lista.Add(minus);
                    minus--;
                } while (minus >= 1);

                int[] pinakas;

                pinakas = lista.ToArray();

                return pinakas;
            }
        }
    }
}
