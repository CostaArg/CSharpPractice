using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsLogicalCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] array = { true, false, true, true, false, true };
            Kata.LogicalCalc(array, "OR");
        }
    }

    public class Kata
    {
        public static bool LogicalCalc(bool[] array, string op)
        {
            bool resultOR = array[0];
            bool resultAND = array[0];
            bool resultXOR = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                resultOR = resultOR || array[i];
            }

            for (int i = 1; i < array.Length; i++)
            {
                resultAND = resultAND && array[i];
            }

            for (int i = 1; i < array.Length; i++)
            {
                resultXOR = resultXOR ^ array[i];
            }

            if (op == "OR") return resultOR;
            else if (op == "AND") return resultAND;
            else return resultXOR;
        }
    }

}
