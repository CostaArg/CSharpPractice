using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSquare
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

public class Kata
    {
        public static bool IsSquare(int n)
        {
            double number = Math.Sqrt(n);
            Math.Truncate(number);

            if (number * number == n)
                return true;
            else
                return false;
        }
    }
}
