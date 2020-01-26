using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsStrongestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = StrongestEvenNumber.strongestEven(2, 4);
            Console.WriteLine(num);
        }
    }
    public class StrongestEvenNumber
    {
        public static int strongestEven(int n, int m)
        {
            double numberN = Convert.ToDouble(n);
            double numberM = Convert.ToDouble(m);

            List<int> counters = new List<int>();
            List<double> numbers = new List<double>();

            int counter = 0;

            for (double i = numberN; i <= numberM; i++)
            {
                do
                {
                    if (i <= 2)
                        break;

                    if (i % 2 == 0)
                    {
                        i /= 2;
                        counter++;
                        Console.WriteLine(i);
                    }
                    else
                        break;


                } while (true);

                numbers.Add(i);
                counters.Add(counter);
                counter = 0;
            }



            return Convert.ToInt32(numbers[counters.Max()]);

            //if (counter1 > counter2)
            //    return n;
            //else if (counter1 < counter2)
            //    return m;
            //else
            //{
            //    if (n > m)
            //        return m;
            //    else
            //        return n;
            //}
        }
    }
}
