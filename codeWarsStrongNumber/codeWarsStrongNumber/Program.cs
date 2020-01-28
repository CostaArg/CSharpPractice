using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsStrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Kata.StrongNumber(0);
            Console.WriteLine(result);
        }
    }

    class Kata
    {
        public static string StrongNumber(int number)
        {
            List<char> charList = new List<char>();
            charList.AddRange(number.ToString());

            List<int> toCalculateList = new List<int>();

            foreach (var item in charList)
            {
                toCalculateList.Add(Convert.ToInt32(item.ToString()));
            }

            int sumFac = 0;
            int saveNumber = number;

            foreach (var item in toCalculateList)
            {
                int facNumber = Factorial(item);
                Console.WriteLine(facNumber);
                sumFac += facNumber;
            }

            if (sumFac == saveNumber)
                return "STRONG!!!!";
            else
                return "Not Strong !!";
        }

        public static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            else
            {
                int facNumber = 1;
                while (number != 1)
                {
                    facNumber = facNumber * number;
                    number = number - 1;
                }
                return facNumber;
            }
        }
    }
}
