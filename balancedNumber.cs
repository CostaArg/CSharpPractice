using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsBalancedNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //balanced number is when the sum of the left side of the middle digit is equal to the sum of the right side
            Kata.BalancedNumber(1221);
        }
    }

    class Kata
    {
        public static string BalancedNumber(int number)
        {
            List<char> charList = new List<char>();

            string numberS = Convert.ToString(number);

            charList.AddRange(numberS);

            double middleD = charList.Count;

            middleD = Math.Truncate(middleD / 2);

            int middle = Convert.ToInt32(middleD);

            int leftSide = 0;
            int rightSide = 0;

            if (charList.Count % 2 != 0)
            {
                for (int i = 0; i < middle; i++)
                {
                    leftSide += Convert.ToInt32(charList[i].ToString());
                }
                for (int i = middle + 1; i < charList.Count; i++)
                {
                    rightSide += Convert.ToInt32(charList[i].ToString());
                }
            }
            else
            {
                for (int i = 0; i < middle - 1; i++)
                {
                    leftSide += Convert.ToInt32(charList[i].ToString());
                }
                for (int i = middle + 1; i < charList.Count; i++)
                {
                    rightSide += Convert.ToInt32(charList[i].ToString());
                }
            }

            if (leftSide == rightSide)
                return "Balanced";
            else
                return "Not Balanced";
        }
    }
}
