using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsTryParseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string Problem(String a)
        {
            double number;
            bool result = Double.TryParse(a, out number);
            if (result)
                return (number * 50 + 6).ToString();
            else
                return "Error";
        }
    }
}
