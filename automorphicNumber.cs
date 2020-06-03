using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsAutomorphic
{
    class Program
    {
        static void Main(string[] args)
        {
            //automorphic number is when a squared number "ends" in the same digits as the number itself
            string result = Kata.Automorphic(76);
            Console.WriteLine(result);
        }
    }

    class Kata
    {
        public static string Automorphic(int n)
        {
            double number = Convert.ToDouble(n);
            double squared = Math.Pow(number, 2);

            List<char> squaredList = new List<char>();
            squaredList.AddRange(squared.ToString());
            squaredList.Reverse();

            List<char> numberList = new List<char>();
            numberList.AddRange(number.ToString());
            numberList.Reverse();

            int counter = 0;

            for (int i = 0; i < number.ToString().Length ; i++)
            {
                if (numberList[i] == squaredList[i])
                    counter++;
            }

            if (counter == number.ToString().Length)
                return "Automorphic";
            else
                return "Not!!";
        }
    }
}
