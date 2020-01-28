using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsWhoseTurn
{
    class Program
    {
        static void Main(string[] args)
        {
            string positions = "b1;g1;b8;g8";
            bool turn = Kata.WhoseTurn(positions);
            Console.WriteLine(turn);
        }
    }

    public static class Kata
    {
        public static bool WhoseTurn(string positions)
        {

        }
    }

}