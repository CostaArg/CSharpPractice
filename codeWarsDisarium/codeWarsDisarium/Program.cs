using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsDisarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 89;
            string result = Kata.DisariumNumber(number);
            Console.WriteLine(result);
        }
    }

    class Kata
    {
        public static string DisariumNumber(int number)
        {
            List<char> charList = new List<char>();

            charList.AddRange(number.ToString());

            double sum = 0;
            int counter = 1;

            List<double> numberList = new List<double>();

            foreach (var item in charList)
            {
                numberList.Add(Convert.ToDouble(item.ToString()));
            }

            foreach (var item in numberList)
            {
                sum += Math.Pow(item, counter);
                counter++;
            }

            if (sum == number)
                return "Disarium !!";
            else
                return "Not !!";
        }
    }
}
