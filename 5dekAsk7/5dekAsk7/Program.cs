using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5dekAsk7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dwse to mhkos ths prwtis kathetis pleuras: ");
            double prwtiPleura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dwse to mhkos ths deuteris kathetis pleuras: ");
            double deuteriPleura = Convert.ToDouble(Console.ReadLine());

            double pithagorio = Math.Pow(prwtiPleura, 2) + Math.Pow(deuteriPleura, 2);

            Console.WriteLine("H upoteinousa einai: " + pithagorio);
        }
    }
}
