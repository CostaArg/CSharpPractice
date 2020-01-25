using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsBanjo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

public class Kata
    {
        public static string AreYouPlayingBanjo(string name)
        {
            string letter = Convert.ToString(name[0]);

            if (letter.ToUpper() == "R")
                return name + " plays banjo";
            else
                return name + " does not play banjo";
        }
    }
}
