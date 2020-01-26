using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSquareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
           int num = Kata.SquareDigits(9119);
            Console.WriteLine(num);
        }
    }

    public class Kata
    {
        public static int SquareDigits(int n)
        {
            List<char> charList = new List<char>();

            charList.AddRange(n.ToString());

            string sNum = null;
            double dNum = 0;

            foreach (var item in charList)
            {
                dNum = Convert.ToDouble(item.ToString());
                dNum = Math.Pow(dNum, 2);
                sNum += dNum;
            }

            return Convert.ToInt32(sNum);
        }
    }
}
