using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsJumpingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string something = Kata.JumpingNumber(354);
            Console.WriteLine(something);
        }
    }
    class Kata
    {
        public static string JumpingNumber(int number)
        {
            List<char> charList = new List<char>();

            string sNumber = Convert.ToString(number);

            charList.AddRange(sNumber);

            List<int> intList = new List<int>();

            foreach (var item in charList)
            {
                intList.Add(Convert.ToInt32(item));
            }

            for (int i = 1; i < intList.Count; i++)
            {
                if ( (intList[i] != (intList[i - 1] - 1)) && (intList[i] != (intList[i - 1] + 1)) )
                    return "Not!!";
            }

            return "Jumping!!";
        }
    }
}
