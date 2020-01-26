using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsWideMouthedFrog
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string MouthSize(string animal)
        {
            if (animal.ToLower() == "alligator")
                return "small";
            else
                return "wide";
        }
    }
}
