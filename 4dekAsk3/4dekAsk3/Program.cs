using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4dekAsk3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give the number of the audience: ");
            double audience = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the number of males: ");
            double males = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the number of females: ");
            double females = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the number of children: ");
            double children = Convert.ToDouble(Console.ReadLine());

            double athrisma = 0, ginomeno = 0, mesosOros = 0, posostoPaidion = 0, posostoAndron = 0, enilikoi = 0;

            audience = males + females + children;
            posostoPaidion = children / audience * 100;

            enilikoi = males + females;
            posostoAndron = males / enilikoi * 100;


            Console.WriteLine("The number of the audience is: " + audience);
            Console.WriteLine("The percentage of children is: " + posostoPaidion + "%");
            Console.WriteLine("The percentage of males times the adults is: " + posostoAndron + "%");
        }
    }
}
