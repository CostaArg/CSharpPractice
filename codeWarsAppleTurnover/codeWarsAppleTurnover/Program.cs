using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsAppleTurnover
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string Apple(object n)
        {
            double number = Convert.ToDouble(n);
            double squared = Math.Pow(number, 2);

            if (squared > 1000)
                return "It's hotter than the sun!!";
            else
                return "Help yourself to a honeycomb Yorkie for the glovebox.";
        }
    }
}
