using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsDrawStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Kata.DrawStairs(7);
            Console.WriteLine(word);
        }
    }

    public class Kata
    {
        public static string DrawStairs(int n)
        {
            string word = null;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    word += " ";
                }

                word += "I";
                if (i != n - 1)
                    word += "\n";
                counter++;
            }

            return word;
        }
    }
}
