using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternaryOperator
{
    class Program
    {

        static int papades(int x, int y)
        {
            int result = x > y ? x : y;
            return result;
        }

        static void Main(string[] args)
        {
            /* me if
                        int i = 10;
                        string result;
                        if (i > 10)
                        {
                            result = "bravo";
                        }
                        else
                        {
                            result = "try again please";
                        }
                        Console.WriteLine(result);*/

            /* me triadiko
            int i = 10;
            string result = i > 10 ? "bravo" : "try again";
            Console.WriteLine(result);*/

            Console.WriteLine("Dwse ton prwto arithmo");
            int prwtos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dwse ton deutero arithmo");
            int deuteros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O megaluteros einai: " + papades(prwtos, deuteros));
        }
    }
}
