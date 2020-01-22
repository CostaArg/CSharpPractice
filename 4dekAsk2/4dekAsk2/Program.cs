using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4dekAsk2
{
    class Program
    {
        static void Main(string[] args)
        {
            double timiMetaTinEkptosi = 180;
            double ekptosi = 0.2;
            double arxikiTimi;

            arxikiTimi = timiMetaTinEkptosi / (1 - ekptosi);

            Console.WriteLine("Price before sale is: " + arxikiTimi);
        }
    }
}
