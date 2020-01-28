using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsWhoseMove
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.WhoseMove("black", true);
        }
    }

    public class Kata
    {
        public static string WhoseMove(string lastPlayer, bool win)
        {
            if (lastPlayer == "black" && win == true) return "black";
            else if (lastPlayer == "black" && win == false) return "white";
            else if (lastPlayer == "white" && win == true) return "white";
            else if (lastPlayer == "white" && win == false) return "black";
            else return "";
        }
    }
}
