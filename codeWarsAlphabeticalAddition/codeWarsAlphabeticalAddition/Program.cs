using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsAlphabeticalAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { 'y' , 'a'};
            Console.WriteLine(Kata.AddLetters(letters));
        }
    }

    public class Kata
    {
        public static char AddLetters(char[] letters)
        {
            int sum = 26;

            foreach (var item in letters)
            {
                sum += Convert.ToInt32(item - 96);
            }

            while (sum > 26)
            {
                sum -= 26;
            }

            return Convert.ToChar(sum + 96);
        }
    }
}
