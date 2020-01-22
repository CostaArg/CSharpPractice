using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1me7
{
    class Program
    {
        static void Main(string[] args)
        {
            string arithmos;
            int arithmosAk;

            Console.WriteLine("Enter your number between 1 and 7: ");
            arithmos = Console.ReadLine();
            arithmosAk = Convert.ToInt32(arithmos);

            if (arithmosAk >= 1 && arithmosAk <= 7)
            {
                if (arithmosAk == 5)
                {
                    Console.WriteLine("Your number can't be 5");
                }
                else
                {
                    Console.WriteLine("Your number is not 5. Good job!");
                }

            }
        }
    }
}
