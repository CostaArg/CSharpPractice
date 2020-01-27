using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your two numbers with either '*, /, -, +': ");
            string input = Console.ReadLine();
            string operand;

            if (input.IndexOf("*", 0) != -1)
            {
                operand = input.Substring(input.IndexOf("*", 0), 1);
            }
            else if (input.IndexOf("/", 0) != -1)
            {
                operand = input.Substring(input.IndexOf("/", 0), 1);
            }
            else if (input.IndexOf("-", 0) != -1)
            {
                operand = input.Substring(input.IndexOf("-", 0), 1);
            }
            else
            {
                operand = input.Substring(input.IndexOf("+", 0), 1);
            }

            string[] number = new string[2];
            number[0] = input.Substring(0, input.IndexOf(operand, 0));
            number[1] = input.Substring(input.IndexOf(operand) + 1);

            if (operand == "*")
            {
                Console.WriteLine(Convert.ToDouble(number[0]) * Convert.ToDouble(number[1]));

            }
            else if (operand == "/")
            {
                Console.WriteLine(Convert.ToDecimal(number[0]) / Convert.ToDecimal(number[1]));

            }
            else if (operand == "+")
            {
                Console.WriteLine(Convert.ToDouble(number[0]) + Convert.ToDouble(number[1]));

            }
            else
            {
                Console.WriteLine(Convert.ToDouble(number[0]) - Convert.ToDouble(number[1]));
            }
        }
    }
}