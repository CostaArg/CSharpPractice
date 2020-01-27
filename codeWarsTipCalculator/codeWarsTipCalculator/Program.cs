using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsTipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static int CalculateTip(double amount, string rating)
        {
            if (rating.ToLower() == "terrible") return 0;
            else if (rating.ToLower() == "poor") return Convert.ToInt32(Math.Ceiling(amount * 5 / 100));
            else if (rating.ToLower() == "good") return Convert.ToInt32(Math.Ceiling(amount * 10 / 100));
            else if (rating.ToLower() == "great") return Convert.ToInt32(Math.Ceiling(amount * 15 / 100));
            else if (rating.ToLower() == "excellent") return Convert.ToInt32(Math.Ceiling(amount * 20 / 100));
            else return -1;
        }
    }
}
