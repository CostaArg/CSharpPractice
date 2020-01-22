using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4dekAsk1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your 1st number out of 3: ");
            double prwtos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your 2nd number out of 3: ");
            double deuteros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your 3rd number out of 3: ");
            double tritos = Convert.ToDouble(Console.ReadLine());

            double athrisma = 0, ginomeno = 0, mesosOros = 0;

            athrisma = prwtos + deuteros + tritos;
            ginomeno = prwtos * deuteros * tritos;
            mesosOros = ginomeno / 3;

            Console.WriteLine("Your sum is: " + athrisma);
            Console.WriteLine("Your product is: " + ginomeno);
            Console.WriteLine("Your average is: " + mesosOros);

        }
    }
}
