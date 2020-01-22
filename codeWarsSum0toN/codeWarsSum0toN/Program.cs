using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSum0toN
{
    class Program
    {
        static void Main(string[] args)
        {
            string kati = SequenceSum.ShowSequence(6);
            Console.WriteLine(kati);
        }

public class SequenceSum
    {
        public static string ShowSequence(int n)
        {

            int counter = 0;
            int sum = 0;
            string calculations = "";

            do
            {
                sum = sum + counter;
                calculations = calculations + counter + "+";
                counter++;
            } while (counter <= n);

                calculations = calculations.Remove(calculations.Length - 1);
                calculations = calculations + " = " + sum;

                return calculations;

        }
    }
}
}
